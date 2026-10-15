namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct StdVideoAV1SequenceHeader()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoAV1SequenceHeaderFlags Flags;

        /// <summary>
        ///     <c>SeqProfile</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoAV1Profile SeqProfile;

        /// <summary>
        ///     <c>FrameWidthBitsMinus_1</c>
        /// </summary>
        [FieldOffset(8)]
        public byte FrameWidthBitsMinus_1;

        /// <summary>
        ///     <c>FrameHeightBitsMinus_1</c>
        /// </summary>
        [FieldOffset(9)]
        public byte FrameHeightBitsMinus_1;

        /// <summary>
        ///     <c>MaxFrameWidthMinus_1</c>
        /// </summary>
        [FieldOffset(10)]
        public ushort MaxFrameWidthMinus_1;

        /// <summary>
        ///     <c>MaxFrameHeightMinus_1</c>
        /// </summary>
        [FieldOffset(12)]
        public ushort MaxFrameHeightMinus_1;

        /// <summary>
        ///     <c>DeltaFrameIdLengthMinus_2</c>
        /// </summary>
        [FieldOffset(14)]
        public byte DeltaFrameIdLengthMinus_2;

        /// <summary>
        ///     <c>AdditionalFrameIdLengthMinus_1</c>
        /// </summary>
        [FieldOffset(15)]
        public byte AdditionalFrameIdLengthMinus_1;

        /// <summary>
        ///     <c>OrderHintBitsMinus_1</c>
        /// </summary>
        [FieldOffset(16)]
        public byte OrderHintBitsMinus_1;

        /// <summary>
        ///     <c>SeqForceIntegerMv</c>
        /// </summary>
        [FieldOffset(17)]
        public byte SeqForceIntegerMv;

        /// <summary>
        ///     <c>SeqForceScreenContentTools</c>
        /// </summary>
        [FieldOffset(18)]
        public byte SeqForceScreenContentTools;

        ///
        [FieldOffset(19)]
        public fixed byte Reserved1[5];

        /// <summary>
        ///     <c>ColorConfig</c>
        /// </summary>
        [FieldOffset(24)]
        public StdVideoAV1ColorConfig* ColorConfig;

        /// <summary>
        ///     <c>TimingInfo</c>
        /// </summary>
        [FieldOffset(32)]
        public StdVideoAV1TimingInfo* TimingInfo;
    }
}
