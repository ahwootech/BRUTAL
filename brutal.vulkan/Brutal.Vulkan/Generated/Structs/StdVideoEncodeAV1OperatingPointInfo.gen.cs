namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct StdVideoEncodeAV1OperatingPointInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeAV1OperatingPointInfoFlags Flags;

        /// <summary>
        ///     <c>OperatingPointIdc</c>
        /// </summary>
        [FieldOffset(4)]
        public ushort OperatingPointIdc;

        /// <summary>
        ///     <c>SeqLevelIdx</c>
        /// </summary>
        [FieldOffset(6)]
        public byte SeqLevelIdx;

        /// <summary>
        ///     <c>SeqTier</c>
        /// </summary>
        [FieldOffset(7)]
        public byte SeqTier;

        /// <summary>
        ///     <c>DecoderBufferDelay</c>
        /// </summary>
        [FieldOffset(8)]
        public int DecoderBufferDelay;

        /// <summary>
        ///     <c>EncoderBufferDelay</c>
        /// </summary>
        [FieldOffset(12)]
        public int EncoderBufferDelay;

        /// <summary>
        ///     <c>InitialDisplayDelayMinus_1</c>
        /// </summary>
        [FieldOffset(16)]
        public byte InitialDisplayDelayMinus_1;
    }
}
