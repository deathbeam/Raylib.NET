using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct GlyphInfo
{
    /// <summary>
    /// Character value (Unicode)
    /// </summary>
    public int Value;
    /// <summary>
    /// Character offset X when drawing
    /// </summary>
    public int OffsetX;
    /// <summary>
    /// Character offset Y when drawing
    /// </summary>
    public int OffsetY;
    /// <summary>
    /// Character advance position X
    /// </summary>
    public int AdvanceX;
    /// <summary>
    /// Character image data
    /// </summary>
    public Image Image;

    public GlyphInfo(int Value, int OffsetX, int OffsetY, int AdvanceX, Image Image)
    {
        this.Value = Value;
        this.OffsetX = OffsetX;
        this.OffsetY = OffsetY;
        this.AdvanceX = AdvanceX;
        this.Image = Image;
    }
}