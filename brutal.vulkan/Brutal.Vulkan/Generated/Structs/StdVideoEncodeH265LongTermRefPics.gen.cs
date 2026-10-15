namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 148)]
    public unsafe partial struct StdVideoEncodeH265LongTermRefPics()
    {
        /// <summary>
        ///     <c>NumLongTermSps</c>
        /// </summary>
        [FieldOffset(0)]
        public byte NumLongTermSps;

        /// <summary>
        ///     <c>NumLongTermPics</c>
        /// </summary>
        [FieldOffset(1)]
        public byte NumLongTermPics;

        ///
        [FieldOffset(2)]
        public fixed byte LtIdxSps[32];

        ///
        [FieldOffset(34)]
        public fixed byte PocLsbLt[16];

        /// <summary>
        ///     <c>UsedByCurrPicLtFlag</c>
        /// </summary>
        [FieldOffset(50)]
        public ushort UsedByCurrPicLtFlag;

        ///
        [FieldOffset(52)]
        public fixed byte DeltaPocMsbPresentFlag[48];

        ///
        [FieldOffset(100)]
        public fixed byte DeltaPocMsbCycleLt[48];
    }
}
