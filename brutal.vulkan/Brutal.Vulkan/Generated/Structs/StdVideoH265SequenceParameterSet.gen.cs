namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public unsafe partial struct StdVideoH265SequenceParameterSet()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH265SpsFlags Flags;

        /// <summary>
        ///     <c>ChromaFormatIdc</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH265ChromaFormatIdc ChromaFormatIdc;

        /// <summary>
        ///     <c>PicWidthInLumaSamples</c>
        /// </summary>
        [FieldOffset(8)]
        public int PicWidthInLumaSamples;

        /// <summary>
        ///     <c>PicHeightInLumaSamples</c>
        /// </summary>
        [FieldOffset(12)]
        public int PicHeightInLumaSamples;

        /// <summary>
        ///     <c>SpsVideoParameterSetId</c>
        /// </summary>
        [FieldOffset(16)]
        public byte SpsVideoParameterSetId;

        /// <summary>
        ///     <c>SpsMaxSubLayersMinus1</c>
        /// </summary>
        [FieldOffset(17)]
        public byte SpsMaxSubLayersMinus1;

        /// <summary>
        ///     <c>SpsSeqParameterSetId</c>
        /// </summary>
        [FieldOffset(18)]
        public byte SpsSeqParameterSetId;

        /// <summary>
        ///     <c>BitDepthLumaMinus8</c>
        /// </summary>
        [FieldOffset(19)]
        public byte BitDepthLumaMinus8;

        /// <summary>
        ///     <c>BitDepthChromaMinus8</c>
        /// </summary>
        [FieldOffset(20)]
        public byte BitDepthChromaMinus8;

        /// <summary>
        ///     <c>Log2MaxPicOrderCntLsbMinus4</c>
        /// </summary>
        [FieldOffset(21)]
        public byte Log2MaxPicOrderCntLsbMinus4;

        /// <summary>
        ///     <c>Log2MinLumaCodingBlockSizeMinus3</c>
        /// </summary>
        [FieldOffset(22)]
        public byte Log2MinLumaCodingBlockSizeMinus3;

        /// <summary>
        ///     <c>Log2DiffMaxMinLumaCodingBlockSize</c>
        /// </summary>
        [FieldOffset(23)]
        public byte Log2DiffMaxMinLumaCodingBlockSize;

        /// <summary>
        ///     <c>Log2MinLumaTransformBlockSizeMinus2</c>
        /// </summary>
        [FieldOffset(24)]
        public byte Log2MinLumaTransformBlockSizeMinus2;

        /// <summary>
        ///     <c>Log2DiffMaxMinLumaTransformBlockSize</c>
        /// </summary>
        [FieldOffset(25)]
        public byte Log2DiffMaxMinLumaTransformBlockSize;

        /// <summary>
        ///     <c>MaxTransformHierarchyDepthInter</c>
        /// </summary>
        [FieldOffset(26)]
        public byte MaxTransformHierarchyDepthInter;

        /// <summary>
        ///     <c>MaxTransformHierarchyDepthIntra</c>
        /// </summary>
        [FieldOffset(27)]
        public byte MaxTransformHierarchyDepthIntra;

        /// <summary>
        ///     <c>NumShortTermRefPicSets</c>
        /// </summary>
        [FieldOffset(28)]
        public byte NumShortTermRefPicSets;

        /// <summary>
        ///     <c>NumLongTermRefPicsSps</c>
        /// </summary>
        [FieldOffset(29)]
        public byte NumLongTermRefPicsSps;

        /// <summary>
        ///     <c>PcmSampleBitDepthLumaMinus1</c>
        /// </summary>
        [FieldOffset(30)]
        public byte PcmSampleBitDepthLumaMinus1;

        /// <summary>
        ///     <c>PcmSampleBitDepthChromaMinus1</c>
        /// </summary>
        [FieldOffset(31)]
        public byte PcmSampleBitDepthChromaMinus1;

        /// <summary>
        ///     <c>Log2MinPcmLumaCodingBlockSizeMinus3</c>
        /// </summary>
        [FieldOffset(32)]
        public byte Log2MinPcmLumaCodingBlockSizeMinus3;

        /// <summary>
        ///     <c>Log2DiffMaxMinPcmLumaCodingBlockSize</c>
        /// </summary>
        [FieldOffset(33)]
        public byte Log2DiffMaxMinPcmLumaCodingBlockSize;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(34)]
        public byte Reserved1;

        /// <summary>
        ///     <c>Reserved2</c>
        /// </summary>
        [FieldOffset(35)]
        public byte Reserved2;

        /// <summary>
        ///     <c>PaletteMaxSize</c>
        /// </summary>
        [FieldOffset(36)]
        public byte PaletteMaxSize;

        /// <summary>
        ///     <c>DeltaPaletteMaxPredictorSize</c>
        /// </summary>
        [FieldOffset(37)]
        public byte DeltaPaletteMaxPredictorSize;

        /// <summary>
        ///     <c>MotionVectorResolutionControlIdc</c>
        /// </summary>
        [FieldOffset(38)]
        public byte MotionVectorResolutionControlIdc;

        /// <summary>
        ///     <c>SpsNumPalettePredictorInitializersMinus1</c>
        /// </summary>
        [FieldOffset(39)]
        public byte SpsNumPalettePredictorInitializersMinus1;

        /// <summary>
        ///     <c>ConfWinLeftOffset</c>
        /// </summary>
        [FieldOffset(40)]
        public int ConfWinLeftOffset;

        /// <summary>
        ///     <c>ConfWinRightOffset</c>
        /// </summary>
        [FieldOffset(44)]
        public int ConfWinRightOffset;

        /// <summary>
        ///     <c>ConfWinTopOffset</c>
        /// </summary>
        [FieldOffset(48)]
        public int ConfWinTopOffset;

        /// <summary>
        ///     <c>ConfWinBottomOffset</c>
        /// </summary>
        [FieldOffset(52)]
        public int ConfWinBottomOffset;

        /// <summary>
        ///     <c>ProfileTierLevel</c>
        /// </summary>
        [FieldOffset(56)]
        public StdVideoH265ProfileTierLevel* ProfileTierLevel;

        /// <summary>
        ///     <c>DecPicBufMgr</c>
        /// </summary>
        [FieldOffset(64)]
        public StdVideoH265DecPicBufMgr* DecPicBufMgr;

        /// <summary>
        ///     <c>ScalingLists</c>
        /// </summary>
        [FieldOffset(72)]
        public StdVideoH265ScalingLists* ScalingLists;

        /// <summary>
        ///     <c>ShortTermRefPicSet</c>
        /// </summary>
        [FieldOffset(80)]
        public StdVideoH265ShortTermRefPicSet* ShortTermRefPicSet;

        /// <summary>
        ///     <c>LongTermRefPicsSps</c>
        /// </summary>
        [FieldOffset(88)]
        public StdVideoH265LongTermRefPicsSps* LongTermRefPicsSps;

        /// <summary>
        ///     <c>SequenceParameterSetVui</c>
        /// </summary>
        [FieldOffset(96)]
        public StdVideoH265SequenceParameterSetVui* SequenceParameterSetVui;

        /// <summary>
        ///     <c>PredictorPaletteEntries</c>
        /// </summary>
        [FieldOffset(104)]
        public StdVideoH265PredictorPaletteEntries* PredictorPaletteEntries;
    }
}
