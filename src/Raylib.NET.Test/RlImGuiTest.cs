using System.Numerics;
using Hexa.NET.ImGui;
using Xunit;

namespace RaylibNET.Test;

public unsafe class RlImGuiTest
{
    [Fact]
    public void AtlasGrowKeepsTheWhitePixelOfOlderTextureGenerations()
    {
        ImGui.SetCurrentContext(ImGui.CreateContext());
        try
        {
            var io = ImGui.GetIO();
            io.Fonts.AddFontDefault();
            // Headless NewFrame needs a backend name and a display size.
            fixed (byte* name = "test"u8)
                io.BackendPlatformName = name;
            io.BackendFlags |= ImGuiBackendFlags.RendererHasTextures;
            io.DisplaySize = new Vector2(640, 480);
            io.DeltaTime = 0.016f;

            ImGui.NewFrame();
            ImGui.Begin("atlas");
            ImGui.Text("outline");
            ImGui.End();
            ImGui.EndFrame();
            ImGui.Render();

            var atlas = io.Fonts;
            var first = atlas.TexData;
            var firstSize = new Vector2(first.Width, first.Height);
            var firstUv = atlas.TexUvWhitePixel;

            // A larger pushed size bakes more glyphs than the initial texture holds, so the atlas grows.
            ImGui.NewFrame();
            ImGui.Begin("atlas");
            ImGui.PushFont(io.Fonts.Fonts[0], 64f);
            ImGui.Text(
                "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~"
            );
            ImGui.PopFont();
            ImGui.End();
            ImGui.EndFrame();
            ImGui.Render();

            var current = atlas.TexData;
            Assert.True(atlas.TexList.Size >= 2, "the atlas did not grow, so no older generation survived");

            // The renderer rebuilds an older generation's white pixel UV by scaling the current one by the size ratio.
            var currentSize = new Vector2(current.Width, current.Height);
            var scaled = atlas.TexUvWhitePixel * (currentSize / firstSize);
            Assert.Equal(firstUv.X, scaled.X, 5);
            Assert.Equal(firstUv.Y, scaled.Y, 5);

            // Which works because the white pixel keeps its atlas position across a grow.
            var firstPixel = (firstUv * firstSize) - new Vector2(0.5f);
            var currentPixel = (atlas.TexUvWhitePixel * currentSize) - new Vector2(0.5f);
            Assert.Equal(firstPixel.X, currentPixel.X, 2);
            Assert.Equal(firstPixel.Y, currentPixel.Y, 2);
        }
        finally
        {
            ImGui.DestroyContext();
        }
    }

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
