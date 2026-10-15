namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct StdVideoDecodeVP9PictureInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoDecodeVP9PictureInfoFlags Flags;

        /// <summary>
        ///     <c>Profile</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoVP9Profile Profile;

        /// <summary>
        ///     <c>FrameType</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoVP9FrameType FrameType;

        /// <summary>
        ///     <c>FrameContextIdx</c>
        /// </summary>
        [FieldOffset(12)]
        public byte FrameContextIdx;

        /// <summary>
        ///     <c>ResetFrameContext</c>
        /// </summary>
        [FieldOffset(13)]
        public byte ResetFrameContext;

        /// <summary>
        ///     <c>RefreshFrameFlags</c>
        /// </summary>
        [FieldOffset(14)]
        public byte RefreshFrameFlags;

        /// <summary>
        ///     <c>RefFrameSignBiasMask</c>
        /// </summary>
        [FieldOffset(15)]
        public byte RefFrameSignBiasMask;

        /// <summary>
        ///     <c>InterpolationFilter</c>
        /// </summary>
        [FieldOffset(16)]
        public StdVideoVP9InterpolationFilter InterpolationFilter;

        /// <summary>
        ///     <c>BaseQIdx</c>
        /// </summary>
        [FieldOffset(20)]
        public byte BaseQIdx;

        /// <summary>
        ///     <c>DeltaQYDc</c>
        /// </summary>
        [FieldOffset(21)]
        public byte DeltaQYDc;

        /// <summary>
        ///     <c>DeltaQUvDc</c>
        /// </summary>
        [FieldOffset(22)]
        public byte DeltaQUvDc;

        /// <summary>
        ///     <c>DeltaQUvAc</c>
        /// </summary>
        [FieldOffset(23)]
        public byte DeltaQUvAc;

        /// <summary>
        ///     <c>TileColsLog2</c>
        /// </summary>
        [FieldOffset(24)]
        public byte TileColsLog2;

        /// <summary>
        ///     <c>TileRowsLog2</c>
        /// </summary>
        [FieldOffset(25)]
        public byte TileRowsLog2;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(26)]
        public ushort3 Reserved1;

        /// <summary>
        ///     <c>ColorConfig</c>
        /// </summary>
        [FieldOffset(32)]
        public StdVideoVP9ColorConfig* ColorConfig;

        /// <summary>
        ///     <c>LoopFilter</c>
        /// </summary>
        [FieldOffset(40)]
        public StdVideoVP9LoopFilter* LoopFilter;

        /// <summary>
        ///     <c>Segmentation</c>
        /// </summary>
        [FieldOffset(48)]
        public StdVideoVP9Segmentation* Segmentation;
    }
}
