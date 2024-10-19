using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace Raylib.NET;

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

    public Sound(AudioStream Stream, uint FrameCount)
    {
        this.Stream = Stream;
        this.FrameCount = FrameCount;
    }
}