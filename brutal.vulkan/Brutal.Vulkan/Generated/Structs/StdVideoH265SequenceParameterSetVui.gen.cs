namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct StdVideoH265SequenceParameterSetVui()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH265SpsVuiFlags Flags;

        /// <summary>
        ///     <c>AspectRatioIdc</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH265AspectRatioIdc AspectRatioIdc;

        /// <summary>
        ///     <c>SarWidth</c>
        /// </summary>
        [FieldOffset(8)]
        public ushort SarWidth;

        /// <summary>
        ///     <c>SarHeight</c>
        /// </summary>
        [FieldOffset(10)]
        public ushort SarHeight;

        /// <summary>
        ///     <c>VideoFormat</c>
        /// </summary>
        [FieldOffset(12)]
        public byte VideoFormat;

        /// <summary>
        ///     <c>ColourPrimaries</c>
        /// </summary>
        [FieldOffset(13)]
        public byte ColourPrimaries;

        /// <summary>
        ///     <c>TransferCharacteristics</c>
        /// </summary>
        [FieldOffset(14)]
        public byte TransferCharacteristics;

        /// <summary>
        ///     <c>MatrixCoeffs</c>
        /// </summary>
        [FieldOffset(15)]
        public byte MatrixCoeffs;

        /// <summary>
        ///     <c>ChromaSampleLocTypeTopField</c>
        /// </summary>
        [FieldOffset(16)]
        public byte ChromaSampleLocTypeTopField;

        /// <summary>
        ///     <c>ChromaSampleLocTypeBottomField</c>
        /// </summary>
        [FieldOffset(17)]
        public byte ChromaSampleLocTypeBottomField;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(18)]
        public byte Reserved1;

        /// <summary>
        ///     <c>Reserved2</c>
        /// </summary>
        [FieldOffset(19)]
        public byte Reserved2;

        /// <summary>
        ///     <c>DefDispWinLeftOffset</c>
        /// </summary>
        [FieldOffset(20)]
        public ushort DefDispWinLeftOffset;

        /// <summary>
        ///     <c>DefDispWinRightOffset</c>
        /// </summary>
        [FieldOffset(22)]
        public ushort DefDispWinRightOffset;

        /// <summary>
        ///     <c>DefDispWinTopOffset</c>
        /// </summary>
        [FieldOffset(24)]
        public ushort DefDispWinTopOffset;

        /// <summary>
        ///     <c>DefDispWinBottomOffset</c>
        /// </summary>
        [FieldOffset(26)]
        public ushort DefDispWinBottomOffset;

        /// <summary>
        ///     <c>VuiNumUnitsInTick</c>
        /// </summary>
        [FieldOffset(28)]
        public int VuiNumUnitsInTick;

        /// <summary>
        ///     <c>VuiTimeScale</c>
        /// </summary>
        [FieldOffset(32)]
        public int VuiTimeScale;

        /// <summary>
        ///     <c>VuiNumTicksPocDiffOneMinus1</c>
        /// </summary>
        [FieldOffset(36)]
        public int VuiNumTicksPocDiffOneMinus1;

        /// <summary>
        ///     <c>MinSpatialSegmentationIdc</c>
        /// </summary>
        [FieldOffset(40)]
        public ushort MinSpatialSegmentationIdc;

        /// <summary>
        ///     <c>Reserved3</c>
        /// </summary>
        [FieldOffset(42)]
        public ushort Reserved3;

        /// <summary>
        ///     <c>MaxBytesPerPicDenom</c>
        /// </summary>
        [FieldOffset(44)]
        public byte MaxBytesPerPicDenom;

        /// <summary>
        ///     <c>MaxBitsPerMinCuDenom</c>
        /// </summary>
        [FieldOffset(45)]
        public byte MaxBitsPerMinCuDenom;

        /// <summary>
        ///     <c>Log2MaxMvLengthHorizontal</c>
        /// </summary>
        [FieldOffset(46)]
        public byte Log2MaxMvLengthHorizontal;

        /// <summary>
        ///     <c>Log2MaxMvLengthVertical</c>
        /// </summary>
        [FieldOffset(47)]
        public byte Log2MaxMvLengthVertical;

        /// <summary>
        ///     <c>HrdParameters</c>
        /// </summary>
        [FieldOffset(48)]
        public StdVideoH265HrdParameters* HrdParameters;
    }
}
