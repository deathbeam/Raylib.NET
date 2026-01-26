const std = @import("std");
const rl = @import("raylib");

pub fn build(b: *std.Build) !void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    // Determine linkage based on target
    const linkage = if (target.result.os.tag == .emscripten)
        std.builtin.LinkMode.static
    else
        std.builtin.LinkMode.dynamic;

    // Get raylib options for configuring the build
    const options = rl.Options{
        .linkage = linkage,
        .linux_display_backend = .X11,
        .opengl_version = .gl_4_3,
    };

    // Build raylib using raylib's build system
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
    // Note: On Ubuntu/Debian, cross-compilation libraries are installed in multiarch paths.
    // On other distros (like Arch), these paths don't exist and Zig will warn but continue.
    // The warnings are cosmetic and don't affect the build - standard paths are added first.
    switch (target.result.os.tag) {
        .linux => {
            // Add standard paths that work on all distros
            raylib.addLibraryPath(.{ .cwd_relative = "/usr/lib" });
            raylib.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });

            // Add Ubuntu/Debian multiarch paths for cross-compilation
            // These are needed for CI builds on Ubuntu when cross-compiling to different architectures
            if (target.result.cpu.arch == .aarch64) {
                raylib.addLibraryPath(.{ .cwd_relative = "/usr/lib/aarch64-linux-gnu/" });
                raylib.addIncludePath(.{ .cwd_relative = "/usr/include/aarch64-linux-gnu/" });
            } else if (target.result.cpu.arch == .x86) {
                raylib.addLibraryPath(.{ .cwd_relative = "/usr/lib/i386-linux-gnu/" });
                raylib.addIncludePath(.{ .cwd_relative = "/usr/include/i386-linux-gnu/" });
                // https://github.com/ziglang/zig/issues/7935
                raylib.link_z_notext = true;
            } else if (target.result.cpu.arch == .x86_64) {
                raylib.addLibraryPath(.{ .cwd_relative = "/usr/lib/x86_64-linux-gnu/" });
                raylib.addIncludePath(.{ .cwd_relative = "/usr/include/x86_64-linux-gnu/" });
            }
        },
        else => {},
    }

    // Add raygui using raylib's helper function
    const raygui_dep = b.dependency("raygui", .{
        .target = target,
        .optimize = optimize,
    });
    rl.addRaygui(b, raylib, raygui_dep, options);

    // Install the library
    // For non-emscripten targets, also build a static library version
    if (target.result.os.tag != .emscripten) {
        // Install the shared library
        b.installArtifact(raylib);

        // Also build and install a static version
        const raylib_static_dep = b.dependency("raylib", .{
            .target = target,
            .optimize = optimize,
            .raudio = options.raudio,
            .rmodels = options.rmodels,
            .rshapes = options.rshapes,
            .rtext = options.rtext,
            .rtextures = options.rtextures,
            .platform = options.platform,
            .linkage = .static,
            .linux_display_backend = options.linux_display_backend,
            .opengl_version = options.opengl_version,
            .android_api_version = options.android_api_version,
            .android_ndk = options.android_ndk,
        });
        const raylib_static = raylib_static_dep.artifact("raylib");

        // Add same platform-specific paths for static lib
        switch (target.result.os.tag) {
            .linux => {
                raylib_static.addLibraryPath(.{ .cwd_relative = "/usr/lib" });
                raylib_static.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });

                // Add multiarch paths for cross-compilation
                if (target.result.cpu.arch == .aarch64) {
                    raylib_static.addLibraryPath(.{ .cwd_relative = "/usr/lib/aarch64-linux-gnu/" });
                    raylib_static.addIncludePath(.{ .cwd_relative = "/usr/include/aarch64-linux-gnu/" });
                } else if (target.result.cpu.arch == .x86) {
                    raylib_static.addLibraryPath(.{ .cwd_relative = "/usr/lib/i386-linux-gnu/" });
                    raylib_static.addIncludePath(.{ .cwd_relative = "/usr/include/i386-linux-gnu/" });
                    raylib_static.link_z_notext = true;
                } else if (target.result.cpu.arch == .x86_64) {
                    raylib_static.addLibraryPath(.{ .cwd_relative = "/usr/lib/x86_64-linux-gnu/" });
                    raylib_static.addIncludePath(.{ .cwd_relative = "/usr/include/x86_64-linux-gnu/" });
                }
            },
            else => {},
        }

        // Add raygui to static library too
        rl.addRaygui(b, raylib_static, raygui_dep, .{
            .linkage = .static,
            .linux_display_backend = options.linux_display_backend,
            .opengl_version = options.opengl_version,
        });

        b.installArtifact(raylib_static);
    } else {
        // For emscripten, just install the static library
        b.installArtifact(raylib);
    }
}
