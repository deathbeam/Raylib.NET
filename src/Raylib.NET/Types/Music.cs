using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

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

    public unsafe Music(AudioStream stream, uint frameCount, NativeBool looping, int ctxType, void* ctxData)
    {
        this.Stream = stream;
        this.FrameCount = frameCount;
        this.Looping = looping;
        this.CtxType = ctxType;
        this.CtxData = ctxData;
    }
}