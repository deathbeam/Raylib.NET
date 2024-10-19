using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct AutomationEvent
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