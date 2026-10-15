namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct StdVideoH265ShortTermRefPicSet()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH265ShortTermRefPicSetFlags Flags;

        /// <summary>
        ///     <c>DeltaIdxMinus1</c>
        /// </summary>
        [FieldOffset(4)]
        public int DeltaIdxMinus1;

        /// <summary>
        ///     <c>UseDeltaFlag</c>
        /// </summary>
        [FieldOffset(8)]
        public ushort UseDeltaFlag;

        /// <summary>
        ///     <c>AbsDeltaRpsMinus1</c>
        /// </summary>
        [FieldOffset(10)]
        public ushort AbsDeltaRpsMinus1;

        /// <summary>
        ///     <c>UsedByCurrPicFlag</c>
        /// </summary>
        [FieldOffset(12)]
        public ushort UsedByCurrPicFlag;

        /// <summary>
        ///     <c>UsedByCurrPicS0Flag</c>
        /// </summary>
        [FieldOffset(14)]
        public ushort UsedByCurrPicS0Flag;

        /// <summary>
        ///     <c>UsedByCurrPicS1Flag</c>
        /// </summary>
        [FieldOffset(16)]
        public ushort UsedByCurrPicS1Flag;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(18)]
        public ushort Reserved1;

        /// <summary>
        ///     <c>Reserved2</c>
        /// </summary>
        [FieldOffset(20)]
        public byte Reserved2;

        /// <summary>
        ///     <c>Reserved3</c>
        /// </summary>
        [FieldOffset(21)]
        public byte Reserved3;

        /// <summary>
        ///     <c>NumNegativePics</c>
        /// </summary>
        [FieldOffset(22)]
        public byte NumNegativePics;

        /// <summary>
        ///     <c>NumPositivePics</c>
        /// </summary>
        [FieldOffset(23)]
        public byte NumPositivePics;

        ///
        [FieldOffset(24)]
        public fixed ushort DeltaPocS0Minus1[16];

        ///
        [FieldOffset(56)]
        public fixed ushort DeltaPocS1Minus1[16];
    }
}
