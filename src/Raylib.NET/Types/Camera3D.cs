using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Camera3D
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

    public Camera3D(Vector3 position, Vector3 target, Vector3 up, float fovy, int projection)
    {
        this.Position = position;
        this.Target = target;
        this.Up = up;
        this.Fovy = fovy;
        this.Projection = projection;
    }
}