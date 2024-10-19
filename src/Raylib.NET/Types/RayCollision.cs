using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

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

    public RayCollision(NativeBool Hit, float Distance, Vector3 Point, Vector3 Normal)
    {
        this.Hit = Hit;
        this.Distance = Distance;
        this.Point = Point;
        this.Normal = Normal;
    }
}