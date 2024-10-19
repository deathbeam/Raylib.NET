using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Material
{
    /// <summary>
    /// Material shader
    /// </summary>
    public Shader Shader;
    /// <summary>
    /// Material maps array (MAX_MATERIAL_MAPS)
    /// </summary>
    public unsafe MaterialMap* Maps;
    /// <summary>
    /// Material generic parameters (if required)
    /// </summary>
    public unsafe fixed float Params[4];
}