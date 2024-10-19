using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct Camera3D
{
    /// <summary>
    /// Camera position
    /// </summary>
    public Vector3 Position;
    /// <summary>
    /// Camera target it looks-at
    /// </summary>
    public Vector3 Target;
    /// <summary>
    /// Camera up vector (rotation over its axis)
    /// </summary>
    public Vector3 Up;
    /// <summary>
    /// Camera field-of-view aperture in Y (degrees) in perspective, used as near plane width in orthographic
    /// </summary>
    public float Fovy;
    /// <summary>
    /// Camera projection: CAMERA_PERSPECTIVE or CAMERA_ORTHOGRAPHIC
    /// </summary>
    public int Projection;

    public Camera3D(Vector3 Position, Vector3 Target, Vector3 Up, float Fovy, int Projection)
    {
        this.Position = Position;
        this.Target = Target;
        this.Up = Up;
        this.Fovy = Fovy;
        this.Projection = Projection;
    }
}