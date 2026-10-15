// The inbound half of the package's UTF-8 boundary plumbing (outbound half: StringUtils.cs).
// Scratch pattern: stackalloc first, SpanOwner spill when too large, `fixed` at the call site.

using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.OpenAlApi;

/// <summary>
///     Transcodes a managed string to NUL-terminated UTF-8 in a caller-provided (typically
///     stack-allocated) buffer, spilling to a pooled buffer when the encoding does not fit -
///     <c>using var utf8 = new Utf8Buffer(s, stackalloc byte[Utf8Buffer.StackBufferSize]);</c>.
///     Never allocates on the GC heap. Call sites pin with <c>fixed (byte* p = utf8.Span)</c>
///     around the native call: a <see langword="null"/> input yields an empty <see cref="Span"/>,
///     which <c>fixed</c> pins as null - OpenAL's NULL default/absence sentinel - while an empty
///     string is a one-byte span holding the NUL, which pins non-null.
/// </summary>
internal ref struct Utf8Buffer
{
    /// <summary>
    ///     The buffer size call sites stackalloc: covers any string of up to 84 chars at the
    ///     3-bytes-per-char worst-case estimate, without the exact-count pass.
    /// </summary>
    public const int StackBufferSize = 0x100;

    private SpanOwner<byte> _owner;
    private readonly ReadOnlySpan<byte> _bytes;

    /// <summary>The encoded bytes INCLUDING the NUL terminator; empty when the input was <see langword="null"/>.</summary>
    public ReadOnlySpan<byte> Span => _bytes;

    /// <summary>The encoded length in bytes, excluding the NUL terminator; 0 when the input was <see langword="null"/>.</summary>
    public int Length => _bytes.IsEmpty ? 0 : _bytes.Length - 1;

    public Utf8Buffer(string? managed, Span<byte> buffer)
    {
        _owner = SpanOwner<byte>.Empty;
        if (managed is null)
            return;

        const int MaxUtf8BytesPerChar = 3;

        // >= for the NUL terminator; the long cast avoids a checked multiply.
        if ((long)MaxUtf8BytesPerChar * managed.Length + 1 >= buffer.Length)
        {
            // The estimate overflows the buffer - only now pay for an exact count.
            var exactByteCount = checked(Encoding.UTF8.GetByteCount(managed) + 1); // + 1 for the NUL
            if (exactByteCount > buffer.Length)
            {
                _owner = SpanOwner<byte>.Allocate(exactByteCount);
                var spillLength = Encoding.UTF8.GetBytes(managed, _owner.Span);
                _owner.Span[spillLength] = 0;
                _bytes = _owner.Span[..(spillLength + 1)];
                return;
            }
        }

        var length = Encoding.UTF8.GetBytes(managed, buffer);
        buffer[length] = 0;
        _bytes = buffer[..(length + 1)];
    }

    /// <summary>Returns the pooled spill buffer, if one was rented.</summary>
    public void Dispose() => _owner.Dispose();
}
