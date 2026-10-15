#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate KtxErrorCode IterateCallbackDelegate(
        int miplevel,
        int face,
        int width,
        int height,
        int depth,
        ulong faceLodSize,
        IntPtr pixels,
        IntPtr userdata
    );
}
#pragma warning restore 1591
