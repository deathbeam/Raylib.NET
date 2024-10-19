using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Music
{
    /// <summary>
    /// Audio stream
    /// </summary>
    public AudioStream Stream;
    /// <summary>
    /// Total number of frames (considering channels)
    /// </summary>
    public uint FrameCount;
    /// <summary>
    /// Music looping enable
    /// </summary>
    public NativeBool Looping;
    /// <summary>
    /// Type of music context (audio filetype)
    /// </summary>
    public int CtxType;
    /// <summary>
    /// Audio context data, depends on type
    /// </summary>
    public unsafe void* CtxData;

    public unsafe Music(AudioStream Stream, uint FrameCount, NativeBool Looping, int CtxType, void* CtxData)
    {
        this.Stream = Stream;
        this.FrameCount = FrameCount;
        this.Looping = Looping;
        this.CtxType = CtxType;
        this.CtxData = CtxData;
    }
}