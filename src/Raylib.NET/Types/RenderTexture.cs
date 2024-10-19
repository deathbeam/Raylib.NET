using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct RenderTexture
{
    /// <summary>
    /// OpenGL framebuffer object id
    /// </summary>
    public uint Id;
    /// <summary>
    /// Color buffer attachment texture
    /// </summary>
    public Texture Texture;
    /// <summary>
    /// Depth buffer attachment texture
    /// </summary>
    public Texture Depth;

    public RenderTexture(uint Id, Texture Texture, Texture Depth)
    {
        this.Id = Id;
        this.Texture = Texture;
        this.Depth = Depth;
    }
}