#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public unsafe partial struct Orientation
    {
        /// <summary>Orientation in X</summary>
        [FieldOffset(0)]
        public readonly OrientationX X;

        /// <summary>Orientation in Y</summary>
        [FieldOffset(4)]
        public readonly OrientationY Y;

        /// <summary>Orientation in Z</summary>
        [FieldOffset(8)]
        public readonly OrientationZ Z;
    }
}
#pragma warning restore 1591
