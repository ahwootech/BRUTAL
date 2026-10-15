namespace Brutal.Strings;

using ArenaString = ReadOnlySpan<Char8>;

/// <summary>
/// Packs multiple null-terminated strings (aka chunks) into one fixed-capacity <see cref="StringBuilder{TChar}"/>.
/// The buffer never reallocates (Capacity == MaxCapacity), so every span handed out stays valid
/// until the next <see cref="Clear"/>. Being an arena, the suggested lifetime is a frame / tick.
/// Each chunk owns a trailing <c>\0</c> terminator, so beginning or growing one needs room:
/// throws <see cref="ArgumentOutOfRangeException"/> when the arena is full.
/// </summary>
public class ArenaStringBuilder(int capacity)
{
    // Fixed capacity: cannot grow as a realloc would dangle every mid-flight chunk.
    private readonly StringBuilder8 _sb = new(capacity: capacity, maxCapacity: capacity);

    /// <inheritdoc cref="StringBuilder{TChar}.Clear" />
    public void Clear() => _sb.Clear();

    /// Begins a chunk (empty span at the current position).
    public ArenaString Begin()
    {
        // StringBuilder keeps a \0 at Contents.Length: skip 1 to avoid clobbering the previous chunk's null-terminator.
        if (_sb.WrittenSpan.Length > 0)
            _sb.Advance(1);
        var contents = _sb.WrittenSpan;
        return contents[contents.Length..]; // empty span at the current write position
    }

    /// Returns the span from <paramref name="origin"/> to the builder's current write position.
    public void Extend(scoped ref ArenaString origin)
    {
        var contents = _sb.WrittenSpan;
        var start = (int)
            Unsafe.ByteOffset(in MemoryMarshal.GetReference(contents), in MemoryMarshal.GetReference(origin));
        origin = contents[start..];
    }

    /// Appends <paramref name="value"/> to the <paramref name="origin"/> chunk.
    public void Append<T>(ref ArenaString origin, T value, int alignment = 0, String16? format = null)
    {
        _sb.Append(value, alignment, format);
        Extend(ref origin);
    }

    /// <inheritdoc cref="Append{T}"/>
    public void Append(ref ArenaString origin, scoped ReadOnlySpan<Char8> value, int alignment = 0)
    {
        _sb.Append(value, alignment);
        Extend(ref origin);
    }

    /// <inheritdoc cref="Append{T}"/>
    public void Append(ref ArenaString origin, scoped ReadOnlySpan<Char16> value, int alignment = 0)
    {
        _sb.Append(value, alignment);
        Extend(ref origin);
    }

    /// Appends and returns a standalone chunk.
    public ArenaString Append(String8View value)
    {
        var origin = Begin();
        _sb.Append(value);
        Extend(ref origin);
        return origin;
    }

    /// <inheritdoc cref="Append(String8View)"/>
    public ArenaString Append(ReadOnlySpan<Char16> value)
    {
        var origin = Begin();
        _sb.Append(value);
        Extend(ref origin);
        return origin;
    }

    /// Folds a hole's <paramref name="value"/> into the <paramref name="origin"/> chunk.
    public void Absorb(ref ArenaString origin, scoped ArenaString value, int alignment = 0)
    {
        /*
         * The value may have arrived three ways, told apart by where it sits relative to our chunk:
         *  - nested $"...": written straight through our chunk (starts exactly where we end) -> absorb in place;
         *  - inline string/char->ImString conversion: wrote mid-flight, landing at our tail behind its own Begin
         *    separator -> rewind over the stray bytes and re-lay contiguously;
         *  - external (u8 literal, a variable's span): not in the arena -> just copy it in.
         */
        var written = _sb.WrittenSpan;
        ref var baseRef = ref MemoryMarshal.GetReference(written);
        var valueOffset = Unsafe.ByteOffset(in baseRef, in MemoryMarshal.GetReference(value));
        var originEnd = (int)Unsafe.ByteOffset(in baseRef, in MemoryMarshal.GetReference(origin)) + origin.Length;

        // Only trust the offset math if `value` actually lives in our arena buffer (offset within [0, Capacity]).
        if ((nuint)valueOffset <= (nuint)_sb.Capacity)
        {
            var valueStart = (int)valueOffset;
            if (valueStart == originEnd) // nested write-through: already part of our chunk
            {
                if (alignment != 0)
                    AlignFrom(ref origin, value, alignment);
                else
                    Extend(ref origin);
                return;
            }
            if (valueStart + value.Length == written.Length) // inline conversion that wrote at our tail
                _sb.Position = originEnd; // rewind over its stray bytes (Begin separator + content) before re-laying
        }

        // Re-lay (or copy) the value contiguously at the chunk end. When rewound, this is a forward copy with
        // dest (originEnd) < src (valueStart) - memmove-safe even though value aliases the tail.
        Append(ref origin, value, alignment);
    }

    /// <inheritdoc cref="StringBuilder{TChar}.AlignFrom"/>
    public void AlignFrom(ref ArenaString origin, scoped ArenaString nested, int alignment)
    {
        var start = (int)
            Unsafe.ByteOffset(in MemoryMarshal.GetReference(_sb.WrittenSpan), in MemoryMarshal.GetReference(nested));
        _sb.AlignFrom(start, alignment);
        Extend(ref origin);
    }
}
