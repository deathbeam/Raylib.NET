using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct DrawCall
{
    /// <summary>
    /// Drawing mode: LINES, TRIANGLES, QUADS
    /// </summary>
    public int Mode;
    /// <summary>
    /// Number of vertex of the draw
    /// </summary>
    public int VertexCount;
    /// <summary>
    /// Number of vertex required for index alignment (LINES, TRIANGLES)
    /// </summary>
    public int VertexAlignment;
    /// <summary>
    /// Texture id to be used on the draw -> Use to create new draw call if changes
    /// </summary>
    public uint TextureId;

    public DrawCall(int Mode, int VertexCount, int VertexAlignment, uint TextureId)
    {
        this.Mode = Mode;
        this.VertexCount = VertexCount;
        this.VertexAlignment = VertexAlignment;
        this.TextureId = TextureId;
    }
}