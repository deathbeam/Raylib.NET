using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct AutomationEventList
{
    /// <summary>
    /// Events max entries (MAX_AUTOMATION_EVENTS)
    /// </summary>
    public uint Capacity;
    /// <summary>
    /// Events entries count
    /// </summary>
    public uint Count;
    /// <summary>
    /// Events entries
    /// </summary>
    public unsafe AutomationEvent* Events;

    public unsafe AutomationEventList(uint Capacity, uint Count, AutomationEvent* Events)
    {
        this.Capacity = Capacity;
        this.Count = Count;
        this.Events = Events;
    }
}