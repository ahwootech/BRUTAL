using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.Enums;

/// Represents a mask for a regular enum, ie turns a non-[Flags] enum into a [Flags] enum.
[SuppressMessage("ReSharper", "StaticMemberInGenericType")]
public struct EnumMask<T> : IEquatable<EnumMask<T>>, IBitwiseOperators<EnumMask<T>, EnumMask<T>, EnumMask<T>>
    where T : unmanaged, Enum
{
    public static readonly int BitCount = Unsafe.SizeOf<T>() * 8;

    /// A mask with no flags set.
    public static readonly EnumMask<T> Empty = default;

    /// A mask with all the bits set.
    public static readonly EnumMask<T> Full = FromMask(~default(T));

    /// A mask with all the known flags set.
    public static readonly EnumMask<T> KnownFlags;

    static EnumMask()
    {
        if (Enum<T>.IsBitMask)
            throw new NotSupportedException($"{typeof(T)} is already a [Flags] enum!");

        if (Enum<T>.MinValue < default(T))
            throw new NotSupportedException(
                $"{typeof(T)}: unsupported enum member range, value {Enum<T>.MinValue} ({Enum<T>.MinValue:d}) is negative, only positive values are supported."
            );
        if (Enum<T>.MaxValue >= Enum<T>.CreateTruncating(BitCount))
            throw new NotSupportedException(
                $"{typeof(T)}: unsupported enum member range, value {Enum<T>.MaxValue} ({Enum<T>.MaxValue:d}) is bigger than the underlying size ({BitCount})."
            );

        // do these last in case T is non-compliant
        KnownFlags = new(Enum<T>.Values);
        BitNames = ComputeBitNames();
    }

    T _value;

    /// Create a mask from a bit mask, ie no shifting.
    public static EnumMask<T> FromMask(T mask)
    {
        EnumMask<T> result;
        result._value = mask;
        return result;
    }

    /// Create a mask from a flag, ie shifting it.
    public static EnumMask<T> FromFlag(T flag) => new(flag);

    /// Create a mask from a flag, ie shifting it.
    public EnumMask(T flag)
    {
        _value = flag.ShiftLeft(); // 1 << flag
    }

    /// Create a mask with the given flags set.
    public EnumMask(params ReadOnlySpan<T> flags)
    {
        foreach (var flag in flags)
            _value |= flag.ShiftLeft(); // 1 << flag
    }

    public static implicit operator EnumMask<T>(T flag) => new(flag);

    #region this[flag/mask] accessors

    /// Get/set the value of a flag.
    public bool this[T flag]
    {
        get => Contains(flag);
        set => Set(flag, value);
    }

    /// Get/set the value of a mask.
    public bool this[EnumMask<T> mask]
    {
        get => ContainsAll(mask);
        set => Set(mask, value);
    }

    #endregion

    #region operators

    public static EnumMask<T> operator |(EnumMask<T> a, EnumMask<T> b) => FromMask(a._value | b._value);

    public static EnumMask<T> operator &(EnumMask<T> a, EnumMask<T> b) => FromMask(a._value & b._value);

    public static EnumMask<T> operator ^(EnumMask<T> a, EnumMask<T> b) => FromMask(a._value ^ b._value);

    public static EnumMask<T> operator ~(EnumMask<T> a) => FromMask(~a._value);

    #endregion

    #region Contains/Add/Remove/Set(flag)

    /// <inheritdoc cref="EnumExtensions.ContainsAny{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
    public bool Contains(T flag) => _value.ContainsAny(flag.ShiftLeft());

    /// <inheritdoc cref="EnumExtensions.Add{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public EnumMask<T> Add(T flag)
    {
        _value.Add(flag.ShiftLeft());
        return this;
    }

    /// <inheritdoc cref="EnumExtensions.Remove{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public EnumMask<T> Remove(T flag)
    {
        _value.Remove(flag.ShiftLeft());
        return this;
    }

    /// <inheritdoc cref="EnumExtensions.Set{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public EnumMask<T> Set(T flag, bool enabled) => enabled ? Add(flag) : Remove(flag);

    #endregion

    #region Contains/Add/Remove/Set(mask)

    /// <inheritdoc cref="EnumExtensions.ContainsAll{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
    public bool ContainsAll(EnumMask<T> mask) => _value.ContainsAll(mask._value);

    /// <inheritdoc cref="EnumExtensions.ContainsAll{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
    public bool ContainsAny(EnumMask<T> mask) => _value.ContainsAny(mask._value);

    /// <inheritdoc cref="EnumExtensions.Add{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public EnumMask<T> Add(EnumMask<T> mask)
    {
        _value.Add(mask._value);
        return this;
    }

    /// <inheritdoc cref="EnumExtensions.Remove{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public EnumMask<T> Remove(EnumMask<T> mask)
    {
        _value.Remove(mask._value);
        return this;
    }

    /// <inheritdoc cref="EnumExtensions.Set{T}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public EnumMask<T> Set(EnumMask<T> mask, bool enabled) => enabled ? Add(mask) : Remove(mask);

    #endregion

    /// Is the mask empty? ie no bits set.
    public bool IsEmpty => _value == default;

    /// Is the mask full? ie all bits set.
    public bool IsFull => _value == ~default(T);

    /// Does the mask have only a single bit set?
    public bool IsPow2 => _value.IsPow2;

    /// If the mask has only a single bit set, return it (ie its index).
    public bool TryGetSingleFlag(out T flag)
    {
        var result = _value.TryGetBitIndex(out var index);
        flag = Enum<T>.CreateTruncating(index);
        return result;
    }

    /// Return the inverse of this mask, ie all bits flipped.
    public EnumMask<T> Inversed => FromMask(~_value);

    #region ToString() - TODO: ISpanFormattable etc

    public static readonly string[] BitNames;

    static string[] ComputeBitNames()
    {
        var names = new string?[BitCount];

        // set names for known bits
        foreach (var (value, name) in Enum<T>.Pairs)
        {
            names[value.ToIntTruncating()] = name;
        }

        // unknown bits = integer value
        for (var i = 0; i < BitCount; i++)
        {
            names[i] ??= i.ToString();
        }

        return names!;
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
        for (var i = 0; i < BitCount; i++)
            if (Contains(Enum<T>.CreateTruncating(i)))
                tmpBitNames.Span[tmpBitNameCount++] = BitNames[i];
        ToStringCache[_value] = s = string.Join(", ", tmpBitNames.Span[..tmpBitNameCount]);
        return s;
    }

    #endregion

    #region equality members

    public bool Equals(EnumMask<T> other)
    {
        return _value == other._value; // don't use Equals() as it boxes
    }

    public override bool Equals(object? obj)
    {
        return obj is EnumMask<T> other && Equals(other);
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    public static bool operator ==(EnumMask<T> left, EnumMask<T> right)
    {
        return left._value == right._value;
    }

    public static bool operator !=(EnumMask<T> left, EnumMask<T> right)
    {
        return left._value != right._value;
    }

    #endregion
}
