namespace Brutal.Enums;

public static class EnumExtensions
{
    /// <summary>
    /// All the methods here are only relevant for [Flags] enums
    /// (except for <see cref="ToMask"/>, which is only relevant for _non_-[Flags] enums).
    ///
    /// Terms:
    /// - A <b>flag</b> represents a single bit.
    /// - A <b>mask</b> represents a combination of bits (compound enum value).
    /// </summary>
    extension<T>(ref T @this)
        where T : unmanaged, Enum
    {
        /// <i>(Mask / bit-field / <c>[Flags]</c> enums only.)</i>
        /// Add (set) the other flag/mask to this mask.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Add(T other)
        {
            @this |= other;
            return @this;
        }

        /// <i>(Mask / bit-field / <c>[Flags]</c> enums only.)</i>
        /// Remove (unset) the other flag/mask from this mask.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Remove(T other)
        {
            @this &= ~other;
            return @this;
        }

        /// <i>(Mask / bit-field / <c>[Flags]</c> enums only.)</i>
        /// Add/remove (set/unset) the other flag/mask to/from this mask.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Set(T other, bool enabled)
        {
            return enabled ? @this.Add(other) : @this.Remove(other);
        }
    }

    extension<T>(T @this)
        where T : unmanaged, Enum
    {
        /// <summary>
        /// <i>(Mask / bit-field / <c>[Flags]</c> enums only.)</i>
        /// Does this mask entirely contain <paramref name="other"/>?
        /// Ie, does this mask contain all the flags in <paramref name="other"/>?
        /// <br/>
        /// Similarly to <see cref="HashSet{T}.IsSupersetOf"/>, this method returns true if the set of bits
        /// represented by <paramref name="other"/> is empty, even if the current mask is empty.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
        public bool ContainsAll(T other)
        {
            return (@this & other) == other; // same as @this.HasFlag(mask);
        }

        /// <i>(Mask / bit-field / <c>[Flags]</c> enums only.)</i>
        /// Does this mask contain any of the bits in <paramref name="other"/>?
        [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
        public bool ContainsAny(T other)
        {
            return (@this & other) != default;
        }

        /// Return an <see cref="EnumMask{T}"/> containing this value.
        [MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
        public EnumMask<T> ToMask() => new(@this);
    }
}
