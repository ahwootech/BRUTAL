// At the project root deliberately: a net11 polyfill (see below) wants to be visible, and it is
// NOT carrier substrate - it survived the Simd/ pause because the matrix register kernels ride it.
namespace Brutal.Numerics;

/* The two-source shuffle, as the BCL would spell it if net10 had one.
 *
 * `Sse.Shuffle(a, b, imm)` takes two lanes from each operand; the portable surface has no
 * equivalent, and the ZipLower/ZipUpper pair that would cover the common cases arrives in net11
 * (verified absent from net10 by the vehicle-surface probe). Until then every caller pays
 * permute + permute + blend, and the only question is whether they each spell it themselves.
 *
 * This is deliberately shaped as a static extension so it reads `Vector128.Shuffle2(...)`, i.e.
 * exactly like the member whose absence it is covering - which is also the signal for what to do
 * on the net11 bump: delete this file and let the calls bind to the real thing.
 *
 * Two concrete overloads rather than a generic one: the shuffle index operand is the lane-sized
 * integer twin (int for float, long for double), so a generic body would have to re-derive the
 * twin per T - the same typed-index problem the carrier's Shuffle already carries. The matrix
 * kernels only ever need these two row shapes. */
internal static class VectorShuffle2
{
    extension(Vector128)
    {
        /// <summary>Two-source shuffle: (a[a0], a[a1], b[b2], b[b3]). Constant indices fold both permutes and the blend.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> Shuffle2(Vector128<float> a, Vector128<float> b, int a0, int a1, int b2, int b3)
        {
            return Vector128.ConditionalSelect(
                Vector128.Create(0, 0, -1, -1).AsSingle(),
                Vector128.ShuffleNative(b, Vector128.Create(b2, b3, b2, b3)),
                Vector128.ShuffleNative(a, Vector128.Create(a0, a1, a0, a1))
            );
        }
    }

    extension(Vector256)
    {
        /// <inheritdoc cref="Shuffle2(Vector128{float}, Vector128{float}, int, int, int, int)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Shuffle2(
            Vector256<double> a,
            Vector256<double> b,
            int a0,
            int a1,
            int b2,
            int b3
        )
        {
            return Vector256.ConditionalSelect(
                Vector256.Create(0L, 0L, -1L, -1L).AsDouble(),
                Vector256.ShuffleNative(b, Vector256.Create((long)b2, b3, b2, b3)),
                Vector256.ShuffleNative(a, Vector256.Create((long)a0, a1, a0, a1))
            );
        }
    }
}
