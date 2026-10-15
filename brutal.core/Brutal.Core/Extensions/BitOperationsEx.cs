namespace System.Numerics;

public static class BitOperationsEx
{
    extension(BitOperations)
    {
        /// <summary>
        /// If <paramref name="mask"/> has only a single bit set, output its <paramref name="index"/>, otherwise return false.
        /// </summary>
        /// <param name="mask">A bit-mask value that potentially only contains a single bit.</param>
        /// <param name="index">The index of the single bit, if true.</param>
        /// <returns>Whether <paramref name="mask"/> contains a single bit.</returns>
        public static bool TryGetBitIndex<T>(T mask, out byte index)
            where T : unmanaged, IBinaryInteger<T>
        {
            if (!T.IsPow2(mask))
            {
                index = 0;
                return false;
            }

            var tzc = T.TrailingZeroCount(mask);
            index = byte.CreateTruncating(tzc);
            return true;
        }
    }
}
