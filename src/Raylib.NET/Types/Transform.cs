using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Transform
{
    /// <summary>
    /// Translation
    /// </summary>
    public Vector3 Translation;
    /// <summary>
    /// Rotation
    /// </summary>
    public Vector4 Rotation;
    /// <summary>
    /// Scale
    /// </summary>
    public Vector3 Scale;

    public Transform(Vector3 Translation, Vector4 Rotation, Vector3 Scale)
    {
        this.Translation = Translation;
        this.Rotation = Rotation;
        this.Scale = Scale;
    }
}