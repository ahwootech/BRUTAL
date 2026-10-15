namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public unsafe partial struct StdVideoDecodeAV1PictureInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoDecodeAV1PictureInfoFlags Flags;

        /// <summary>
        ///     <c>FrameType</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoAV1FrameType FrameType;

        /// <summary>
        ///     <c>CurrentFrameId</c>
        /// </summary>
        [FieldOffset(8)]
        public int CurrentFrameId;

        /// <summary>
        ///     <c>OrderHint</c>
        /// </summary>
        [FieldOffset(12)]
        public byte OrderHint;

        /// <summary>
        ///     <c>PrimaryRefFrame</c>
        /// </summary>
        [FieldOffset(13)]
        public byte PrimaryRefFrame;

        /// <summary>
        ///     <c>RefreshFrameFlags</c>
        /// </summary>
        [FieldOffset(14)]
        public byte RefreshFrameFlags;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(15)]
        public byte Reserved1;

        /// <summary>
        ///     <c>InterpolationFilter</c>
        /// </summary>
        [FieldOffset(16)]
        public StdVideoAV1InterpolationFilter InterpolationFilter;

        /// <summary>
        ///     <c>TxMode</c>
        /// </summary>
        [FieldOffset(20)]
        public StdVideoAV1TxMode TxMode;

        /// <summary>
        ///     <c>DeltaQRes</c>
        /// </summary>
        [FieldOffset(24)]
        public byte DeltaQRes;

        /// <summary>
        ///     <c>DeltaLfRes</c>
        /// </summary>
        [FieldOffset(25)]
        public byte DeltaLfRes;

        /// <summary>
        ///     <c>SkipModeFrame</c>
        /// </summary>
        [FieldOffset(26)]
        public byte2 SkipModeFrame;

        /// <summary>
        ///     <c>CodedDenom</c>
        /// </summary>
        [FieldOffset(28)]
        public byte CodedDenom;

        /// <summary>
        ///     <c>Reserved2</c>
        /// </summary>
        [FieldOffset(29)]
        public byte3 Reserved2;

        ///
        [FieldOffset(32)]
        public fixed byte OrderHints[8];

        ///
        [FieldOffset(40)]
        public fixed int ExpectedFrameId[8];

        /// <summary>
        ///     <c>TileInfo</c>
        /// </summary>
        [FieldOffset(72)]
        public StdVideoAV1TileInfo* TileInfo;

        /// <summary>
        ///     <c>Quantization</c>
        /// </summary>
        [FieldOffset(80)]
        public StdVideoAV1Quantization* Quantization;

        /// <summary>
        ///     <c>Segmentation</c>
        /// </summary>
        [FieldOffset(88)]
        public StdVideoAV1Segmentation* Segmentation;

        /// <summary>
        ///     <c>LoopFilter</c>
        /// </summary>
        [FieldOffset(96)]
        public StdVideoAV1LoopFilter* LoopFilter;

        /// <summary>
        ///     <c>CDEF</c>
        /// </summary>
        [FieldOffset(104)]
        public StdVideoAV1CDEF* CDEF;

        /// <summary>
        ///     <c>LoopRestoration</c>
        /// </summary>
        [FieldOffset(112)]
        public StdVideoAV1LoopRestoration* LoopRestoration;

        /// <summary>
        ///     <c>GlobalMotion</c>
        /// </summary>
        [FieldOffset(120)]
        public StdVideoAV1GlobalMotion* GlobalMotion;

        /// <summary>
        ///     <c>FilmGrain</c>
        /// </summary>
        [FieldOffset(128)]
        public StdVideoAV1FilmGrain* FilmGrain;
    }
}
