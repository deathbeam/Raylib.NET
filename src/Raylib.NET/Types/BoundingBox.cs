using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct BoundingBox
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