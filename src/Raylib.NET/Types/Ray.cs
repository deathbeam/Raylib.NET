using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct Ray
{
    /// <summary>
    /// Ray position (origin)
    /// </summary>
    public Vector3 Position;
    /// <summary>
    /// Ray direction (normalized)
    /// </summary>
    public Vector3 Direction;

    public Ray(Vector3 Position, Vector3 Direction)
    {
        this.Position = Position;
        this.Direction = Direction;
    }
}