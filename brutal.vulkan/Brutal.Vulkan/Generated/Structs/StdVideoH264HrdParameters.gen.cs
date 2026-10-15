namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 308)]
    public unsafe partial struct StdVideoH264HrdParameters()
    {
        /// <summary>
        ///     <c>CpbCntMinus1</c>
        /// </summary>
        [FieldOffset(0)]
        public byte CpbCntMinus1;

        /// <summary>
        ///     <c>BitRateScale</c>
        /// </summary>
        [FieldOffset(1)]
        public byte BitRateScale;

        /// <summary>
        ///     <c>CpbSizeScale</c>
        /// </summary>
        [FieldOffset(2)]
        public byte CpbSizeScale;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(3)]
        public byte Reserved1;

        ///
        [FieldOffset(4)]
        public fixed int BitRateValueMinus1[32];

        ///
        [FieldOffset(132)]
        public fixed int CpbSizeValueMinus1[32];

        ///
        [FieldOffset(260)]
        public fixed byte CbrFlag[32];

        /// <summary>
        ///     <c>InitialCpbRemovalDelayLengthMinus1</c>
        /// </summary>
        [FieldOffset(292)]
        public int InitialCpbRemovalDelayLengthMinus1;

        /// <summary>
        ///     <c>CpbRemovalDelayLengthMinus1</c>
        /// </summary>
        [FieldOffset(296)]
        public int CpbRemovalDelayLengthMinus1;

        /// <summary>
        ///     <c>DpbOutputDelayLengthMinus1</c>
        /// </summary>
        [FieldOffset(300)]
        public int DpbOutputDelayLengthMinus1;

        /// <summary>
        ///     <c>TimeOffsetLength</c>
        /// </summary>
        [FieldOffset(304)]
        public int TimeOffsetLength;
    }
}
