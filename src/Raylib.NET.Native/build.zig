const std = @import("std");
const rl = @import("raylib");

pub fn build(b: *std.Build) !void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    const options = rl.Options.getOptions(b);

    const raylib_dep = b.dependency("raylib", .{
        .target = target,
        .optimize = optimize,
        .raudio = options.raudio,
        .rmodels = options.rmodels,
        .rshapes = options.rshapes,
        .rtext = options.rtext,
        .rtextures = options.rtextures,
        .platform = options.platform,
        .linkage = options.linkage,
        .linux_display_backend = options.linux_display_backend,
        .opengl_version = options.opengl_version,
        .android_api_version = options.android_api_version,
        .android_ndk = options.android_ndk,
    });
    const raylib = raylib_dep.artifact("raylib");

    // Add platform-specific include/library paths for cross-compiling
    switch (target.result.os.tag) {
        .linux => {
            if (target.result.cpu.arch == .aarch64) {
                raylib.addLibraryPath(.{ .cwd_relative = "/usr/lib/aarch64-linux-gnu/" });
                raylib.addIncludePath(.{ .cwd_relative = "/usr/include/aarch64-linux-gnu/" });
                raylib.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
            } else if (target.result.cpu.arch == .x86) {
                raylib.addLibraryPath(.{ .cwd_relative = "/usr/lib/i386-linux-gnu/" });
                raylib.addIncludePath(.{ .cwd_relative = "/usr/include/i386-linux-gnu/" });
                raylib.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
                raylib.link_z_notext = true;
            } else if (target.result.cpu.arch == .x86_64) {
                raylib.addLibraryPath(.{ .cwd_relative = "/usr/lib/x86_64-linux-gnu/" });
                raylib.addIncludePath(.{ .cwd_relative = "/usr/include/x86_64-linux-gnu/" });
                raylib.addIncludePath(.{ .cwd_relative = "/usr/include" });
            } else {
                raylib.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
            }
            raylib.addLibraryPath(.{ .cwd_relative = "/usr/lib" });
        },
        else => {},
    }

    const raygui_dep = b.dependency("raygui", .{
        .target = target,
        .optimize = optimize,
    });

    rl.addRaygui(b, raylib, raygui_dep, options);

    b.installArtifact(raylib);
}
