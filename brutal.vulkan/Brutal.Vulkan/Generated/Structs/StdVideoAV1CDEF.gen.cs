namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 34)]
    public unsafe partial struct StdVideoAV1CDEF()
    {
        /// <summary>
        ///     <c>CdefDampingMinus_3</c>
        /// </summary>
        [FieldOffset(0)]
        public byte CdefDampingMinus_3;

        /// <summary>
        ///     <c>CdefBits</c>
        /// </summary>
        [FieldOffset(1)]
        public byte CdefBits;

        ///
        [FieldOffset(2)]
        public fixed byte CdefYPriStrength[8];

        ///
        [FieldOffset(10)]
        public fixed byte CdefYSecStrength[8];

        ///
        [FieldOffset(18)]
        public fixed byte CdefUvPriStrength[8];

        ///
        [FieldOffset(26)]
        public fixed byte CdefUvSecStrength[8];
    }
}
