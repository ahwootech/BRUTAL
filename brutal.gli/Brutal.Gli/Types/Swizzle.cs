using System.Runtime.InteropServices;

namespace Brutal.GliApi;

public static partial class Gli
{
    /// <summary>
    ///     Represent the source of a channel
    /// </summary>
    public enum Swizzle
    {
        Red,
        Green,
        Blue,
        Alpha,
        Zero,
        One,
        First = Red,
        ChannelFirst = Red,
        ChannelLast = Alpha,
        Last = One,
    }

    /// <summary>
    ///     Implementation of the Gli swizzles
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Swizzles()
    {
        /// <summary>
        /// The R channel swizzle
        /// </summary>
        public Swizzle R = Swizzle.Red;

        /// <summary>
        /// The G channel swizzle
        /// </summary>
        public Swizzle G = Swizzle.Green;

        /// <summary>
        /// The B channel swizzle
        /// </summary>
        public Swizzle B = Swizzle.Blue;

        /// <summary>
        /// The A channel swizzle
        /// </summary>
        public Swizzle A = Swizzle.Alpha;

        /// <summary>
        ///
        /// </summary>
        public static Swizzles Identity => new Swizzles();
    }
}
