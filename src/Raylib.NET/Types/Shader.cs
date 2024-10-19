using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

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

    public unsafe Shader(uint Id, int* Locs)
    {
        this.Id = Id;
        this.Locs = Locs;
    }
}