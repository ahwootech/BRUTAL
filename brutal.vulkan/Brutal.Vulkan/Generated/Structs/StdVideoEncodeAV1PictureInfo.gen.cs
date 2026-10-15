namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public unsafe partial struct StdVideoEncodeAV1PictureInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeAV1PictureInfoFlags Flags;

        /// <summary>
        ///     <c>FrameType</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoAV1FrameType FrameType;

        /// <summary>
        ///     <c>FramePresentationTime</c>
        /// </summary>
        [FieldOffset(8)]
        public int FramePresentationTime;

        /// <summary>
        ///     <c>CurrentFrameId</c>
        /// </summary>
        [FieldOffset(12)]
        public int CurrentFrameId;

        /// <summary>
        ///     <c>OrderHint</c>
        /// </summary>
        [FieldOffset(16)]
        public byte OrderHint;

        /// <summary>
        ///     <c>PrimaryRefFrame</c>
        /// </summary>
        [FieldOffset(17)]
        public byte PrimaryRefFrame;

        /// <summary>
        ///     <c>RefreshFrameFlags</c>
        /// </summary>
        [FieldOffset(18)]
        public byte RefreshFrameFlags;

        /// <summary>
        ///     <c>CodedDenom</c>
        /// </summary>
        [FieldOffset(19)]
        public byte CodedDenom;

        /// <summary>
        ///     <c>RenderWidthMinus_1</c>
        /// </summary>
        [FieldOffset(20)]
        public ushort RenderWidthMinus_1;

        /// <summary>
        ///     <c>RenderHeightMinus_1</c>
        /// </summary>
        [FieldOffset(22)]
        public ushort RenderHeightMinus_1;

        /// <summary>
        ///     <c>InterpolationFilter</c>
        /// </summary>
        [FieldOffset(24)]
        public StdVideoAV1InterpolationFilter InterpolationFilter;

        /// <summary>
        ///     <c>TxMode</c>
        /// </summary>
        [FieldOffset(28)]
        public StdVideoAV1TxMode TxMode;

        /// <summary>
        ///     <c>DeltaQRes</c>
        /// </summary>
        [FieldOffset(32)]
        public byte DeltaQRes;

        /// <summary>
        ///     <c>DeltaLfRes</c>
        /// </summary>
        [FieldOffset(33)]
        public byte DeltaLfRes;

        ///
        [FieldOffset(34)]
        public fixed byte RefOrderHint[8];

        ///
        [FieldOffset(42)]
        public fixed byte RefFrameIdx[7];

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(49)]
        public byte3 Reserved1;

        ///
        [FieldOffset(52)]
        public fixed int DeltaFrameIdMinus_1[7];

        /// <summary>
        ///     <c>TileInfo</c>
        /// </summary>
        [FieldOffset(80)]
        public StdVideoAV1TileInfo* TileInfo;

        /// <summary>
        ///     <c>Quantization</c>
        /// </summary>
        [FieldOffset(88)]
        public StdVideoAV1Quantization* Quantization;

        /// <summary>
        ///     <c>Segmentation</c>
        /// </summary>
        [FieldOffset(96)]
        public StdVideoAV1Segmentation* Segmentation;

        /// <summary>
        ///     <c>LoopFilter</c>
        /// </summary>
        [FieldOffset(104)]
        public StdVideoAV1LoopFilter* LoopFilter;

        /// <summary>
        ///     <c>CDEF</c>
        /// </summary>
        [FieldOffset(112)]
        public StdVideoAV1CDEF* CDEF;

        /// <summary>
        ///     <c>LoopRestoration</c>
        /// </summary>
        [FieldOffset(120)]
        public StdVideoAV1LoopRestoration* LoopRestoration;

        /// <summary>
        ///     <c>GlobalMotion</c>
        /// </summary>
        [FieldOffset(128)]
        public StdVideoAV1GlobalMotion* GlobalMotion;

        /// <summary>
        ///     <c>ExtensionHeader</c>
        /// </summary>
        [FieldOffset(136)]
        public StdVideoEncodeAV1ExtensionHeader* ExtensionHeader;

        /// <summary>
        ///     <c>BufferRemovalTimes</c>
        /// </summary>
        [FieldOffset(144)]
        public int* BufferRemovalTimes;
    }
}
