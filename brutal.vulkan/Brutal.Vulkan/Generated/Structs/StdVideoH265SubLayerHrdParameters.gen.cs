namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 516)]
    public unsafe partial struct StdVideoH265SubLayerHrdParameters()
    {
        ///
        [FieldOffset(0)]
        public fixed int BitRateValueMinus1[32];

        ///
        [FieldOffset(128)]
        public fixed int CpbSizeValueMinus1[32];

        ///
        [FieldOffset(256)]
        public fixed int CpbSizeDuValueMinus1[32];

        ///
        [FieldOffset(384)]
        public fixed int BitRateDuValueMinus1[32];

        /// <summary>
        ///     <c>CbrFlag</c>
        /// </summary>
        [FieldOffset(512)]
        public int CbrFlag;
    }
}
