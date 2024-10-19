using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Font
{
    /// <summary>
    /// Base size (default chars height)
    /// </summary>
    public int BaseSize;
    /// <summary>
    /// Number of glyph characters
    /// </summary>
    public int GlyphCount;
    /// <summary>
    /// Padding around the glyph characters
    /// </summary>
    public int GlyphPadding;
    /// <summary>
    /// Texture atlas containing the glyphs
    /// </summary>
    public Texture Texture;
    /// <summary>
    /// Rectangles in texture for the glyphs
    /// </summary>
    public unsafe Vector4* Recs;
    /// <summary>
    /// Glyphs info data
    /// </summary>
    public unsafe GlyphInfo* Glyphs;

    public unsafe Font(int BaseSize, int GlyphCount, int GlyphPadding, Texture Texture, Vector4* Recs, GlyphInfo* Glyphs)
    {
        this.BaseSize = BaseSize;
        this.GlyphCount = GlyphCount;
        this.GlyphPadding = GlyphPadding;
        this.Texture = Texture;
        this.Recs = Recs;
        this.Glyphs = Glyphs;
    }
}