namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct StdVideoEncodeAV1DecoderModelInfo()
    {
        /// <summary>
        ///     <c>BufferDelayLengthMinus_1</c>
        /// </summary>
        [FieldOffset(0)]
        public byte BufferDelayLengthMinus_1;

        /// <summary>
        ///     <c>BufferRemovalTimeLengthMinus_1</c>
        /// </summary>
        [FieldOffset(1)]
        public byte BufferRemovalTimeLengthMinus_1;

        /// <summary>
        ///     <c>FramePresentationTimeLengthMinus_1</c>
        /// </summary>
        [FieldOffset(2)]
        public byte FramePresentationTimeLengthMinus_1;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(3)]
        public byte Reserved1;

        /// <summary>
        ///     <c>NumUnitsInDecodingTick</c>
        /// </summary>
        [FieldOffset(4)]
        public int NumUnitsInDecodingTick;
    }
}
