using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class Kernel32
    {
        [DllImport(Libraries.Kernel32, EntryPoint = "ReadFile", ExactSpelling = true, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern unsafe bool ReadFile(
             SafeHandle fileHandle,
             byte* buffer,
             int byteCount,
             out int bytesRead,
             IntPtr overlapped
        );
    }
}
