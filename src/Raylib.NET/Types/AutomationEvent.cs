using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct AutomationEvent
{
    /// <summary>
    /// Event frame
    /// </summary>
    public uint Frame;
    /// <summary>
    /// Event type (AutomationEventType)
    /// </summary>
    public uint Type;
    /// <summary>
    /// Event parameters (if required)
    /// </summary>
    public unsafe fixed int Params[4];
}