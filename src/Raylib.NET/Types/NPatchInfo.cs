// This file was generated by Bindgen, do not edit it manually.
using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

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

    public NPatchInfo(Vector4 source, int left, int top, int right, int bottom, int layout)
    {
        this.Source = source;
        this.Left = left;
        this.Top = top;
        this.Right = right;
        this.Bottom = bottom;
        this.Layout = layout;
    }
}