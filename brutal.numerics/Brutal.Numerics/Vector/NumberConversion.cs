namespace Brutal.Numerics;

/* One shared body for the vectors' INumberBase TryConvertFrom* protocol - the per-type explicit
 * implementations are one-line forwards into TryConvertFrom, with the overflow policy carried as
 * a generic marker struct. Deduplicated for assembly size: the typeof dispatch below exists once
 * instead of once per vector type x policy (it was ~27% of the library's IL as generated code),
 * and still JIT-folds to the single live branch per instantiation - the BCL's own pattern.
 *
 * Semantics (also documented in Vector.numerics.tt): scalars embed along One - a broadcast; a
 * sibling vector converts per lane when the arities match (the lane-count check inside FromLanes
 * rejects a cross-arity pair). Quaternions embed scalars on the real axis instead, so they keep
 * their own generated protocol. */
internal static class NumberConversion
{
    /// <summary>The overflow policy of one TryConvertFrom flavor, as a JIT-foldable marker struct.</summary>
    internal interface IPolicy
    {
        static abstract TComponent Convert<TComponent, TOther>(TOther value)
            where TComponent : INumberBase<TComponent>
            where TOther : INumberBase<TOther>;
    }

    internal readonly struct Checked : IPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TComponent Convert<TComponent, TOther>(TOther value)
            where TComponent : INumberBase<TComponent>
            where TOther : INumberBase<TOther>
        {
            return TComponent.CreateChecked(value);
        }
    }

    internal readonly struct Saturating : IPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TComponent Convert<TComponent, TOther>(TOther value)
            where TComponent : INumberBase<TComponent>
            where TOther : INumberBase<TOther>
        {
            return TComponent.CreateSaturating(value);
        }
    }

    internal readonly struct Truncating : IPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TComponent Convert<TComponent, TOther>(TOther value)
            where TComponent : INumberBase<TComponent>
            where TOther : INumberBase<TOther>
        {
            return TComponent.CreateTruncating(value);
        }
    }

    // the supported-set dispatch: self, then the 8 scalar component types, then every non-bool
    // vector type (cross-arity pairs fall out via the lane-count check)
    internal static bool TryConvertFrom<TVector, TComponent, TOther, TPolicy>(TOther value, out TVector result)
        where TVector : unmanaged, IVector<TVector, TComponent>
        where TComponent : unmanaged, INumberBase<TComponent>
        where TOther : INumberBase<TOther>
        where TPolicy : IPolicy
    {
        if (typeof(TOther) == typeof(TVector))
        {
            result = (TVector)(object)value!;
            return true;
        }

        if (typeof(TOther) == typeof(sbyte))
            return Broadcast<TVector, TComponent, sbyte, TPolicy>((sbyte)(object)value!, out result);
        if (typeof(TOther) == typeof(byte))
            return Broadcast<TVector, TComponent, byte, TPolicy>((byte)(object)value!, out result);
        if (typeof(TOther) == typeof(short))
            return Broadcast<TVector, TComponent, short, TPolicy>((short)(object)value!, out result);
        if (typeof(TOther) == typeof(ushort))
            return Broadcast<TVector, TComponent, ushort, TPolicy>((ushort)(object)value!, out result);
        if (typeof(TOther) == typeof(int))
            return Broadcast<TVector, TComponent, int, TPolicy>((int)(object)value!, out result);
        if (typeof(TOther) == typeof(uint))
            return Broadcast<TVector, TComponent, uint, TPolicy>((uint)(object)value!, out result);
        if (typeof(TOther) == typeof(long))
            return Broadcast<TVector, TComponent, long, TPolicy>((long)(object)value!, out result);
        if (typeof(TOther) == typeof(ulong))
            return Broadcast<TVector, TComponent, ulong, TPolicy>((ulong)(object)value!, out result);
        if (typeof(TOther) == typeof(float))
            return Broadcast<TVector, TComponent, float, TPolicy>((float)(object)value!, out result);
        if (typeof(TOther) == typeof(double))
            return Broadcast<TVector, TComponent, double, TPolicy>((double)(object)value!, out result);

        if (typeof(TOther) == typeof(sbyte2))
        {
            var other = (sbyte2)(object)value!;
            return FromLanes<TVector, TComponent, sbyte, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(sbyte3))
        {
            var other = (sbyte3)(object)value!;
            return FromLanes<TVector, TComponent, sbyte, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(sbyte4))
        {
            var other = (sbyte4)(object)value!;
            return FromLanes<TVector, TComponent, sbyte, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(byte2))
        {
            var other = (byte2)(object)value!;
            return FromLanes<TVector, TComponent, byte, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(byte3))
        {
            var other = (byte3)(object)value!;
            return FromLanes<TVector, TComponent, byte, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(byte4))
        {
            var other = (byte4)(object)value!;
            return FromLanes<TVector, TComponent, byte, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(short2))
        {
            var other = (short2)(object)value!;
            return FromLanes<TVector, TComponent, short, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(short3))
        {
            var other = (short3)(object)value!;
            return FromLanes<TVector, TComponent, short, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(short4))
        {
            var other = (short4)(object)value!;
            return FromLanes<TVector, TComponent, short, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(ushort2))
        {
            var other = (ushort2)(object)value!;
            return FromLanes<TVector, TComponent, ushort, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(ushort3))
        {
            var other = (ushort3)(object)value!;
            return FromLanes<TVector, TComponent, ushort, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(ushort4))
        {
            var other = (ushort4)(object)value!;
            return FromLanes<TVector, TComponent, ushort, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(int2))
        {
            var other = (int2)(object)value!;
            return FromLanes<TVector, TComponent, int, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(int3))
        {
            var other = (int3)(object)value!;
            return FromLanes<TVector, TComponent, int, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(int4))
        {
            var other = (int4)(object)value!;
            return FromLanes<TVector, TComponent, int, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(uint2))
        {
            var other = (uint2)(object)value!;
            return FromLanes<TVector, TComponent, uint, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(uint3))
        {
            var other = (uint3)(object)value!;
            return FromLanes<TVector, TComponent, uint, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(uint4))
        {
            var other = (uint4)(object)value!;
            return FromLanes<TVector, TComponent, uint, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(long2))
        {
            var other = (long2)(object)value!;
            return FromLanes<TVector, TComponent, long, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(long3))
        {
            var other = (long3)(object)value!;
            return FromLanes<TVector, TComponent, long, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(long4))
        {
            var other = (long4)(object)value!;
            return FromLanes<TVector, TComponent, long, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(ulong2))
        {
            var other = (ulong2)(object)value!;
            return FromLanes<TVector, TComponent, ulong, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(ulong3))
        {
            var other = (ulong3)(object)value!;
            return FromLanes<TVector, TComponent, ulong, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(ulong4))
        {
            var other = (ulong4)(object)value!;
            return FromLanes<TVector, TComponent, ulong, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(float2))
        {
            var other = (float2)(object)value!;
            return FromLanes<TVector, TComponent, float, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(float3))
        {
            var other = (float3)(object)value!;
            return FromLanes<TVector, TComponent, float, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(float4))
        {
            var other = (float4)(object)value!;
            return FromLanes<TVector, TComponent, float, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(double2))
        {
            var other = (double2)(object)value!;
            return FromLanes<TVector, TComponent, double, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(double3))
        {
            var other = (double3)(object)value!;
            return FromLanes<TVector, TComponent, double, TPolicy>(other.AsSpan(), out result);
        }
        if (typeof(TOther) == typeof(double4))
        {
            var other = (double4)(object)value!;
            return FromLanes<TVector, TComponent, double, TPolicy>(other.AsSpan(), out result);
        }

        result = default;
        return false;
    }

    private static bool Broadcast<TVector, TComponent, TSource, TPolicy>(TSource value, out TVector result)
        where TVector : unmanaged, IVector<TVector, TComponent>
        where TComponent : unmanaged, INumberBase<TComponent>
        where TSource : INumberBase<TSource>
        where TPolicy : IPolicy
    {
        var converted = TPolicy.Convert<TComponent, TSource>(value);
        Span<TComponent> lanes = stackalloc TComponent[TVector.ComponentCount];
        lanes.Fill(converted);
        result = TVector.Create(lanes);
        return true;
    }

    private static bool FromLanes<TVector, TComponent, TSource, TPolicy>(
        ReadOnlySpan<TSource> source,
        out TVector result
    )
        where TVector : unmanaged, IVector<TVector, TComponent>
        where TComponent : unmanaged, INumberBase<TComponent>
        where TSource : INumberBase<TSource>
        where TPolicy : IPolicy
    {
        if (source.Length != TVector.ComponentCount)
        {
            result = default;
            return false;
        }
        Span<TComponent> lanes = stackalloc TComponent[source.Length];
        for (var i = 0; i < source.Length; i++)
            lanes[i] = TPolicy.Convert<TComponent, TSource>(source[i]);
        result = TVector.Create(lanes);
        return true;
    }
}
