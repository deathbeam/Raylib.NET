using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct BoundingBox
{
    /// <summary>
    /// Minimum vertex box-corner
    /// </summary>
    public Vector3 Min;
    /// <summary>
    /// Maximum vertex box-corner
    /// </summary>
    public Vector3 Max;

    public BoundingBox(Vector3 Min, Vector3 Max)
    {
        this.Min = Min;
        this.Max = Max;
    }
}