namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct StdVideoDecodeAV1ReferenceInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoDecodeAV1ReferenceInfoFlags Flags;

        /// <summary>
        ///     <c>FrameType</c>
        /// </summary>
        [FieldOffset(4)]
        public byte FrameType;

        /// <summary>
        ///     <c>RefFrameSignBias</c>
        /// </summary>
        [FieldOffset(5)]
        public byte RefFrameSignBias;

        /// <summary>
        ///     <c>OrderHint</c>
        /// </summary>
        [FieldOffset(6)]
        public byte OrderHint;

        ///
        [FieldOffset(7)]
        public fixed byte SavedOrderHints[8];
    }
}
