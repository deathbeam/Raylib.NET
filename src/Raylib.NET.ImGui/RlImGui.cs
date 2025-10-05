using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace RaylibNET;

public static class RlImGui
{
    private static IntPtr ImGuiContext = IntPtr.Zero;
    private static ImGuiMouseCursor CurrentMouseCursor = ImGuiMouseCursor.COUNT;
    private static Texture FontTexture;
    private static readonly Dictionary<ImGuiMouseCursor, int> MouseCursorMap = [];
    private static readonly Dictionary<int, ImGuiKey> RaylibKeyMap = [];

    internal static bool LastFrameFocused = false;
    internal static bool LastControlPressed = false;
    internal static bool LastShiftPressed = false;
    internal static bool LastAltPressed = false;
    internal static bool LastSuperPressed = false;

    internal static bool IsControlDown() => Raylib.IsKeyDown((int)KeyboardKey.KEY_RIGHT_CONTROL) || Raylib.IsKeyDown((int)KeyboardKey.KEY_LEFT_CONTROL);
    internal static bool IsShiftDown() => Raylib.IsKeyDown((int)KeyboardKey.KEY_LEFT_SHIFT) || Raylib.IsKeyDown((int)KeyboardKey.KEY_RIGHT_SHIFT);
    internal static bool IsAltDown() => Raylib.IsKeyDown((int)KeyboardKey.KEY_LEFT_ALT) || Raylib.IsKeyDown((int)KeyboardKey.KEY_RIGHT_ALT);
    internal static bool IsSuperDown() => Raylib.IsKeyDown((int)KeyboardKey.KEY_LEFT_SUPER) || Raylib.IsKeyDown((int)KeyboardKey.KEY_RIGHT_SUPER);

    public static void Setup(bool darkTheme = true, bool enableDocking = false)
    {
        BeginInitImGui();

        if (darkTheme)
            ImGui.StyleColorsDark();
        else
            ImGui.StyleColorsLight();

        if (enableDocking)
            ImGui.GetIO().ConfigFlags |= ImGuiConfigFlags.DockingEnable;

        EndInitImGui();
    }

    public static void BeginInitImGui()
    {
        LastFrameFocused = Raylib.IsWindowFocused();
        LastControlPressed = false;
        LastShiftPressed = false;
        LastAltPressed = false;
        LastSuperPressed = false;

        FontTexture.Id = 0;

        SetupKeymap();

        ImGuiContext = ImGui.CreateContext();
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
        RaylibKeyMap[(int)KeyboardKey.KEY_ZERO] = ImGuiKey._0;
        RaylibKeyMap[(int)KeyboardKey.KEY_ONE] = ImGuiKey._1;
        RaylibKeyMap[(int)KeyboardKey.KEY_TWO] = ImGuiKey._2;
        RaylibKeyMap[(int)KeyboardKey.KEY_THREE] = ImGuiKey._3;
        RaylibKeyMap[(int)KeyboardKey.KEY_FOUR] = ImGuiKey._4;
        RaylibKeyMap[(int)KeyboardKey.KEY_FIVE] = ImGuiKey._5;
        RaylibKeyMap[(int)KeyboardKey.KEY_SIX] = ImGuiKey._6;
        RaylibKeyMap[(int)KeyboardKey.KEY_SEVEN] = ImGuiKey._7;
        RaylibKeyMap[(int)KeyboardKey.KEY_EIGHT] = ImGuiKey._8;
        RaylibKeyMap[(int)KeyboardKey.KEY_NINE] = ImGuiKey._9;
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
        MouseCursorMap[ImGuiMouseCursor.ResizeEW] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_EW;
        MouseCursorMap[ImGuiMouseCursor.ResizeNESW] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_NESW;
        MouseCursorMap[ImGuiMouseCursor.ResizeNS] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_NS;
        MouseCursorMap[ImGuiMouseCursor.ResizeNWSE] = (int)MouseCursor.MOUSE_CURSOR_RESIZE_NWSE;
        MouseCursorMap[ImGuiMouseCursor.NotAllowed] = (int)MouseCursor.MOUSE_CURSOR_NOT_ALLOWED;
    }

    public static unsafe void ReloadFonts()
    {
        ImGui.SetCurrentContext(ImGuiContext);
        ImGuiIOPtr io = ImGui.GetIO();

        io.Fonts.GetTexDataAsRGBA32(
                out byte* pixels,
                out int width,
                out int height,
                out int bytesPerPixel
        );

        Image image = new()
        {
            Data = pixels,
            Width = width,
            Height = height,
            Mipmaps = 1,
            Format = (int)PixelFormat.PIXELFORMAT_UNCOMPRESSED_R8G8B8A8,
        };

        if (Raylib.IsTextureValid(FontTexture))
            Raylib.UnloadTexture(FontTexture);

        FontTexture = Raylib.LoadTextureFromImage(image);

        io.Fonts.SetTexID(new IntPtr(FontTexture.Id));
    }

    unsafe internal static sbyte* rImGuiGetClipText(IntPtr userData)
    {
         return (sbyte*)Marshal.StringToHGlobalAnsi(Raylib.GetClipboardText());
    }

    unsafe internal static void rlImGuiSetClipText(IntPtr userData, sbyte* text)
    {
        Raylib.SetClipboardText(Marshal.PtrToStringAnsi((IntPtr)text)!);
    }

    private unsafe delegate sbyte* GetClipTextCallback(IntPtr userData);
    private unsafe delegate void SetClipTextCallback(IntPtr userData, sbyte* text);

    private static GetClipTextCallback? GetClipCallback;
    private static SetClipTextCallback? SetClipCallback;

    public static void EndInitImGui()
    {
        SetupMouseCursors();

        ImGui.SetCurrentContext(ImGuiContext);

        var fonts = ImGui.GetIO().Fonts;
        fonts.AddFontDefault();

        ImGuiIOPtr io = ImGui.GetIO();
        ImGuiPlatformIOPtr platformIO = ImGui.GetPlatformIO();

        io.BackendFlags |= ImGuiBackendFlags.HasMouseCursors | ImGuiBackendFlags.HasSetMousePos | ImGuiBackendFlags.HasGamepad;
        io.MousePos.X = 0;
        io.MousePos.Y = 0;

        unsafe
        {
            SetClipCallback = new SetClipTextCallback(rlImGuiSetClipText);
            platformIO.Platform_SetClipboardTextFn = Marshal.GetFunctionPointerForDelegate(SetClipCallback);

            GetClipCallback = new GetClipTextCallback(rImGuiGetClipText);
            platformIO.Platform_GetClipboardTextFn = Marshal.GetFunctionPointerForDelegate(GetClipCallback);
        }

        platformIO.Platform_ClipboardUserData = IntPtr.Zero;
        ReloadFonts();
    }

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

        io.DisplayFramebufferScale = new Vector2(1, 1);

        if (Raylib.IsWindowState(0x00002000) /* ConfigFlags.HighDpiWindow */)
            io.DisplayFramebufferScale = Raylib.GetWindowScaleDPI();

        io.DeltaTime = dt >= 0 ? dt : Raylib.GetFrameTime();

        if (io.WantSetMousePos)
        {
            Raylib.SetMousePosition((int)io.MousePos.X, (int)io.MousePos.Y);
        }
        else
        {
            io.AddMousePosEvent(Raylib.GetMouseX(), Raylib.GetMouseY());
        }

        SetMouseEvent(io, 0, ImGuiMouseButton.Left);
        SetMouseEvent(io, 1, ImGuiMouseButton.Right);
        SetMouseEvent(io, 2, ImGuiMouseButton.Middle);
        SetMouseEvent(io, 3, ImGuiMouseButton.Middle + 1);
        SetMouseEvent(io, 4, ImGuiMouseButton.Middle + 2);

        var wheelMove = Raylib.GetMouseWheelMoveV();
        io.AddMouseWheelEvent(wheelMove.X, wheelMove.Y);

        if ((io.ConfigFlags & ImGuiConfigFlags.NoMouseCursorChange) == 0)
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

        var pressed = Raylib.GetCharPressed();
        while (pressed != 0)
        {
            io.AddInputCharacter((uint)pressed);
            pressed = Raylib.GetCharPressed();
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

    public static void Begin(float dt = -1)
    {
        ImGui.SetCurrentContext(ImGuiContext);

        NewFrame(dt);
        FrameEvents();
        ImGui.NewFrame();
    }

    private static void EnableScissor(float x, float y, float width, float height)
    {
        Rlgl.EnableScissorTest();
        ImGuiIOPtr io = ImGui.GetIO();

        Vector2 scale = new(1.0f, 1.0f);
        if (Raylib.IsWindowState(0x00002000))
            scale = io.DisplayFramebufferScale;

        Rlgl.Scissor(
            (int)(x * scale.X),
            (int)((io.DisplaySize.Y - (int)(y + height)) * scale.Y),
            (int)(width * scale.X),
            (int)(height * scale.Y));
    }

    private static void TriangleVert(ImDrawVertPtr idx_vert)
    {
        Vector4 color = ImGui.ColorConvertU32ToFloat4(idx_vert.col);

        Rlgl.Color4f(color.X, color.Y, color.Z, color.W);
        Rlgl.TexCoord2f(idx_vert.uv.X, idx_vert.uv.Y);
        Rlgl.Vertex2f(idx_vert.pos.X, idx_vert.pos.Y);
    }

    private static void RenderTriangles(uint count, uint indexStart, ImVector<ushort> indexBuffer, ImPtrVector<ImDrawVertPtr> vertBuffer, IntPtr texturePtr)
    {
        if (count < 3)
            return;

        uint textureId = 0;
        if (texturePtr != IntPtr.Zero)
            textureId = (uint)texturePtr.ToInt32();

        Rlgl.Begin(4); // RL_TRIANGLES
        Rlgl.SetTexture(textureId);

        for (int i = 0; i <= (count - 3); i += 3)
        {
            if (Rlgl.CheckRenderBatchLimit(3))
            {
                Rlgl.Begin(4);
                Rlgl.SetTexture(textureId);
            }

            ushort indexA = indexBuffer[(int)indexStart + i];
            ushort indexB = indexBuffer[(int)indexStart + i + 1];
            ushort indexC = indexBuffer[(int)indexStart + i + 2];

            ImDrawVertPtr vertexA = vertBuffer[indexA];
            ImDrawVertPtr vertexB = vertBuffer[indexB];
            ImDrawVertPtr vertexC = vertBuffer[indexC];

            TriangleVert(vertexA);
            TriangleVert(vertexB);
            TriangleVert(vertexC);
        }
        Rlgl.End();
    }

    private delegate void Callback(ImDrawListPtr list, ImDrawCmdPtr cmd);

    private static void RenderData()
    {
        Rlgl.DrawRenderBatchActive();
        Rlgl.DisableBackfaceCulling();

        var data = ImGui.GetDrawData();

        for (int l = 0; l < data.CmdListsCount; l++)
        {
            ImDrawListPtr commandList = data.CmdLists[l];

            for (int cmdIndex = 0; cmdIndex < commandList.CmdBuffer.Size; cmdIndex++)
            {
                var cmd = commandList.CmdBuffer[cmdIndex];

                EnableScissor(cmd.ClipRect.X - data.DisplayPos.X, cmd.ClipRect.Y - data.DisplayPos.Y, cmd.ClipRect.Z - (cmd.ClipRect.X - data.DisplayPos.X), cmd.ClipRect.W - (cmd.ClipRect.Y - data.DisplayPos.Y));
                if (cmd.UserCallback != IntPtr.Zero)
                {
                    Callback cb = Marshal.GetDelegateForFunctionPointer<Callback>(cmd.UserCallback);
                    cb(commandList, cmd);
                    continue;
                }

                RenderTriangles(cmd.ElemCount, cmd.IdxOffset, commandList.IdxBuffer, commandList.VtxBuffer, cmd.TextureId);

                Rlgl.DrawRenderBatchActive();
            }
        }
        Rlgl.SetTexture(0);
        Rlgl.DisableScissorTest();
        Rlgl.EnableBackfaceCulling();
    }

    public static void End()
    {
        ImGui.SetCurrentContext(ImGuiContext);
        ImGui.Render();
        RenderData();
    }

    public static void Shutdown()
    {
        Raylib.UnloadTexture(FontTexture);
        ImGui.DestroyContext();
    }

    public static void Image(Texture image)
    {
        ImGui.Image(new IntPtr(image.Id), new Vector2(image.Width, image.Height));
    }

    public static void ImageSize(Texture image, int width, int height)
    {
        ImGui.Image(new IntPtr(image.Id), new Vector2(width, height));
    }

    public static void ImageSize(Texture image, Vector2 size)
    {
        ImGui.Image(new IntPtr(image.Id), size);
    }

    public static void ImageRect(Texture image, int destWidth, int destHeight, Vector4 sourceRect)
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

        ImGui.Image(new IntPtr(image.Id), new Vector2(destWidth, destHeight), uv0, uv1);
    }

    public static void ImageRenderTexture(RenderTexture image)
    {
        ImageRect(image.Texture, image.Texture.Width, image.Texture.Height, new Vector4(0, 0, image.Texture.Width, -image.Texture.Height));
    }

    public static void ImageRenderTextureFit(RenderTexture image, bool center = true)
    {
        Vector2 area = ImGui.GetContentRegionAvail();

        float scale = area.X / image.Texture.Width;

        float y = image.Texture.Height * scale;
        if (y > area.Y)
        {
            scale = area.Y / image.Texture.Height;
        }

        int sizeX = (int)(image.Texture.Width * scale);
        int sizeY = (int)(image.Texture.Height * scale);

        if (center)
        {
            ImGui.SetCursorPosX(0);
            ImGui.SetCursorPosX(area.X / 2 - sizeX / 2);
            ImGui.SetCursorPosY(ImGui.GetCursorPosY() + (area.Y / 2 - sizeY / 2));
        }

        ImageRect(image.Texture, sizeX, sizeY, new Vector4(0, 0, image.Texture.Width, -image.Texture.Height));
    }

    public static bool ImageButton(string name, Texture image)
    {
        return ImageButtonSize(name, image, new Vector2(image.Width, image.Height));
    }

    public static bool ImageButtonSize(string name, Texture image, Vector2 size)
    {
        return ImGui.ImageButton(name, new IntPtr(image.Id), size);
    }
}
