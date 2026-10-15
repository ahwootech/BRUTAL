namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct StdVideoEncodeAV1ReferenceInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeAV1ReferenceInfoFlags Flags;

        /// <summary>
        ///     <c>RefFrameId</c>
        /// </summary>
        [FieldOffset(4)]
        public int RefFrameId;

        /// <summary>
        ///     <c>FrameType</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoAV1FrameType FrameType;

        /// <summary>
        ///     <c>OrderHint</c>
        /// </summary>
        [FieldOffset(12)]
        public byte OrderHint;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(13)]
        public byte3 Reserved1;

        /// <summary>
        ///     <c>ExtensionHeader</c>
        /// </summary>
        [FieldOffset(16)]
        public StdVideoEncodeAV1ExtensionHeader* ExtensionHeader;
    }
}
