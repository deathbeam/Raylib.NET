using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public partial struct AudioStream
{
    /// <summary>
    /// Pointer to internal data used by the audio system
    /// </summary>
    public unsafe rAudioBuffer* Buffer;
    /// <summary>
    /// Pointer to internal data processor, useful for audio effects
    /// </summary>
    public unsafe rAudioProcessor* Processor;
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

    public unsafe AudioStream(rAudioBuffer* Buffer, rAudioProcessor* Processor, uint SampleRate, uint SampleSize, uint Channels)
    {
        this.Buffer = Buffer;
        this.Processor = Processor;
        this.SampleRate = SampleRate;
        this.SampleSize = SampleSize;
        this.Channels = Channels;
    }
}