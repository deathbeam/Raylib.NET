using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

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

    public RenderTexture(uint id, Texture texture, Texture depth)
    {
        this.Id = id;
        this.Texture = texture;
        this.Depth = depth;
    }
}