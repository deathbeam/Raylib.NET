const std = @import("std");
const rl = @import("raylib");

/// Build raylib with raygui, given options, and platform-specific paths
fn buildRaylib(
    b: *std.Build,
    target: std.Build.ResolvedTarget,
    optimize: std.builtin.OptimizeMode,
    options: rl.Options,
) *std.Build.Step.Compile {
    const raylib_dep = b.dependency("raylib", .{
        .target = target,
        .optimize = optimize,
        .raudio = options.raudio,
        .rmodels = options.rmodels,
        .rshapes = options.rshapes,
        .rtext = options.rtext,
        .rtextures = options.rtextures,
        .raygui = options.raygui,
        .platform = options.platform,
        .linkage = options.linkage,
        .linux_display_backend = options.linux_display_backend,
        .opengl_version = options.opengl_version,
        .config = options.config,
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
                raylib.root_module.addLibraryPath(.{ .cwd_relative = "/usr/lib/aarch64-linux-gnu/" });
                raylib.root_module.addIncludePath(.{ .cwd_relative = "/usr/include/aarch64-linux-gnu/" });
                raylib.root_module.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
            } else if (target.result.cpu.arch == .x86) {
                raylib.root_module.addLibraryPath(.{ .cwd_relative = "/usr/lib/i386-linux-gnu/" });
                raylib.root_module.addIncludePath(.{ .cwd_relative = "/usr/include/i386-linux-gnu/" });
                raylib.root_module.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
                // https://github.com/ziglang/zig/issues/7935
                raylib.link_z_notext = true;
            } else if (target.result.cpu.arch == .x86_64) {
                raylib.root_module.addLibraryPath(.{ .cwd_relative = "/usr/lib/x86_64-linux-gnu/" });
                raylib.root_module.addIncludePath(.{ .cwd_relative = "/usr/include/x86_64-linux-gnu/" });
                raylib.root_module.addIncludePath(.{ .cwd_relative = "/usr/include" });
            } else {
                raylib.root_module.addSystemIncludePath(.{ .cwd_relative = "/usr/include" });
            }

            raylib.root_module.addLibraryPath(.{ .cwd_relative = "/usr/lib" });
        },
        else => {},
    }

    return raylib;
}

pub fn build(b: *std.Build) !void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    // Determine linkage based on target
    const linkage = if (target.result.os.tag == .emscripten)
        std.builtin.LinkMode.static
    else
        std.builtin.LinkMode.dynamic;

    // Determine OpenGL version based on target
    const opengl_version = if (target.result.os.tag == .emscripten)
        rl.OpenglVersion.gles_3
    else
        rl.OpenglVersion.gl_4_3;

    const platform = if (target.result.os.tag == .emscripten)
        rl.PlatformBackend.glfw
    else
        rl.PlatformBackend.rgfw;

    // Get raylib options for configuring the build
    const options = rl.Options{
        .linkage = linkage,
        .raygui = true,
        .linux_display_backend = .Wayland,
        .opengl_version = opengl_version,
        .platform = platform
    };

    // Build raylib with raygui using raylib's build system
    const raylib = buildRaylib(b, target, optimize, options);

    // Install the library
    // For non-emscripten targets, also build a static library version
    if (target.result.os.tag != .emscripten) {
        // Install the shared library
        b.installArtifact(raylib);

        // Also build and install a static version
        var static_options = options;
        static_options.linkage = .static;
        const raylib_static = buildRaylib(b, target, optimize, static_options);
        b.installArtifact(raylib_static);
    } else {
        // For emscripten, just install the static library
        b.installArtifact(raylib);
    }
}
