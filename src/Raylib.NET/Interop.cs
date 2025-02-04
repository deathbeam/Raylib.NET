// This file was generated by Bindgen, do not edit it manually.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: DisableRuntimeMarshalling]

namespace Bindgen.Interop;

[StructLayout(LayoutKind.Sequential)]
public readonly struct NativeBool(sbyte value)
{
    private readonly sbyte _value = value;

    public static implicit operator bool(NativeBool nbool)
    {
        return nbool._value != 0;
    }

    public static implicit operator NativeBool(bool value)
    {
        return new NativeBool((sbyte)(value ? 1 : 0));
    }

    public static implicit operator sbyte(NativeBool nbool)
    {
        return nbool._value;
    }

    public static implicit operator NativeBool(sbyte value)
    {
        return new NativeBool(value);
    }
}