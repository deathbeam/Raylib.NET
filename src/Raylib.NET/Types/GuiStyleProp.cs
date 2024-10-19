using System.Runtime.InteropServices;
using Bindgen.Interop;
using System.Numerics;

namespace RaylibNET;

[StructLayout(LayoutKind.Sequential)]
public partial struct GuiStyleProp
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

    public GuiStyleProp(ushort controlId, ushort propertyId, int propertyValue)
    {
        this.ControlId = controlId;
        this.PropertyId = propertyId;
        this.PropertyValue = propertyValue;
    }
}