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
    // Due to *terrible* zig default behaviour for include paths when cross-compiling I have to do this
    // The includes are resolved properly only when -Dtarget=native (or omitted) is passed
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
                // https://github.com/ziglang/zig/issues/7935
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
                if (target.result.cpu.arch == .aarch64) {
                    raylib_static.addLibraryPath(.{ .cwd_relative = "/usr/lib/aarch64-linux-gnu/" });
                    raylib_static.addIncludePath(.{ .cwd_relative = "/usr/include/aarch64-linux-gnu/" });
                    raylib_static.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
                } else if (target.result.cpu.arch == .x86) {
                    raylib_static.addLibraryPath(.{ .cwd_relative = "/usr/lib/i386-linux-gnu/" });
                    raylib_static.addIncludePath(.{ .cwd_relative = "/usr/include/i386-linux-gnu/" });
                    raylib_static.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
                    raylib_static.link_z_notext = true;
                } else if (target.result.cpu.arch == .x86_64) {
                    raylib_static.addLibraryPath(.{ .cwd_relative = "/usr/lib/x86_64-linux-gnu/" });
                    raylib_static.addIncludePath(.{ .cwd_relative = "/usr/include/x86_64-linux-gnu/" });
                    raylib_static.addIncludePath(.{ .cwd_relative = "/usr/include" });
                } else {
                    raylib_static.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
                }

                raylib_static.addLibraryPath(.{ .cwd_relative = "/usr/lib" });
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
