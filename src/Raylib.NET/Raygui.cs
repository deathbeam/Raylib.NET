using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Numerics;
using Bindgen.Interop;

namespace Raylib.NET;

public static unsafe partial class Raygui
{
    public const string LIBRARY = "raygui";

    public const int BUILD_LIBTYPE_SHARED = 1;

    public const int RAYGUI_IMPLEMENTATION = 1;

    public const int RAYGUI_VERSION_MAJOR = 4;

    public const int RAYGUI_VERSION_MINOR = 5;

    public const int RAYGUI_VERSION_PATCH = 0;

    public const string RAYGUI_VERSION = "4.5-dev";

    public const int RAYLIB_VERSION_MAJOR = 5;

    public const int RAYLIB_VERSION_MINOR = 5;

    public const int RAYLIB_VERSION_PATCH = 0;

    public const string RAYLIB_VERSION = "5.5-dev";

    public const float PI = 3.14159265358979323846f;

    public static readonly float DEG2RAD = (PI/180.0f);

    public static readonly float RAD2DEG = (180.0f/PI);

    public const int SCROLLBAR_LEFT_SIDE = 0;

    public const int SCROLLBAR_RIGHT_SIDE = 1;

    public const int RAYGUI_ICON_SIZE = 16;

    public const int RAYGUI_ICON_MAX_ICONS = 256;

    public const int RAYGUI_ICON_MAX_NAME_LENGTH = 32;

    public static readonly float RAYGUI_ICON_DATA_ELEMENTS = (RAYGUI_ICON_SIZE*RAYGUI_ICON_SIZE/32);

    public const int RAYGUI_MAX_CONTROLS = 16;

    public const int RAYGUI_MAX_PROPS_BASE = 16;

    public const int RAYGUI_MAX_PROPS_EXTENDED = 8;

    public const int RAYGUI_WINDOWBOX_STATUSBAR_HEIGHT = 24;

    public const int RAYGUI_GROUPBOX_LINE_THICK = 1;

    public const int RAYGUI_LINE_MARGIN_TEXT = 12;

    public const int RAYGUI_LINE_TEXT_PADDING = 4;

    public const int RAYGUI_PANEL_BORDER_WIDTH = 1;

    public const int RAYGUI_TABBAR_ITEM_WIDTH = 160;

    public const int RAYGUI_MIN_SCROLLBAR_WIDTH = 40;

    public const int RAYGUI_MIN_SCROLLBAR_HEIGHT = 40;

    public const int RAYGUI_MIN_MOUSE_WHEEL_SPEED = 20;

    public const int RAYGUI_TOGGLEGROUP_MAX_ITEMS = 32;

    public const int RAYGUI_TEXTBOX_AUTO_CURSOR_COOLDOWN = 40;

    public const int RAYGUI_TEXTBOX_AUTO_CURSOR_DELAY = 1;

    public const int RAYGUI_VALUEBOX_MAX_CHARS = 32;

    public const int RAYGUI_COLORBARALPHA_CHECKED_SIZE = 10;

    public const int RAYGUI_MESSAGEBOX_BUTTON_HEIGHT = 24;

    public const int RAYGUI_MESSAGEBOX_BUTTON_PADDING = 12;

    public const int RAYGUI_TEXTINPUTBOX_BUTTON_HEIGHT = 24;

    public const int RAYGUI_TEXTINPUTBOX_BUTTON_PADDING = 12;

    public const int RAYGUI_TEXTINPUTBOX_HEIGHT = 26;

    public const float RAYGUI_GRID_ALPHA = 0.15f;

    public const int MAX_LINE_BUFFER_SIZE = 256;

    public const int ICON_TEXT_PADDING = 4;

    public const int RAYGUI_MAX_TEXT_LINES = 128;

    public const int RAYGUI_TEXTSPLIT_MAX_ITEMS = 128;

    public const int RAYGUI_TEXTSPLIT_MAX_TEXT_SIZE = 1024;

    /// <summary>
    /// Window-related functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void InitWindow(int width, int height, string title);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CloseWindow();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool WindowShouldClose();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowReady();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowFullscreen();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowHidden();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowMinimized();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowMaximized();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowFocused();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowResized();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWindowState(uint flag);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowState(uint flags);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearWindowState(uint flags);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ToggleFullscreen();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ToggleBorderlessWindowed();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void MaximizeWindow();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void MinimizeWindow();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void RestoreWindow();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowIcon(Image image);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetWindowIcons(Image* images, int count);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowTitle(string title);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowPosition(int x, int y);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowMonitor(int monitor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowMinSize(int width, int height);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowMaxSize(int width, int height);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowSize(int width, int height);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowOpacity(float opacity);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetWindowFocused();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void* GetWindowHandle();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetScreenWidth();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetScreenHeight();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetRenderWidth();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetRenderHeight();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorCount();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCurrentMonitor();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMonitorPosition(int monitor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorWidth(int monitor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorHeight(int monitor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorPhysicalWidth(int monitor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorPhysicalHeight(int monitor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMonitorRefreshRate(int monitor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWindowPosition();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWindowScaleDPI();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetMonitorName(int monitor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetClipboardText(string text);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetClipboardText();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableEventWaiting();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableEventWaiting();

    /// <summary>
    /// Cursor-related functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ShowCursor();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void HideCursor();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsCursorHidden();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EnableCursor();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DisableCursor();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsCursorOnScreen();

    /// <summary>
    /// Drawing-related functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ClearBackground(Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginDrawing();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndDrawing();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginMode2D(Camera2D camera);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndMode2D();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginMode3D(Camera3D camera);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndMode3D();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginTextureMode(RenderTexture target);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndTextureMode();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginShaderMode(Shader shader);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndShaderMode();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginBlendMode(int mode);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndBlendMode();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginScissorMode(int x, int y, int width, int height);

    /// <summary>
    /// Prevents name mangling of functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndScissorMode();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void BeginVrStereoMode(VrStereoConfig config);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void EndVrStereoMode();

    /// <summary>
    /// VR stereo config functions for VR simulator
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadVrStereoConfig(VrStereoConfig config);

    /// <summary>
    /// Shader management functions
    /// NOTE: Shader functionality is not available on OpenGL 1.1
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader LoadShader(string vsFileName, string fsFileName);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Shader LoadShaderFromMemory(string vsCode, string fsCode);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsShaderReady(Shader shader);

    /// <summary>
    /// required for: isspace() [GuiTextBox()]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetShaderLocation(Shader shader, string uniformName);

    /// <summary>
    /// Required for: FILE, fopen(), fclose(), fprintf(), feof(), fscanf(), vsprintf() [GuiLoadStyle(), GuiLoadIcons()]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetShaderLocationAttrib(Shader shader, string attribName);

    /// <summary>
    /// Required for: malloc(), calloc(), free() [GuiLoadStyle(), GuiLoadIcons()]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetShaderValue(Shader shader, int locIndex, void* value, int uniformType);

    /// <summary>
    /// Required for: strlen() [GuiTextBox(), GuiValueBox()], memset(), memcpy()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetShaderValueV(Shader shader, int locIndex, void* value, int uniformType, int count);

    /// <summary>
    /// Required for: va_list, va_start(), vfprintf(), va_end() [TextFormat()]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetShaderValueMatrix(Shader shader, int locIndex, Matrix4x4 mat);

    /// <summary>
    /// Required for: roundf() [GuiColorPicker()]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetShaderValueTexture(Shader shader, int locIndex, Texture texture);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadShader(Shader shader);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Ray GetScreenToWorldRay(Vector2 position, Camera3D camera);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Ray GetScreenToWorldRayEx(Vector2 position, Camera3D camera, int width, int height);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreen(Vector3 position, Camera3D camera);

    /// <summary>
    /// Check if two rectangles are equal, used to validate a slider bounds as an id
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetCameraMatrix(Camera3D camera);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Matrix4x4 GetCameraMatrix2D(Camera2D camera);

    /// <summary>
    /// Embedded icons, no external file provided
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTargetFPS(int fps);

    /// <summary>
    /// Size of icons in pixels (squared)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetFrameTime();

    /// <summary>
    /// Maximum number of icons
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial double GetTime();

    /// <summary>
    /// Maximum length of icon name id
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFPS();

    /// <summary>
    /// NOTE: Number of elemens depend on RAYGUI_ICON_SIZE (by default 16x16 pixels)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SwapScreenBuffer();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PollInputEvents();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void WaitTime(double seconds);

    /// <summary>
    /// Random values generation functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetRandomSeed(uint seed);

    /// <summary>
    /// NOTE 1: Every icon is codified in binary form, using 1 bit per pixel, so,
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetRandomValue(int min, int max);

    /// <summary>
    /// every 16x16 icon requires 8 integers (16*16/32) to be stored
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int* LoadRandomSequence(uint count, int min, int max);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadRandomSequence(int* sequence);

    /// <summary>
    /// Misc. functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TakeScreenshot(string fileName);

    /// <summary>
    /// guiIcons size is by default: 256*(16*16/32) = 2048*4 = 8192 bytes = 8 KB
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetConfigFlags(uint flags);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void OpenURL(string url);

    /// <summary>
    /// ICON_FILE_SAVE_CLASSIC
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void TraceLog(int logLevel, string text);

    /// <summary>
    /// ICON_FOLDER_OPEN
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTraceLogLevel(int logLevel);

    /// <summary>
    /// ICON_FOLDER_SAVE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void* MemAlloc(uint size);

    /// <summary>
    /// ICON_FILE_OPEN
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void* MemRealloc(void* ptr, uint size);

    /// <summary>
    /// ICON_FILE_SAVE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void MemFree(void* ptr);

    /// <summary>
    /// ICON_FILETYPE_TEXT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetTraceLogCallback(delegate* unmanaged[Cdecl]<int, string, string, void> callback);

    /// <summary>
    /// ICON_FILETYPE_AUDIO
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetLoadFileDataCallback(delegate* unmanaged[Cdecl]<string, int*, byte*> callback);

    /// <summary>
    /// ICON_FILETYPE_IMAGE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetSaveFileDataCallback(delegate* unmanaged[Cdecl]<string, void*, int, NativeBool> callback);

    /// <summary>
    /// ICON_FILETYPE_PLAY
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetLoadFileTextCallback(delegate* unmanaged[Cdecl]<string, string> callback);

    /// <summary>
    /// ICON_FILETYPE_VIDEO
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetSaveFileTextCallback(delegate* unmanaged[Cdecl]<string, string, NativeBool> callback);

    /// <summary>
    /// ICON_FILE_CUT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* LoadFileData(string fileName, int* dataSize);

    /// <summary>
    /// ICON_FILE_PASTE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadFileData(byte* data);

    /// <summary>
    /// ICON_CURSOR_HAND
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial NativeBool SaveFileData(string fileName, void* data, int dataSize);

    /// <summary>
    /// ICON_CURSOR_POINTER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial NativeBool ExportDataAsCode(byte* data, int dataSize, string fileName);

    /// <summary>
    /// ICON_CURSOR_CLASSIC
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string LoadFileText(string fileName);

    /// <summary>
    /// ICON_PENCIL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadFileText(string text);

    /// <summary>
    /// ICON_PENCIL_BIG
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool SaveFileText(string fileName, string text);

    /// <summary>
    /// ICON_COLOR_PICKER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool FileExists(string fileName);

    /// <summary>
    /// ICON_RUBBER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool DirectoryExists(string dirPath);

    /// <summary>
    /// ICON_COLOR_BUCKET
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsFileExtension(string fileName, string ext);

    /// <summary>
    /// ICON_TEXT_T
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetFileLength(string fileName);

    /// <summary>
    /// ICON_TEXT_A
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetFileExtension(string fileName);

    /// <summary>
    /// ICON_SCALE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetFileName(string filePath);

    /// <summary>
    /// ICON_RESIZE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetFileNameWithoutExt(string filePath);

    /// <summary>
    /// ICON_FILTER_POINT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetDirectoryPath(string filePath);

    /// <summary>
    /// ICON_FILTER_BILINEAR
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetPrevDirectoryPath(string dirPath);

    /// <summary>
    /// ICON_CROP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetWorkingDirectory();

    /// <summary>
    /// ICON_CROP_ALPHA
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetApplicationDirectory();

    /// <summary>
    /// ICON_SQUARE_TOGGLE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int MakeDirectory(string dirPath);

    /// <summary>
    /// ICON_SYMMETRY
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ChangeDirectory(string dir);

    /// <summary>
    /// ICON_SYMMETRY_HORIZONTAL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsPathFile(string path);

    /// <summary>
    /// ICON_SYMMETRY_VERTICAL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsFileNameValid(string fileName);

    /// <summary>
    /// ICON_LENS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDirectoryFiles(string dirPath);

    /// <summary>
    /// ICON_LENS_BIG
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDirectoryFilesEx(string basePath, string filter, NativeBool scanSubdirs);

    /// <summary>
    /// ICON_EYE_ON
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadDirectoryFiles(FilePathList files);

    /// <summary>
    /// ICON_EYE_OFF
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsFileDropped();

    /// <summary>
    /// ICON_FILTER_TOP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial FilePathList LoadDroppedFiles();

    /// <summary>
    /// ICON_FILTER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadDroppedFiles(FilePathList files);

    /// <summary>
    /// ICON_TARGET_POINT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial long GetFileModTime(string fileName);

    /// <summary>
    /// ICON_TARGET_MOVE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* CompressData(byte* data, int dataSize, int* compDataSize);

    /// <summary>
    /// ICON_CURSOR_MOVE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* DecompressData(byte* compData, int compDataSize, int* dataSize);

    /// <summary>
    /// ICON_CURSOR_SCALE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string EncodeDataBase64(byte* data, int dataSize, int* outputSize);

    /// <summary>
    /// ICON_CURSOR_SCALE_RIGHT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* DecodeDataBase64(byte* data, int* outputSize);

    /// <summary>
    /// ICON_REDO
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial AutomationEventList LoadAutomationEventList(string fileName);

    /// <summary>
    /// ICON_REREDO
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadAutomationEventList(AutomationEventList list);

    /// <summary>
    /// ICON_MUTATE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportAutomationEventList(AutomationEventList list, string fileName);

    /// <summary>
    /// ICON_ROTATE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetAutomationEventList(AutomationEventList* list);

    /// <summary>
    /// ICON_REPEAT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAutomationEventBaseFrame(int frame);

    /// <summary>
    /// ICON_SHUFFLE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StartAutomationEventRecording();

    /// <summary>
    /// ICON_EMPTYBOX
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopAutomationEventRecording();

    /// <summary>
    /// ICON_TARGET
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlayAutomationEvent(AutomationEvent @event);

    /// <summary>
    /// ICON_CURSOR_SCALE_LEFT_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyPressed(int key);

    /// <summary>
    /// ICON_UNDO_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyPressedRepeat(int key);

    /// <summary>
    /// ICON_REDO_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyDown(int key);

    /// <summary>
    /// ICON_REREDO_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyReleased(int key);

    /// <summary>
    /// ICON_MUTATE_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsKeyUp(int key);

    /// <summary>
    /// ICON_ROTATE_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetKeyPressed();

    /// <summary>
    /// ICON_REPEAT_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCharPressed();

    /// <summary>
    /// ICON_SHUFFLE_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetExitKey(int key);

    /// <summary>
    /// ICON_BOX_TOP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadAvailable(int gamepad);

    /// <summary>
    /// ICON_BOX_TOP_RIGHT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GetGamepadName(int gamepad);

    /// <summary>
    /// ICON_BOX_RIGHT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadButtonPressed(int gamepad, int button);

    /// <summary>
    /// ICON_BOX_BOTTOM_RIGHT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadButtonDown(int gamepad, int button);

    /// <summary>
    /// ICON_BOX_BOTTOM
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadButtonReleased(int gamepad, int button);

    /// <summary>
    /// ICON_BOX_BOTTOM_LEFT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGamepadButtonUp(int gamepad, int button);

    /// <summary>
    /// ICON_BOX_LEFT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGamepadButtonPressed();

    /// <summary>
    /// ICON_BOX_TOP_LEFT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGamepadAxisCount(int gamepad);

    /// <summary>
    /// ICON_BOX_CENTER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGamepadAxisMovement(int gamepad, int axis);

    /// <summary>
    /// ICON_BOX_CIRCLE_MASK
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int SetGamepadMappings(string mappings);

    /// <summary>
    /// ICON_POT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetGamepadVibration(int gamepad, float leftMotor, float rightMotor);

    /// <summary>
    /// ICON_DITHERING
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMouseButtonPressed(int button);

    /// <summary>
    /// ICON_MIPMAPS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMouseButtonDown(int button);

    /// <summary>
    /// ICON_BOX_GRID
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMouseButtonReleased(int button);

    /// <summary>
    /// ICON_GRID
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMouseButtonUp(int button);

    /// <summary>
    /// ICON_BOX_CORNERS_SMALL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMouseX();

    /// <summary>
    /// ICON_BOX_CORNERS_BIG
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetMouseY();

    /// <summary>
    /// ICON_FOUR_BOXES
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMousePosition();

    /// <summary>
    /// ICON_GRID_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMouseDelta();

    /// <summary>
    /// ICON_BOX_MULTISIZE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMousePosition(int x, int y);

    /// <summary>
    /// ICON_ZOOM_SMALL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseOffset(int offsetX, int offsetY);

    /// <summary>
    /// ICON_ZOOM_MEDIUM
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseScale(float scaleX, float scaleY);

    /// <summary>
    /// ICON_ZOOM_BIG
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMouseWheelMove();

    /// <summary>
    /// ICON_ZOOM_ALL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetMouseWheelMoveV();

    /// <summary>
    /// ICON_ZOOM_CENTER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMouseCursor(int cursor);

    /// <summary>
    /// ICON_BOX_CONCENTRIC
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchX();

    /// <summary>
    /// ICON_BOX_GRID_BIG
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchY();

    /// <summary>
    /// ICON_OK_TICK
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetTouchPosition(int index);

    /// <summary>
    /// ICON_CROSS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchPointId(int index);

    /// <summary>
    /// ICON_ARROW_LEFT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTouchPointCount();

    /// <summary>
    /// ICON_ARROW_RIGHT_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetGesturesEnabled(uint flags);

    /// <summary>
    /// ICON_ARROW_DOWN_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsGestureDetected(uint gesture);

    /// <summary>
    /// ICON_ARROW_UP_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGestureDetected();

    /// <summary>
    /// ICON_AUDIO
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGestureHoldDuration();

    /// <summary>
    /// ICON_FX
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetGestureDragVector();

    /// <summary>
    /// ICON_WAVE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGestureDragAngle();

    /// <summary>
    /// ICON_WAVE_SINUS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetGesturePinchVector();

    /// <summary>
    /// ICON_WAVE_SQUARE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetGesturePinchAngle();

    /// <summary>
    /// ICON_PLAYER_PLAY
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateCamera(Camera3D* camera, int mode);

    /// <summary>
    /// ICON_PLAYER_PAUSE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateCameraPro(Camera3D* camera, Vector3 movement, Vector3 rotation, float zoom);

    /// <summary>
    /// ICON_TOOLS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetShapesTexture(Texture texture, Vector4 source);

    /// <summary>
    /// ICON_GEAR
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture GetShapesTexture();

    /// <summary>
    /// ICON_GEAR_BIG
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetShapesTextureRectangle();

    /// <summary>
    /// ICON_LASER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPixel(int posX, int posY, Color color);

    /// <summary>
    /// ICON_COIN
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPixelV(Vector2 position, Color color);

    /// <summary>
    /// ICON_EXPLOSION
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    /// <summary>
    /// ICON_1UP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineV(Vector2 startPos, Vector2 endPos, Color color);

    /// <summary>
    /// ICON_PLAYER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// ICON_PLAYER_JUMP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawLineStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// ICON_KEY
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color);

    /// <summary>
    /// ICON_DEMON
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircle(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// ICON_TEXT_POPUP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// ICON_GEAR_EX
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// ICON_CRACK
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleGradient(int centerX, int centerY, float radius, Color inner, Color outer);

    /// <summary>
    /// ICON_CRACK_POINTS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleV(Vector2 center, float radius, Color color);

    /// <summary>
    /// ICON_STAR
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleLines(int centerX, int centerY, float radius, Color color);

    /// <summary>
    /// ICON_DOOR
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircleLinesV(Vector2 center, float radius, Color color);

    /// <summary>
    /// ICON_EXIT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// ICON_MODE_2D
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);

    /// <summary>
    /// ICON_MODE_3D
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// ICON_CUBE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

    /// <summary>
    /// ICON_CUBE_FACE_TOP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangle(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// ICON_CUBE_FACE_LEFT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleV(Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// ICON_CUBE_FACE_FRONT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRec(Vector4 rec, Color color);

    /// <summary>
    /// ICON_CUBE_FACE_BOTTOM
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectanglePro(Vector4 rec, Vector2 origin, float rotation, Color color);

    /// <summary>
    /// ICON_CUBE_FACE_RIGHT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientV(int posX, int posY, int width, int height, Color top, Color bottom);

    /// <summary>
    /// ICON_CUBE_FACE_BACK
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientH(int posX, int posY, int width, int height, Color left, Color right);

    /// <summary>
    /// ICON_CAMERA
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleGradientEx(Vector4 rec, Color topLeft, Color bottomLeft, Color topRight, Color bottomRight);

    /// <summary>
    /// ICON_SPECIAL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleLines(int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// ICON_LINK_NET
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleLinesEx(Vector4 rec, float lineThick, Color color);

    /// <summary>
    /// ICON_LINK_BOXES
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRounded(Vector4 rec, float roundness, int segments, Color color);

    /// <summary>
    /// ICON_LINK_MULTI
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRoundedLines(Vector4 rec, float roundness, int segments, Color color);

    /// <summary>
    /// ICON_LINK
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRectangleRoundedLinesEx(Vector4 rec, float roundness, int segments, float lineThick, Color color);

    /// <summary>
    /// ICON_LINK_BROKE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// ICON_TEXT_NOTES
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// ICON_NOTEBOOK
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleFan(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// ICON_SUITCASE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleStrip(Vector2* points, int pointCount, Color color);

    /// <summary>
    /// ICON_SUITCASE_ZIP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// ICON_MAILBOX
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color);

    /// <summary>
    /// ICON_MONITOR
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color);

    /// <summary>
    /// ICON_PHOTO_CAMERA_FLASH
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineLinear(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// ICON_HOUSE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBasis(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// ICON_HEART
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineCatmullRom(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// ICON_CORNER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBezierQuadratic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// ICON_VERTICAL_BARS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawSplineBezierCubic(Vector2* points, int pointCount, float thick, Color color);

    /// <summary>
    /// ICON_VERTICAL_BARS_FILL
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentLinear(Vector2 p1, Vector2 p2, float thick, Color color);

    /// <summary>
    /// ICON_LIFE_BARS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// ICON_INFO
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// ICON_CROSSLINE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBezierQuadratic(Vector2 p1, Vector2 c2, Vector2 p3, float thick, Color color);

    /// <summary>
    /// ICON_HELP
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSplineSegmentBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float thick, Color color);

    /// <summary>
    /// ICON_LAYERS_VISIBLE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointLinear(Vector2 startPos, Vector2 endPos, float t);

    /// <summary>
    /// ICON_LAYERS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

    /// <summary>
    /// ICON_WINDOW
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);

    /// <summary>
    /// ICON_HIDPI
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBezierQuad(Vector2 p1, Vector2 c2, Vector2 p3, float t);

    /// <summary>
    /// ICON_FILETYPE_BINARY
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 GetSplinePointBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float t);

    /// <summary>
    /// ICON_FILE_NEW
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionRecs(Vector4 rec1, Vector4 rec2);

    /// <summary>
    /// ICON_FOLDER_ADD
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2);

    /// <summary>
    /// ICON_ALARM
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionCircleRec(Vector2 center, float radius, Vector4 rec);

    /// <summary>
    /// ICON_CPU
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionPointRec(Vector2 point, Vector4 rec);

    /// <summary>
    /// ICON_ROM
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius);

    /// <summary>
    /// ICON_STEP_OVER
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3);

    /// <summary>
    /// ICON_STEP_INTO
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial NativeBool CheckCollisionPointPoly(Vector2 point, Vector2* points, int pointCount);

    /// <summary>
    /// ICON_STEP_OUT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial NativeBool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2* collisionPoint);

    /// <summary>
    /// ICON_RESTART
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);

    /// <summary>
    /// ICON_BREAKPOINT_ON
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionCircleLine(Vector2 center, float radius, Vector2 p1, Vector2 p2);

    /// <summary>
    /// ICON_BREAKPOINT_OFF
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetCollisionRec(Vector4 rec1, Vector4 rec2);

    /// <summary>
    /// ICON_HELP_BOX
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImage(string fileName);

    /// <summary>
    /// ICON_INFO_BOX
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageRaw(string fileName, int width, int height, int format, int headerSize);

    /// <summary>
    /// ICON_PRIORITY
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image LoadImageAnim(string fileName, int* frames);

    /// <summary>
    /// ICON_LAYERS_ISO
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image LoadImageAnimFromMemory(string fileType, byte* fileData, int dataSize, int* frames);

    /// <summary>
    /// ICON_LAYERS2
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image LoadImageFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// ICON_MLAYERS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageFromTexture(Texture texture);

    /// <summary>
    /// ICON_MAPS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image LoadImageFromScreen();

    /// <summary>
    /// ICON_HOT
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsImageReady(Image image);

    /// <summary>
    /// ICON_229
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadImage(Image image);

    /// <summary>
    /// ICON_230
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportImage(Image image, string fileName);

    /// <summary>
    /// ICON_231
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial byte* ExportImageToMemory(Image image, string fileType, int* fileSize);

    /// <summary>
    /// ICON_232
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportImageAsCode(Image image, string fileName);

    /// <summary>
    /// ICON_235
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageColor(int width, int height, Color color);

    /// <summary>
    /// ICON_236
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientLinear(int width, int height, int direction, Color start, Color end);

    /// <summary>
    /// ICON_237
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientRadial(int width, int height, float density, Color inner, Color outer);

    /// <summary>
    /// ICON_238
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageGradientSquare(int width, int height, float density, Color inner, Color outer);

    /// <summary>
    /// ICON_239
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageChecked(int width, int height, int checksX, int checksY, Color col1, Color col2);

    /// <summary>
    /// ICON_240
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageWhiteNoise(int width, int height, float factor);

    /// <summary>
    /// ICON_241
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);

    /// <summary>
    /// ICON_242
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageCellular(int width, int height, int tileSize);

    /// <summary>
    /// ICON_243
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image GenImageText(int width, int height, string text);

    /// <summary>
    /// ICON_246
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageCopy(Image image);

    /// <summary>
    /// ICON_247
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageFromImage(Image image, Vector4 rec);

    /// <summary>
    /// ICON_248
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageFromChannel(Image image, int selectedChannel);

    /// <summary>
    /// ICON_249
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageText(string text, int fontSize, Color color);

    /// <summary>
    /// ICON_250
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Image ImageTextEx(Font font, string text, float fontSize, float spacing, Color tint);

    /// <summary>
    /// ICON_251
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageFormat(Image* image, int newFormat);

    /// <summary>
    /// ICON_252
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageToPOT(Image* image, Color fill);

    /// <summary>
    /// ICON_253
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageCrop(Image* image, Vector4 crop);

    /// <summary>
    /// ICON_254
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageAlphaCrop(Image* image, float threshold);

    /// <summary>
    /// ICON_255
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageAlphaClear(Image* image, Color color, float threshold);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageAlphaMask(Image* image, Image alphaMask);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageAlphaPremultiply(Image* image);

    /// <summary>
    /// NOTE: A pointer to current icons array should be defined
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageBlurGaussian(Image* image, int blurSize);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageKernelConvolution(Image* image, float* kernel, int kernelSize);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageResize(Image* image, int newWidth, int newHeight);

    /// <summary>
    /// !RAYGUI_NO_ICONS && !RAYGUI_CUSTOM_ICONS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageResizeNN(Image* image, int newWidth, int newHeight);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageResizeCanvas(Image* image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageMipmaps(Image* image);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDither(Image* image, int rBpp, int gBpp, int bBpp, int aBpp);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageFlipVertical(Image* image);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageFlipHorizontal(Image* image);

    /// <summary>
    /// WARNING: Those values define the total size of the style data array,
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageRotate(Image* image, int degrees);

    /// <summary>
    /// if changed, previous saved styles could become incompatible
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageRotateCW(Image* image);

    /// <summary>
    /// Maximum number of controls
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageRotateCCW(Image* image);

    /// <summary>
    /// Maximum number of base properties
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorTint(Image* image, Color color);

    /// <summary>
    /// Maximum number of extended properties
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorInvert(Image* image);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorGrayscale(Image* image);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorContrast(Image* image, float contrast);

    /// <summary>
    /// Types and Structures Definition
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorBrightness(Image* image, int brightness);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageColorReplace(Image* image, Color color, Color replace);

    /// <summary>
    /// Gui control property style color element
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color* LoadImageColors(Image image);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color* LoadImagePalette(Image image, int maxPaletteSize, int* colorCount);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadImageColors(Color* colors);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadImagePalette(Color* colors);

    /// <summary>
    /// Global Variables Definition
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetImageAlphaBorder(Image image, float threshold);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GetImageColor(Image image, int x, int y);

    /// <summary>
    /// Gui lock state (no inputs processed)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageClearBackground(Image* dst, Color color);

    /// <summary>
    /// Gui controls transparency
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawPixel(Image* dst, int posX, int posY, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawPixelV(Image* dst, Vector2 position, Color color);

    /// <summary>
    /// Gui icon default scale (if icons enabled)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawLine(Image* dst, int startPosX, int startPosY, int endPosX, int endPosY, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawLineV(Image* dst, Vector2 start, Vector2 end, Color color);

    /// <summary>
    /// Tooltip enabled/disabled
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawLineEx(Image* dst, Vector2 start, Vector2 end, int thick, Color color);

    /// <summary>
    /// Tooltip string pointer (string provided by user)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawCircle(Image* dst, int centerX, int centerY, int radius, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawCircleV(Image* dst, Vector2 center, int radius, Color color);

    /// <summary>
    /// Gui control exclusive mode (no inputs processed except current control)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawCircleLines(Image* dst, int centerX, int centerY, int radius, Color color);

    /// <summary>
    /// Gui control exclusive bounds rectangle, used as an unique identifier
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawCircleLinesV(Image* dst, Vector2 center, int radius, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawRectangle(Image* dst, int posX, int posY, int width, int height, Color color);

    /// <summary>
    /// Cursor index, shared by all GuiTextBox*()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawRectangleV(Image* dst, Vector2 position, Vector2 size, Color color);

    /// <summary>
    /// static int blinkCursorFrameCounter = 0;       // Frame counter for cursor blinking
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawRectangleRec(Image* dst, Vector4 rec, Color color);

    /// <summary>
    /// Cooldown frame counter for automatic cursor movement on key-down
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawRectangleLines(Image* dst, Vector4 rec, int thick, Color color);

    /// <summary>
    /// Delay frame counter for automatic cursor movement
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangle(Image* dst, Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangleEx(Image* dst, Vector2 v1, Vector2 v2, Vector2 v3, Color c1, Color c2, Color c3);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangleLines(Image* dst, Vector2 v1, Vector2 v2, Vector2 v3, Color color);

    /// <summary>
    /// Style data array for all gui style properties (allocated on data segment by default)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangleFan(Image* dst, Vector2* points, int pointCount, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTriangleStrip(Image* dst, Vector2* points, int pointCount, Color color);

    /// <summary>
    /// NOTE 1: First set of BASE properties are generic to all controls but could be individually
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDraw(Image* dst, Image src, Vector4 srcRec, Vector4 dstRec, Color tint);

    /// <summary>
    /// overwritten per control, first set of EXTENDED properties are generic to all controls and
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawText(Image* dst, string text, int posX, int posY, int fontSize, Color color);

    /// <summary>
    /// can not be overwritten individually but custom EXTENDED properties can be used by control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void ImageDrawTextEx(Image* dst, Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Texture loading functions
    /// NOTE: These functions require GPU access
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture LoadTexture(string fileName);

    /// <summary>
    /// guiStyle size is by default: 16*(16 + 8) = 384*4 = 1536 bytes = 1.5 KB
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture LoadTextureFromImage(Image image);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Texture LoadTextureCubemap(Image image, int layout);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RenderTexture LoadRenderTexture(int width, int height);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsTextureReady(Texture texture);

    /// <summary>
    /// Style loaded flag for lazy style initialization
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadTexture(Texture texture);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsRenderTextureReady(RenderTexture target);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadRenderTexture(RenderTexture target);

    /// <summary>
    /// Standalone Mode Functions Declaration
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateTexture(Texture texture, void* pixels);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateTextureRec(Texture texture, Vector4 rec, void* pixels);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GenTextureMipmaps(Texture* texture);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextureFilter(Texture texture, int filter);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextureWrap(Texture texture, int wrap);

    /// <summary>
    /// Texture drawing functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTexture(Texture texture, int posX, int posY, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureV(Texture texture, Vector2 position, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureEx(Texture texture, Vector2 position, float rotation, float scale, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureRec(Texture texture, Vector4 source, Vector2 position, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTexturePro(Texture texture, Vector4 source, Vector4 dest, Vector2 origin, float rotation, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextureNPatch(Texture texture, NPatchInfo nPatchInfo, Vector4 dest, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// -------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ColorIsEqual(Color col1, Color col2);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color Fade(Color color, float alpha);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int ColorToInt(Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 ColorNormalize(Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorFromNormalized(Vector4 normalized);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 ColorToHSV(Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorFromHSV(float hue, float saturation, float value);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorTint(Color color, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorBrightness(Color color, float factor);

    /// <summary>
    /// -- GuiTextBox(), GuiValueBox()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorContrast(Color color, float contrast);

    /// <summary>
    /// -------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorAlpha(Color color, float alpha);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorAlphaBlend(Color dst, Color src, Color tint);

    /// <summary>
    /// Drawing required functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color ColorLerp(Color color1, Color color2, float factor);

    /// <summary>
    /// -------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GetColor(uint hexValue);

    /// <summary>
    /// -- GuiDrawRectangle()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Color GetPixelColor(void* srcPtr, int format);

    /// <summary>
    /// -- GuiColorPicker()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetPixelColor(void* dstPtr, Color color, int format);

    /// <summary>
    /// -------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetPixelDataSize(int width, int height, int format);

    /// <summary>
    /// -- GuiLoadStyle(), required to load texture from embedded font atlas image
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font GetFontDefault();

    /// <summary>
    /// -- GuiLoadStyle(), required to set shapes rec to font white rec (optimization)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font LoadFont(string fileName);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Font LoadFontEx(string fileName, int fontSize, int* codepoints, int codepointCount);

    /// <summary>
    /// -- GuiLoadStyle(), required to load charset data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font LoadFontFromImage(Image image, Color key, int firstChar);

    /// <summary>
    /// -- GuiLoadStyle(), required to unload charset data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Font LoadFontFromMemory(string fileType, byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsFontReady(Font font);

    /// <summary>
    /// -- GuiLoadStyle(), required to find charset/font file from text .rgs
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial GlyphInfo* LoadFontData(byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount, int @type);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Image GenImageFontAtlas(GlyphInfo* glyphs, Vector4** glyphRecs, int glyphCount, int fontSize, int padding, int packMethod);

    /// <summary>
    /// -- GuiLoadStyle(), required to load required font codepoints list
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadFontData(GlyphInfo* glyphs, int glyphCount);

    /// <summary>
    /// -- GuiLoadStyle(), required to unload codepoints list
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadFont(Font font);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportFontAsCode(Font font, string fileName);

    /// <summary>
    /// Text drawing functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawFPS(int posX, int posY);

    /// <summary>
    /// raylib functions already implemented in raygui
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawText(string text, int posX, int posY, int fontSize, Color color);

    /// <summary>
    /// -------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Returns a Color struct from hexadecimal value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Returns hexadecimal value for a Color
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint);

    /// <summary>
    /// Check if point is inside rectangle
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTextCodepoints(Font font, int* codepoints, int codepointCount, Vector2 position, float fontSize, float spacing, Color tint);

    /// <summary>
    /// Get integer value from text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetTextLineSpacing(int spacing);

    /// <summary>
    /// Get float value from text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int MeasureText(string text, int fontSize);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing);

    /// <summary>
    /// Get next codepoint in a UTF-8 encoded text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetGlyphIndex(Font font, int codepoint);

    /// <summary>
    /// Encode codepoint into UTF-8 text (char array size returned as parameter)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial GlyphInfo GetGlyphInfo(Font font, int codepoint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetGlyphAtlasRec(Font font, int codepoint);

    /// <summary>
    /// Text codepoints management functions (unicode characters)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string LoadUTF8(int* codepoints, int length);

    /// <summary>
    /// RAYGUI_STANDALONE
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadUTF8(string text);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int* LoadCodepoints(string text, int* count);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadCodepoints(int* codepoints);

    /// <summary>
    /// Module specific Functions Declaration
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetCodepointCount(string text);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GetCodepoint(string text, int* codepointSize);

    /// <summary>
    /// Load style from memory (binary only)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GetCodepointNext(string text, int* codepointSize);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GetCodepointPrevious(string text, int* codepointSize);

    /// <summary>
    /// Gui get text width using gui font and style
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string CodepointToUTF8(int codepoint, int* utf8Size);

    /// <summary>
    /// Gui draw text using default font
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextCopy(string dst, string src);

    /// <summary>
    /// Gui draw rectangle using default raygui style
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool TextIsEqual(string text1, string text2);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial uint TextLength(string text);

    /// <summary>
    /// Split controls text into multiple strings
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextFormat(string text);

    /// <summary>
    /// Convert color data from HSV to RGB
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextSubtext(string text, int position, int length);

    /// <summary>
    /// Convert color data from RGB to HSV
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextReplace(string text, string replace, string @by);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextInsert(string text, string insert, int position);

    /// <summary>
    /// Scroll bar control, used by GuiScrollPanel()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string TextJoin(sbyte** textList, int count, string delimiter);

    /// <summary>
    /// Draw tooltip using control rec position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** TextSplit(string text, sbyte delimiter, int* count);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void TextAppend(string text, string append, int* position);

    /// <summary>
    /// Fade color by an alpha factor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextFindIndex(string text, string find);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToUpper(string text);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToLower(string text);

    /// <summary>
    /// Gui Setup Functions Definition
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToPascal(string text);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToSnake(string text);

    /// <summary>
    /// Enable gui global state
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string TextToCamel(string text);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int TextToInteger(string text);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float TextToFloat(string text);

    /// <summary>
    /// Basic geometric 3D shapes drawing functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color);

    /// <summary>
    /// Unlock gui global state
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPoint3D(Vector3 position, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color);

    /// <summary>
    /// Check if gui is locked (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawTriangleStrip3D(Vector3* points, int pointCount, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCube(Vector3 position, float width, float height, float length, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeV(Vector3 position, Vector3 size, Color color);

    /// <summary>
    /// Set gui controls alpha global state
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCubeWiresV(Vector3 position, Vector3 size, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphere(Vector3 centerPos, float radius, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

    /// <summary>
    /// Set gui state (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawPlane(Vector3 centerPos, Vector2 size, Color color);

    /// <summary>
    /// Get gui state (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawRay(Ray ray, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawGrid(int slices, float spacing);

    /// <summary>
    /// Model management functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Model LoadModel(string fileName);

    /// <summary>
    /// NOTE: If we try to setup a font but default style has not been
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Model LoadModelFromMesh(Mesh mesh);

    /// <summary>
    /// lazily loaded before, it will be overwritten, so we need to force
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsModelReady(Model model);

    /// <summary>
    /// default style loading first
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadModel(Model model);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial BoundingBox GetModelBoundingBox(Model model);

    /// <summary>
    /// Model drawing functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModel(Model model, Vector3 position, float scale, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelWires(Model model, Vector3 position, float scale, Color tint);

    /// <summary>
    /// Get custom gui font
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelPoints(Model model, Vector3 position, float scale, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawModelPointsEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBoundingBox(BoundingBox box, Color color);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboard(Camera3D camera, Texture texture, Vector3 position, float scale, Color tint);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboardRec(Camera3D camera, Texture texture, Vector4 source, Vector3 position, Vector2 size, Color tint);

    /// <summary>
    /// Set control style property value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawBillboardPro(Camera3D camera, Texture texture, Vector4 source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint);

    /// <summary>
    /// Mesh management functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UploadMesh(Mesh* mesh, NativeBool dynamic);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateMeshBuffer(Mesh mesh, int index, void* data, int dataSize, int offset);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadMesh(Mesh mesh);

    /// <summary>
    /// Default properties are propagated to all controls
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void DrawMesh(Mesh mesh, Material material, Matrix4x4 transform);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DrawMeshInstanced(Mesh mesh, Material material, Matrix4x4* transforms, int instances);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial BoundingBox GetMeshBoundingBox(Mesh mesh);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GenMeshTangents(Mesh* mesh);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportMesh(Mesh mesh, string fileName);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportMeshAsCode(Mesh mesh, string fileName);

    /// <summary>
    /// Mesh generation functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshPoly(int sides, float radius);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshPlane(float width, float length, int resX, int resZ);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCube(float width, float height, float length);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshSphere(float radius, int rings, int slices);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshHemiSphere(float radius, int rings, int slices);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCylinder(float radius, float height, int slices);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCone(float radius, float height, int slices);

    /// <summary>
    /// Gui Controls Functions Definition
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshTorus(float radius, float size, int radSeg, int sides);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshKnot(float radius, float size, int radSeg, int sides);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshHeightmap(Image heightmap, Vector3 size);

    /// <summary>
    /// Window Box control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Mesh GenMeshCubicmap(Image cubicmap, Vector3 cubeSize);

    /// <summary>
    /// Window title bar height (including borders)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Material* LoadMaterials(string fileName, int* materialCount);

    /// <summary>
    /// NOTE: This define is also used by GuiMessageBox() and GuiTextInputBox()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Material LoadMaterialDefault();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMaterialReady(Material material);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadMaterial(Material material);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetMaterialTexture(Material* material, int mapType, Texture texture);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetModelMeshMaterial(Model* model, int meshId, int materialId);

    /// <summary>
    /// Model animations loadingunloading functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial ModelAnimation* LoadModelAnimations(string fileName, int* animCount);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateModelAnimation(Model model, ModelAnimation anim, int frame);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadModelAnimation(ModelAnimation anim);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadModelAnimations(ModelAnimation* animations, int animCount);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsModelAnimationValid(Model model, ModelAnimation anim);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateModelAnimationBoneMatrices(Model model, ModelAnimation anim, int frame);

    /// <summary>
    /// Collision detection functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionBoxes(BoundingBox box1, BoundingBox box2);

    /// <summary>
    /// Update control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool CheckCollisionBoxSphere(BoundingBox box, Vector3 center, float radius);

    /// <summary>
    /// --------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionSphere(Ray ray, Vector3 center, float radius);

    /// <summary>
    /// NOTE: Logic is directly managed by button
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionBox(Ray ray, BoundingBox box);

    /// <summary>
    /// --------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionMesh(Ray ray, Mesh mesh, Matrix4x4 transform);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3);

    /// <summary>
    /// Draw control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial RayCollision GetRayCollisionQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4);

    /// <summary>
    /// Audio device management functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void InitAudioDevice();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void CloseAudioDevice();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsAudioDeviceReady();

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMasterVolume(float volume);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMasterVolume();

    /// <summary>
    /// WaveSound loadingunloading functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Wave LoadWave(string fileName);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Wave LoadWaveFromMemory(string fileType, byte* fileData, int dataSize);

    /// <summary>
    /// --------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsWaveReady(Wave wave);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSound(string fileName);

    /// <summary>
    /// Window close button clicked: result = 1
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSoundFromWave(Wave wave);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Sound LoadSoundAlias(Sound source);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsSoundReady(Sound sound);

    /// <summary>
    /// Group Box control with text name
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateSound(Sound sound, void* data, int sampleCount);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadWave(Wave wave);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadSound(Sound sound);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadSoundAlias(Sound @alias);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportWave(Wave wave, string fileName);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool ExportWaveAsCode(Wave wave, string fileName);

    /// <summary>
    /// WaveSound management functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlaySound(Sound sound);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopSound(Sound sound);

    /// <summary>
    /// Draw control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PauseSound(Sound sound);

    /// <summary>
    /// --------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ResumeSound(Sound sound);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsSoundPlaying(Sound sound);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundVolume(Sound sound, float volume);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundPitch(Sound sound, float pitch);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetSoundPan(Sound sound, float pan);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Wave WaveCopy(Wave wave);

    /// <summary>
    /// --------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void WaveCrop(Wave* wave, int initFrame, int finalFrame);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void WaveFormat(Wave* wave, int sampleRate, int sampleSize, int channels);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial float* LoadWaveSamples(Wave wave);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UnloadWaveSamples(float* samples);

    /// <summary>
    /// Music management functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Music LoadMusicStream(string fileName);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial Music LoadMusicStreamFromMemory(string fileType, byte* data, int dataSize);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMusicReady(Music music);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadMusicStream(Music music);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlayMusicStream(Music music);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsMusicStreamPlaying(Music music);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UpdateMusicStream(Music music);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopMusicStream(Music music);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PauseMusicStream(Music music);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ResumeMusicStream(Music music);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SeekMusicStream(Music music, float position);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMusicVolume(Music music, float volume);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMusicPitch(Music music, float pitch);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetMusicPan(Music music, float pan);

    /// <summary>
    /// Draw control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMusicTimeLength(Music music);

    /// <summary>
    /// --------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial float GetMusicTimePlayed(Music music);

    /// <summary>
    /// AudioStream management functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial AudioStream LoadAudioStream(uint sampleRate, uint sampleSize, uint channels);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsAudioStreamReady(AudioStream stream);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void UnloadAudioStream(AudioStream stream);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void UpdateAudioStream(AudioStream stream, void* data, int frameCount);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsAudioStreamProcessed(AudioStream stream);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PlayAudioStream(AudioStream stream);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void PauseAudioStream(AudioStream stream);

    /// <summary>
    /// Draw line with embedded text label: "--- text --------------"
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void ResumeAudioStream(AudioStream stream);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool IsAudioStreamPlaying(AudioStream stream);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void StopAudioStream(AudioStream stream);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAudioStreamVolume(AudioStream stream, float volume);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAudioStreamPitch(AudioStream stream, float pitch);

    /// <summary>
    /// --------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAudioStreamPan(AudioStream stream, float pan);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void SetAudioStreamBufferSizeDefault(int size);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void SetAudioStreamCallback(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> callback);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void AttachAudioStreamProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> processor);

    /// <summary>
    /// Panel control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DetachAudioStreamProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> processor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void AttachAudioMixedProcessor(delegate* unmanaged[Cdecl]<void*, uint, void> processor);

    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void DetachAudioMixedProcessor(delegate* unmanaged[Cdecl]<void*, uint, void> processor);

    /// <summary>
    /// Enable gui controls (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiEnable();

    /// <summary>
    /// Disable gui controls (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDisable();

    /// <summary>
    /// Lock gui controls (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLock();

    /// <summary>
    /// Unlock gui controls (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiUnlock();

    /// <summary>
    /// Check if gui is locked (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool GuiIsLocked();

    /// <summary>
    /// Set gui controls alpha (global state), alpha goes from 0.0f to 1.0f
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetAlpha(float alpha);

    /// <summary>
    /// Set gui state (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetState(int state);

    /// <summary>
    /// Get gui state (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGetState();

    /// <summary>
    /// Set gui custom font (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetFont(Font font);

    /// <summary>
    /// Get gui custom font (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font GuiGetFont();

    /// <summary>
    /// Set one style property
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetStyle(int control, int @property, int value);

    /// <summary>
    /// Get one style property
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGetStyle(int control, int @property);

    /// <summary>
    /// Load style file over global style variable (.rgs)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLoadStyle(string fileName);

    /// <summary>
    /// Load style default over global style
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLoadStyleDefault();

    /// <summary>
    /// Enable gui tooltips (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiEnableTooltip();

    /// <summary>
    /// Disable gui tooltips (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDisableTooltip();

    /// <summary>
    /// Set tooltip string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetTooltip(string tooltip);

    /// <summary>
    /// Get text with icon id prepended (if supported)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GuiIconText(int iconId, string text);

    /// <summary>
    /// Set default icon drawing size
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetIconScale(int scale);

    /// <summary>
    /// Get raygui icons data pointer
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint* GuiGetIcons();

    /// <summary>
    /// Load raygui icons file (.rgi) into internal icons data
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** GuiLoadIcons(string fileName, NativeBool loadIconsName);

    /// <summary>
    /// Draw icon using pixel size at specified position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDrawIcon(int iconId, int posX, int posY, int pixelSize, Color color);

    /// <summary>
    /// Window Box control, shows a window that can be closed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiWindowBox(Vector4 bounds, string title);

    /// <summary>
    /// Group Box control with text name
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGroupBox(Vector4 bounds, string text);

    /// <summary>
    /// Line separator control, could contain text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLine(Vector4 bounds, string text);

    /// <summary>
    /// Panel control, useful to group controls
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiPanel(Vector4 bounds, string text);

    /// <summary>
    /// Tab Bar control, returns TAB to be closed or -1
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiTabBar(Vector4 bounds, sbyte** text, int count, int* active);

    /// <summary>
    /// Scroll Panel control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiScrollPanel(Vector4 bounds, string text, Vector4 content, Vector2* scroll, Vector4* view);

    /// <summary>
    /// Label control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLabel(Vector4 bounds, string text);

    /// <summary>
    /// Button control, returns true when clicked
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiButton(Vector4 bounds, string text);

    /// <summary>
    /// Label button control, returns true when clicked
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLabelButton(Vector4 bounds, string text);

    /// <summary>
    /// Toggle Button control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggle(Vector4 bounds, string text, NativeBool* active);

    /// <summary>
    /// Toggle Group control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggleGroup(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Toggle Slider control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggleSlider(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Check Box control, returns true when active
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiCheckBox(Vector4 bounds, string text, NativeBool* @checked);

    /// <summary>
    /// Combo Box control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiComboBox(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Dropdown Box control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiDropdownBox(Vector4 bounds, string text, int* active, NativeBool editMode);

    /// <summary>
    /// Spinner control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSpinner(Vector4 bounds, string text, int* value, int minValue, int maxValue, NativeBool editMode);

    /// <summary>
    /// Value Box control, updates input text with numbers
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiValueBox(Vector4 bounds, string text, int* value, int minValue, int maxValue, NativeBool editMode);

    /// <summary>
    /// Value box control for float values
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiValueBoxFloat(Vector4 bounds, string text, string textValue, float* value, NativeBool editMode);

    /// <summary>
    /// Text Box control, updates input text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiTextBox(Vector4 bounds, string text, int textSize, NativeBool editMode);

    /// <summary>
    /// Slider control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSlider(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Slider Bar control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSliderBar(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Progress Bar control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiProgressBar(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Status Bar control, shows info text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiStatusBar(Vector4 bounds, string text);

    /// <summary>
    /// Dummy control for placeholders
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiDummyRec(Vector4 bounds, string text);

    /// <summary>
    /// Grid control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiGrid(Vector4 bounds, string text, float spacing, int subdivs, Vector2* mouseCell);

    /// <summary>
    /// List View control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiListView(Vector4 bounds, string text, int* scrollIndex, int* active);

    /// <summary>
    /// List View with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiListViewEx(Vector4 bounds, sbyte** text, int count, int* scrollIndex, int* active, int* focus);

    /// <summary>
    /// Message Box control, displays a message
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiMessageBox(Vector4 bounds, string title, string message, string buttons);

    /// <summary>
    /// Text Input Box control, ask for text, supports secret
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiTextInputBox(Vector4 bounds, string title, string message, string buttons, string text, int textMaxSize, NativeBool* secretViewActive);

    /// <summary>
    /// Color Picker control (multiple color controls)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPicker(Vector4 bounds, string text, Color* color);

    /// <summary>
    /// Color Panel control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPanel(Vector4 bounds, string text, Color* color);

    /// <summary>
    /// Color Bar Alpha control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorBarAlpha(Vector4 bounds, string text, float* alpha);

    /// <summary>
    /// Color Bar Hue control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorBarHue(Vector4 bounds, string text, float* value);

    /// <summary>
    /// Color Picker control that avoids conversion to RGB on each call (multiple color controls)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPickerHSV(Vector4 bounds, string text, Vector3* colorHsv);

    /// <summary>
    /// Color Panel control that updates Hue-Saturation-Value color value, used by GuiColorPickerHSV()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPanelHSV(Vector4 bounds, string text, Vector3* colorHsv);

    /// <summary>
    /// Load style from memory (binary only)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GuiLoadStyleFromMemory(byte* fileData, int dataSize);

    /// <summary>
    /// Gui get text width using gui font and style
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTextWidth(string text);

    /// <summary>
    /// Get text bounds considering control bounds
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetTextBounds(int control, Vector4 bounds);

    /// <summary>
    /// Get text icon if provided and move text cursor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string GetTextIcon(string text, int* iconId);

    /// <summary>
    /// Gui draw text using default font
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDrawText(string text, Vector4 textBounds, int alignment, Color tint);

    /// <summary>
    /// Gui draw rectangle using default raygui style
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDrawRectangle(Vector4 rec, int borderWidth, Color borderColor, Color color);

    /// <summary>
    /// Split controls text into multiple strings
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** GuiTextSplit(string text, sbyte delimiter, int* count, int* textRow);

    /// <summary>
    /// Convert color data from HSV to RGB
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 ConvertHSVtoRGB(Vector3 hsv);

    /// <summary>
    /// Convert color data from RGB to HSV
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 ConvertRGBtoHSV(Vector3 rgb);

    /// <summary>
    /// Scroll bar control, used by GuiScrollPanel()
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiScrollBar(Vector4 bounds, int value, int minValue, int maxValue);

    /// <summary>
    /// Draw tooltip using control rec position
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiTooltip(Vector4 controlRec);

    /// <summary>
    /// Fade color by an alpha factor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GuiFade(Color color, float alpha);

    /// <summary>
    /// Global gui state control functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiEnable();

    /// <summary>
    /// Disable gui global state
    /// NOTE: We check for STATE_NORMAL to avoid messing custom global state setups
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDisable();

    /// <summary>
    /// Lock gui global state
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLock();

    /// <summary>
    /// Unlock gui global state
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiUnlock();

    /// <summary>
    /// Check if gui is locked (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial NativeBool GuiIsLocked();

    /// <summary>
    /// Set gui controls alpha global state
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetAlpha(float alpha);

    /// <summary>
    /// Set gui state (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetState(int state);

    /// <summary>
    /// Get gui state (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGetState();

    /// <summary>
    /// Font setget functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetFont(Font font);

    /// <summary>
    /// Get custom gui font
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Font GuiGetFont();

    /// <summary>
    /// Style setget functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetStyle(int control, int @property, int value);

    /// <summary>
    /// Get control style property value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGetStyle(int control, int @property);

    /// <summary>
    /// Controls
    /// ----------------------------------------------------------------------------------------------------------
    /// Containerseparator controls, useful for controls organization
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiWindowBox(Vector4 bounds, string title);

    /// <summary>
    /// Group Box control with text name
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiGroupBox(Vector4 bounds, string text);

    /// <summary>
    /// Line control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLine(Vector4 bounds, string text);

    /// <summary>
    /// Panel control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiPanel(Vector4 bounds, string text);

    /// <summary>
    /// Tab Bar control
    /// NOTE: Using GuiToggle() for the TABS
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiTabBar(Vector4 bounds, sbyte** text, int count, int* active);

    /// <summary>
    /// Scroll Panel control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiScrollPanel(Vector4 bounds, string text, Vector4 content, Vector2* scroll, Vector4* view);

    /// <summary>
    /// Basic controls set
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLabel(Vector4 bounds, string text);

    /// <summary>
    /// Button control, returns true when clicked
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiButton(Vector4 bounds, string text);

    /// <summary>
    /// Label button control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiLabelButton(Vector4 bounds, string text);

    /// <summary>
    /// Toggle Button control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggle(Vector4 bounds, string text, NativeBool* active);

    /// <summary>
    /// Toggle Group control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggleGroup(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Toggle Slider control extended
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiToggleSlider(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Check Box control, returns 1 when state changed
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiCheckBox(Vector4 bounds, string text, NativeBool* @checked);

    /// <summary>
    /// Combo Box control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiComboBox(Vector4 bounds, string text, int* active);

    /// <summary>
    /// Dropdown Box control
    /// NOTE: Returns mouse click
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiDropdownBox(Vector4 bounds, string text, int* active, NativeBool editMode);

    /// <summary>
    /// Text Box control
    /// NOTE: Returns true on ENTER pressed (useful for data validation)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiTextBox(Vector4 bounds, string text, int textSize, NativeBool editMode);

    /// <summary>
    /// Spinner control, returns selected value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSpinner(Vector4 bounds, string text, int* value, int minValue, int maxValue, NativeBool editMode);

    /// <summary>
    /// Value Box control, updates input text with numbers
    /// NOTE: Requires static variables: frameCounter
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiValueBox(Vector4 bounds, string text, int* value, int minValue, int maxValue, NativeBool editMode);

    /// <summary>
    /// Floating point Value Box control, updates input val_str with numbers
    /// NOTE: Requires static variables: frameCounter
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiValueBoxFloat(Vector4 bounds, string text, string textValue, float* value, NativeBool editMode);

    /// <summary>
    /// Slider control with pro parameters
    /// NOTE: Other GuiSlider*() controls use this one
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSliderPro(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue, int sliderWidth);

    /// <summary>
    /// Slider control extended, returns selected value and has text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSlider(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Slider Bar control extended, returns selected value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiSliderBar(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Progress Bar control extended, shows current progress value
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiProgressBar(Vector4 bounds, string textLeft, string textRight, float* value, float minValue, float maxValue);

    /// <summary>
    /// Status Bar control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiStatusBar(Vector4 bounds, string text);

    /// <summary>
    /// Dummy rectangle control, intended for placeholding
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiDummyRec(Vector4 bounds, string text);

    /// <summary>
    /// Advance controls set
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiListView(Vector4 bounds, string text, int* scrollIndex, int* active);

    /// <summary>
    /// List View control with extended parameters
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiListViewEx(Vector4 bounds, sbyte** text, int count, int* scrollIndex, int* active, int* focus);

    /// <summary>
    /// Color Panel control - Color (RGBA) variant.
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPanel(Vector4 bounds, string text, Color* color);

    /// <summary>
    /// Color Bar Alpha control
    /// NOTE: Returns alpha value normalized [0..1]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorBarAlpha(Vector4 bounds, string text, float* alpha);

    /// <summary>
    /// Color Bar Hue control
    /// Returns hue value normalized [0..1]
    /// NOTE: Other similar bars (for reference):
    /// Color GuiColorBarSat() [WHITE->color]
    /// Color GuiColorBarValue() [BLACK->color], HSVHSL
    /// float GuiColorBarLuminance() [BLACK->WHITE]
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorBarHue(Vector4 bounds, string text, float* hue);

    /// <summary>
    /// Color Picker control
    /// NOTE: It's divided in multiple controls:
    /// Color GuiColorPanel(Rectangle bounds, Color color)
    /// float GuiColorBarAlpha(Rectangle bounds, float alpha)
    /// float GuiColorBarHue(Rectangle bounds, float value)
    /// NOTE: bounds define GuiColorPanel() size
    /// NOTE: this picker converts RGB to HSV, which can cause the Hue control to jump. If you have this problem, consider using the HSV variant instead
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPicker(Vector4 bounds, string text, Color* color);

    /// <summary>
    /// Color Picker control that avoids conversion to RGB and back to HSV on each call, thus avoiding jittering.
    /// The user can call ConvertHSVtoRGB() to convert *colorHsv value to RGB.
    /// NOTE: It's divided in multiple controls:
    /// int GuiColorPanelHSV(Rectangle bounds, const char *text, Vector3 *colorHsv)
    /// int GuiColorBarAlpha(Rectangle bounds, const char *text, float *alpha)
    /// float GuiColorBarHue(Rectangle bounds, float value)
    /// NOTE: bounds define GuiColorPanelHSV() size
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPickerHSV(Vector4 bounds, string text, Vector3* colorHsv);

    /// <summary>
    /// Color Panel control - HSV variant
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiColorPanelHSV(Vector4 bounds, string text, Vector3* colorHsv);

    /// <summary>
    /// Message Box control
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiMessageBox(Vector4 bounds, string title, string message, string buttons);

    /// <summary>
    /// Text Input Box control, ask for text
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiTextInputBox(Vector4 bounds, string title, string message, string buttons, string text, int textMaxSize, NativeBool* secretViewActive);

    /// <summary>
    /// Grid control
    /// NOTE: Returns grid mouse-hover selected cell
    /// About drawing lines at subpixel spacing, simple put, not easy solution:
    /// https:stackoverflow.comquestions44354502d-opengl-drawing-lines-that-dont-exactly-fit-pixel-raster
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial int GuiGrid(Vector4 bounds, string text, float spacing, int subdivs, Vector2* mouseCell);

    /// <summary>
    /// Tooltips management functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiEnableTooltip();

    /// <summary>
    /// Disable gui tooltips (global state)
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDisableTooltip();

    /// <summary>
    /// Set tooltip string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetTooltip(string tooltip);

    /// <summary>
    /// Styles loading functions
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLoadStyle(string fileName);

    /// <summary>
    /// Load style default over global style
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiLoadStyleDefault();

    /// <summary>
    /// Icons functionality
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial string GuiIconText(int iconId, string text);

    /// <summary>
    /// Get full icons data pointer
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial uint* GuiGetIcons();

    /// <summary>
    /// Load raygui icons file (.rgi)
    /// NOTE: In case nameIds are required, they can be requested with loadIconsName,
    /// they are returned as a guiIconsName[iconCount][RAYGUI_ICON_MAX_NAME_LENGTH],
    /// WARNING: guiIconsName[]][] memory should be manually freed!
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** GuiLoadIcons(string fileName, NativeBool loadIconsName);

    /// <summary>
    /// Draw selected icon using rectangles pixel-by-pixel
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDrawIcon(int iconId, int posX, int posY, int pixelSize, Color color);

    /// <summary>
    /// Set icon drawing size
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiSetIconScale(int scale);

    /// <summary>
    /// ----------------------------------------------------------------------------------
    /// Module specific Functions Declaration
    /// ----------------------------------------------------------------------------------
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial void GuiLoadStyleFromMemory(byte* fileData, int dataSize);

    /// <summary>
    /// Gui get text width considering icon
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GetTextWidth(string text);

    /// <summary>
    /// Get text bounds considering control bounds
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector4 GetTextBounds(int control, Vector4 bounds);

    /// <summary>
    /// Get text icon if provided and move text cursor
    /// NOTE: We support up to 999 values for iconId
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial string GetTextIcon(string text, int* iconId);

    /// <summary>
    /// Get text divided into lines (by line-breaks '@n ')
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** GetTextLines(string text, int* count);

    /// <summary>
    /// Get text width to next space for provided string
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial float GetNextSpaceWidth(string text, int* nextSpaceIndex);

    /// <summary>
    /// Gui draw text using default font
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDrawText(string text, Vector4 textBounds, int alignment, Color tint);

    /// <summary>
    /// Gui draw rectangle using default raygui plain style with borders
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiDrawRectangle(Vector4 rec, int borderWidth, Color borderColor, Color color);

    /// <summary>
    /// Draw tooltip using control bounds
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial void GuiTooltip(Vector4 controlRec);

    /// <summary>
    /// Split controls text into multiple strings
    /// Also check for multiple columns (required by GuiToggleGroup())
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe partial sbyte** GuiTextSplit(string text, sbyte delimiter, int* count, int* textRow);

    /// <summary>
    /// Convert color data from RGB to HSV
    /// NOTE: Color data should be passed normalized
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 ConvertRGBtoHSV(Vector3 rgb);

    /// <summary>
    /// Convert color data from HSV to RGB
    /// NOTE: Color data should be passed normalized
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Vector3 ConvertHSVtoRGB(Vector3 hsv);

    /// <summary>
    /// Scroll bar control (used by GuiScrollPanel())
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial int GuiScrollBar(Vector4 bounds, int value, int minValue, int maxValue);

    /// <summary>
    /// Color fade-in or fade-out, alpha goes from 0.0f to 1.0f
    /// WARNING: It multiplies current alpha by alpha scale factor
    /// </summary>
    [LibraryImport(LIBRARY, StringMarshalling = StringMarshalling.Utf8)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    public static partial Color GuiFade(Color color, float alpha);
}
