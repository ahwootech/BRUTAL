namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct StdVideoH265HrdParameters()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH265HrdFlags Flags;

        /// <summary>
        ///     <c>TickDivisorMinus2</c>
        /// </summary>
        [FieldOffset(4)]
        public byte TickDivisorMinus2;

        /// <summary>
        ///     <c>DuCpbRemovalDelayIncrementLengthMinus1</c>
        /// </summary>
        [FieldOffset(5)]
        public byte DuCpbRemovalDelayIncrementLengthMinus1;

        /// <summary>
        ///     <c>DpbOutputDelayDuLengthMinus1</c>
        /// </summary>
        [FieldOffset(6)]
        public byte DpbOutputDelayDuLengthMinus1;

        /// <summary>
        ///     <c>BitRateScale</c>
        /// </summary>
        [FieldOffset(7)]
        public byte BitRateScale;

        /// <summary>
        ///     <c>CpbSizeScale</c>
        /// </summary>
        [FieldOffset(8)]
        public byte CpbSizeScale;

        /// <summary>
        ///     <c>CpbSizeDuScale</c>
        /// </summary>
        [FieldOffset(9)]
        public byte CpbSizeDuScale;

        /// <summary>
        ///     <c>InitialCpbRemovalDelayLengthMinus1</c>
        /// </summary>
        [FieldOffset(10)]
        public byte InitialCpbRemovalDelayLengthMinus1;

        /// <summary>
        ///     <c>AuCpbRemovalDelayLengthMinus1</c>
        /// </summary>
        [FieldOffset(11)]
        public byte AuCpbRemovalDelayLengthMinus1;

        /// <summary>
        ///     <c>DpbOutputDelayLengthMinus1</c>
        /// </summary>
        [FieldOffset(12)]
        public byte DpbOutputDelayLengthMinus1;

        ///
        [FieldOffset(13)]
        public fixed byte CpbCntMinus1[7];

        ///
        [FieldOffset(20)]
        public fixed ushort ElementalDurationInTcMinus1[7];

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(34)]
        public ushort3 Reserved;

        /// <summary>
        ///     <c>SubLayerHrdParametersNal</c>
        /// </summary>
        [FieldOffset(40)]
        public StdVideoH265SubLayerHrdParameters* SubLayerHrdParametersNal;

        /// <summary>
        ///     <c>SubLayerHrdParametersVcl</c>
        /// </summary>
        [FieldOffset(48)]
        public StdVideoH265SubLayerHrdParameters* SubLayerHrdParametersVcl;
    }
}
