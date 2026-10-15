using System.Runtime.InteropServices;

namespace Brutal.KtxApi;

/// <summary>
/// Binds to the native free() used by the KTX library itself, for releasing buffers it allocated
/// with malloc() (e.g. via WriteToMemory/WriteKtx2ToMemory). See KtxNativeBuffer.
/// </summary>
internal static unsafe partial class KtxNativeMemory
{
    [LibraryImport("Ktx", EntryPoint = "ktx_FreeWriteToMemoryBuffer1")]
    public static partial void Free(void* ptr);
}
