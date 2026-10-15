namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH265SpsVuiFlags()
    {
        /// <summary>
        ///     <c>AspectRatioInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _aspectRatioInfoPresentFlag;

        /// <summary>
        ///     <c>OverscanInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _overscanInfoPresentFlag;

        /// <summary>
        ///     <c>OverscanAppropriateFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _overscanAppropriateFlag;

        /// <summary>
        ///     <c>VideoSignalTypePresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _videoSignalTypePresentFlag;

        /// <summary>
        ///     <c>VideoFullRangeFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _videoFullRangeFlag;

        /// <summary>
        ///     <c>ColourDescriptionPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _colourDescriptionPresentFlag;

        /// <summary>
        ///     <c>ChromaLocInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _chromaLocInfoPresentFlag;

        /// <summary>
        ///     <c>NeutralChromaIndicationFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _neutralChromaIndicationFlag;

        /// <summary>
        ///     <c>FieldSeqFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _fieldSeqFlag;

        /// <summary>
        ///     <c>FrameFieldInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _frameFieldInfoPresentFlag;

        /// <summary>
        ///     <c>DefaultDisplayWindowFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _defaultDisplayWindowFlag;

        /// <summary>
        ///     <c>VuiTimingInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vuiTimingInfoPresentFlag;

        /// <summary>
        ///     <c>VuiPocProportionalToTimingFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vuiPocProportionalToTimingFlag;

        /// <summary>
        ///     <c>VuiHrdParametersPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vuiHrdParametersPresentFlag;

        /// <summary>
        ///     <c>BitstreamRestrictionFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _bitstreamRestrictionFlag;

        /// <summary>
        ///     <c>TilesFixedStructureFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _tilesFixedStructureFlag;

        /// <summary>
        ///     <c>MotionVectorsOverPicBoundariesFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _motionVectorsOverPicBoundariesFlag;

        /// <summary>
        ///     <c>RestrictedRefPicListsFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _restrictedRefPicListsFlag;
    }

    public partial struct StdVideoH265SpsVuiFlags
    {
        /// <inheritdoc cref="_aspectRatioInfoPresentFlag"/>
        public bool AspectRatioInfoPresentFlag
        {
            get => BitFields.HasFlag(_aspectRatioInfoPresentFlag, 0);
            set => BitFields.SetFlag(ref _aspectRatioInfoPresentFlag, 0, value);
        }

        /// <inheritdoc cref="_overscanInfoPresentFlag"/>
        public bool OverscanInfoPresentFlag
        {
            get => BitFields.HasFlag(_overscanInfoPresentFlag, 1);
            set => BitFields.SetFlag(ref _overscanInfoPresentFlag, 1, value);
        }

        /// <inheritdoc cref="_overscanAppropriateFlag"/>
        public bool OverscanAppropriateFlag
        {
            get => BitFields.HasFlag(_overscanAppropriateFlag, 2);
            set => BitFields.SetFlag(ref _overscanAppropriateFlag, 2, value);
        }

        /// <inheritdoc cref="_videoSignalTypePresentFlag"/>
        public bool VideoSignalTypePresentFlag
        {
            get => BitFields.HasFlag(_videoSignalTypePresentFlag, 3);
            set => BitFields.SetFlag(ref _videoSignalTypePresentFlag, 3, value);
        }

        /// <inheritdoc cref="_videoFullRangeFlag"/>
        public bool VideoFullRangeFlag
        {
            get => BitFields.HasFlag(_videoFullRangeFlag, 4);
            set => BitFields.SetFlag(ref _videoFullRangeFlag, 4, value);
        }

        /// <inheritdoc cref="_colourDescriptionPresentFlag"/>
        public bool ColourDescriptionPresentFlag
        {
            get => BitFields.HasFlag(_colourDescriptionPresentFlag, 5);
            set => BitFields.SetFlag(ref _colourDescriptionPresentFlag, 5, value);
        }

        /// <inheritdoc cref="_chromaLocInfoPresentFlag"/>
        public bool ChromaLocInfoPresentFlag
        {
            get => BitFields.HasFlag(_chromaLocInfoPresentFlag, 6);
            set => BitFields.SetFlag(ref _chromaLocInfoPresentFlag, 6, value);
        }

        /// <inheritdoc cref="_neutralChromaIndicationFlag"/>
        public bool NeutralChromaIndicationFlag
        {
            get => BitFields.HasFlag(_neutralChromaIndicationFlag, 7);
            set => BitFields.SetFlag(ref _neutralChromaIndicationFlag, 7, value);
        }

        /// <inheritdoc cref="_fieldSeqFlag"/>
        public bool FieldSeqFlag
        {
            get => BitFields.HasFlag(_fieldSeqFlag, 8);
            set => BitFields.SetFlag(ref _fieldSeqFlag, 8, value);
        }

        /// <inheritdoc cref="_frameFieldInfoPresentFlag"/>
        public bool FrameFieldInfoPresentFlag
        {
            get => BitFields.HasFlag(_frameFieldInfoPresentFlag, 9);
            set => BitFields.SetFlag(ref _frameFieldInfoPresentFlag, 9, value);
        }

        /// <inheritdoc cref="_defaultDisplayWindowFlag"/>
        public bool DefaultDisplayWindowFlag
        {
            get => BitFields.HasFlag(_defaultDisplayWindowFlag, 10);
            set => BitFields.SetFlag(ref _defaultDisplayWindowFlag, 10, value);
        }

        /// <inheritdoc cref="_vuiTimingInfoPresentFlag"/>
        public bool VuiTimingInfoPresentFlag
        {
            get => BitFields.HasFlag(_vuiTimingInfoPresentFlag, 11);
            set => BitFields.SetFlag(ref _vuiTimingInfoPresentFlag, 11, value);
        }

        /// <inheritdoc cref="_vuiPocProportionalToTimingFlag"/>
        public bool VuiPocProportionalToTimingFlag
        {
            get => BitFields.HasFlag(_vuiPocProportionalToTimingFlag, 12);
            set => BitFields.SetFlag(ref _vuiPocProportionalToTimingFlag, 12, value);
        }

        /// <inheritdoc cref="_vuiHrdParametersPresentFlag"/>
        public bool VuiHrdParametersPresentFlag
        {
            get => BitFields.HasFlag(_vuiHrdParametersPresentFlag, 13);
            set => BitFields.SetFlag(ref _vuiHrdParametersPresentFlag, 13, value);
        }

        /// <inheritdoc cref="_bitstreamRestrictionFlag"/>
        public bool BitstreamRestrictionFlag
        {
            get => BitFields.HasFlag(_bitstreamRestrictionFlag, 14);
            set => BitFields.SetFlag(ref _bitstreamRestrictionFlag, 14, value);
        }

        /// <inheritdoc cref="_tilesFixedStructureFlag"/>
        public bool TilesFixedStructureFlag
        {
            get => BitFields.HasFlag(_tilesFixedStructureFlag, 15);
            set => BitFields.SetFlag(ref _tilesFixedStructureFlag, 15, value);
        }

        /// <inheritdoc cref="_motionVectorsOverPicBoundariesFlag"/>
        public bool MotionVectorsOverPicBoundariesFlag
        {
            get => BitFields.HasFlag(_motionVectorsOverPicBoundariesFlag, 16);
            set => BitFields.SetFlag(ref _motionVectorsOverPicBoundariesFlag, 16, value);
        }

        /// <inheritdoc cref="_restrictedRefPicListsFlag"/>
        public bool RestrictedRefPicListsFlag
        {
            get => BitFields.HasFlag(_restrictedRefPicListsFlag, 17);
            set => BitFields.SetFlag(ref _restrictedRefPicListsFlag, 17, value);
        }
    }
}
