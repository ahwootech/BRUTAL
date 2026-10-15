using System.Runtime.InteropServices;

namespace Brutal.OpenGlApi;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate nint GlGetProcAddressFunc(byte* program);
