using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Image
{
    /// <summary>
    /// Image raw data
    /// </summary>
    public unsafe void* Data;
    /// <summary>
    /// Image base width
    /// </summary>
    public int Width;
    /// <summary>
    /// Image base height
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

    public unsafe Image(void* Data, int Width, int Height, int Mipmaps, int Format)
    {
        this.Data = Data;
        this.Width = Width;
        this.Height = Height;
        this.Mipmaps = Mipmaps;
        this.Format = Format;
    }
}