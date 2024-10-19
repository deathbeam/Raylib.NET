using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

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

    public Transform(Vector3 translation, Vector4 rotation, Vector3 scale)
    {
        this.Translation = translation;
        this.Rotation = rotation;
        this.Scale = scale;
    }
}