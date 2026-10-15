using System.Runtime.InteropServices;

namespace Brutal.FmodApi;

public partial struct FileAsyncDoneFuncPtr
{
    public unsafe void Invoke(AsyncReadInfo* info, Result result)
    {
        if (_ptr == IntPtr.Zero)
            return;

        var func = Marshal.GetDelegateForFunctionPointer<FileAsyncDoneFunc>(_ptr);
        func(info, result);
    }
}
