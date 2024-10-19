using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Texture
{
    /// <summary>
    /// OpenGL texture id
    /// </summary>
    public uint Id;
    /// <summary>
    /// Texture base width
    /// </summary>
    public int Width;
    /// <summary>
    /// Texture base height
    /// </summary>
    public int Height;
    /// <summary>
    /// Mipmap levels, 1 by default
    /// </summary>
    public int Mipmaps;
    /// <summary>
    /// Data format (PixelFormat type)
    /// </summary>
    public int Format;

    public Texture(uint id, int width, int height, int mipmaps, int format)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.Mipmaps = mipmaps;
        this.Format = format;
    }
}