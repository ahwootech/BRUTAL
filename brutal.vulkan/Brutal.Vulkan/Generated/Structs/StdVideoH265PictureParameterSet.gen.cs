namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public unsafe partial struct StdVideoH265PictureParameterSet()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH265PpsFlags Flags;

        /// <summary>
        ///     <c>PpsPicParameterSetId</c>
        /// </summary>
        [FieldOffset(4)]
        public byte PpsPicParameterSetId;

        /// <summary>
        ///     <c>PpsSeqParameterSetId</c>
        /// </summary>
        [FieldOffset(5)]
        public byte PpsSeqParameterSetId;

        /// <summary>
        ///     <c>SpsVideoParameterSetId</c>
        /// </summary>
        [FieldOffset(6)]
        public byte SpsVideoParameterSetId;

        /// <summary>
        ///     <c>NumExtraSliceHeaderBits</c>
        /// </summary>
        [FieldOffset(7)]
        public byte NumExtraSliceHeaderBits;

        /// <summary>
        ///     <c>NumRefIdxL0DefaultActiveMinus1</c>
        /// </summary>
        [FieldOffset(8)]
        public byte NumRefIdxL0DefaultActiveMinus1;

        /// <summary>
        ///     <c>NumRefIdxL1DefaultActiveMinus1</c>
        /// </summary>
        [FieldOffset(9)]
        public byte NumRefIdxL1DefaultActiveMinus1;

        /// <summary>
        ///     <c>InitQpMinus26</c>
        /// </summary>
        [FieldOffset(10)]
        public byte InitQpMinus26;

        /// <summary>
        ///     <c>DiffCuQpDeltaDepth</c>
        /// </summary>
        [FieldOffset(11)]
        public byte DiffCuQpDeltaDepth;

        /// <summary>
        ///     <c>PpsCbQpOffset</c>
        /// </summary>
        [FieldOffset(12)]
        public byte PpsCbQpOffset;

        /// <summary>
        ///     <c>PpsCrQpOffset</c>
        /// </summary>
        [FieldOffset(13)]
        public byte PpsCrQpOffset;

        /// <summary>
        ///     <c>PpsBetaOffsetDiv2</c>
        /// </summary>
        [FieldOffset(14)]
        public byte PpsBetaOffsetDiv2;

        /// <summary>
        ///     <c>PpsTcOffsetDiv2</c>
        /// </summary>
        [FieldOffset(15)]
        public byte PpsTcOffsetDiv2;

        /// <summary>
        ///     <c>Log2ParallelMergeLevelMinus2</c>
        /// </summary>
        [FieldOffset(16)]
        public byte Log2ParallelMergeLevelMinus2;

        /// <summary>
        ///     <c>Log2MaxTransformSkipBlockSizeMinus2</c>
        /// </summary>
        [FieldOffset(17)]
        public byte Log2MaxTransformSkipBlockSizeMinus2;

        /// <summary>
        ///     <c>DiffCuChromaQpOffsetDepth</c>
        /// </summary>
        [FieldOffset(18)]
        public byte DiffCuChromaQpOffsetDepth;

        /// <summary>
        ///     <c>ChromaQpOffsetListLenMinus1</c>
        /// </summary>
        [FieldOffset(19)]
        public byte ChromaQpOffsetListLenMinus1;

        ///
        [FieldOffset(20)]
        public fixed byte CbQpOffsetList[6];

        ///
        [FieldOffset(26)]
        public fixed byte CrQpOffsetList[6];

        /// <summary>
        ///     <c>Log2SaoOffsetScaleLuma</c>
        /// </summary>
        [FieldOffset(32)]
        public byte Log2SaoOffsetScaleLuma;

        /// <summary>
        ///     <c>Log2SaoOffsetScaleChroma</c>
        /// </summary>
        [FieldOffset(33)]
        public byte Log2SaoOffsetScaleChroma;

        /// <summary>
        ///     <c>PpsActYQpOffsetPlus5</c>
        /// </summary>
        [FieldOffset(34)]
        public byte PpsActYQpOffsetPlus5;

        /// <summary>
        ///     <c>PpsActCbQpOffsetPlus5</c>
        /// </summary>
        [FieldOffset(35)]
        public byte PpsActCbQpOffsetPlus5;

        /// <summary>
        ///     <c>PpsActCrQpOffsetPlus3</c>
        /// </summary>
        [FieldOffset(36)]
        public byte PpsActCrQpOffsetPlus3;

        /// <summary>
        ///     <c>PpsNumPalettePredictorInitializers</c>
        /// </summary>
        [FieldOffset(37)]
        public byte PpsNumPalettePredictorInitializers;

        /// <summary>
        ///     <c>LumaBitDepthEntryMinus8</c>
        /// </summary>
        [FieldOffset(38)]
        public byte LumaBitDepthEntryMinus8;

        /// <summary>
        ///     <c>ChromaBitDepthEntryMinus8</c>
        /// </summary>
        [FieldOffset(39)]
        public byte ChromaBitDepthEntryMinus8;

        /// <summary>
        ///     <c>NumTileColumnsMinus1</c>
        /// </summary>
        [FieldOffset(40)]
        public byte NumTileColumnsMinus1;

        /// <summary>
        ///     <c>NumTileRowsMinus1</c>
        /// </summary>
        [FieldOffset(41)]
        public byte NumTileRowsMinus1;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(42)]
        public byte Reserved1;

        /// <summary>
        ///     <c>Reserved2</c>
        /// </summary>
        [FieldOffset(43)]
        public byte Reserved2;

        ///
        [FieldOffset(44)]
        public fixed ushort ColumnWidthMinus1[19];

        ///
        [FieldOffset(82)]
        public fixed ushort RowHeightMinus1[21];

        /// <summary>
        ///     <c>Reserved3</c>
        /// </summary>
        [FieldOffset(124)]
        public int Reserved3;

        /// <summary>
        ///     <c>ScalingLists</c>
        /// </summary>
        [FieldOffset(128)]
        public StdVideoH265ScalingLists* ScalingLists;

        /// <summary>
        ///     <c>PredictorPaletteEntries</c>
        /// </summary>
        [FieldOffset(136)]
        public StdVideoH265PredictorPaletteEntries* PredictorPaletteEntries;
    }
}
