namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 1000)]
    public unsafe partial struct StdVideoH265ScalingLists()
    {
        /// <summary>
        ///     <c>ScalingList4x4</c>
        /// </summary>
        [FieldOffset(0)]
        public byte_16_6 ScalingList4x4;

        /// <summary>
        ///     <c>ScalingList8x8</c>
        /// </summary>
        [FieldOffset(96)]
        public byte_64_6 ScalingList8x8;

        /// <summary>
        ///     <c>ScalingList16x16</c>
        /// </summary>
        [FieldOffset(480)]
        public byte_64_6 ScalingList16x16;

        /// <summary>
        ///     <c>ScalingList32x32</c>
        /// </summary>
        [FieldOffset(864)]
        public byte_64_2 ScalingList32x32;

        ///
        [FieldOffset(992)]
        public fixed byte ScalingListDCCoef16x16[6];

        /// <summary>
        ///     <c>ScalingListDCCoef32x32</c>
        /// </summary>
        [FieldOffset(998)]
        public byte2 ScalingListDCCoef32x32;
    }
}
