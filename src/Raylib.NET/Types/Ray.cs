using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Ray
{
    /// <summary>
    /// Ray position (origin)
    /// </summary>
    public Vector3 Position;
    /// <summary>
    /// Ray direction (normalized)
    /// </summary>
    public Vector3 Direction;

    public Ray(Vector3 position, Vector3 direction)
    {
        this.Position = position;
        this.Direction = direction;
    }
}