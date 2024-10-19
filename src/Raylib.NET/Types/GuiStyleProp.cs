using System.Numerics;
using System.Runtime.InteropServices;
using Bindgen.Interop;

namespace Raylib.NET;

[StructLayout(LayoutKind.Sequential)]
public struct GuiStyleProp
{
    /// <summary>
    /// Control identifier
    /// </summary>
    public ushort ControlId;
    /// <summary>
    /// Property identifier
    /// </summary>
    public ushort PropertyId;
    /// <summary>
    /// Property value
    /// </summary>
    public int PropertyValue;

    public GuiStyleProp(ushort ControlId, ushort PropertyId, int PropertyValue)
    {
        this.ControlId = ControlId;
        this.PropertyId = PropertyId;
        this.PropertyValue = PropertyValue;
    }
}