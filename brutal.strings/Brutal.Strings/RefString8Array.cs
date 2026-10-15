using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.Strings;

public ref struct RefString8Array(ElementCount length, ByteSize numBytes) : IDisposable
{
    private readonly SpanOwner<Char8> _owner = SpanOwner<Char8>.Allocate(
        (int)(numBytes + ByteSize.Of<int>(length) + ByteSize.Of<nint>(length))
    );

    public ElementCount Count;
    public ElementCount Length = length;
    public ByteSize NumBytes = numBytes;
    private bool _disposed = false;

    public RefString8Array(ReadOnlySpan<String16> strings)
        : this(strings.Length, GetTotalByteCount(strings))
    {
        var written = 0;

        var bytes = _owner.Span;
        var offsets = bytes[(int)NumBytes..].Cast<Char8, int>();

        for (var i = 0; i < strings.Length; i++)
        {
            // Assert null terminator
            Debug.Assert(written == 0 || bytes[written - 1] == 0);

            offsets[i] = written;

            written += Utf8.GetBytes(strings[i], bytes[written..]);
            bytes[written++] = 0;
        }

        Debug.Assert(written == (int)NumBytes);
    }

    public RefString8Array(ReadOnlySpan<String8> strings)
        : this(strings.Length, GetTotalByteCount(strings))
    {
        var written = 0;

        var bytes = _owner.Span;
        var offsets = bytes[(int)NumBytes..].Cast<Char8, int>();

        for (var i = 0; i < strings.Length; i++)
        {
            // Assert null terminator
            Debug.Assert(written == 0 || bytes[written - 1] == 0);

            offsets[i] = written;
            strings[i].CopyTo(bytes[written..]);
            written += strings[i].Length;
            bytes[written++] = 0;
        }

        Debug.Assert(written == (int)NumBytes);
    }

    public unsafe Char8** CommitFixedRegion(Char8* fixedPointer)
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(RefString8Array));
        Debug.Assert(fixedPointer == Unsafe.AsPointer(ref _owner.Span[0]));

        var bytes = new Span<Char8>(fixedPointer, _owner.Span.Length);
        var offsets = bytes[(int)NumBytes..].Cast<Char8, int>();
        var pointers = offsets[(int)Length..].Cast<int, nint>();

        for (var i = 0; i < Length; i++)
        {
            pointers[i] = (nint)fixedPointer + offsets[i];
        }

        return (Char8**)pointers.AsPointer();
    }

    public void AppendString(ReadOnlySpan<Char8> str)
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(RefString8Array));
        if (Count == Length)
            throw new InvalidOperationException("Array is full");

        _owner.Span[(int)(NumBytes + ByteSize.Of<nint>(Count))] = (Char8)str.Length;
        str.CopyTo(_owner.Span[(int)(NumBytes + ByteSize.Of<nint>(Count) + 1)..]);
        Count++;
    }

    public static ByteSize GetTotalByteCount(ReadOnlySpan<String8> strings)
    {
        var count = 0;
        foreach (var str in strings)
            count += str.Length + 1;
        return (ByteSize)count;
    }

    public static ByteSize GetTotalByteCount(ReadOnlySpan<String16> strings)
    {
        var count = 0;
        foreach (var str in strings)
            count += Utf8.GetByteCount(str) + 1;
        return (ByteSize)count;
    }

    public ref Char8 GetPinnableReference()
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(RefString8Array));
        return ref _owner.Span[0];
    }

    public static implicit operator RefString8Array(ReadOnlySpan<String8> strings) => new(strings);

    public static implicit operator RefString8Array(ReadOnlySpan<String16> strings) => new(strings);

    public static implicit operator RefString8Array(Span<String8> strings) => new(strings);

    public static implicit operator RefString8Array(Span<String16> strings) => new(strings);

    public static implicit operator RefString8Array(String8[] strings) => new(strings);

    public static implicit operator RefString8Array(String16[] strings) => new(strings);

    public void Dispose()
    {
        if (_disposed)
            return;
        _disposed = true;
        _owner.Dispose();
    }
}
