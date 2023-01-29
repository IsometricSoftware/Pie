using System.Runtime.InteropServices;

namespace Pie.Freetype.Native;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct FT_Generic
{
    public void* Data;
    public delegate*<void*, void> Finalizer;
}