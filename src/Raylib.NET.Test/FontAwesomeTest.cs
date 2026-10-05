using System.Numerics;
using Hexa.NET.ImGui;
using RaylibNET;
using Xunit;

namespace RaylibNET.Test;

public unsafe class FontAwesomeTest
{
    [Fact]
    public void MergedIconsAreFixedWidth()
    {
        ImGui.SetCurrentContext(ImGui.CreateContext());
        try
        {
            var io = ImGui.GetIO();
            io.Fonts.AddFontDefault();
            RlImGui.SetupFontAwesome();

            // Headless NewFrame (font atlas bakes here) needs a backend name and a display size.
            fixed (byte* name = "test"u8)
                io.BackendPlatformName = name;
            io.BackendFlags |= ImGuiBackendFlags.RendererHasTextures;
            io.DisplaySize = new Vector2(640, 480);
            io.DeltaTime = 0.016f;
            ImGui.NewFrame();

            // Positive control: the icon glyphs really baked into the font.
            var baked = io.Fonts.Fonts[0].LastBaked;
            Assert.False(baked.IsNull);
            Assert.True(baked.FindGlyphNoFallback(FontAwesome.ArrowRightLong[0]) != null);

            // Icons with wildly different natural widths must measure identically.
            string[] icons =
            [
                FontAwesome.CircleNotch, FontAwesome.Heart, FontAwesome.ArrowRight,
                FontAwesome.ArrowRightLong, FontAwesome.ArrowsLeftRight, FontAwesome.Gears,
                FontAwesome.Jedi, FontAwesome.Rocket
            ];
            var widths = icons.Select(i => ImGui.CalcTextSize(i).X).Distinct().ToList();
            Assert.Single(widths);

            ImGui.EndFrame();
        }
        finally
        {
            ImGui.DestroyContext();
        }
    }
}
