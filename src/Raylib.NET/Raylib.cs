using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Numerics;
using Bindgen.Interop;

namespace Raylib.NET;

public static unsafe partial class Raylib
{
    public const string LIBRARY = "raylib";

    public const int RAYLIB_VERSION_MAJOR = 5;

    public const int RAYLIB_VERSION_MINOR = 5;

    public const int RAYLIB_VERSION_PATCH = 0;

    public const string RAYLIB_VERSION = "5.5-dev";

    public const float PI = 3.14159265358979323846f;

    public static readonly float DEG2RAD = (PI/180.0f);

    public static readonly float RAD2DEG = (180.0f/PI);

    /// <summary>
    /// Initialize window and OpenGL context
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void InitWindow(int width, int height, string title);

    /// <summary>
    /// Close window and unload OpenGL context
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CloseWindow();

    /// <summary>
    /// Check if application should close (KEY_ESCAPE pressed or windows close icon clicked)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool WindowShouldClose();

    /// <summary>
    /// Check if window has been initialized successfully
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowReady();

    /// <summary>
    /// Check if window is currently fullscreen
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowFullscreen();

    /// <summary>
    /// Check if window is currently hidden (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowHidden();

    /// <summary>
    /// Check if window is currently minimized (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowMinimized();

    /// <summary>
    /// Check if window is currently maximized (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowMaximized();

    /// <summary>
    /// Check if window is currently focused (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowFocused();

    /// <summary>
    /// Check if window has been resized last frame
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowResized();

    /// <summary>
    /// Check if one specific window flag is enabled
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowState(uint flag);

    /// <summary>
    /// Set window configuration state using flags (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowState(uint flags);

    /// <summary>
    /// Clear window configuration state flags
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearWindowState(uint flags);

    /// <summary>
    /// Toggle window state: fullscreen/windowed [resizes monitor to match window resolution] (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ToggleFullscreen();

    /// <summary>
    /// Toggle window state: borderless windowed [resizes window to match monitor resolution] (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ToggleBorderlessWindowed();

    /// <summary>
    /// Set window state: maximized, if resizable (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void MaximizeWindow();

    /// <summary>
    /// Set window state: minimized, if resizable (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void MinimizeWindow();

    /// <summary>
    /// Set window state: not minimized/maximized (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void RestoreWindow();

    /// <summary>
    /// Set icon for window (single image, RGBA 32bit, only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowIcon(Image image);

    /// <summary>
    /// Set icon for window (multiple images, RGBA 32bit, only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetWindowIcons(Image* images, int count);

    /// <summary>
    /// Set title for window (only PLATFORM_DESKTOP and PLATFORM_WEB)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowTitle(string title);

    /// <summary>
    /// Set window position on screen (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowPosition(int x, int y);

    /// <summary>
    /// Set monitor for the current window
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowMonitor(int monitor);

    /// <summary>
    /// Set window minimum dimensions (for FLAG_WINDOW_RESIZABLE)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowMinSize(int width, int height);

    /// <summary>
    /// Set window maximum dimensions (for FLAG_WINDOW_RESIZABLE)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowMaxSize(int width, int height);

    /// <summary>
    /// Set window dimensions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowSize(int width, int height);

    /// <summary>
    /// Set window opacity [0.0f..1.0f] (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowOpacity(float opacity);

    /// <summary>
    /// Set window focused (only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowFocused();

    /// <summary>
    /// Get native window handle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void* GetWindowHandle();

    /// <summary>
    /// Get current screen width
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetScreenWidth();

    /// <summary>
    /// Get current screen height
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetScreenHeight();

    /// <summary>
    /// Get current render width (it considers HiDPI)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetRenderWidth();

    /// <summary>
    /// Get current render height (it considers HiDPI)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetRenderHeight();

    /// <summary>
    /// Get number of connected monitors
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorCount();

    /// <summary>
    /// Get current connected monitor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCurrentMonitor();

    /// <summary>
    /// Get specified monitor position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMonitorPosition(int monitor);

    /// <summary>
    /// Get specified monitor width (current video mode used by monitor)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorWidth(int monitor);

    /// <summary>
    /// Get specified monitor height (current video mode used by monitor)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorHeight(int monitor);

    /// <summary>
    /// Get specified monitor physical width in millimetres
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorPhysicalWidth(int monitor);

    /// <summary>
    /// Get specified monitor physical height in millimetres
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorPhysicalHeight(int monitor);

    /// <summary>
    /// Get specified monitor refresh rate
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorRefreshRate(int monitor);

    /// <summary>
    /// Get window position XY on monitor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWindowPosition();

    /// <summary>
    /// Get window scale DPI factor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWindowScaleDPI();

    /// <summary>
    /// Get the human-readable, UTF-8 encoded name of the specified monitor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetMonitorName(int monitor);

    /// <summary>
    /// Set clipboard text content
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetClipboardText(string text);

    /// <summary>
    /// Get clipboard text content
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetClipboardText();

    /// <summary>
    /// Enable waiting for events on EndDrawing(), no automatic event polling
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableEventWaiting();

    /// <summary>
    /// Disable waiting for events on EndDrawing(), automatic events polling
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableEventWaiting();

    /// <summary>
    /// Shows cursor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ShowCursor();

    /// <summary>
    /// Hides cursor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void HideCursor();

    /// <summary>
    /// Check if cursor is not visible
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsCursorHidden();

    /// <summary>
    /// Enables cursor (unlock cursor)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableCursor();

    /// <summary>
    /// Disables cursor (lock cursor)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableCursor();

    /// <summary>
    /// Check if cursor is on the screen
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsCursorOnScreen();

    /// <summary>
    /// Set background color (framebuffer clear color)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearBackground(Color color);

    /// <summary>
    /// Setup canvas (framebuffer) to start drawing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginDrawing();

    /// <summary>
    /// End canvas drawing and swap buffers (double buffering)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndDrawing();

    /// <summary>
    /// Begin 2D mode with custom camera (2D)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginMode2D(Camera2D camera);

    /// <summary>
    /// Ends 2D mode with custom camera
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndMode2D();

    /// <summary>
    /// Begin 3D mode with custom camera (3D)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginMode3D(Camera3D camera);

    /// <summary>
    /// Ends 3D mode and returns to default 2D orthographic mode
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndMode3D();

    /// <summary>
    /// Begin drawing to render texture
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginTextureMode(RenderTexture target);

    /// <summary>
    /// Ends drawing to render texture
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndTextureMode();

    /// <summary>
    /// Begin custom shader drawing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginShaderMode(Shader shader);

    /// <summary>
    /// End custom shader drawing (use default shader)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndShaderMode();

    /// <summary>
    /// Begin blending mode (alpha, additive, multiplied, subtract, custom)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginBlendMode(int mode);

    /// <summary>
    /// End blending mode (reset to default: alpha blending)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndBlendMode();

    /// <summary>
    /// Begin scissor mode (define screen area for following drawing)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginScissorMode(int x, int y, int width, int height);

    /// <summary>
    /// End scissor mode
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndScissorMode();

    /// <summary>
    /// Begin stereo rendering (requires VR simulator)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginVrStereoMode(VrStereoConfig config);

    /// <summary>
    /// End stereo rendering (requires VR simulator)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndVrStereoMode();

    /// <summary>
    /// Load VR stereo config for VR simulator device parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);

    /// <summary>
    /// Unload VR stereo config
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadVrStereoConfig(VrStereoConfig config);

    /// <summary>
    /// Load shader from files and bind default locations
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader LoadShader(string vsFileName, string fsFileName);

    /// <summary>
    /// Load shader from code strings and bind default locations
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader LoadShaderFromMemory(string vsCode, string fsCode);

    /// <summary>
    /// Check if a shader is valid (loaded on GPU)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsShaderValid(Shader shader);

    /// <summary>
    /// Get shader uniform location
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetShaderLocation(Shader shader, string uniformName);

    /// <summary>
    /// Get shader attribute location
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetShaderLocationAttrib(Shader shader, string attribName);

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetShaderValue(Shader shader, int locIndex, void* value, int uniformType);

    /// <summary>
    /// Set shader uniform value vector
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetShaderValueV(Shader shader, int locIndex, void* value, int uniformType, int count);

    /// <summary>
    /// Set shader uniform value (matrix 4x4)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetShaderValueMatrix(Shader shader, int locIndex, Matrix4x4 mat);

    /// <summary>
    /// Set shader uniform value for texture (sampler2d)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetShaderValueTexture(Shader shader, int locIndex, Texture texture);

    /// <summary>
    /// Unload shader from GPU memory (VRAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadShader(Shader shader);

    /// <summary>
    /// Get a ray trace from screen position (i.e mouse)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Ray GetScreenToWorldRay(Vector2 position, Camera3D camera);

    /// <summary>
    /// Get a ray trace from screen position (i.e mouse) in a viewport
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Ray GetScreenToWorldRayEx(Vector2 position, Camera3D camera, int width, int height);

    /// <summary>
    /// Get the screen space position for a 3d world space position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreen(Vector3 position, Camera3D camera);

    /// <summary>
    /// Get size position for a 3d world space position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height);

    /// <summary>
    /// Get the screen space position for a 2d camera world space position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera);

    /// <summary>
    /// Get the world space position for a 2d camera screen space position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera);

    /// <summary>
    /// Get camera transform matrix (view matrix)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetCameraMatrix(Camera3D camera);

    /// <summary>
    /// Get camera 2d transform matrix
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetCameraMatrix2D(Camera2D camera);

    /// <summary>
    /// Set target FPS (maximum)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTargetFPS(int fps);

    /// <summary>
    /// Get time in seconds for last frame drawn (delta time)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetFrameTime();

    /// <summary>
    /// Get elapsed time in seconds since InitWindow()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial double GetTime();

    /// <summary>
    /// Get current FPS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFPS();

    /// <summary>
    /// Swap back buffer with front buffer (screen drawing)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SwapScreenBuffer();

    /// <summary>
    /// Register all input events
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PollInputEvents();

    /// <summary>
    /// Wait for some time (halt program execution)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void WaitTime(double seconds);

    /// <summary>
    /// Set the seed for the random number generator
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetRandomSeed(uint seed);

    /// <summary>
    /// Get a random value between min and max (both included)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetRandomValue(int min, int max);

    /// <summary>
    /// Load random values sequence, no values repeated
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int* LoadRandomSequence(uint count, int min, int max);

    /// <summary>
    /// Unload random values sequence
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadRandomSequence(int* sequence);

    /// <summary>
    /// Takes a screenshot of current screen (filename extension defines format)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TakeScreenshot(string fileName);

    /// <summary>
    /// Setup init configuration flags (view FLAGS)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetConfigFlags(uint flags);

    /// <summary>
    /// Open URL with default system browser (if available)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void OpenURL(string url);

    /// <summary>
    /// Show trace log messages (LOG_DEBUG, LOG_INFO, LOG_WARNING, LOG_ERROR...)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TraceLog(int logLevel, string text);

    /// <summary>
    /// Set the current threshold (minimum) log level
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTraceLogLevel(int logLevel);

    /// <summary>
    /// Internal memory allocator
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void* MemAlloc(uint size);

    /// <summary>
    /// Internal memory reallocator
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void* MemRealloc(void* ptr, uint size);

    /// <summary>
    /// Internal memory free
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void MemFree(void* ptr);

    /// <summary>
    /// Set custom trace log
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetTraceLogCallback(delegate* unmanaged[Cdecl]<int, string, string, void> callback);

    /// <summary>
    /// Set custom file binary data loader
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetLoadFileDataCallback(delegate* unmanaged[Cdecl]<string, int*, byte*> callback);

    /// <summary>
    /// Set custom file binary data saver
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetSaveFileDataCallback(delegate* unmanaged[Cdecl]<string, void*, int, NativeBool> callback);

    /// <summary>
    /// Set custom file text data loader
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetLoadFileTextCallback(delegate* unmanaged[Cdecl]<string, string> callback);

    /// <summary>
    /// Set custom file text data saver
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetSaveFileTextCallback(delegate* unmanaged[Cdecl]<string, string, NativeBool> callback);

    /// <summary>
    /// Load file data as byte array (read)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* LoadFileData(string fileName, int* dataSize);

    /// <summary>
    /// Unload file data allocated by LoadFileData()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadFileData(byte* data);

    /// <summary>
    /// Save data to file from byte array (write), returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial NativeBool SaveFileData(string fileName, void* data, int dataSize);

    /// <summary>
    /// Export data to code (.h), returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial NativeBool ExportDataAsCode(byte* data, int dataSize, string fileName);

    /// <summary>
    /// Load text data from file (read), returns a '\0' terminated string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string LoadFileText(string fileName);

    /// <summary>
    /// Unload file text data allocated by LoadFileText()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadFileText(string text);

    /// <summary>
    /// Save text data to file (write), string must be '\0' terminated, returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool SaveFileText(string fileName, string text);

    /// <summary>
    /// Check if file exists
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool FileExists(string fileName);

    /// <summary>
    /// Check if a directory path exists
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool DirectoryExists(string dirPath);

    /// <summary>
    /// Check file extension (including point: .png, .wav)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsFileExtension(string fileName, string ext);

    /// <summary>
    /// Get file length in bytes (NOTE: GetFileSize() conflicts with windows.h)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFileLength(string fileName);

    /// <summary>
    /// Get pointer to extension for a filename string (includes dot: '.png')
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetFileExtension(string fileName);

    /// <summary>
    /// Get pointer to filename for a path string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetFileName(string filePath);

    /// <summary>
    /// Get filename string without extension (uses static string)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetFileNameWithoutExt(string filePath);

    /// <summary>
    /// Get full path for a given fileName with path (uses static string)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetDirectoryPath(string filePath);

    /// <summary>
    /// Get previous directory path for a given path (uses static string)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetPrevDirectoryPath(string dirPath);

    /// <summary>
    /// Get current working directory (uses static string)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetWorkingDirectory();

    /// <summary>
    /// Get the directory of the running application (uses static string)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetApplicationDirectory();

    /// <summary>
    /// Create directories (including full path requested), returns 0 on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int MakeDirectory(string dirPath);

    /// <summary>
    /// Change working directory, return true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ChangeDirectory(string dir);

    /// <summary>
    /// Check if a given path is a file or a directory
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsPathFile(string path);

    /// <summary>
    /// Check if fileName is valid for the platform/OS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsFileNameValid(string fileName);

    /// <summary>
    /// Load directory filepaths
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDirectoryFiles(string dirPath);

    /// <summary>
    /// Load directory filepaths with extension filtering and recursive directory scan. Use 'DIR' in the filter string to include directories in the result
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDirectoryFilesEx(string basePath, string filter, NativeBool scanSubdirs);

    /// <summary>
    /// Unload filepaths
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadDirectoryFiles(FilePathList files);

    /// <summary>
    /// Check if a file has been dropped into window
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsFileDropped();

    /// <summary>
    /// Load dropped filepaths
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDroppedFiles();

    /// <summary>
    /// Unload dropped filepaths
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadDroppedFiles(FilePathList files);

    /// <summary>
    /// Get file modification time (last write time)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial long GetFileModTime(string fileName);

    /// <summary>
    /// Compress data (DEFLATE algorithm), memory must be MemFree()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* CompressData(byte* data, int dataSize, int* compDataSize);

    /// <summary>
    /// Decompress data (DEFLATE algorithm), memory must be MemFree()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* DecompressData(byte* compData, int compDataSize, int* dataSize);

    /// <summary>
    /// Encode data to Base64 string, memory must be MemFree()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string EncodeDataBase64(byte* data, int dataSize, int* outputSize);

    /// <summary>
    /// Decode Base64 string data, memory must be MemFree()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* DecodeDataBase64(byte* data, int* outputSize);

    /// <summary>
    /// Compute CRC32 hash code
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint ComputeCRC32(byte* data, int dataSize);

    /// <summary>
    /// Compute MD5 hash code, returns static int[4] (16 bytes)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint* ComputeMD5(byte* data, int dataSize);

    /// <summary>
    /// Compute SHA1 hash code, returns static int[5] (20 bytes)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint* ComputeSHA1(byte* data, int dataSize);

    /// <summary>
    /// Load automation events list from file, NULL for empty list, capacity = MAX_AUTOMATION_EVENTS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial AutomationEventList LoadAutomationEventList(string fileName);

    /// <summary>
    /// Unload automation events list from file
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadAutomationEventList(AutomationEventList list);

    /// <summary>
    /// Export automation events list as text file
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportAutomationEventList(AutomationEventList list, string fileName);

    /// <summary>
    /// Set automation event list to record to
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetAutomationEventList(AutomationEventList* list);

    /// <summary>
    /// Set automation event internal base frame to start recording
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAutomationEventBaseFrame(int frame);

    /// <summary>
    /// Start recording automation events (AutomationEventList must be set)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StartAutomationEventRecording();

    /// <summary>
    /// Stop recording automation events
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopAutomationEventRecording();

    /// <summary>
    /// Play a recorded automation event
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlayAutomationEvent(AutomationEvent @event);

    /// <summary>
    /// Check if a key has been pressed once
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyPressed(int key);

    /// <summary>
    /// Check if a key has been pressed again (Only PLATFORM_DESKTOP)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyPressedRepeat(int key);

    /// <summary>
    /// Check if a key is being pressed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyDown(int key);

    /// <summary>
    /// Check if a key has been released once
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyReleased(int key);

    /// <summary>
    /// Check if a key is NOT being pressed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyUp(int key);

    /// <summary>
    /// Get key pressed (keycode), call it multiple times for keys queued, returns 0 when the queue is empty
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetKeyPressed();

    /// <summary>
    /// Get char pressed (unicode), call it multiple times for chars queued, returns 0 when the queue is empty
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCharPressed();

    /// <summary>
    /// Set a custom key to exit program (default is ESC)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetExitKey(int key);

    /// <summary>
    /// Check if a gamepad is available
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadAvailable(int gamepad);

    /// <summary>
    /// Get gamepad internal name id
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetGamepadName(int gamepad);

    /// <summary>
    /// Check if a gamepad button has been pressed once
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadButtonPressed(int gamepad, int button);

    /// <summary>
    /// Check if a gamepad button is being pressed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadButtonDown(int gamepad, int button);

    /// <summary>
    /// Check if a gamepad button has been released once
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadButtonReleased(int gamepad, int button);

    /// <summary>
    /// Check if a gamepad button is NOT being pressed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadButtonUp(int gamepad, int button);

    /// <summary>
    /// Get the last gamepad button pressed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGamepadButtonPressed();

    /// <summary>
    /// Get gamepad axis count for a gamepad
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGamepadAxisCount(int gamepad);

    /// <summary>
    /// Get axis movement value for a gamepad axis
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGamepadAxisMovement(int gamepad, int axis);

    /// <summary>
    /// Set internal gamepad mappings (SDL_GameControllerDB)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int SetGamepadMappings(string mappings);

    /// <summary>
    /// Set gamepad vibration for both motors
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetGamepadVibration(int gamepad, float leftMotor, float rightMotor);

    /// <summary>
    /// Check if a mouse button has been pressed once
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMouseButtonPressed(int button);

    /// <summary>
    /// Check if a mouse button is being pressed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMouseButtonDown(int button);

    /// <summary>
    /// Check if a mouse button has been released once
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMouseButtonReleased(int button);

    /// <summary>
    /// Check if a mouse button is NOT being pressed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMouseButtonUp(int button);

    /// <summary>
    /// Get mouse position X
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMouseX();

    /// <summary>
    /// Get mouse position Y
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMouseY();

    /// <summary>
    /// Get mouse position XY
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMousePosition();

    /// <summary>
    /// Get mouse delta between frames
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMouseDelta();

    /// <summary>
    /// Set mouse position XY
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMousePosition(int x, int y);

    /// <summary>
    /// Set mouse offset
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseOffset(int offsetX, int offsetY);

    /// <summary>
    /// Set mouse scaling
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseScale(float scaleX, float scaleY);

    /// <summary>
    /// Get mouse wheel movement for X or Y, whichever is larger
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMouseWheelMove();

    /// <summary>
    /// Get mouse wheel movement for both X and Y
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMouseWheelMoveV();

    /// <summary>
    /// Set mouse cursor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseCursor(int cursor);

    /// <summary>
    /// Get touch position X for touch point 0 (relative to screen size)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchX();

    /// <summary>
    /// Get touch position Y for touch point 0 (relative to screen size)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchY();

    /// <summary>
    /// Get touch position XY for a touch point index (relative to screen size)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetTouchPosition(int index);

    /// <summary>
    /// Get touch point identifier for given index
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchPointId(int index);

    /// <summary>
    /// Get number of touch points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchPointCount();

    /// <summary>
    /// Enable a set of gestures using flags
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetGesturesEnabled(uint flags);

    /// <summary>
    /// Check if a gesture have been detected
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGestureDetected(uint gesture);

    /// <summary>
    /// Get latest detected gesture
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGestureDetected();

    /// <summary>
    /// Get gesture hold time in milliseconds
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGestureHoldDuration();

    /// <summary>
    /// Get gesture drag vector
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetGestureDragVector();

    /// <summary>
    /// Get gesture drag angle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGestureDragAngle();

    /// <summary>
    /// Get gesture pinch delta
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetGesturePinchVector();

    /// <summary>
    /// Get gesture pinch angle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGesturePinchAngle();

    /// <summary>
    /// Update camera position for selected mode
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateCamera(Camera3D* camera, int mode);

    /// <summary>
    /// Update camera movement/rotation
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateCameraPro(Camera3D* camera, Vector3 movement, Vector3 rotation, float zoom);

    /// <summary>
    /// Set texture and rectangle to be used on shapes drawing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetShapesTexture(Texture texture, Vector4 source);

    /// <summary>
    /// Get texture that is used for shapes drawing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture GetShapesTexture();

    /// <summary>
    /// Get texture source rectangle that is used for shapes drawing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetShapesTextureRectangle();

    /// <summary>
    /// Draw a pixel using geometry [Can be slow, use with care]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPixel(int posX, int posY, Color color);

    /// <summary>
    /// Draw a pixel using geometry (Vector version) [Can be slow, use with care]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPixelV(Vector2 position, Color color);

    /// <summary>
    /// Draw a line
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    /// <summary>
    /// Draw a line (using gl lines)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineV(Vector2 startPos, Vector2 endPos, Color color);

    /// <summary>
    /// Draw a line (using triangles/quads)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// Draw lines sequence (using gl lines)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawLineStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw line segment cubic-bezier in-out interpolation
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// Draw a color-filled circle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircle(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// Draw a piece of a circle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw circle sector outline
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw a gradient-filled circle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleGradient(int centerX, int centerY, float radius, Color inner, Color outer);

    /// <summary>
    /// Draw a color-filled circle (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleV(Vector2 center, float radius, Color color);

    /// <summary>
    /// Draw circle outline
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleLines(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// Draw circle outline (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleLinesV(Vector2 center, float radius, Color color);

    /// <summary>
    /// Draw ellipse
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// Draw ellipse outline
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// Draw ring
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw ring outline
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// Draw a color-filled rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangle(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw a color-filled rectangle (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleV(Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// Draw a color-filled rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRec(Vector4 rec, Color color);

    /// <summary>
    /// Draw a color-filled rectangle with pro parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectanglePro(Vector4 rec, Vector2 origin, float rotation, Color color);

    /// <summary>
    /// Draw a vertical-gradient-filled rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientV(int posX, int posY, int width, int height, Color top, Color bottom);

    /// <summary>
    /// Draw a horizontal-gradient-filled rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientH(int posX, int posY, int width, int height, Color left, Color right);

    /// <summary>
    /// Draw a gradient-filled rectangle with custom vertex colors
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientEx(Vector4 rec, Color topLeft, Color bottomLeft, Color topRight, Color bottomRight);

    /// <summary>
    /// Draw rectangle outline
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleLines(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw rectangle outline with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleLinesEx(Vector4 rec, float lineThick, Color color);

    /// <summary>
    /// Draw rectangle with rounded edges
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRounded(Vector4 rec, float roundness, int segments, Color color);

    /// <summary>
    /// Draw rectangle lines with rounded edges
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRoundedLines(Vector4 rec, float roundness, int segments, Color color);

    /// <summary>
    /// Draw rectangle with rounded edges outline
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRoundedLinesEx(Vector4 rec, float roundness, int segments, float lineThick, Color color);

    /// <summary>
    /// Draw a color-filled triangle (vertex in counter-clockwise order!)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw triangle outline (vertex in counter-clockwise order!)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw a triangle fan defined by points (first vertex is the center)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleFan(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a regular polygon (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// Draw a polygon outline of n sides
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// Draw a polygon outline of n sides with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color);

    /// <summary>
    /// Draw spline: Linear, minimum 2 points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineLinear(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: B-Spline, minimum 4 points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBasis(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Catmull-Rom, minimum 4 points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineCatmullRom(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Quadratic Bezier, minimum 3 points (1 control point): [p1, c2, p3, c4...]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBezierQuadratic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline: Cubic Bezier, minimum 4 points (2 control points): [p1, c2, c3, p4, c5, c6...]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBezierCubic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Linear, 2 points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentLinear(Vector2 p1, Vector2 p2, float thick, Color color);

    /// <summary>
    /// Draw spline segment: B-Spline, 4 points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Catmull-Rom, 4 points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Quadratic Bezier, 2 points, 1 control point
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBezierQuadratic(Vector2 p1, Vector2 c2, Vector2 p3, float thick, Color color);

    /// <summary>
    /// Draw spline segment: Cubic Bezier, 2 points, 2 control points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// Get (evaluate) spline point: Linear
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointLinear(Vector2 startPos, Vector2 endPos, float t);

    /// <summary>
    /// Get (evaluate) spline point: B-Spline
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

    /// <summary>
    /// Get (evaluate) spline point: Catmull-Rom
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

    /// <summary>
    /// Get (evaluate) spline point: Quadratic Bezier
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBezierQuad(Vector2 p1, Vector2 c2, Vector2 p3, float t);

    /// <summary>
    /// Get (evaluate) spline point: Cubic Bezier
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float t);

    /// <summary>
    /// Check collision between two rectangles
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionRecs(Vector4 rec1, Vector4 rec2);

    /// <summary>
    /// Check collision between two circles
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2);

    /// <summary>
    /// Check collision between circle and rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionCircleRec(Vector2 center, float radius, Vector4 rec);

    /// <summary>
    /// Check if point is inside rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionPointRec(Vector2 point, Vector4 rec);

    /// <summary>
    /// Check if point is inside circle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius);

    /// <summary>
    /// Check if point is inside a triangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3);

    /// <summary>
    /// Check if point is within a polygon described by array of vertices
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial NativeBool CheckCollisionPointPoly(Vector2 point, Vector2* points, int pointCount);

    /// <summary>
    /// Check the collision between two lines defined by two points each, returns collision point by reference
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial NativeBool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2* collisionPoint);

    /// <summary>
    /// Check if point belongs to line created between two points [p1] and [p2] with defined margin in pixels [threshold]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);

    /// <summary>
    /// Check if circle collides with a line created betweeen two points [p1] and [p2]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionCircleLine(Vector2 center, float radius, Vector2 p1, Vector2 p2);

    /// <summary>
    /// Get collision rectangle for two rectangles collision
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetCollisionRec(Vector4 rec1, Vector4 rec2);

    /// <summary>
    /// Load image from file into CPU memory (RAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImage(string fileName);

    /// <summary>
    /// Load image from RAW file data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageRaw(string fileName, int width, int height, int format, int headerSize);

    /// <summary>
    /// Load image sequence from file (frames appended to image.data)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image LoadImageAnim(string fileName, int* frames);

    /// <summary>
    /// Load image sequence from memory buffer
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image LoadImageAnimFromMemory(string fileType, byte* fileData, int dataSize, int* frames);

    /// <summary>
    /// Load image from memory buffer, fileType refers to extension: i.e. '.png'
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image LoadImageFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// Load image from GPU texture data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageFromTexture(Texture texture);

    /// <summary>
    /// Load image from screen buffer and (screenshot)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageFromScreen();

    /// <summary>
    /// Check if an image is valid (data and parameters)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsImageValid(Image image);

    /// <summary>
    /// Unload image from CPU memory (RAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadImage(Image image);

    /// <summary>
    /// Export image data to file, returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportImage(Image image, string fileName);

    /// <summary>
    /// Export image to memory buffer
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* ExportImageToMemory(Image image, string fileType, int* fileSize);

    /// <summary>
    /// Export image as code file defining an array of bytes, returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportImageAsCode(Image image, string fileName);

    /// <summary>
    /// Generate image: plain color
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageColor(int width, int height, Color color);

    /// <summary>
    /// Generate image: linear gradient, direction in degrees [0..360], 0=Vertical gradient
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientLinear(int width, int height, int direction, Color start, Color end);

    /// <summary>
    /// Generate image: radial gradient
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientRadial(int width, int height, float density, Color inner, Color outer);

    /// <summary>
    /// Generate image: square gradient
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientSquare(int width, int height, float density, Color inner, Color outer);

    /// <summary>
    /// Generate image: checked
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageChecked(int width, int height, int checksX, int checksY, Color col1, Color col2);

    /// <summary>
    /// Generate image: white noise
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageWhiteNoise(int width, int height, float factor);

    /// <summary>
    /// Generate image: perlin noise
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);

    /// <summary>
    /// Generate image: cellular algorithm, bigger tileSize means bigger cells
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageCellular(int width, int height, int tileSize);

    /// <summary>
    /// Generate image: grayscale image from text data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageText(int width, int height, string text);

    /// <summary>
    /// Create an image duplicate (useful for transformations)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageCopy(Image image);

    /// <summary>
    /// Create an image from another image piece
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageFromImage(Image image, Vector4 rec);

    /// <summary>
    /// Create an image from a selected channel of another image (GRAYSCALE)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageFromChannel(Image image, int selectedChannel);

    /// <summary>
    /// Create an image from text (default font)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageText(string text, int fontSize, Color color);

    /// <summary>
    /// Create an image from text (custom sprite font)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageTextEx(Font font, string text, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Convert image data to desired format
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageFormat(Image* image, int newFormat);

    /// <summary>
    /// Convert image to POT (power-of-two)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageToPOT(Image* image, Color fill);

    /// <summary>
    /// Crop an image to a defined rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageCrop(Image* image, Vector4 crop);

    /// <summary>
    /// Crop image depending on alpha value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageAlphaCrop(Image* image, float threshold);

    /// <summary>
    /// Clear alpha channel to desired color
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageAlphaClear(Image* image, Color color, float threshold);

    /// <summary>
    /// Apply alpha mask to image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageAlphaMask(Image* image, Image alphaMask);

    /// <summary>
    /// Premultiply alpha channel
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageAlphaPremultiply(Image* image);

    /// <summary>
    /// Apply Gaussian blur using a box blur approximation
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageBlurGaussian(Image* image, int blurSize);

    /// <summary>
    /// Apply custom square convolution kernel to image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageKernelConvolution(Image* image, float* kernel, int kernelSize);

    /// <summary>
    /// Resize image (Bicubic scaling algorithm)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageResize(Image* image, int newWidth, int newHeight);

    /// <summary>
    /// Resize image (Nearest-Neighbor scaling algorithm)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageResizeNN(Image* image, int newWidth, int newHeight);

    /// <summary>
    /// Resize canvas and fill with color
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageResizeCanvas(Image* image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill);

    /// <summary>
    /// Compute all mipmap levels for a provided image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageMipmaps(Image* image);

    /// <summary>
    /// Dither image data to 16bpp or lower (Floyd-Steinberg dithering)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDither(Image* image, int rBpp, int gBpp, int bBpp, int aBpp);

    /// <summary>
    /// Flip image vertically
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageFlipVertical(Image* image);

    /// <summary>
    /// Flip image horizontally
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageFlipHorizontal(Image* image);

    /// <summary>
    /// Rotate image by input angle in degrees (-359 to 359)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageRotate(Image* image, int degrees);

    /// <summary>
    /// Rotate image clockwise 90deg
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageRotateCW(Image* image);

    /// <summary>
    /// Rotate image counter-clockwise 90deg
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageRotateCCW(Image* image);

    /// <summary>
    /// Modify image color: tint
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorTint(Image* image, Color color);

    /// <summary>
    /// Modify image color: invert
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorInvert(Image* image);

    /// <summary>
    /// Modify image color: grayscale
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorGrayscale(Image* image);

    /// <summary>
    /// Modify image color: contrast (-100 to 100)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorContrast(Image* image, float contrast);

    /// <summary>
    /// Modify image color: brightness (-255 to 255)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorBrightness(Image* image, int brightness);

    /// <summary>
    /// Modify image color: replace color
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorReplace(Image* image, Color color, Color replace);

    /// <summary>
    /// Load color data from image as a Color array (RGBA - 32bit)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color* LoadImageColors(Image image);

    /// <summary>
    /// Load colors palette from image as a Color array (RGBA - 32bit)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color* LoadImagePalette(Image image, int maxPaletteSize, int* colorCount);

    /// <summary>
    /// Unload color data loaded with LoadImageColors()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadImageColors(Color* colors);

    /// <summary>
    /// Unload colors palette loaded with LoadImagePalette()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadImagePalette(Color* colors);

    /// <summary>
    /// Get image alpha border rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetImageAlphaBorder(Image image, float threshold);

    /// <summary>
    /// Get image pixel color at (x, y) position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GetImageColor(Image image, int x, int y);

    /// <summary>
    /// Clear image background with given color
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageClearBackground(Image* dst, Color color);

    /// <summary>
    /// Draw pixel within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawPixel(Image* dst, int posX, int posY, Color color);

    /// <summary>
    /// Draw pixel within an image (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawPixelV(Image* dst, Vector2 position, Color color);

    /// <summary>
    /// Draw line within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawLine(Image* dst, int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    /// <summary>
    /// Draw line within an image (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawLineV(Image* dst, Vector2 start, Vector2 end, Color color);

    /// <summary>
    /// Draw a line defining thickness within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawLineEx(Image* dst, Vector2 start, Vector2 end, int thick, Color color);

    /// <summary>
    /// Draw a filled circle within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawCircle(Image* dst, int centerX, int centerY, int radius, Color color);

    /// <summary>
    /// Draw a filled circle within an image (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawCircleV(Image* dst, Vector2 center, int radius, Color color);

    /// <summary>
    /// Draw circle outline within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawCircleLines(Image* dst, int centerX, int centerY, int radius, Color color);

    /// <summary>
    /// Draw circle outline within an image (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawCircleLinesV(Image* dst, Vector2 center, int radius, Color color);

    /// <summary>
    /// Draw rectangle within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawRectangle(Image* dst, int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Draw rectangle within an image (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawRectangleV(Image* dst, Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// Draw rectangle within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawRectangleRec(Image* dst, Vector4 rec, Color color);

    /// <summary>
    /// Draw rectangle lines within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawRectangleLines(Image* dst, Vector4 rec, int thick, Color color);

    /// <summary>
    /// Draw triangle within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangle(Image* dst, Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw triangle with interpolated colors within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangleEx(Image* dst, Vector2 v1, Vector2 v2, Vector2 v3, Color c1, Color c2, Color c3);

    /// <summary>
    /// Draw triangle outline within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangleLines(Image* dst, Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Draw a triangle fan defined by points within an image (first vertex is the center)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangleFan(Image* dst, Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points within an image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangleStrip(Image* dst, Vector2* points, int pointCount, Color color);

    /// <summary>
    /// Draw a source image within a destination image (tint applied to source)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDraw(Image* dst, Image src, Vector4 srcRec, Vector4 dstRec, Color tint);

    /// <summary>
    /// Draw text (using default font) within an image (destination)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawText(Image* dst, string text, int posX, int posY, int fontSize, Color color);

    /// <summary>
    /// Draw text (custom sprite font) within an image (destination)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTextEx(Image* dst, Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Load texture from file into GPU memory (VRAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture LoadTexture(string fileName);

    /// <summary>
    /// Load texture from image data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture LoadTextureFromImage(Image image);

    /// <summary>
    /// Load cubemap from image, multiple image cubemap layouts supported
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture LoadTextureCubemap(Image image, int layout);

    /// <summary>
    /// Load texture for rendering (framebuffer)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RenderTexture LoadRenderTexture(int width, int height);

    /// <summary>
    /// Check if a texture is valid (loaded in GPU)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsTextureValid(Texture texture);

    /// <summary>
    /// Unload texture from GPU memory (VRAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadTexture(Texture texture);

    /// <summary>
    /// Check if a render texture is valid (loaded in GPU)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsRenderTextureValid(RenderTexture target);

    /// <summary>
    /// Unload render texture from GPU memory (VRAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadRenderTexture(RenderTexture target);

    /// <summary>
    /// Update GPU texture with new data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateTexture(Texture texture, void* pixels);

    /// <summary>
    /// Update GPU texture rectangle with new data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateTextureRec(Texture texture, Vector4 rec, void* pixels);

    /// <summary>
    /// Generate GPU mipmaps for a texture
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GenTextureMipmaps(Texture* texture);

    /// <summary>
    /// Set texture scaling filter mode
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextureFilter(Texture texture, int filter);

    /// <summary>
    /// Set texture wrapping mode
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextureWrap(Texture texture, int wrap);

    /// <summary>
    /// Draw a Texture2D
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTexture(Texture texture, int posX, int posY, Color tint);

    /// <summary>
    /// Draw a Texture2D with position defined as Vector2
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureV(Texture texture, Vector2 position, Color tint);

    /// <summary>
    /// Draw a Texture2D with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureEx(Texture texture, Vector2 position, float rotation, float scale, Color tint);

    /// <summary>
    /// Draw a part of a texture defined by a rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureRec(Texture texture, Vector4 source, Vector2 position, Color tint);

    /// <summary>
    /// Draw a part of a texture defined by a rectangle with 'pro' parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTexturePro(Texture texture, Vector4 source, Vector4 dest, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// Draws a texture (or part of it) that stretches or shrinks nicely
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureNPatch(Texture texture, NPatchInfo nPatchInfo, Vector4 dest, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// Check if two colors are equal
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ColorIsEqual(Color col1, Color col2);

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color Fade(Color color, float alpha);

    /// <summary>
    /// Get hexadecimal value for a Color (0xRRGGBBAA)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int ColorToInt(Color color);

    /// <summary>
    /// Get Color normalized as float [0..1]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 ColorNormalize(Color color);

    /// <summary>
    /// Get Color from normalized values [0..1]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorFromNormalized(Vector4 normalized);

    /// <summary>
    /// Get HSV values for a Color, hue [0..360], saturation/value [0..1]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 ColorToHSV(Color color);

    /// <summary>
    /// Get a Color from HSV values, hue [0..360], saturation/value [0..1]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorFromHSV(float hue, float saturation, float value);

    /// <summary>
    /// Get color multiplied with another color
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorTint(Color color, Color tint);

    /// <summary>
    /// Get color with brightness correction, brightness factor goes from -1.0f to 1.0f
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorBrightness(Color color, float factor);

    /// <summary>
    /// Get color with contrast correction, contrast values between -1.0f and 1.0f
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorContrast(Color color, float contrast);

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorAlpha(Color color, float alpha);

    /// <summary>
    /// Get src alpha-blended into dst color with tint
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorAlphaBlend(Color dst, Color src, Color tint);

    /// <summary>
    /// Get color lerp interpolation between two colors, factor [0.0f..1.0f]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorLerp(Color color1, Color color2, float factor);

    /// <summary>
    /// Get Color structure from hexadecimal value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GetColor(uint hexValue);

    /// <summary>
    /// Get Color from a source pixel pointer of certain format
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color GetPixelColor(void* srcPtr, int format);

    /// <summary>
    /// Set color formatted into destination pixel pointer
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetPixelColor(void* dstPtr, Color color, int format);

    /// <summary>
    /// Get pixel data size in bytes for certain format
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetPixelDataSize(int width, int height, int format);

    /// <summary>
    /// Get the default Font
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font GetFontDefault();

    /// <summary>
    /// Load font from file into GPU memory (VRAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font LoadFont(string fileName);

    /// <summary>
    /// Load font from file with extended parameters, use NULL for codepoints and 0 for codepointCount to load the default character set, font size is provided in pixels height
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Font LoadFontEx(string fileName, int fontSize, int* codepoints, int codepointCount);

    /// <summary>
    /// Load font from Image (XNA style)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font LoadFontFromImage(Image image, Color key, int firstChar);

    /// <summary>
    /// Load font from memory buffer, fileType refers to extension: i.e. '.ttf'
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Font LoadFontFromMemory(string fileType, byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount);

    /// <summary>
    /// Check if a font is valid (font data loaded, WARNING: GPU texture not checked)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsFontValid(Font font);

    /// <summary>
    /// Load font data for further use
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial GlyphInfo* LoadFontData(byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount, int @type);

    /// <summary>
    /// Generate image font atlas using chars info
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image GenImageFontAtlas(GlyphInfo* glyphs, Vector4** glyphRecs, int glyphCount, int fontSize, int padding, int packMethod);

    /// <summary>
    /// Unload font chars info data (RAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadFontData(GlyphInfo* glyphs, int glyphCount);

    /// <summary>
    /// Unload font from GPU memory (VRAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadFont(Font font);

    /// <summary>
    /// Export font as code file, returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportFontAsCode(Font font, string fileName);

    /// <summary>
    /// Draw current FPS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawFPS(int posX, int posY);

    /// <summary>
    /// Draw text (using default font)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawText(string text, int posX, int posY, int fontSize, Color color);

    /// <summary>
    /// Draw text using font and additional parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Draw text using Font and pro parameters (rotation)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Draw one character (codepoint)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint);

    /// <summary>
    /// Draw multiple character (codepoint)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTextCodepoints(Font font, int* codepoints, int codepointCount, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Set vertical line spacing when drawing with line-breaks
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextLineSpacing(int spacing);

    /// <summary>
    /// Measure string width for default font
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int MeasureText(string text, int fontSize);

    /// <summary>
    /// Measure string size for Font
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing);

    /// <summary>
    /// Get glyph index position in font for a codepoint (unicode character), fallback to '?' if not found
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGlyphIndex(Font font, int codepoint);

    /// <summary>
    /// Get glyph font info data for a codepoint (unicode character), fallback to '?' if not found
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial GlyphInfo GetGlyphInfo(Font font, int codepoint);

    /// <summary>
    /// Get glyph rectangle in font atlas for a codepoint (unicode character), fallback to '?' if not found
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetGlyphAtlasRec(Font font, int codepoint);

    /// <summary>
    /// Load UTF-8 text encoded from codepoints array
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string LoadUTF8(int* codepoints, int length);

    /// <summary>
    /// Unload UTF-8 text encoded from codepoints array
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadUTF8(string text);

    /// <summary>
    /// Load all codepoints from a UTF-8 text string, codepoints count returned by parameter
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int* LoadCodepoints(string text, int* count);

    /// <summary>
    /// Unload codepoints data from memory
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadCodepoints(int* codepoints);

    /// <summary>
    /// Get total number of codepoints in a UTF-8 encoded string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCodepointCount(string text);

    /// <summary>
    /// Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GetCodepoint(string text, int* codepointSize);

    /// <summary>
    /// Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GetCodepointNext(string text, int* codepointSize);

    /// <summary>
    /// Get previous codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GetCodepointPrevious(string text, int* codepointSize);

    /// <summary>
    /// Encode one codepoint into UTF-8 byte array (array length returned as parameter)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string CodepointToUTF8(int codepoint, int* utf8Size);

    /// <summary>
    /// Copy one string to another, returns bytes copied
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextCopy(string dst, string src);

    /// <summary>
    /// Check if two text string are equal
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool TextIsEqual(string text1, string text2);

    /// <summary>
    /// Get text length, checks for '\0' ending
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint TextLength(string text);

    /// <summary>
    /// Text formatting with variables (sprintf() style)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextFormat(string text);

    /// <summary>
    /// Get a piece of a text string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextSubtext(string text, int position, int length);

    /// <summary>
    /// Replace text string (WARNING: memory must be freed!)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextReplace(string text, string replace, string @by);

    /// <summary>
    /// Insert text in a position (WARNING: memory must be freed!)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextInsert(string text, string insert, int position);

    /// <summary>
    /// Join text strings with delimiter
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string TextJoin(sbyte** textList, int count, string delimiter);

    /// <summary>
    /// Split text into multiple strings
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** TextSplit(string text, sbyte delimiter, int* count);

    /// <summary>
    /// Append text at specific position and move cursor!
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void TextAppend(string text, string append, int* position);

    /// <summary>
    /// Find first text occurrence within a string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextFindIndex(string text, string find);

    /// <summary>
    /// Get upper case version of provided string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToUpper(string text);

    /// <summary>
    /// Get lower case version of provided string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToLower(string text);

    /// <summary>
    /// Get Pascal case notation version of provided string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToPascal(string text);

    /// <summary>
    /// Get Snake case notation version of provided string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToSnake(string text);

    /// <summary>
    /// Get Camel case notation version of provided string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToCamel(string text);

    /// <summary>
    /// Get integer value from text (negative values not supported)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextToInteger(string text);

    /// <summary>
    /// Get float value from text (negative values not supported)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float TextToFloat(string text);

    /// <summary>
    /// Draw a line in 3D world space
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color);

    /// <summary>
    /// Draw a point in 3D space, actually a small line
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPoint3D(Vector3 position, Color color);

    /// <summary>
    /// Draw a circle in 3D world space
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color);

    /// <summary>
    /// Draw a color-filled triangle (vertex in counter-clockwise order!)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color);

    /// <summary>
    /// Draw a triangle strip defined by points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleStrip3D(Vector3* points, int pointCount, Color color);

    /// <summary>
    /// Draw cube
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCube(Vector3 position, float width, float height, float length, Color color);

    /// <summary>
    /// Draw cube (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Draw cube wires
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);

    /// <summary>
    /// Draw cube wires (Vector version)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeWiresV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Draw sphere
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphere(Vector3 centerPos, float radius, Color color);

    /// <summary>
    /// Draw sphere with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color);

    /// <summary>
    /// Draw sphere wires
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color);

    /// <summary>
    /// Draw a cylinder/cone
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    /// <summary>
    /// Draw a cylinder with base at startPos and top at endPos
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Draw a cylinder/cone wires
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    /// <summary>
    /// Draw a cylinder wires with base at startPos and top at endPos
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Draw a capsule with the center of its sphere caps at startPos and endPos
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    /// <summary>
    /// Draw capsule wireframe with the center of its sphere caps at startPos and endPos
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    /// <summary>
    /// Draw a plane XZ
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPlane(Vector3 centerPos, Vector2 size, Color color);

    /// <summary>
    /// Draw a ray line
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRay(Ray ray, Color color);

    /// <summary>
    /// Draw a grid (centered at (0, 0, 0))
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawGrid(int slices, float spacing);

    /// <summary>
    /// Load model from files (meshes and materials)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Model LoadModel(string fileName);

    /// <summary>
    /// Load model from generated mesh (default material)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Model LoadModelFromMesh(Mesh mesh);

    /// <summary>
    /// Check if a model is valid (loaded in GPU, VAO/VBOs)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsModelValid(Model model);

    /// <summary>
    /// Unload model (including meshes) from memory (RAM and/or VRAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadModel(Model model);

    /// <summary>
    /// Compute model bounding box limits (considers all meshes)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial BoundingBox GetModelBoundingBox(Model model);

    /// <summary>
    /// Draw a model (with texture if set)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModel(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw a model wires (with texture if set)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelWires(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model wires (with texture if set) with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw a model as points
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelPoints(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a model as points with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelPointsEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    /// <summary>
    /// Draw bounding box (wires)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBoundingBox(BoundingBox box, Color color);

    /// <summary>
    /// Draw a billboard texture
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboard(Camera3D camera, Texture texture, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Draw a billboard texture defined by source
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboardRec(Camera3D camera, Texture texture, Vector4 source, Vector3 position, Vector2 size, Color tint);

    /// <summary>
    /// Draw a billboard texture defined by source and rotation
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboardPro(Camera3D camera, Texture texture, Vector4 source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// Upload mesh vertex data in GPU and provide VAO/VBO ids
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UploadMesh(Mesh* mesh, NativeBool dynamic);

    /// <summary>
    /// Update mesh vertex data in GPU for a specific buffer index
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateMeshBuffer(Mesh mesh, int index, void* data, int dataSize, int offset);

    /// <summary>
    /// Unload mesh data from CPU and GPU
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadMesh(Mesh mesh);

    /// <summary>
    /// Draw a 3d mesh with material and transform
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawMesh(Mesh mesh, Material material, Matrix4x4 transform);

    /// <summary>
    /// Draw multiple mesh instances with material and different transforms
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawMeshInstanced(Mesh mesh, Material material, Matrix4x4* transforms, int instances);

    /// <summary>
    /// Compute mesh bounding box limits
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial BoundingBox GetMeshBoundingBox(Mesh mesh);

    /// <summary>
    /// Compute mesh tangents
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GenMeshTangents(Mesh* mesh);

    /// <summary>
    /// Export mesh data to file, returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportMesh(Mesh mesh, string fileName);

    /// <summary>
    /// Export mesh as code file (.h) defining multiple arrays of vertex attributes
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportMeshAsCode(Mesh mesh, string fileName);

    /// <summary>
    /// Generate polygonal mesh
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshPoly(int sides, float radius);

    /// <summary>
    /// Generate plane mesh (with subdivisions)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshPlane(float width, float length, int resX, int resZ);

    /// <summary>
    /// Generate cuboid mesh
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCube(float width, float height, float length);

    /// <summary>
    /// Generate sphere mesh (standard sphere)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshSphere(float radius, int rings, int slices);

    /// <summary>
    /// Generate half-sphere mesh (no bottom cap)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshHemiSphere(float radius, int rings, int slices);

    /// <summary>
    /// Generate cylinder mesh
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCylinder(float radius, float height, int slices);

    /// <summary>
    /// Generate cone/pyramid mesh
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCone(float radius, float height, int slices);

    /// <summary>
    /// Generate torus mesh
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshTorus(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// Generate trefoil knot mesh
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshKnot(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// Generate heightmap mesh from image data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshHeightmap(Image heightmap, Vector3 size);

    /// <summary>
    /// Generate cubes-based map mesh from image data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCubicmap(Image cubicmap, Vector3 cubeSize);

    /// <summary>
    /// Load materials from model file
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Material* LoadMaterials(string fileName, int* materialCount);

    /// <summary>
    /// Load default material (Supports: DIFFUSE, SPECULAR, NORMAL maps)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Material LoadMaterialDefault();

    /// <summary>
    /// Check if a material is valid (shader assigned, map textures loaded in GPU)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMaterialValid(Material material);

    /// <summary>
    /// Unload material from GPU memory (VRAM)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadMaterial(Material material);

    /// <summary>
    /// Set texture for a material map type (MATERIAL_MAP_DIFFUSE, MATERIAL_MAP_SPECULAR...)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetMaterialTexture(Material* material, int mapType, Texture texture);

    /// <summary>
    /// Set material for a mesh
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetModelMeshMaterial(Model* model, int meshId, int materialId);

    /// <summary>
    /// Load model animations from file
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial ModelAnimation* LoadModelAnimations(string fileName, int* animCount);

    /// <summary>
    /// Update model animation pose
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateModelAnimation(Model model, ModelAnimation anim, int frame);

    /// <summary>
    /// Unload animation data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadModelAnimation(ModelAnimation anim);

    /// <summary>
    /// Unload animation array data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadModelAnimations(ModelAnimation* animations, int animCount);

    /// <summary>
    /// Check model animation skeleton match
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsModelAnimationValid(Model model, ModelAnimation anim);

    /// <summary>
    /// Update model animation mesh bone matrices (Note GPU skinning does not work on Mac)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateModelAnimationBoneMatrices(Model model, ModelAnimation anim, int frame);

    /// <summary>
    /// Check collision between two spheres
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2);

    /// <summary>
    /// Check collision between two bounding boxes
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionBoxes(BoundingBox box1, BoundingBox box2);

    /// <summary>
    /// Check collision between box and sphere
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionBoxSphere(BoundingBox box, Vector3 center, float radius);

    /// <summary>
    /// Get collision info between ray and sphere
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionSphere(Ray ray, Vector3 center, float radius);

    /// <summary>
    /// Get collision info between ray and box
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionBox(Ray ray, BoundingBox box);

    /// <summary>
    /// Get collision info between ray and mesh
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionMesh(Ray ray, Mesh mesh, Matrix4x4 transform);

    /// <summary>
    /// Get collision info between ray and triangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3);

    /// <summary>
    /// Get collision info between ray and quad
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4);

    /// <summary>
    /// Initialize audio device and context
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void InitAudioDevice();

    /// <summary>
    /// Close the audio device and context
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CloseAudioDevice();

    /// <summary>
    /// Check if audio device has been initialized successfully
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsAudioDeviceReady();

    /// <summary>
    /// Set master volume (listener)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMasterVolume(float volume);

    /// <summary>
    /// Get master volume (listener)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMasterVolume();

    /// <summary>
    /// Load wave data from file
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Wave LoadWave(string fileName);

    /// <summary>
    /// Load wave from memory buffer, fileType refers to extension: i.e. '.wav'
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Wave LoadWaveFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// Checks if wave data is valid (data loaded and parameters)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWaveValid(Wave wave);

    /// <summary>
    /// Load sound from file
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSound(string fileName);

    /// <summary>
    /// Load sound from wave data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSoundFromWave(Wave wave);

    /// <summary>
    /// Create a new sound that shares the same sample data as the source sound, does not own the sound data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSoundAlias(Sound source);

    /// <summary>
    /// Checks if a sound is valid (data loaded and buffers initialized)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsSoundValid(Sound sound);

    /// <summary>
    /// Update sound buffer with new data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateSound(Sound sound, void* data, int sampleCount);

    /// <summary>
    /// Unload wave data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadWave(Wave wave);

    /// <summary>
    /// Unload sound
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadSound(Sound sound);

    /// <summary>
    /// Unload a sound alias (does not deallocate sample data)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadSoundAlias(Sound @alias);

    /// <summary>
    /// Export wave data to file, returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportWave(Wave wave, string fileName);

    /// <summary>
    /// Export wave sample data to code (.h), returns true on success
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportWaveAsCode(Wave wave, string fileName);

    /// <summary>
    /// Play a sound
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlaySound(Sound sound);

    /// <summary>
    /// Stop playing a sound
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopSound(Sound sound);

    /// <summary>
    /// Pause a sound
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PauseSound(Sound sound);

    /// <summary>
    /// Resume a paused sound
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ResumeSound(Sound sound);

    /// <summary>
    /// Check if a sound is currently playing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsSoundPlaying(Sound sound);

    /// <summary>
    /// Set volume for a sound (1.0 is max level)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundVolume(Sound sound, float volume);

    /// <summary>
    /// Set pitch for a sound (1.0 is base level)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundPitch(Sound sound, float pitch);

    /// <summary>
    /// Set pan for a sound (0.5 is center)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundPan(Sound sound, float pan);

    /// <summary>
    /// Copy a wave to a new wave
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Wave WaveCopy(Wave wave);

    /// <summary>
    /// Crop a wave to defined frames range
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void WaveCrop(Wave* wave, int initFrame, int finalFrame);

    /// <summary>
    /// Convert wave data to desired format
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void WaveFormat(Wave* wave, int sampleRate, int sampleSize, int channels);

    /// <summary>
    /// Load samples data from wave as a 32bit float data array
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial float* LoadWaveSamples(Wave wave);

    /// <summary>
    /// Unload samples data loaded with LoadWaveSamples()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadWaveSamples(float* samples);

    /// <summary>
    /// Load music stream from file
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Music LoadMusicStream(string fileName);

    /// <summary>
    /// Load music stream from data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Music LoadMusicStreamFromMemory(string fileType, byte* data, int dataSize);

    /// <summary>
    /// Checks if a music stream is valid (context and buffers initialized)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMusicValid(Music music);

    /// <summary>
    /// Unload music stream
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadMusicStream(Music music);

    /// <summary>
    /// Start music playing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlayMusicStream(Music music);

    /// <summary>
    /// Check if music is playing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMusicStreamPlaying(Music music);

    /// <summary>
    /// Updates buffers for music streaming
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateMusicStream(Music music);

    /// <summary>
    /// Stop music playing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopMusicStream(Music music);

    /// <summary>
    /// Pause music playing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PauseMusicStream(Music music);

    /// <summary>
    /// Resume playing paused music
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ResumeMusicStream(Music music);

    /// <summary>
    /// Seek music to a position (in seconds)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SeekMusicStream(Music music, float position);

    /// <summary>
    /// Set volume for music (1.0 is max level)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMusicVolume(Music music, float volume);

    /// <summary>
    /// Set pitch for a music (1.0 is base level)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMusicPitch(Music music, float pitch);

    /// <summary>
    /// Set pan for a music (0.5 is center)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMusicPan(Music music, float pan);

    /// <summary>
    /// Get music time length (in seconds)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMusicTimeLength(Music music);

    /// <summary>
    /// Get current music time played (in seconds)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMusicTimePlayed(Music music);

    /// <summary>
    /// Load audio stream (to stream raw audio pcm data)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial AudioStream LoadAudioStream(uint sampleRate, uint sampleSize, uint channels);

    /// <summary>
    /// Checks if an audio stream is valid (buffers initialized)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsAudioStreamValid(AudioStream stream);

    /// <summary>
    /// Unload audio stream and free memory
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadAudioStream(AudioStream stream);

    /// <summary>
    /// Update audio stream buffers with data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateAudioStream(AudioStream stream, void* data, int frameCount);

    /// <summary>
    /// Check if any audio stream buffers requires refill
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsAudioStreamProcessed(AudioStream stream);

    /// <summary>
    /// Play audio stream
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlayAudioStream(AudioStream stream);

    /// <summary>
    /// Pause audio stream
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PauseAudioStream(AudioStream stream);

    /// <summary>
    /// Resume audio stream
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ResumeAudioStream(AudioStream stream);

    /// <summary>
    /// Check if audio stream is playing
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsAudioStreamPlaying(AudioStream stream);

    /// <summary>
    /// Stop audio stream
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopAudioStream(AudioStream stream);

    /// <summary>
    /// Set volume for audio stream (1.0 is max level)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAudioStreamVolume(AudioStream stream, float volume);

    /// <summary>
    /// Set pitch for audio stream (1.0 is base level)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAudioStreamPitch(AudioStream stream, float pitch);

    /// <summary>
    /// Set pan for audio stream (0.5 is centered)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAudioStreamPan(AudioStream stream, float pan);

    /// <summary>
    /// Default size for new audio streams
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAudioStreamBufferSizeDefault(int size);

    /// <summary>
    /// Audio thread callback to request new data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetAudioStreamCallback(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> callback);

    /// <summary>
    /// Attach audio stream processor to stream, receives the samples as 'float'
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void AttachAudioStreamProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> processor);

    /// <summary>
    /// Detach audio stream processor from stream
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DetachAudioStreamProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> processor);

    /// <summary>
    /// Attach audio stream processor to the entire audio pipeline, receives the samples as 'float'
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void AttachAudioMixedProcessor(delegate* unmanaged[Cdecl]<void*, uint, void> processor);

    /// <summary>
    /// Detach audio stream processor from the entire audio pipeline
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DetachAudioMixedProcessor(delegate* unmanaged[Cdecl]<void*, uint, void> processor);
}
