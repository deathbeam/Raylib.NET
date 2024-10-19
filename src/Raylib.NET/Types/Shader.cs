using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Shader
{
    /// <summary>
    /// Shader program id
    /// </summary>
    public uint Id;
    /// <summary>
    /// Shader locations array (RL_MAX_SHADER_LOCATIONS)
    /// </summary>
    public unsafe int* Locs;

    public unsafe Shader(uint id, int* locs)
    {
        this.Id = id;
        this.Locs = locs;
    }
}