const std = @import("std");
const builtin = @import("builtin");

pub fn compileRaylib(b: *std.Build, target: std.Build.ResolvedTarget, optimize: std.builtin.OptimizeMode, shared: bool) !*std.Build.Step.Compile {
    const raylib = b.dependency("raylib", .{ .target = target, .optimize = optimize, .linkage = if (shared) std.builtin.LinkMode.dynamic else std.builtin.LinkMode.static, .linux_display_backend = .X11 });
    const raygui = b.dependency("raygui", .{ .target = target, .optimize = optimize });
    const lib = raylib.artifact("raylib");

    switch (target.result.os.tag) {
        // Due to *terrible* zig default behaviour for include paths when cross-compiling I have to do this
        // The includes are resolved properly only when -Dtarget=native (or omitted) is passed
        .linux => {
            if (target.result.cpu.arch == .aarch64) {
                lib.addLibraryPath(.{ .cwd_relative = "/usr/lib/aarch64-linux-gnu/" });
                lib.addIncludePath(.{ .cwd_relative = "/usr/include/aarch64-linux-gnu/" });
                lib.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
            } else if (target.result.cpu.arch == .x86) {
                lib.addLibraryPath(.{ .cwd_relative = "/usr/lib/i386-linux-gnu/" });
                lib.addIncludePath(.{ .cwd_relative = "/usr/include/i386-linux-gnu/" });
                lib.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
                // https://github.com/ziglang/zig/issues/7935
                lib.link_z_notext = true;
            } else if (target.result.cpu.arch == .x86_64) {
                lib.addLibraryPath(.{ .cwd_relative = "/usr/lib/x86_64-linux-gnu/" });
                lib.addIncludePath(.{ .cwd_relative = "/usr/include/x86_64-linux-gnu/" });
                lib.addIncludePath(.{ .cwd_relative = "/usr/include" });
            } else {
                lib.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
            }

            lib.addLibraryPath(.{ .cwd_relative = "/usr/lib" });
        },
        else => {}
    }

    var gen_step = b.addWriteFiles();
    lib.step.dependOn(&gen_step.step);

    var cflags = std.ArrayList([]const u8){};
    defer cflags.deinit(b.allocator);

    try cflags.appendSlice(b.allocator, &[_][]const u8{
        "-std=gnu99",
        "-D_GNU_SOURCE",
        "-DGL_SILENCE_DEPRECATION=199309L",
        "-fno-sanitize=undefined",
    });

    if (shared) {
        try cflags.appendSlice(b.allocator, &[_][]const u8{
            "-fPIC",
            "-DBUILD_LIBTYPE_SHARED",
        });
    }

    lib.addCSourceFile(.{
        .file = gen_step.add("raygui.c", "#define RAYGUI_IMPLEMENTATION\n#include \"raygui.h\"\n"),
        .flags = cflags.items,
    });

    lib.addIncludePath(raylib.path("src"));
    lib.addIncludePath(raygui.path("src"));
    lib.installHeader(raygui.path("src/raygui.h"), "raygui.h");

    return lib;
}

pub fn build(b: *std.Build) !void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    if (target.result.os.tag != .emscripten) {
        b.installArtifact(try compileRaylib(b, target, optimize, true));
    }

    b.installArtifact(try compileRaylib(b, target, optimize, false));
}
