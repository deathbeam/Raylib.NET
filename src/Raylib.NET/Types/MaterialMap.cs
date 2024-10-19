using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct MaterialMap
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

    public MaterialMap(Texture texture, Color color, float value)
    {
        this.Texture = texture;
        this.Color = color;
        this.Value = value;
    }
}