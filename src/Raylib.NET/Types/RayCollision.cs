using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct RayCollision
{
    /// <summary>
    /// Did the ray hit something?
    /// </summary>
    public NativeBool Hit;
    /// <summary>
    /// Distance to the nearest hit
    /// </summary>
    public float Distance;
    /// <summary>
    /// Point of the nearest hit
    /// </summary>
    public Vector3 Point;
    /// <summary>
    /// Surface normal of hit
    /// </summary>
    public Vector3 Normal;

    public RayCollision(NativeBool hit, float distance, Vector3 point, Vector3 normal)
    {
        this.Hit = hit;
        this.Distance = distance;
        this.Point = point;
        this.Normal = normal;
    }
}