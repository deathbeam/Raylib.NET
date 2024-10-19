using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct MaterialMap
{
    /// <summary>
    /// Material map texture
    /// </summary>
    public Texture Texture;
    /// <summary>
    /// Material map color
    /// </summary>
    public Color Color;
    /// <summary>
    /// Material map value
    /// </summary>
    public float Value;

    public MaterialMap(Texture Texture, Color Color, float Value)
    {
        this.Texture = Texture;
        this.Color = Color;
        this.Value = Value;
    }
}