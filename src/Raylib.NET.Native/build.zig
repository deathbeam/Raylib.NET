const std = @import("std");

const raylib_dir = "../../lib/raylib";
const raygui_dir = "../../lib/raygui";

fn linkWindows(mod: *std.Build.Module) void {
    mod.linkSystemLibrary("opengl32", .{});
    mod.linkSystemLibrary("winmm", .{});
    mod.linkSystemLibrary("gdi32", .{});
}

fn linkMacOS(b: *std.Build, mod: *std.Build.Module) void {
    if (b.lazyDependency("xcode_frameworks", .{})) |dep| {
        mod.addSystemFrameworkPath(dep.path("Frameworks"));
        mod.addSystemIncludePath(dep.path("include"));
        mod.addLibraryPath(dep.path("lib"));
    }

    mod.linkFramework("Foundation", .{});
    mod.linkFramework("CoreServices", .{});
    mod.linkFramework("CoreGraphics", .{});
    mod.linkFramework("AppKit", .{});
    mod.linkFramework("IOKit", .{});
    mod.linkFramework("QuartzCore", .{});
}

// Generate wayland protocol headers with wayland-scanner for every protocol xml shipped
fn waylandGenerate(b: *std.Build, raylib: *std.Build.Step.Compile) void {
    const protocols_dir = raylib_dir ++ "/src/external/glfw/deps/wayland";

    const io = b.graph.io;
    var dir = std.Io.Dir.cwd().openDir(io, protocols_dir, .{ .iterate = true }) catch
        @panic("missing " ++ protocols_dir);
    defer dir.close(io);

    var it = dir.iterate();
    while (it.next(io) catch @panic("iterating " ++ protocols_dir)) |entry| {
        if (entry.kind != .file or !std.mem.endsWith(u8, entry.name, ".xml")) continue;
        const protocol = entry.name[0 .. entry.name.len - ".xml".len];
        const xml = b.fmt("{s}/{s}.xml", .{ protocols_dir, protocol });

        const client_header = b.addSystemCommand(&.{ "wayland-scanner", "client-header" });
        client_header.addFileArg(b.path(xml));
        const client_out = client_header.addOutputFileArg(b.fmt("{s}-client-protocol.h", .{protocol}));
        raylib.root_module.addIncludePath(client_out.dirname());
        raylib.step.dependOn(&client_header.step);

        const code_header = b.addSystemCommand(&.{ "wayland-scanner", "private-code" });
        code_header.addFileArg(b.path(xml));
        const code_out = code_header.addOutputFileArg(b.fmt("{s}-client-protocol-code.h", .{protocol}));
        raylib.root_module.addIncludePath(code_out.dirname());
        raylib.step.dependOn(&code_header.step);
    }
}

fn addRaygui(b: *std.Build, raylib: *std.Build.Step.Compile) void {
    const gen = b.addWriteFiles();
    raylib.step.dependOn(&gen.step);

    // raygui.h is header-only, compile the implementation into the library
    const raygui_c = gen.add("raygui.c", "#define RAYGUI_IMPLEMENTATION\n#include \"raygui.h\"\n");
    raylib.root_module.addCSourceFile(.{ .file = raygui_c, .flags = &.{"-std=c99"} });
    raylib.root_module.addIncludePath(b.path(raygui_dir ++ "/src"));

    raylib.installHeader(b.path(raygui_dir ++ "/src/raygui.h"), "raygui.h");
}

fn buildRaylib(
    b: *std.Build,
    target: std.Build.ResolvedTarget,
    optimize: std.builtin.OptimizeMode,
    linkage: std.builtin.LinkMode,
) *std.Build.Step.Compile {
    const os = target.result.os.tag;

    const mod = b.createModule(.{
        .target = target,
        .optimize = optimize,
        .link_libc = true,
    });

    const raylib = b.addLibrary(.{
        // windows: the dll import lib and the static archive would both be raylib.lib and overwrite each other
        .name = if (linkage == .static and os == .windows) "raylib_static" else "raylib",
        .linkage = linkage,
        .root_module = mod,
    });

    // On Linux (glibc) avoid _GNU_SOURCE, on glibc >= 2.38 it redirects sscanf(), strtol()...
    // to __isoc23_*() symbols, so the generated library fails to link with older glibc versions
    if (os == .linux) {
        mod.addCMacro("_DEFAULT_SOURCE", "");
    } else {
        mod.addCMacro("_GNU_SOURCE", "");
    }
    mod.addCMacro("GL_SILENCE_DEPRECATION", "199309L");

    if (linkage == .dynamic) {
        mod.pic = true;
        mod.addCMacro("BUILD_LIBTYPE_SHARED", "");
    }

    mod.addCMacro("SUPPORT_MODULE_RSHAPES", "1");
    mod.addCMacro("SUPPORT_MODULE_RTEXTURES", "1");
    mod.addCMacro("SUPPORT_MODULE_RTEXT", "1");
    mod.addCMacro("SUPPORT_MODULE_RMODELS", "1");
    mod.addCMacro("SUPPORT_MODULE_RAUDIO", "1");

    mod.addIncludePath(b.path(raylib_dir ++ "/src"));
    mod.addIncludePath(b.path(raylib_dir ++ "/src/platforms"));
    mod.addIncludePath(b.path(raylib_dir ++ "/src/external/glfw/include"));

    const sources = [_][]const u8{
        raylib_dir ++ "/src/rcore.c",
        raylib_dir ++ "/src/rshapes.c",
        raylib_dir ++ "/src/rtextures.c",
        raylib_dir ++ "/src/rtext.c",
        raylib_dir ++ "/src/rmodels.c",
        raylib_dir ++ "/src/raudio.c",
    };
    const flags = [_][]const u8{if (os == .emscripten) "-std=gnu99" else "-std=c99"};

    switch (os) {
        .windows => {
            mod.addCMacro("PLATFORM_DESKTOP_GLFW", "");
            mod.addCMacro("GRAPHICS_API_OPENGL_43", "");
            linkWindows(mod);

            const files = sources ++ [_][]const u8{raylib_dir ++ "/src/rglfw.c"};
            mod.addCSourceFiles(.{ .files = &files, .flags = &flags });
        },
        .linux => {
            mod.addCMacro("PLATFORM_DESKTOP_GLFW", "");
            mod.addCMacro("GRAPHICS_API_OPENGL_43", "");
            mod.addCMacro("_GLFW_WAYLAND", "");
            mod.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
            waylandGenerate(b, raylib);

            const files = sources ++ [_][]const u8{raylib_dir ++ "/src/rglfw.c"};
            mod.addCSourceFiles(.{ .files = &files, .flags = &flags });
        },
        .macos => {
            // macOS only supports OpenGL up to 4.1, so use the 3.3 backend there
            mod.addCMacro("PLATFORM_DESKTOP_GLFW", "");
            mod.addCMacro("GRAPHICS_API_OPENGL_33", "");
            linkMacOS(b, mod);

            mod.addCSourceFiles(.{ .files = &sources, .flags = &flags });

            // rglfw.c includes Objective-C files, compile it separately with -ObjC
            mod.addCSourceFile(.{
                .file = b.path(raylib_dir ++ "/src/rglfw.c"),
                .flags = &.{ "-std=c99", "-ObjC" },
            });
        },
        .emscripten => {
            mod.addCMacro("PLATFORM_WEB", "");
            mod.addCMacro("GRAPHICS_API_OPENGL_ES3", "");
            mod.addCSourceFiles(.{ .files = &sources, .flags = &flags });
        },
        else => @panic("Target is not supported"),
    }

    if (os == .emscripten) {
        const sysroot = b.sysroot orelse @panic("emscripten needs --sysroot $(EMSDK)/upstream/emscripten");
        mod.addIncludePath(.{ .cwd_relative = b.pathJoin(&.{ sysroot, "cache/sysroot/include" }) });
    }

    addRaygui(b, raylib);

    return raylib;
}

fn installHeaders(b: *std.Build, raylib: *std.Build.Step.Compile) void {
    raylib.installHeader(b.path(raylib_dir ++ "/src/raylib.h"), "raylib.h");
    raylib.installHeader(b.path(raylib_dir ++ "/src/rcamera.h"), "rcamera.h");
    raylib.installHeader(b.path(raylib_dir ++ "/src/raymath.h"), "raymath.h");
    raylib.installHeader(b.path(raylib_dir ++ "/src/rlgl.h"), "rlgl.h");
}

pub fn build(b: *std.Build) !void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});
    const os = target.result.os.tag;

    // the windows static lib needs the msvc sdk, which only windows hosts have
    const linkages: []const std.builtin.LinkMode = if (os == .emscripten)
        &.{.static}
    else if (os == .windows and b.graph.host.result.os.tag != .windows)
        &.{.dynamic}
    else
        &.{ .dynamic, .static };

    for (linkages, 0..) |linkage, i| {
        // the static lib is linked by MSVC link.exe (NativeAOT), so build it with the msvc abi
        var lib_target = target;
        if (linkage == .static and os == .windows) {
            var query = target.query;
            query.abi = .msvc;
            lib_target = b.resolveTargetQuery(query);
        }
        const raylib = buildRaylib(b, lib_target, optimize, linkage);
        if (i == 0) installHeaders(b, raylib);
        b.installArtifact(raylib);
    }
}
