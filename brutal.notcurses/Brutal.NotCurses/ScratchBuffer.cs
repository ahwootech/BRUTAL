using System.Buffers;
using System.Text;
using Brutal.Strings;

namespace Brutal.NotCursesApi;

/// <summary>
/// UTF-8 encoded scratch buffer for marshalling C# strings across the cgo
/// boundary. Stack-allocated for short strings, pool-rented for long ones.
/// <see cref="Bytes"/> excludes the trailing NUL, which lives at Bytes.Length in the underlying storage.
/// </summary>
internal ref struct ScratchBuffer : IDisposable
{
    public readonly byte[]? Allocation;
    public Span<byte> Bytes;
    public int BytesWritten;

    public ScratchBuffer(string text, Span<byte> stackAlloc)
    {
        // HOT PATH: Try to encode directly into the stack allocation, assuming it will work the first time
        if (Encoding.UTF8.TryGetBytes(text, stackAlloc, out BytesWritten))
        {
            // Handle the edge case where the stack allocation is exactly the right size, but does not have enough
            // room for the null terminator.
            if (BytesWritten == stackAlloc.Length)
            {
                Bytes = Allocation = ArrayPool<byte>.Shared.Rent(BytesWritten + 1);
                stackAlloc.CopyTo(Bytes);
            }
            else
            {
                Bytes = stackAlloc;
            }
        }
        else
        {
            // Fallback to pool allocation if encoding fails
            var maxRequired = Utf8.GetMaxByteCount(text.Length) + 1;
            Bytes = Allocation = ArrayPool<byte>.Shared.Rent(maxRequired);
            BytesWritten = Utf8.GetBytes(text, Bytes);
        }

        // Ensure the buffer is always null-terminated and sliced to the length of the string excluding the terminator.
        Bytes[BytesWritten] = 0;
        Bytes = Bytes[..BytesWritten];
    }

    public void Dispose()
    {
        if (Allocation != null)
            ArrayPool<byte>.Shared.Return(Allocation);
    }
}
