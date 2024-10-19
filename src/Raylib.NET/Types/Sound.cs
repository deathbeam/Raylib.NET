using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct Sound
{
    /// <summary>
    /// Audio stream
    /// </summary>
    public AudioStream Stream;
    /// <summary>
    /// Total number of frames (considering channels)
    /// </summary>
    public uint FrameCount;

    public Sound(AudioStream stream, uint frameCount)
    {
        this.Stream = stream;
        this.FrameCount = frameCount;
    }
}