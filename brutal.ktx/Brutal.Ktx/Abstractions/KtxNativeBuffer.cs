namespace Brutal.KtxApi;

/// <summary>
/// Owns a native buffer returned by WriteToMemory/WriteKtx2ToMemory. The buffer is allocated with
/// malloc() inside the native KTX library, so it must be freed with the matching native free() -
/// Dispose() does this for you. Do not free the underlying pointer with any other allocator (e.g.
/// Brutal.Memory.Mem.Free), as that frees memory with a different allocator than the one that
/// allocated it, corrupting the heap.
/// </summary>
public unsafe struct KtxNativeBuffer : IDisposable
{
    private byte* _pointer;

    /// <summary>The size of the buffer in bytes.</summary>
    public ulong Length { get; }

    /// <summary>Raw pointer to the native buffer.</summary>
    public byte* Pointer => _pointer;

    /// <summary>
    /// A read-only view of the buffer. Throws if Length exceeds int.MaxValue, since Span&lt;T&gt;
    /// cannot address more than 2GiB - use Pointer and Length directly for buffers that large.
    /// </summary>
    public ReadOnlySpan<byte> Span => new(_pointer, checked((int)Length));

    internal KtxNativeBuffer(byte* pointer, ulong length)
    {
        _pointer = pointer;
        Length = length;
    }

    public void Dispose()
    {
        if (_pointer is null)
            return;

        KtxNativeMemory.Free(_pointer);
        _pointer = null;
    }
}
