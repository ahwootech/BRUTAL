using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Brutal.Enums;

/// Provides information about a given Enum type.
[SuppressMessage("ReSharper", "StaticMemberInGenericType")]
public static class Enum<T>
    where T : unmanaged, Enum
{
    public static readonly int BitCount = Unsafe.SizeOf<T>() * 8;
    public static readonly Type UnderlyingType = typeof(T).GetEnumUnderlyingType();

    public static readonly T[] Values = (T[])Enum.GetValues(typeof(T));
    public static readonly string[] Names = Enum.GetNames(typeof(T));
    public static readonly int Count = Values.Length;
    public static readonly T MinValue,
        MaxValue;

    public static readonly (T value, string name)[] Pairs = new (T value, string name)[Count];

    static Enum()
    {
        for (var i = 0; i < Count; i++)
        {
            Pairs[i] = (Values[i], Names[i]);
        }

        if (Count > 0)
        {
            // values are already sorted
            MinValue = Values[0];
            MaxValue = Values[^1];
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
    public static T CreateTruncating(int value) => EnumOperators.CreateTruncating<T>(value);

    #region specific to mask / bit-field / [Flags] enums

    /// Does this enum represent a bit-field? aka [Flags] enum.
    public static readonly bool IsBitMask = typeof(T).GetCustomAttribute<FlagsAttribute>() != null;

    /// For a bit-field enum, this a mask with all the enum's available flags/bits set.
    /// Otherwise, 0 for non-bit-field enums.
    public static readonly T KnownFlagsMask = ComputeKnownFlagsMask();

    static T ComputeKnownFlagsMask()
    {
        if (!IsBitMask)
            return default;

        var all = default(T);
        foreach (var flag in Values)
            all |= flag;
        return all;
    }

    #region single-bit values / compound values

    /// For a bit-field enum, the list of available single-bit values (compound/multi-bit values are excluded).
    /// Otherwise, empty for non-bit-field enums.
    public static readonly T[] BitValues = ComputeBitValues(true);

    /// For a bit-field enum, the list of available compound/multi-bit values.
    /// Otherwise, empty for non-bit-field enums.
    public static readonly T[] CompoundValues = ComputeBitValues(false);

    static T[] ComputeBitValues(bool bitOrCompound)
    {
        if (!IsBitMask)
            return [];

        Span<T> bits = stackalloc T[Count];
        var bitCount = 0;

        for (var i = 0; i < Count; i++)
        {
            var v = Values[i];
            if (v.IsPow2 == bitOrCompound)
            {
                bits[bitCount++] = v;
            }
        }

        return bitCount > 0 ? bits[..bitCount].ToArray() : [];
    }

    #endregion

    #endregion
}
