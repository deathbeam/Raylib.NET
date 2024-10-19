const std = @import("std");

pub fn compileRaylib(b: *std.Build, target: std.Build.ResolvedTarget, optimize: std.builtin.OptimizeMode, shared: bool) *std.Build.Step.Compile {
    const raylib = b.dependency("raylib", .{ .target = target, .optimize = optimize, .shared = shared, .linux_display_backend = .X11 });
    const raygui = b.dependency("raygui", .{ .target = target, .optimize = optimize });
    const lib = raylib.artifact("raylib");

    if (target.result.isDarwin()) {
        if (b.lazyDependency("xcode_frameworks", .{
            .target = target,
            .optimize = optimize,
        })) |dep| {
            lib.addSystemFrameworkPath(dep.path("Frameworks"));
            lib.addSystemIncludePath(dep.path("include"));
            lib.addLibraryPath(dep.path("lib"));
        }
    }

    var gen_step = b.addWriteFiles();
    lib.step.dependOn(&gen_step.step);

    const raygui_c_path = gen_step.add("raygui.c", "#define RAYGUI_IMPLEMENTATION\n#include \"raygui.h\"\n");

    lib.addCSourceFile(.{
        .file = raygui_c_path,
        .flags = &[_][]const u8{
            "-std=gnu99",
            "-D_GNU_SOURCE",
            "-DGL_SILENCE_DEPRECATION=199309L",
            "-fno-sanitize=undefined",
        },
    });

    lib.addIncludePath(raylib.path("src"));
    lib.addIncludePath(raygui.path("src"));
    lib.installHeader(raygui.path("src/raygui.h"), "raygui.h");

    // Needed for github actions
    lib.addLibraryPath(.{ .cwd_relative = "/usr/lib/x86_64-linux-gnu/" });
    lib.addIncludePath(.{ .cwd_relative = "/usr/include/x86_64-linux-gnu/" });

    return lib;
}

pub fn build(b: *std.Build) !void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    b.installArtifact(compileRaylib(b, target, optimize, true));
    b.installArtifact(compileRaylib(b, target, optimize, false));
}
