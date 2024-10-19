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

    public GlyphInfo(int value, int offsetX, int offsetY, int advanceX, Image image)
    {
        this.Value = value;
        this.OffsetX = offsetX;
        this.OffsetY = offsetY;
        this.AdvanceX = advanceX;
        this.Image = image;
    }
}