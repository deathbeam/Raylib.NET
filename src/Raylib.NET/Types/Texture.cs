using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

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

    public Texture(uint Id, int Width, int Height, int Mipmaps, int Format)
    {
        this.Id = Id;
        this.Width = Width;
        this.Height = Height;
        this.Mipmaps = Mipmaps;
        this.Format = Format;
    }
}