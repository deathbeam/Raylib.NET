using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct Camera2D
{
    /// <summary>
    /// Camera offset (displacement from target)
    /// </summary>
    public Vector2 Offset;
    /// <summary>
    /// Camera target (rotation and zoom origin)
    /// </summary>
    public Vector2 Target;
    /// <summary>
    /// Camera rotation in degrees
    /// </summary>
    public float Rotation;
    /// <summary>
    /// Camera zoom (scaling), should be 1.0f by default
    /// </summary>
    public float Zoom;

    public Camera2D(Vector2 Offset, Vector2 Target, float Rotation, float Zoom)
    {
        this.Offset = Offset;
        this.Target = Target;
        this.Rotation = Rotation;
        this.Zoom = Zoom;
    }
}