namespace Bindgen;

public class Interop
{
    public static string Generate()
    {
        return $$"""
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

            [StructLayout(LayoutKind.Sequential)]
            public unsafe struct NativeString(sbyte* value) : IDisposable
            {
                private sbyte* _value = value;

                #pragma warning disable CS8603 // Possible null reference return
                public static implicit operator string(NativeString nstring)
                {
                    return Marshal.PtrToStringAnsi((IntPtr)nstring._value);
                }
                #pragma warning restore CS8603 // Possible null reference return

                public static implicit operator NativeString(string value)
                {
                    return new NativeString((sbyte*)Marshal.StringToHGlobalAnsi(value));
                }

                public static implicit operator sbyte*(NativeString nstring)
                {
                    return nstring._value;
                }

                public static implicit operator NativeString(sbyte* value)
                {
                    return new NativeString(value);
                }

                public void Dispose()
                {
                    if (_value != null)
                    {
                        Marshal.FreeHGlobal((IntPtr)_value);
                        _value = null;
                    }
                }
            }
        """;
    }
}
