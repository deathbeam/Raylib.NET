using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct NPatchInfo
{
    /// <summary>
    /// Texture source rectangle
    /// </summary>
    public Vector4 Source;
    /// <summary>
    /// Left border offset
    /// </summary>
    public int Left;
    /// <summary>
    /// Top border offset
    /// </summary>
    public int Top;
    /// <summary>
    /// Right border offset
    /// </summary>
    public int Right;
    /// <summary>
    /// Bottom border offset
    /// </summary>
    public int Bottom;
    /// <summary>
    /// Layout of the n-patch: 3x3, 1x3 or 3x1
    /// </summary>
    public int Layout;

    public NPatchInfo(Vector4 Source, int Left, int Top, int Right, int Bottom, int Layout)
    {
        this.Source = Source;
        this.Left = Left;
        this.Top = Top;
        this.Right = Right;
        this.Bottom = Bottom;
        this.Layout = Layout;
    }
}