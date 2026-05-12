using System.Numerics;
using System.Runtime.InteropServices;
using Hexa.NET.ImGui;
using Hexa.NET.ImNodes;
using Hexa.NET.ImPlot;

namespace RaylibNET;

/// <summary>
/// RlImGui - ImGui integration for Raylib.NET using Hexa.NET.ImGui
///
/// Attribution:
///   - https://github.com/raylib-extras/rlImGui-cs
///   - https://github.com/raylib-extras/rlImGui
///
/// Simple Example:
/// <code>
/// Raylib.InitWindow(800, 600, "ImGui Demo");
/// RlImGui.Setup();
///
/// while (!Raylib.WindowShouldClose())
/// {
///     RlImGui.Begin();
///
///     ImGui.Text("Hello, ImGui!");
///     if (ImGui.Button("Click me"))
///         Console.WriteLine("Clicked!");
///
///     Raylib.BeginDrawing();
///     Raylib.ClearBackground(Color.DARKGRAY);
///     RlImGui.End();
///     Raylib.EndDrawing();
/// }
///
/// RlImGui.Shutdown();
/// Raylib.CloseWindow();
/// </code>
///
/// Advanced Example (Custom Fonts):
/// <code>
/// Raylib.InitWindow(800, 600, "ImGui Custom Fonts");
///
/// RlImGui.BeginSetup();
/// var io = ImGui.GetIO();
/// io.Fonts.AddFontFromFileTTF("Roboto-Regular.ttf", 16.0f);
/// io.ConfigFlags |= ImGuiConfigFlags.DockingEnable;
/// ImGui.StyleColorsLight();
/// RlImGui.EndSetup();
///
/// // ... main loop same as above ...
///
/// RlImGui.Shutdown();
/// Raylib.CloseWindow();
/// </code>
/// </summary>
public static unsafe class RlImGui
{
    //----------------------------------------------------------------------
    // PUBLIC API
    //----------------------------------------------------------------------

    /// <summary>
    /// Simple setup with default font and dark theme.
    /// For custom fonts or themes, use BeginSetup() / EndSetup() instead.
    /// </summary>
    public static void Setup()
    {
        BeginSetup();
        ImGui.StyleColorsDark();

        // Configure default font with proper C++ defaults and DPI scaling
        var io = ImGui.GetIO();
        var defaultConfig = FontConfig(13);
        defaultConfig.PixelSnapH = true;
        io.Fonts.AddFontDefault(defaultConfig);

        EndSetup();
    }

    /// <summary>
    /// Begin custom ImGui setup.
    /// Add fonts, configure IO, set styles, etc. between BeginSetup() and EndSetup().
    /// Must be followed by EndSetup().
    /// </summary>
    /// <example>
    /// RlImGui.BeginSetup();
    /// var io = ImGui.GetIO();
    /// io.Fonts.AddFontFromFileTTF("myfont.ttf", 16.0f);
    /// ImGui.StyleColorsDark();
    /// io.ConfigFlags |= ImGuiConfigFlags.DockingEnable;
    /// RlImGui.EndSetup();
    /// </example>
    public static void BeginSetup()
    {
        LastFrameFocused = Raylib.IsWindowFocused();
        LastControlPressed = false;
        LastShiftPressed = false;
        LastAltPressed = false;
        LastSuperPressed = false;

        SetupKeymap();
        SetupMouseCursors();

        if (ImGuiContext.Handle == null) {
            ImGuiContext = ImGui.CreateContext();
            ImGui.SetCurrentContext(ImGuiContext);
        }

        if (ImNodesContext.Handle == null)
        {
            ImNodes.SetImGuiContext(ImGuiContext);
            ImNodesContext = ImNodes.CreateContext();
        }

        if (ImPlotContext.Handle == null)
        {
            ImPlot.SetImGuiContext(ImGuiContext);
            ImPlotContext = ImPlot.CreateContext();
        }

        SetContexts();
    }

    /// <summary>
    /// Finish ImGui setup.
    /// Must be called after BeginSetup().
    /// Font textures will be created automatically on first render.
    /// FontAwesome icons are automatically merged with your fonts.
    /// </summary>
    public static void EndSetup()
    {
        SetContexts();
        SetupFontAwesome();
        SetupBackend();
    }

    /// <summary>
    /// Begin a new ImGui frame. Call this before any ImGui calls.
    /// </summary>
    /// <param name="dt">Delta time (optional, uses GetFrameTime if negative)</param>
    public static void Begin(float dt = -1)
    {
        SetContexts();
        NewFrame(dt);
        FrameEvents();
        ImGui.NewFrame();
    }

    /// <summary>
    /// End the current ImGui frame and render to screen.
    /// </summary>
    public static void End()
    {
        ImGui.SetCurrentContext(ImGuiContext);
        ImGui.Render();
        RenderData();
    }

    /// <summary>
    /// Shutdown ImGui and cleanup all resources.
    /// </summary>
    public static void Shutdown()
    {
        if (ImGuiContext.Handle == null)
            return;

        ImGui.SetCurrentContext(ImGuiContext);

        // Cleanup all textures managed by ImGui
        var platformIO = ImGui.GetPlatformIO();
        for (int i = 0; i < platformIO.Textures.Size; i++)
        {
            var texture = platformIO.Textures[i].Handle;
            if (texture->Status != ImTextureStatus.Destroyed)
            {
                var backendData = (Texture*)texture->BackendUserData;
                if (backendData != null && Raylib.IsTextureValid(*backendData))
                {
                    Raylib.UnloadTexture(*backendData);
                }
                if (backendData != null)
                    Marshal.FreeHGlobal((IntPtr)backendData);

                texture->BackendUserData = null;
                texture->Status = ImTextureStatus.Destroyed;
                texture->SetTexID((nint)0ul);
            }
        }

        // Free backend data
        if (BackendRendererUserData != IntPtr.Zero)
        {
            Marshal.FreeHGlobal(BackendRendererUserData);
            BackendRendererUserData = IntPtr.Zero;
        }

        ImGui.DestroyContext(ImGuiContext);
        ImGuiContext = default;

        if (ImPlotContext.Handle != null)
        {
            ImPlot.DestroyContext(ImPlotContext);
            ImPlotContext = default;
        }

        if (ImNodesContext.Handle != null)
        {
            ImNodes.DestroyContext(ImNodesContext);
            ImNodesContext = default;
        }
    }

    /// <summary>
    /// Create ImFontConfig with proper C++ defaults and DPI scaling.
    /// Uses ImGui.ImFontConfig() which calls the C++ constructor with proper defaults.
    /// </summary>
    public static ImFontConfigPtr FontConfig(int fontSize)
    {
        var config = ImGui.ImFontConfig();
        config.SizePixels = fontSize;

        // Apply DPI scaling (matching C++ rlImGui logic):
        // On macOS the system handles DPI scaling, so we skip it entirely.
        // On other platforms, always set RasterizerMultiply to the DPI scale,
        // and scale the font size when not in HIGHDPI mode (HIGHDPI already handles it).
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            var scale = Raylib.GetWindowScaleDPI();
            config.RasterizerMultiply = scale.Y;
            if (!Raylib.IsWindowState((int)ConfigFlags.FLAG_WINDOW_HIGHDPI))
                config.SizePixels = MathF.Ceiling(config.SizePixels * scale.Y);
        }

        return config;
    }

    /// <summary>
    /// Display a texture as an image with custom size and UV coordinates.
    /// </summary>
    public static void Image(Texture image, Vector2 size = default, Vector2 uv0 = default, Vector2 uv1 = default)
    {
        var texRef = new ImTextureRef(null, (nint)(ulong)image.Id);
        ImGui.Image(texRef, size, uv0, uv1);
    }

    /// <summary>
    /// Display a texture as an image in ImGui.
    /// </summary>
    public static void Image(Texture image) =>
        Image(image, new Vector2(image.Width, image.Height));


    /// <summary>
    /// Display a portion of a texture as an image using source rectangle (x, y, width, height).
    /// Negative width/height values will flip the image on that axis.
    /// </summary>
    public static void Image(Texture image, Vector2 size, Vector4 sourceRect)
    {
        Vector2 uv0 = new();
        Vector2 uv1 = new();

        if (sourceRect.Z < 0)
        {
            uv0.X = -((float)sourceRect.X / image.Width);
            uv1.X = (uv0.X - (float)(Math.Abs(sourceRect.Z) / image.Width));
        }
        else
        {
            uv0.X = (float)sourceRect.X / image.Width;
            uv1.X = uv0.X + (float)(sourceRect.Z / image.Width);
        }

        if (sourceRect.W < 0)
        {
            uv0.Y = -((float)sourceRect.Y / image.Height);
            uv1.Y = (uv0.Y - (float)(Math.Abs(sourceRect.W) / image.Height));
        }
        else
        {
            uv0.Y = (float)sourceRect.Y / image.Height;
            uv1.Y = uv0.Y + (float)(sourceRect.W / image.Height);
        }

        Image(image, size, uv0, uv1);
    }

    /// <summary>
    /// Display a render texture, automatically flipping Y axis.
    /// </summary>
    public static void Image(RenderTexture image) =>
        Image(image.Texture, new Vector2(image.Texture.Width, image.Texture.Height), new Vector4(0, 0, image.Texture.Width, -image.Texture.Height));

    /// <summary>
    /// Display a render texture with custom size, automatically flipping Y axis.
    /// </summary>
    public static void Image(RenderTexture image, Vector2 size) =>
        Image(image.Texture, size, new Vector4(0, 0, image.Texture.Width, -image.Texture.Height));

    /// <summary>
    /// Draw a texture as an image with custom size and UV coordinates.
    /// </summary>
    public static void AddImage(this ImDrawListPtr drawList, Texture image, Vector2 position = default, Vector2 size = default, Vector2 uv0 = default, Vector2 uv1 = default)
    {
        var texRef = new ImTextureRef(null, (nint)(ulong)image.Id);
        drawList.AddImage(texRef, position, position + size, uv0, uv1);
    }

    /// <summary>
    /// Draw a texture as an image in ImGui.
    /// </summary>
    public static void AddImage(this ImDrawListPtr drawList, Texture image, Vector2 position = default) =>
        AddImage(drawList, image, position, new Vector2(image.Width, image.Height));

    /// <summary>
    /// Draw a portion of a texture as an image using source rectangle (x, y, width, height).
    /// Negative width/height values will flip the image on that axis.
     /// </summary>
    public static void AddImage(this ImDrawListPtr drawList, Texture image, Vector2 position, Vector2 size, Vector4 sourceRect)
    {
        Vector2 uv0 = new();
        Vector2 uv1 = new();

        if (sourceRect.Z < 0)
        {
            uv0.X = -((float)sourceRect.X / image.Width);
            uv1.X = (uv0.X - (float)(Math.Abs(sourceRect.Z) / image.Width));
        }
        else
        {
            uv0.X = (float)sourceRect.X / image.Width;
            uv1.X = uv0.X + (float)(sourceRect.Z / image.Width);
        }

        if (sourceRect.W < 0)
        {
            uv0.Y = -((float)sourceRect.Y / image.Height);
            uv1.Y = (uv0.Y - (float)(Math.Abs(sourceRect.W) / image.Height));
        }
        else
        {
            uv0.Y = (float)sourceRect.Y / image.Height;
            uv1.Y = uv0.Y + (float)(sourceRect.W / image.Height);
        }

        AddImage(drawList, image, position, size, uv0, uv1);
    }

    /// <summary>
    /// Display a texture as a clickable button.
    /// </summary>
    public static bool ImageButton(string name, Texture image, Vector2 size = default, Vector2 uv0 = default, Vector2 uv1 = default)
    {
        var texRef = new ImTextureRef(null, (nint)(ulong)image.Id);
        return ImGui.ImageButton(name, texRef, size, uv0, uv1);
    }

    /// <summary>
    /// Display a portion of a texture as a clickable button using source rectangle (x, y, width, height).
    /// Negative width/height values will flip the image on that axis.
    /// </summary>
    public static bool ImageButton(string name, Texture image, Vector2 size, Vector4 sourceRect)
    {
        Vector2 uv0 = new();
        Vector2 uv1 = new();

        if (sourceRect.Z < 0)
        {
            uv0.X = -((float)sourceRect.X / image.Width);
            uv1.X = (uv0.X - (float)(Math.Abs(sourceRect.Z) / image.Width));
        }
        else
        {
            uv0.X = (float)sourceRect.X / image.Width;
            uv1.X = uv0.X + (float)(sourceRect.Z / image.Width);
        }

        if (sourceRect.W < 0)
        {
            uv0.Y = -((float)sourceRect.Y / image.Height);
            uv1.Y = (uv0.Y - (float)(Math.Abs(sourceRect.W) / image.Height));
        }
        else
        {
            uv0.Y = (float)sourceRect.Y / image.Height;
            uv1.Y = uv0.Y + (float)(sourceRect.W / image.Height);
        }

        return ImageButton(name, image, size, uv0, uv1);
    }

    //----------------------------------------------------------------------
    // PRIVATE IMPLEMENTATION
    //----------------------------------------------------------------------

    private static ImGuiContextPtr ImGuiContext;
    private static ImNodesContextPtr ImNodesContext;
    private static ImPlotContextPtr ImPlotContext;
    private static ImGuiMouseCursor CurrentMouseCursor = ImGuiMouseCursor.Count;
    private static readonly Dictionary<ImGuiMouseCursor, int> MouseCursorMap = [];
    private static readonly Dictionary<int, ImGuiKey> RaylibKeyMap = [];

    // Backend data structure (minimal for now, matching C++ implementation)
    private static IntPtr BackendRendererUserData = IntPtr.Zero;

    private static bool LastFrameFocused = false;
    private static bool LastControlPressed = false;
    private static bool LastShiftPressed = false;
    private static bool LastAltPressed = false;
    private static bool LastSuperPressed = false;

    private static bool IsControlDown() => Raylib.IsKeyDown((int)KeyboardKey.KEY_RIGHT_CONTROL) || Raylib.IsKeyDown((int)KeyboardKey.KEY_LEFT_CONTROL);
    private static bool IsShiftDown() => Raylib.IsKeyDown((int)KeyboardKey.KEY_LEFT_SHIFT) || Raylib.IsKeyDown((int)KeyboardKey.KEY_RIGHT_SHIFT);
    private static bool IsAltDown() => Raylib.IsKeyDown((int)KeyboardKey.KEY_LEFT_ALT) || Raylib.IsKeyDown((int)KeyboardKey.KEY_RIGHT_ALT);
    private static bool IsSuperDown() => Raylib.IsKeyDown((int)KeyboardKey.KEY_LEFT_SUPER) || Raylib.IsKeyDown((int)KeyboardKey.KEY_RIGHT_SUPER);

    private static void SetContexts()
    {
        ImGui.SetCurrentContext(ImGuiContext);

        if (ImPlotContext.Handle != null)
        {
            ImPlot.SetImGuiContext(ImGuiContext);
            ImPlot.SetCurrentContext(ImPlotContext);
        }

        if (ImNodesContext.Handle != null)
        {
            ImNodes.SetImGuiContext(ImGuiContext);
            ImNodes.SetCurrentContext(ImNodesContext);
        }
    }

    private static void SetupBackend()
    {
        var io = ImGui.GetIO();
        fixed (byte* name = "imgui_impl_raylib"u8)
        {
            io.BackendPlatformName = name;
        }
        io.BackendFlags |= ImGuiBackendFlags.HasMouseCursors |
                          ImGuiBackendFlags.HasSetMousePos |
                          ImGuiBackendFlags.HasGamepad |
                          ImGuiBackendFlags.RendererHasTextures;

        io.MousePos = new Vector2(0, 0);

        var platformIO = ImGui.GetPlatformIO();

        SetClipCallback = new SetClipTextCallback(SetClipText);
        platformIO.PlatformSetClipboardTextFn = (delegate* unmanaged<void*, sbyte*, void>)Marshal.GetFunctionPointerForDelegate(SetClipCallback);

        GetClipCallback = new GetClipTextCallback(GetClipText);
        platformIO.PlatformGetClipboardTextFn = (delegate* unmanaged<void*, sbyte*>)Marshal.GetFunctionPointerForDelegate(GetClipCallback);

        platformIO.PlatformClipboardUserData = null;

        // Create minimal backend data
        if (BackendRendererUserData == IntPtr.Zero)
            BackendRendererUserData = Marshal.AllocHGlobal(1); // Minimal allocation

        platformIO.RendererRenderState = (void*)BackendRendererUserData;
    }

    private static void SetupKeymap()
    {
        if (RaylibKeyMap.Count > 0)
            return;

        // build up a map of raylib keys to ImGuiKeys
        RaylibKeyMap[(int)KeyboardKey.KEY_APOSTROPHE] = ImGuiKey.Apostrophe;
        RaylibKeyMap[(int)KeyboardKey.KEY_COMMA] = ImGuiKey.Comma;
        RaylibKeyMap[(int)KeyboardKey.KEY_MINUS] = ImGuiKey.Minus;
        RaylibKeyMap[(int)KeyboardKey.KEY_PERIOD] = ImGuiKey.Period;
        RaylibKeyMap[(int)KeyboardKey.KEY_SLASH] = ImGuiKey.Slash;
        RaylibKeyMap[(int)KeyboardKey.KEY_ZERO] = ImGuiKey.Key0;
        RaylibKeyMap[(int)KeyboardKey.KEY_ONE] = ImGuiKey.Key1;
        RaylibKeyMap[(int)KeyboardKey.KEY_TWO] = ImGuiKey.Key2;
        RaylibKeyMap[(int)KeyboardKey.KEY_THREE] = ImGuiKey.Key3;
        RaylibKeyMap[(int)KeyboardKey.KEY_FOUR] = ImGuiKey.Key4;
        RaylibKeyMap[(int)KeyboardKey.KEY_FIVE] = ImGuiKey.Key5;
        RaylibKeyMap[(int)KeyboardKey.KEY_SIX] = ImGuiKey.Key6;
        RaylibKeyMap[(int)KeyboardKey.KEY_SEVEN] = ImGuiKey.Key7;
        RaylibKeyMap[(int)KeyboardKey.KEY_EIGHT] = ImGuiKey.Key8;
        RaylibKeyMap[(int)KeyboardKey.KEY_NINE] = ImGuiKey.Key9;
        RaylibKeyMap[(int)KeyboardKey.KEY_SEMICOLON] = ImGuiKey.Semicolon;
        RaylibKeyMap[(int)KeyboardKey.KEY_EQUAL] = ImGuiKey.Equal;
        RaylibKeyMap[(int)KeyboardKey.KEY_A] = ImGuiKey.A;
        RaylibKeyMap[(int)KeyboardKey.KEY_B] = ImGuiKey.B;
        RaylibKeyMap[(int)KeyboardKey.KEY_C] = ImGuiKey.C;
        RaylibKeyMap[(int)KeyboardKey.KEY_D] = ImGuiKey.D;
        RaylibKeyMap[(int)KeyboardKey.KEY_E] = ImGuiKey.E;
        RaylibKeyMap[(int)KeyboardKey.KEY_F] = ImGuiKey.F;
        RaylibKeyMap[(int)KeyboardKey.KEY_G] = ImGuiKey.G;
        RaylibKeyMap[(int)KeyboardKey.KEY_H] = ImGuiKey.H;
        RaylibKeyMap[(int)KeyboardKey.KEY_I] = ImGuiKey.I;
        RaylibKeyMap[(int)KeyboardKey.KEY_J] = ImGuiKey.J;
        RaylibKeyMap[(int)KeyboardKey.KEY_K] = ImGuiKey.K;
        RaylibKeyMap[(int)KeyboardKey.KEY_L] = ImGuiKey.L;
        RaylibKeyMap[(int)KeyboardKey.KEY_M] = ImGuiKey.M;
        RaylibKeyMap[(int)KeyboardKey.KEY_N] = ImGuiKey.N;
        RaylibKeyMap[(int)KeyboardKey.KEY_O] = ImGuiKey.O;
        RaylibKeyMap[(int)KeyboardKey.KEY_P] = ImGuiKey.P;
        RaylibKeyMap[(int)KeyboardKey.KEY_Q] = ImGuiKey.Q;
        RaylibKeyMap[(int)KeyboardKey.KEY_R] = ImGuiKey.R;
        RaylibKeyMap[(int)KeyboardKey.KEY_S] = ImGuiKey.S;
        RaylibKeyMap[(int)KeyboardKey.KEY_T] = ImGuiKey.T;
        RaylibKeyMap[(int)KeyboardKey.KEY_U] = ImGuiKey.U;
        RaylibKeyMap[(int)KeyboardKey.KEY_V] = ImGuiKey.V;
        RaylibKeyMap[(int)KeyboardKey.KEY_W] = ImGuiKey.W;
        RaylibKeyMap[(int)KeyboardKey.KEY_X] = ImGuiKey.X;
        RaylibKeyMap[(int)KeyboardKey.KEY_Y] = ImGuiKey.Y;
        RaylibKeyMap[(int)KeyboardKey.KEY_Z] = ImGuiKey.Z;
        RaylibKeyMap[(int)KeyboardKey.KEY_SPACE] = ImGuiKey.Space;
        RaylibKeyMap[(int)KeyboardKey.KEY_ESCAPE] = ImGuiKey.Escape;
        RaylibKeyMap[(int)KeyboardKey.KEY_ENTER] = ImGuiKey.Enter;
        RaylibKeyMap[(int)KeyboardKey.KEY_TAB] = ImGuiKey.Tab;
        RaylibKeyMap[(int)KeyboardKey.KEY_BACKSPACE] = ImGuiKey.Backspace;
        RaylibKeyMap[(int)KeyboardKey.KEY_INSERT] = ImGuiKey.Insert;
        RaylibKeyMap[(int)KeyboardKey.KEY_DELETE] = ImGuiKey.Delete;
        RaylibKeyMap[(int)KeyboardKey.KEY_RIGHT] = ImGuiKey.RightArrow;
        RaylibKeyMap[(int)KeyboardKey.KEY_LEFT] = ImGuiKey.LeftArrow;
        RaylibKeyMap[(int)KeyboardKey.KEY_DOWN] = ImGuiKey.DownArrow;
        RaylibKeyMap[(int)KeyboardKey.KEY_UP] = ImGuiKey.UpArrow;
        RaylibKeyMap[(int)KeyboardKey.KEY_PAGE_UP] = ImGuiKey.PageUp;
        RaylibKeyMap[(int)KeyboardKey.KEY_PAGE_DOWN] = ImGuiKey.PageDown;
        RaylibKeyMap[(int)KeyboardKey.KEY_HOME] = ImGuiKey.Home;
        RaylibKeyMap[(int)KeyboardKey.KEY_END] = ImGuiKey.End;
        RaylibKeyMap[(int)KeyboardKey.KEY_CAPS_LOCK] = ImGuiKey.CapsLock;
        RaylibKeyMap[(int)KeyboardKey.KEY_SCROLL_LOCK] = ImGuiKey.ScrollLock;
        RaylibKeyMap[(int)KeyboardKey.KEY_NUM_LOCK] = ImGuiKey.NumLock;
        RaylibKeyMap[(int)KeyboardKey.KEY_PRINT_SCREEN] = ImGuiKey.PrintScreen;
        RaylibKeyMap[(int)KeyboardKey.KEY_PAUSE] = ImGuiKey.Pause;
        RaylibKeyMap[(int)KeyboardKey.KEY_F1] = ImGuiKey.F1;
        RaylibKeyMap[(int)KeyboardKey.KEY_F2] = ImGuiKey.F2;
        RaylibKeyMap[(int)KeyboardKey.KEY_F3] = ImGuiKey.F3;
        RaylibKeyMap[(int)KeyboardKey.KEY_F4] = ImGuiKey.F4;
        RaylibKeyMap[(int)KeyboardKey.KEY_F5] = ImGuiKey.F5;
        RaylibKeyMap[(int)KeyboardKey.KEY_F6] = ImGuiKey.F6;
        RaylibKeyMap[(int)KeyboardKey.KEY_F7] = ImGuiKey.F7;
        RaylibKeyMap[(int)KeyboardKey.KEY_F8] = ImGuiKey.F8;
        RaylibKeyMap[(int)KeyboardKey.KEY_F9] = ImGuiKey.F9;
        RaylibKeyMap[(int)KeyboardKey.KEY_F10] = ImGuiKey.F10;
        RaylibKeyMap[(int)KeyboardKey.KEY_F11] = ImGuiKey.F11;
        RaylibKeyMap[(int)KeyboardKey.KEY_F12] = ImGuiKey.F12;
        RaylibKeyMap[(int)KeyboardKey.KEY_LEFT_SHIFT] = ImGuiKey.LeftShift;
        RaylibKeyMap[(int)KeyboardKey.KEY_LEFT_CONTROL] = ImGuiKey.LeftCtrl;
        RaylibKeyMap[(int)KeyboardKey.KEY_LEFT_ALT] = ImGuiKey.LeftAlt;
        RaylibKeyMap[(int)KeyboardKey.KEY_LEFT_SUPER] = ImGuiKey.LeftSuper;
        RaylibKeyMap[(int)KeyboardKey.KEY_RIGHT_SHIFT] = ImGuiKey.RightShift;
        RaylibKeyMap[(int)KeyboardKey.KEY_RIGHT_CONTROL] = ImGuiKey.RightCtrl;
        RaylibKeyMap[(int)KeyboardKey.KEY_RIGHT_ALT] = ImGuiKey.RightAlt;
        RaylibKeyMap[(int)KeyboardKey.KEY_RIGHT_SUPER] = ImGuiKey.RightSuper;
        RaylibKeyMap[(int)KeyboardKey.KEY_MENU] = ImGuiKey.Menu;
        RaylibKeyMap[(int)KeyboardKey.KEY_LEFT_BRACKET] = ImGuiKey.LeftBracket;
        RaylibKeyMap[(int)KeyboardKey.KEY_BACKSLASH] = ImGuiKey.Backslash;
        RaylibKeyMap[(int)KeyboardKey.KEY_RIGHT_BRACKET] = ImGuiKey.RightBracket;
        RaylibKeyMap[(int)KeyboardKey.KEY_GRAVE] = ImGuiKey.GraveAccent;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_0] = ImGuiKey.Keypad0;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_1] = ImGuiKey.Keypad1;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_2] = ImGuiKey.Keypad2;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_3] = ImGuiKey.Keypad3;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_4] = ImGuiKey.Keypad4;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_5] = ImGuiKey.Keypad5;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_6] = ImGuiKey.Keypad6;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_7] = ImGuiKey.Keypad7;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_8] = ImGuiKey.Keypad8;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_9] = ImGuiKey.Keypad9;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_DECIMAL] = ImGuiKey.KeypadDecimal;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_DIVIDE] = ImGuiKey.KeypadDivide;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_MULTIPLY] = ImGuiKey.KeypadMultiply;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_SUBTRACT] = ImGuiKey.KeypadSubtract;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_ADD] = ImGuiKey.KeypadAdd;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_ENTER] = ImGuiKey.KeypadEnter;
        RaylibKeyMap[(int)KeyboardKey.KEY_KP_EQUAL] = ImGuiKey.KeypadEqual;
    }

    private static void SetupMouseCursors()
    {
        if (MouseCursorMap.Count > 0)
            return;

        MouseCursorMap[ImGuiMouseCursor.Arrow] = (int)MouseCursor.MOUSE_CURSOR_ARROW;
        MouseCursorMap[ImGuiMouseCursor.TextInput] = (int)MouseCursor.MOUSE_CURSOR_IBEAM;
        MouseCursorMap[ImGuiMouseCursor.Hand] = (int)MouseCursor.MOUSE_CURSOR_POINTING_HAND;
        MouseCursorMap[ImGuiMouseCursor.ResizeAll] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_ALL;
        MouseCursorMap[ImGuiMouseCursor.ResizeEw] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_EW;
        MouseCursorMap[ImGuiMouseCursor.ResizeNesw] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_NESW;
        MouseCursorMap[ImGuiMouseCursor.ResizeNs] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_NS;
        MouseCursorMap[ImGuiMouseCursor.ResizeNwse] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_NWSE;
        MouseCursorMap[ImGuiMouseCursor.NotAllowed] = (int)MouseCursor.MOUSE_CURSOR_NOT_ALLOWED;
    }

    /// <summary>
    /// Setup FontAwesome icons by merging them with existing fonts.
    /// </summary>
    private static void SetupFontAwesome()
    {
        var io = ImGui.GetIO();

        // Define the icon ranges for FontAwesome (ImWchar is 16-bit ushort)
        ushort[] iconRanges =
        [
            FontAwesome.IconMin,
            FontAwesome.IconMax,
            0
        ];

        // Prepare font config with merge settings
        var fontConfig = FontConfig(11);
        fontConfig.MergeMode = true;                    // Merge icons into the previously added font
        fontConfig.PixelSnapH = true;
        fontConfig.FontDataOwnedByAtlas = false;        // Data is owned by us (decoded base64), not ImGui
        fontConfig.OversampleH = 2;                     // FontAwesome uses explicit oversampling
        fontConfig.OversampleV = 1;

        // Decode base64 font data
        byte[] fontData = Convert.FromBase64String(FontAwesomeData.CompressedDataBase64);

        // Set glyph ranges and add font
        unsafe
        {
            fixed (ushort* rangesPtr = iconRanges)
            {
                fixed (byte* dataPtr = fontData)
                {
                    fontConfig.GlyphRanges = (uint*)rangesPtr;

                    // Add FontAwesome font from uncompressed TTF data
                    io.Fonts.AddFontFromMemoryTTF(
                        dataPtr,
                        fontData.Length,
                        fontConfig.SizePixels,
                        fontConfig,
                        (uint*)rangesPtr
                    );
                }
            }
        }
    }

    /// <summary>
    /// Update a texture based on its status (internal backend function).
    /// </summary>
    private static void UpdateTexture(ImTextureData* tex)
    {
        switch (tex->Status)
        {
            case ImTextureStatus.Ok:
            case ImTextureStatus.Destroyed:
            default:
                break;

            case ImTextureStatus.WantCreate:
            {
                Image img = new()
                {
                    Width = tex->Width,
                    Height = tex->Height,
                    Format = tex->Format == ImTextureFormat.Alpha8
                        ? (int)PixelFormat.PIXELFORMAT_UNCOMPRESSED_GRAYSCALE
                        : (int)PixelFormat.PIXELFORMAT_UNCOMPRESSED_R8G8B8A8,
                    Mipmaps = 1,
                    Data = tex->GetPixels()
                };

                // Allocate and store Raylib texture in BackendUserData
                var texture = (Texture*)Marshal.AllocHGlobal(sizeof(Texture));
                tex->BackendUserData = texture;
                *texture = Raylib.LoadTextureFromImage(img);
                tex->SetTexID((nint)(ulong)texture->Id);
                tex->Status = ImTextureStatus.Ok;
                break;
            }

            case ImTextureStatus.WantUpdates:
            {
                var texture = (Texture*)tex->BackendUserData;
                if (texture == null)
                    break;

                Raylib.UpdateTexture(*texture, tex->GetPixels());
                tex->Status = ImTextureStatus.Ok;
                break;
            }

            case ImTextureStatus.WantDestroy:
            {
                var texture = (Texture*)tex->BackendUserData;
                if (texture == null)
                    break;

                if (Raylib.IsTextureValid(*texture))
                    Raylib.UnloadTexture(*texture);

                Marshal.FreeHGlobal((IntPtr)texture);
                tex->BackendUserData = null;
                tex->SetTexID((nint)0ul);
                tex->Status = ImTextureStatus.Destroyed;
                break;
            }
        }
    }

    private static sbyte* GetClipText(void* userData)
    {
        return (sbyte*)Marshal.StringToHGlobalAnsi(Raylib.GetClipboardText());
    }

    private static void SetClipText(void* userData, sbyte* text)
    {
        Raylib.SetClipboardText(Marshal.PtrToStringAnsi((IntPtr)text)!);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate sbyte* GetClipTextCallback(void* userData);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void SetClipTextCallback(void* userData, sbyte* text);

    private static GetClipTextCallback? GetClipCallback;
    private static SetClipTextCallback? SetClipCallback;

    private static void SetMouseEvent(ImGuiIOPtr io, int rayMouse, ImGuiMouseButton imGuiMouse)
    {
        if (Raylib.IsMouseButtonPressed(rayMouse))
            io.AddMouseButtonEvent((int)imGuiMouse, true);
        else if (Raylib.IsMouseButtonReleased(rayMouse))
            io.AddMouseButtonEvent((int)imGuiMouse, false);
    }

    private static void NewFrame(float dt = -1)
    {
        ImGuiIOPtr io = ImGui.GetIO();

        if (Raylib.IsWindowFullscreen())
        {
            int monitor = Raylib.GetCurrentMonitor();
            io.DisplaySize = new Vector2(Raylib.GetMonitorWidth(monitor), Raylib.GetMonitorHeight(monitor));
        }
        else
        {
            io.DisplaySize = new Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());
        }

        Vector2 resolutionScale = Raylib.GetWindowScaleDPI();
        // On macOS the system handles DPI scaling, so keep the DPI scale as-is.
        // On other platforms, reset scale to 1:1 when not in HIGHDPI mode.
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.OSX) &&
            !Raylib.IsWindowState((int)ConfigFlags.FLAG_WINDOW_HIGHDPI))
        {
            resolutionScale = new Vector2(1, 1);
        }

        io.DisplayFramebufferScale = resolutionScale;

        float deltaTime = dt >= 0 ? dt : Raylib.GetFrameTime();
        if (deltaTime <= 0)
            deltaTime = 0.001f;
        io.DeltaTime = deltaTime;

        // Mouse cursor visibility (matching C++ ImGuiNewFrame cursor handling)
        if ((io.BackendFlags & ImGuiBackendFlags.HasMouseCursors) != 0 &&
            (io.ConfigFlags & ImGuiConfigFlags.NoMouseCursorChange) == 0)
        {
            ImGuiMouseCursor imgui_cursor = ImGui.GetMouseCursor();
            if (imgui_cursor != CurrentMouseCursor || io.MouseDrawCursor)
            {
                CurrentMouseCursor = imgui_cursor;
                if (io.MouseDrawCursor || imgui_cursor == ImGuiMouseCursor.None)
                {
                    Raylib.HideCursor();
                }
                else
                {
                    Raylib.ShowCursor();

                    if ((io.ConfigFlags & ImGuiConfigFlags.NoMouseCursorChange) == 0)
                    {
                        if (!MouseCursorMap.TryGetValue(imgui_cursor, out int value))
                            Raylib.SetMouseCursor(0);
                        else
                            Raylib.SetMouseCursor(value);
                    }
                }
            }
        }
    }

    private static void FrameEvents()
    {
        ImGuiIOPtr io = ImGui.GetIO();

        bool focused = Raylib.IsWindowFocused();
        if (focused != LastFrameFocused)
            io.AddFocusEvent(focused);
        LastFrameFocused = focused;

        bool ctrlDown = IsControlDown();
        if (ctrlDown != LastControlPressed)
            io.AddKeyEvent(ImGuiKey.ModCtrl, ctrlDown);
        LastControlPressed = ctrlDown;

        bool shiftDown = IsShiftDown();
        if (shiftDown != LastShiftPressed)
            io.AddKeyEvent(ImGuiKey.ModShift, shiftDown);
        LastShiftPressed = shiftDown;

        bool altDown = IsAltDown();
        if (altDown != LastAltPressed)
            io.AddKeyEvent(ImGuiKey.ModAlt, altDown);
        LastAltPressed = altDown;

        bool superDown = IsSuperDown();
        if (superDown != LastSuperPressed)
            io.AddKeyEvent(ImGuiKey.ModSuper, superDown);
        LastSuperPressed = superDown;

        // Walk the keymap and check for up and down events
        int keyId = Raylib.GetKeyPressed();
        while (keyId != 0)
        {
            if (RaylibKeyMap.TryGetValue(keyId, out ImGuiKey value))
                io.AddKeyEvent(value, true);
            keyId = Raylib.GetKeyPressed();
        }

        foreach (var keyItr in RaylibKeyMap)
        {
            if (Raylib.IsKeyReleased(keyItr.Key))
                io.AddKeyEvent(keyItr.Value, false);
        }

        // Only process text input when ImGui wants keyboard capture
        if (io.WantCaptureKeyboard)
        {
            var pressed = Raylib.GetCharPressed();
            while (pressed != 0)
            {
                io.AddInputCharacter((uint)pressed);
                pressed = Raylib.GetCharPressed();
            }
        }

        // Only process mouse events when window is focused (matching C++ ProcessEvents)
        if (focused)
        {
            if (!io.WantSetMousePos)
                io.AddMousePosEvent(Raylib.GetMouseX(), Raylib.GetMouseY());
            else
                Raylib.SetMousePosition((int)io.MousePos.X, (int)io.MousePos.Y);

            SetMouseEvent(io, 0, ImGuiMouseButton.Left);
            SetMouseEvent(io, 1, ImGuiMouseButton.Right);
            SetMouseEvent(io, 2, ImGuiMouseButton.Middle);
            SetMouseEvent(io, 3, ImGuiMouseButton.Middle + 1);
            SetMouseEvent(io, 4, ImGuiMouseButton.Middle + 2);

            var wheelMove = Raylib.GetMouseWheelMoveV();
            io.AddMouseWheelEvent(wheelMove.X, wheelMove.Y);
        }
        else
        {
            io.AddMousePosEvent(float.MinValue, float.MinValue);
        }

        if ((io.ConfigFlags & ImGuiConfigFlags.NavEnableGamepad) != 0 && Raylib.IsGamepadAvailable(0))
        {
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_LEFT_FACE_UP, ImGuiKey.GamepadDpadUp);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_LEFT_FACE_RIGHT, ImGuiKey.GamepadDpadRight);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_LEFT_FACE_DOWN, ImGuiKey.GamepadDpadDown);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_LEFT_FACE_LEFT, ImGuiKey.GamepadDpadLeft);

            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_RIGHT_FACE_UP, ImGuiKey.GamepadFaceUp);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_RIGHT_FACE_RIGHT, ImGuiKey.GamepadFaceLeft);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_RIGHT_FACE_DOWN, ImGuiKey.GamepadFaceDown);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_RIGHT_FACE_LEFT, ImGuiKey.GamepadFaceRight);

            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_LEFT_TRIGGER_1, ImGuiKey.GamepadL1);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_LEFT_TRIGGER_2, ImGuiKey.GamepadL2);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_RIGHT_TRIGGER_1, ImGuiKey.GamepadR1);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_RIGHT_TRIGGER_2, ImGuiKey.GamepadR2);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_LEFT_THUMB, ImGuiKey.GamepadL3);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_RIGHT_THUMB, ImGuiKey.GamepadR3);

            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_MIDDLE_LEFT, ImGuiKey.GamepadStart);
            HandleGamepadButtonEvent(io, GamepadButton.GAMEPAD_BUTTON_MIDDLE_RIGHT, ImGuiKey.GamepadBack);

            // left stick
            HandleGamepadStickEvent(io, GamepadAxis.GAMEPAD_AXIS_LEFT_X, ImGuiKey.GamepadLStickLeft, ImGuiKey.GamepadLStickRight);
            HandleGamepadStickEvent(io, GamepadAxis.GAMEPAD_AXIS_LEFT_Y, ImGuiKey.GamepadLStickUp, ImGuiKey.GamepadLStickDown);

            // right stick
            HandleGamepadStickEvent(io, GamepadAxis.GAMEPAD_AXIS_RIGHT_X, ImGuiKey.GamepadRStickLeft, ImGuiKey.GamepadRStickRight);
            HandleGamepadStickEvent(io, GamepadAxis.GAMEPAD_AXIS_RIGHT_Y, ImGuiKey.GamepadRStickUp, ImGuiKey.GamepadRStickDown);
        }
    }

    private static void HandleGamepadButtonEvent(ImGuiIOPtr io, GamepadButton button, ImGuiKey key)
    {
        if (Raylib.IsGamepadButtonPressed(0, (int)button))
            io.AddKeyEvent(key, true);
        else if (Raylib.IsGamepadButtonReleased(0, (int)button))
            io.AddKeyEvent(key, false);
    }

    private static void HandleGamepadStickEvent(ImGuiIOPtr io, GamepadAxis axis, ImGuiKey negKey, ImGuiKey posKey)
    {
        const float deadZone = 0.20f;

        float axisValue = Raylib.GetGamepadAxisMovement(0, (int)axis);

        io.AddKeyAnalogEvent(negKey, axisValue < -deadZone, axisValue < -deadZone ? -axisValue : 0);
        io.AddKeyAnalogEvent(posKey, axisValue > deadZone, axisValue > deadZone ? axisValue : 0);
    }

    private static void EnableScissor(float x, float y, float width, float height)
    {
        Rlgl.EnableScissorTest();
        ImGuiIOPtr io = ImGui.GetIO();
        Vector2 scale = io.DisplayFramebufferScale;

        // On non-macOS platforms, when not in HIGHDPI mode, force scale to 1:1
        // (matching C++ EnableScissor logic)
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.OSX) &&
            !Raylib.IsWindowState((int)ConfigFlags.FLAG_WINDOW_HIGHDPI))
        {
            scale = new Vector2(1, 1);
        }

        Rlgl.Scissor(
            (int)(x * scale.X),
            (int)((io.DisplaySize.Y - (int)(y + height)) * scale.Y),
            (int)(width * scale.X),
            (int)(height * scale.Y));
    }

    private static void TriangleVert(ImDrawVert* idx_vert)
    {
        Vector4 color = ImGui.ColorConvertU32ToFloat4(idx_vert->Col);

        Rlgl.Color4f(color.X, color.Y, color.Z, color.W);
        Rlgl.TexCoord2f(idx_vert->Uv.X, idx_vert->Uv.Y);
        Rlgl.Vertex2f(idx_vert->Pos.X, idx_vert->Pos.Y);
    }

    private static void RenderTriangles(uint count, uint indexStart, ushort* indexBuffer, ImDrawVert* vertBuffer, nint texturePtr)
    {
        if (count < 3)
            return;

        uint textureId = (uint)texturePtr;

        Rlgl.Begin(4); // RL_TRIANGLES
        Rlgl.SetTexture(textureId);

        for (int i = 0; i <= (count - 3); i += 3)
        {
            if (Rlgl.CheckRenderBatchLimit(3))
            {
                Rlgl.Begin(4);
                Rlgl.SetTexture(textureId);
            }

            ushort indexA = indexBuffer[indexStart + i];
            ushort indexB = indexBuffer[indexStart + i + 1];
            ushort indexC = indexBuffer[indexStart + i + 2];

            ImDrawVert* vertexA = &vertBuffer[indexA];
            ImDrawVert* vertexB = &vertBuffer[indexB];
            ImDrawVert* vertexC = &vertBuffer[indexC];

            TriangleVert(vertexA);
            TriangleVert(vertexB);
            TriangleVert(vertexC);
        }
        Rlgl.End();
    }

    private static void RenderData()
    {
        var data = ImGui.GetDrawData();

        if (data.Textures.Size > 0)
        {
            for (int i = 0; i < data.Textures.Size; i++)
            {
                var tex = data.Textures[i].Handle;
                if (tex->Status != ImTextureStatus.Ok)
                    UpdateTexture(tex);
            }
        }

        Rlgl.DrawRenderBatchActive();
        Rlgl.DisableBackfaceCulling();

        for (int l = 0; l < data.CmdListsCount; l++)
        {
            var commandList = data.CmdLists[l];

            for (int cmdIndex = 0; cmdIndex < commandList.CmdBuffer.Size; cmdIndex++)
            {
                var cmd = commandList.CmdBuffer[cmdIndex];

                EnableScissor(
                    cmd.ClipRect.X - data.DisplayPos.X,
                    cmd.ClipRect.Y - data.DisplayPos.Y,
                    cmd.ClipRect.Z - (cmd.ClipRect.X - data.DisplayPos.X),
                    cmd.ClipRect.W - (cmd.ClipRect.Y - data.DisplayPos.Y)
                );

                if (cmd.UserCallback != null)
                {
                    ((delegate* unmanaged<ImDrawList*, ImDrawCmd*, void>)cmd.UserCallback)(commandList.Handle, &cmd);
                    continue;
                }

                RenderTriangles(
                    cmd.ElemCount,
                    cmd.IdxOffset,
                    commandList.IdxBuffer.Data,
                    commandList.VtxBuffer.Data,
                    cmd.GetTexID()
                );

                Rlgl.DrawRenderBatchActive();
            }
        }

        Rlgl.SetTexture(0);
        Rlgl.DisableScissorTest();
        Rlgl.EnableBackfaceCulling();
    }
}
