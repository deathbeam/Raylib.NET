// This file is a port of rlImGui_cs to Raylib.NET
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace RaylibNET;

public static class RlImGui
{
    internal static IntPtr ImGuiContext = IntPtr.Zero;
    private static ImGuiMouseCursor CurrentMouseCursor = ImGuiMouseCursor.COUNT;
    private static Dictionary<ImGuiMouseCursor, int> MouseCursorMap = new();
    private static Texture FontTexture;
    static Dictionary<int, ImGuiKey> RaylibKeyMap = new();

    internal static bool LastFrameFocused = false;
    internal static bool LastControlPressed = false;
    internal static bool LastShiftPressed = false;
    internal static bool LastAltPressed = false;
    internal static bool LastSuperPressed = false;

    internal static bool rlImGuiIsControlDown() => Raylib.IsKeyDown(341) || Raylib.IsKeyDown(345); // LeftControl/RightControl
    internal static bool rlImGuiIsShiftDown() => Raylib.IsKeyDown(340) || Raylib.IsKeyDown(344); // LeftShift/RightShift
    internal static bool rlImGuiIsAltDown() => Raylib.IsKeyDown(342) || Raylib.IsKeyDown(346); // LeftAlt/RightAlt
    internal static bool rlImGuiIsSuperDown() => Raylib.IsKeyDown(343) || Raylib.IsKeyDown(347); // LeftSuper/RightSuper

    public delegate void SetupUserFontsCallback(ImGuiIOPtr imGuiIo);
    public static SetupUserFontsCallback? SetupUserFonts = null;

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
        MouseCursorMap = new();

        LastFrameFocused = Raylib.IsWindowFocused();
        LastControlPressed = false;
        LastShiftPressed = false;
        LastAltPressed = false;
        LastSuperPressed = false;

        FontTexture.Id = 0;

        SetupKeymap();

        ImGuiContext = ImGui.CreateContext();
    }

    internal static void SetupKeymap()
    {
        if (RaylibKeyMap.Count > 0)
            return;

        // Map Raylib key codes to ImGuiKey
        RaylibKeyMap[39] = ImGuiKey.Apostrophe;
        RaylibKeyMap[44] = ImGuiKey.Comma;
        RaylibKeyMap[45] = ImGuiKey.Minus;
        RaylibKeyMap[46] = ImGuiKey.Period;
        RaylibKeyMap[47] = ImGuiKey.Slash;
        RaylibKeyMap[48] = ImGuiKey._0;
        RaylibKeyMap[49] = ImGuiKey._1;
        RaylibKeyMap[50] = ImGuiKey._2;
        RaylibKeyMap[51] = ImGuiKey._3;
        RaylibKeyMap[52] = ImGuiKey._4;
        RaylibKeyMap[53] = ImGuiKey._5;
        RaylibKeyMap[54] = ImGuiKey._6;
        RaylibKeyMap[55] = ImGuiKey._7;
        RaylibKeyMap[56] = ImGuiKey._8;
        RaylibKeyMap[57] = ImGuiKey._9;
        RaylibKeyMap[59] = ImGuiKey.Semicolon;
        RaylibKeyMap[61] = ImGuiKey.Equal;
        RaylibKeyMap[65] = ImGuiKey.A;
        RaylibKeyMap[66] = ImGuiKey.B;
        RaylibKeyMap[67] = ImGuiKey.C;
        RaylibKeyMap[68] = ImGuiKey.D;
        RaylibKeyMap[69] = ImGuiKey.E;
        RaylibKeyMap[70] = ImGuiKey.F;
        RaylibKeyMap[71] = ImGuiKey.G;
        RaylibKeyMap[72] = ImGuiKey.H;
        RaylibKeyMap[73] = ImGuiKey.I;
        RaylibKeyMap[74] = ImGuiKey.J;
        RaylibKeyMap[75] = ImGuiKey.K;
        RaylibKeyMap[76] = ImGuiKey.L;
        RaylibKeyMap[77] = ImGuiKey.M;
        RaylibKeyMap[78] = ImGuiKey.N;
        RaylibKeyMap[79] = ImGuiKey.O;
        RaylibKeyMap[80] = ImGuiKey.P;
        RaylibKeyMap[81] = ImGuiKey.Q;
        RaylibKeyMap[82] = ImGuiKey.R;
        RaylibKeyMap[83] = ImGuiKey.S;
        RaylibKeyMap[84] = ImGuiKey.T;
        RaylibKeyMap[85] = ImGuiKey.U;
        RaylibKeyMap[86] = ImGuiKey.V;
        RaylibKeyMap[87] = ImGuiKey.W;
        RaylibKeyMap[88] = ImGuiKey.X;
        RaylibKeyMap[89] = ImGuiKey.Y;
        RaylibKeyMap[90] = ImGuiKey.Z;
        RaylibKeyMap[32] = ImGuiKey.Space;
        RaylibKeyMap[256] = ImGuiKey.Escape;
        RaylibKeyMap[257] = ImGuiKey.Enter;
        RaylibKeyMap[258] = ImGuiKey.Tab;
        RaylibKeyMap[259] = ImGuiKey.Backspace;
        RaylibKeyMap[260] = ImGuiKey.Insert;
        RaylibKeyMap[261] = ImGuiKey.Delete;
        RaylibKeyMap[262] = ImGuiKey.RightArrow;
        RaylibKeyMap[263] = ImGuiKey.LeftArrow;
        RaylibKeyMap[264] = ImGuiKey.DownArrow;
        RaylibKeyMap[265] = ImGuiKey.UpArrow;
        RaylibKeyMap[266] = ImGuiKey.PageUp;
        RaylibKeyMap[267] = ImGuiKey.PageDown;
        RaylibKeyMap[268] = ImGuiKey.Home;
        RaylibKeyMap[269] = ImGuiKey.End;
        RaylibKeyMap[280] = ImGuiKey.CapsLock;
        RaylibKeyMap[281] = ImGuiKey.ScrollLock;
        RaylibKeyMap[282] = ImGuiKey.NumLock;
        RaylibKeyMap[283] = ImGuiKey.PrintScreen;
        RaylibKeyMap[284] = ImGuiKey.Pause;
        RaylibKeyMap[290] = ImGuiKey.F1;
        RaylibKeyMap[291] = ImGuiKey.F2;
        RaylibKeyMap[292] = ImGuiKey.F3;
        RaylibKeyMap[293] = ImGuiKey.F4;
        RaylibKeyMap[294] = ImGuiKey.F5;
        RaylibKeyMap[295] = ImGuiKey.F6;
        RaylibKeyMap[296] = ImGuiKey.F7;
        RaylibKeyMap[297] = ImGuiKey.F8;
        RaylibKeyMap[298] = ImGuiKey.F9;
        RaylibKeyMap[299] = ImGuiKey.F10;
        RaylibKeyMap[300] = ImGuiKey.F11;
        RaylibKeyMap[301] = ImGuiKey.F12;
        RaylibKeyMap[340] = ImGuiKey.LeftShift;
        RaylibKeyMap[341] = ImGuiKey.LeftCtrl;
        RaylibKeyMap[342] = ImGuiKey.LeftAlt;
        RaylibKeyMap[343] = ImGuiKey.LeftSuper;
        RaylibKeyMap[344] = ImGuiKey.RightShift;
        RaylibKeyMap[345] = ImGuiKey.RightCtrl;
        RaylibKeyMap[346] = ImGuiKey.RightAlt;
        RaylibKeyMap[347] = ImGuiKey.RightSuper;
        RaylibKeyMap[348] = ImGuiKey.Menu;
        RaylibKeyMap[91] = ImGuiKey.LeftBracket;
        RaylibKeyMap[92] = ImGuiKey.Backslash;
        RaylibKeyMap[93] = ImGuiKey.RightBracket;
        RaylibKeyMap[96] = ImGuiKey.GraveAccent;
        RaylibKeyMap[320] = ImGuiKey.Keypad0;
        RaylibKeyMap[321] = ImGuiKey.Keypad1;
        RaylibKeyMap[322] = ImGuiKey.Keypad2;
        RaylibKeyMap[323] = ImGuiKey.Keypad3;
        RaylibKeyMap[324] = ImGuiKey.Keypad4;
        RaylibKeyMap[325] = ImGuiKey.Keypad5;
        RaylibKeyMap[326] = ImGuiKey.Keypad6;
        RaylibKeyMap[327] = ImGuiKey.Keypad7;
        RaylibKeyMap[328] = ImGuiKey.Keypad8;
        RaylibKeyMap[329] = ImGuiKey.Keypad9;
        RaylibKeyMap[330] = ImGuiKey.KeypadDecimal;
        RaylibKeyMap[331] = ImGuiKey.KeypadDivide;
        RaylibKeyMap[332] = ImGuiKey.KeypadMultiply;
        RaylibKeyMap[333] = ImGuiKey.KeypadSubtract;
        RaylibKeyMap[334] = ImGuiKey.KeypadAdd;
        RaylibKeyMap[335] = ImGuiKey.KeypadEnter;
        RaylibKeyMap[336] = ImGuiKey.KeypadEqual;
    }

    private static void SetupMouseCursors()
    {
        MouseCursorMap.Clear();
        MouseCursorMap[ImGuiMouseCursor.Arrow] = 0;
        MouseCursorMap[ImGuiMouseCursor.TextInput] = 1;
        MouseCursorMap[ImGuiMouseCursor.Hand] = 2;
        MouseCursorMap[ImGuiMouseCursor.ResizeAll] = 9;
        MouseCursorMap[ImGuiMouseCursor.ResizeEW] = 4;
        MouseCursorMap[ImGuiMouseCursor.ResizeNESW] = 7;
        MouseCursorMap[ImGuiMouseCursor.ResizeNS] = 5;
        MouseCursorMap[ImGuiMouseCursor.ResizeNWSE] = 6;
        MouseCursorMap[ImGuiMouseCursor.NotAllowed] = 10;
    }

    public static unsafe void ReloadFonts()
    {
        ImGui.SetCurrentContext(ImGuiContext);
        ImGuiIOPtr io = ImGui.GetIO();

        int width, height, bytesPerPixel;
        io.Fonts.GetTexDataAsRGBA32(out byte* pixels, out width, out height, out bytesPerPixel);

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

    public static bool LoadDefaultFont = true;

    public static void EndInitImGui()
    {
        SetupMouseCursors();

        ImGui.SetCurrentContext(ImGuiContext);

        var fonts = ImGui.GetIO().Fonts;

        if (LoadDefaultFont)
            ImGui.GetIO().Fonts.AddFontDefault();

        ImGuiIOPtr io = ImGui.GetIO();
        ImGuiPlatformIOPtr platformIO = ImGui.GetPlatformIO();

        SetupUserFonts?.Invoke(io);

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
                        if (!MouseCursorMap.ContainsKey(imgui_cursor))
                            Raylib.SetMouseCursor(0);
                        else
                            Raylib.SetMouseCursor(MouseCursorMap[imgui_cursor]);
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

        bool ctrlDown = rlImGuiIsControlDown();
        if (ctrlDown != LastControlPressed)
            io.AddKeyEvent(ImGuiKey.ModCtrl, ctrlDown);
        LastControlPressed = ctrlDown;

        bool shiftDown = rlImGuiIsShiftDown();
        if (shiftDown != LastShiftPressed)
            io.AddKeyEvent(ImGuiKey.ModShift, shiftDown);
        LastShiftPressed = shiftDown;

        bool altDown = rlImGuiIsAltDown();
        if (altDown != LastAltPressed)
            io.AddKeyEvent(ImGuiKey.ModAlt, altDown);
        LastAltPressed = altDown;

        bool superDown = rlImGuiIsSuperDown();
        if (superDown != LastSuperPressed)
            io.AddKeyEvent(ImGuiKey.ModSuper, superDown);
        LastSuperPressed = superDown;

        int keyId = Raylib.GetKeyPressed();
        while (keyId != 0)
        {
            if (RaylibKeyMap.ContainsKey(keyId))
                io.AddKeyEvent(RaylibKeyMap[keyId], true);
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
