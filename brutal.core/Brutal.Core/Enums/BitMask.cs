using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.Enums;

/// Represents a bit mask, ie a collection of bits that can be set/unset.
[SuppressMessage("ReSharper", "StaticMemberInGenericType")]
public struct BitMask<T> : IEquatable<BitMask<T>>, IBitwiseOperators<BitMask<T>, BitMask<T>, BitMask<T>>
    where T : unmanaged, IBinaryInteger<T>, IUnsignedNumber<T>
{
    public static readonly int BitCount = Unsafe.SizeOf<T>() * 8;

    /// A mask with no bits set.
    public static readonly BitMask<T> Empty = default;

    /// A mask with all the bits set.
    public static readonly BitMask<T> Full = new(T.AllBitsSet);

    T _value;
    public T Value => _value;

    /// Create a mask from a bit mask, ie no shifting.
    public static BitMask<T> FromMask(T mask) => new(mask);

    /// Create a mask from a bit index, ie shifting it.
    public static BitMask<T> FromBit(byte bitIndex) => new(bitIndex);

    /// Create a mask from a value, ie no shifting.
    private BitMask(T mask)
    {
        _value = mask;
    }

    /// Create a mask from a bit index, ie shifting it.
    public BitMask(byte bitIndex)
    {
        _value = T.One << bitIndex;
    }

    /// Create a mask with the given range of bit indices set.
    public BitMask(Range bitRange)
    {
        this[bitRange] = true;
    }

    /// Create a mask with the given bit indices set.
    public BitMask(params ReadOnlySpan<byte> bitIndices)
    {
        foreach (var bitIndex in bitIndices)
            _value |= T.One << bitIndex;
    }

    #region this[index/range] accessors

    /// Get/set the value of a bit by its index.
    public bool this[byte bitIndex]
    {
        get => Contains(bitIndex);
        set => Set(bitIndex, value);
    }

    /// Get/set the value of a bit by its index.
    public bool this[Index bitIndex]
    {
        get => Contains((byte)bitIndex.GetOffset(BitCount));
        set => Set((byte)bitIndex.GetOffset(BitCount), value);
    }

    /// Get/set the value of a range of bits.
    public bool this[Range bitRange]
    {
        get => ContainsAll(new BitMask<T>(bitRange));
        set
        {
            var (offset, length) = bitRange.GetOffsetAndLength(BitCount);
            var start = (byte)offset;
            var end = offset + (byte)length;
            for (var i = start; i < end; i++)
                this[i] = value;
        }
    }

    #endregion

    #region operators

    public static BitMask<T> operator |(BitMask<T> a, BitMask<T> b) => FromMask(a._value | b._value);

    public static BitMask<T> operator &(BitMask<T> a, BitMask<T> b) => FromMask(a._value & b._value);

    public static BitMask<T> operator ^(BitMask<T> a, BitMask<T> b) => FromMask(a._value ^ b._value);

    public static BitMask<T> operator ~(BitMask<T> a) => FromMask(~a._value);

    #endregion

    #region Contains/Add/Remove/Set(bitIndex)

    /// <inheritdoc cref="ContainsAny"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
    public bool Contains(byte bitIndex) => ContainsAny(FromBit(bitIndex));

    /// <inheritdoc cref="Add(BitMask{T})"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public BitMask<T> Add(byte bitIndex) => Add(FromBit(bitIndex));

    /// <inheritdoc cref="Remove(BitMask{T})"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public BitMask<T> Remove(byte bitIndex) => Remove(FromBit(bitIndex));

    /// <inheritdoc cref="Set(BitMask{T}, bool)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public BitMask<T> Set(byte bitIndex, bool enabled) => Set(FromBit(bitIndex), enabled);

    #endregion

    #region Contains/Add/Remove/Set(mask)

    /// <summary>
    /// Does this mask entirely contain <paramref name="other"/>?
    /// Ie, does this mask contain all the bits in <paramref name="other"/>?
    /// <br/>
    /// Similarly to <see cref="HashSet{T}.IsSupersetOf"/>, this method returns true if the set of bits
    /// represented by <paramref name="other"/> is empty, even if the current mask is empty.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
    public bool ContainsAll(BitMask<T> other)
    {
        return (_value & other._value) == other._value;
    }

    /// Does this mask contain any of the bits in <paramref name="other"/>?
    [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
    public bool ContainsAny(BitMask<T> other)
    {
        return (_value & other._value) != T.Zero;
    }

    /// Add (set) the given bits to ours.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public BitMask<T> Add(BitMask<T> other)
    {
        _value |= other._value;
        return this;
    }

    /// Remove (unset) the other bits from ours.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public BitMask<T> Remove(BitMask<T> other)
    {
        _value &= ~other._value;
        return this;
    }

    /// Add/remove (set/unset) the other bits to/from ours.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public BitMask<T> Set(BitMask<T> other, bool enabled) => enabled ? Add(other) : Remove(other);

    #endregion

    /// Is the mask empty? ie no bits set.
    public bool IsEmpty => _value == default;

    /// Is the mask full? ie all bits set.
    public bool IsFull => _value == T.AllBitsSet;

    /// Does the mask have only a single bit set?
    public bool IsPow2 => T.IsPow2(_value);

    /// If the mask has only a single bit set, return its index.
    public bool TryGetBitIndex(out byte index) => BitOperations.TryGetBitIndex(_value, out index);

    /// Return the inverse of this mask, ie all bits flipped.
    public BitMask<T> Inversed => new(~_value);

    #region ToString() - TODO: ISpanFormattable etc

    public static readonly string[] BitNames = ComputeBitNames();

    static string[] ComputeBitNames()
    {
        var names = new string[BitCount];
        for (var i = 0; i < BitCount; i++)
        {
            names[i] = i.ToString();
        }
        return names;
    }

    static readonly ConcurrentDictionary<T, string> ToStringCache = new();

    public override string ToString()
    {
        // try to get string from cache
        if (ToStringCache.TryGetValue(_value, out var s))
        {
            return s;
        }

        if (IsEmpty)
            return "(empty)";
        if (IsFull)
            return "(full)";

        // compute string and cache it
        using var tmpBitNames = SpanOwner<string>.Allocate(BitCount);
        var tmpBitNameCount = 0;
        for (byte i = 0; i < BitCount; i++)
            if (Contains(i))
                tmpBitNames.Span[tmpBitNameCount++] = BitNames[i];
        ToStringCache[_value] = s = $"({string.Join(", ", tmpBitNames.Span[..tmpBitNameCount])})";
        return s;
    }

    #endregion

    #region equality members

    public bool Equals(BitMask<T> other)
    {
        return _value.Equals(other._value);
    }

    public override bool Equals(object? obj)
    {
        return obj is BitMask<T> other && Equals(other);
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    public static bool operator ==(BitMask<T> left, BitMask<T> right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(BitMask<T> left, BitMask<T> right)
    {
        return !left.Equals(right);
    }

    #endregion
}
