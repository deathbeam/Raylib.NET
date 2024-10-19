const std = @import("std");
const rl = @import("raylib");

pub const LibType = enum { Shared, Static };

var _raylib_lib_cache: ?*std.Build.Step.Compile = null;
fn getRaylib(b: *std.Build, target: std.Build.ResolvedTarget, optimize: std.builtin.OptimizeMode) *std.Build.Step.Compile {
    if (_raylib_lib_cache) |lib| return lib else {
        const raylib = b.dependency("raylib", .{});

        const lib = raylib.artifact("raylib");

        const raygui_dep = b.dependency("raygui", .{
            .target = target,
            .optimize = optimize,
        });

        var gen_step = b.addWriteFiles();
        lib.step.dependOn(&gen_step.step);

        const raygui_c_path = gen_step.add("raygui.c", "#define RAYGUI_IMPLEMENTATION\n#include \"raygui.h\"\n");
        lib.addCSourceFile(.{
            .file = raygui_c_path,
            .flags = &[_][]const u8{
                "-std=gnu99",
                "-D_GNU_SOURCE",
                "-DGL_SILENCE_DEPRECATION=199309L",
                "-fno-sanitize=undefined", // https://github.com/raysan5/raylib/issues/3674
            },
        });
        lib.addIncludePath(raylib.path("src"));
        lib.addIncludePath(raygui_dep.path("src"));

        lib.installHeader(raygui_dep.path("src/raygui.h"), "raygui.h");

        b.installArtifact(lib);
        _raylib_lib_cache = lib;
        return lib;
    }
}

pub fn compileFlecs(b: *std.Build, target: std.Build.ResolvedTarget, optimize: std.builtin.OptimizeMode, lib_type: LibType) void {
    const lib = switch (lib_type) {
        .Shared => b.addSharedLibrary(.{
            .name = "raylib",
            .target = target,
            .optimize = optimize,
            .strip = optimize != .Debug,
            // .link_libc = true,
        }),
        .Static => b.addStaticLibrary(.{
            .name = "raylib",
            .target = target,
            .optimize = optimize,
            .strip = optimize != .Debug,
            // .link_libc = true,
        }),
    };

    const raylib = getRaylib(b, target, optimize);
    lib.linkLibrary(raylib);
    b.installArtifact(lib);
}

pub fn build(b: *std.Build) !void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    compileFlecs(b, target, optimize, LibType.Shared);
    compileFlecs(b, target, optimize, LibType.Static);
}
