using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct Wave
{
    /// <summary>
    /// Total number of frames (considering channels)
    /// </summary>
    public uint FrameCount;
    /// <summary>
    /// Frequency (samples per second)
    /// </summary>
    public uint SampleRate;
    /// <summary>
    /// Bit depth (bits per sample): 8, 16, 32 (24 not supported)
    /// </summary>
    public uint SampleSize;
    /// <summary>
    /// Number of channels (1-mono, 2-stereo, ...)
    /// </summary>
    public uint Channels;
    /// <summary>
    /// Buffer data pointer
    /// </summary>
    public unsafe void* Data;

    public unsafe Wave(uint FrameCount, uint SampleRate, uint SampleSize, uint Channels, void* Data)
    {
        this.FrameCount = FrameCount;
        this.SampleRate = SampleRate;
        this.SampleSize = SampleSize;
        this.Channels = Channels;
        this.Data = Data;
    }
}