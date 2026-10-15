namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH265PpsFlags()
    {
        /// <summary>
        ///     <c>DependentSliceSegmentsEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _dependentSliceSegmentsEnabledFlag;

        /// <summary>
        ///     <c>OutputFlagPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _outputFlagPresentFlag;

        /// <summary>
        ///     <c>SignDataHidingEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _signDataHidingEnabledFlag;

        /// <summary>
        ///     <c>CabacInitPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _cabacInitPresentFlag;

        /// <summary>
        ///     <c>ConstrainedIntraPredFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _constrainedIntraPredFlag;

        /// <summary>
        ///     <c>TransformSkipEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _transformSkipEnabledFlag;

        /// <summary>
        ///     <c>CuQpDeltaEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _cuQpDeltaEnabledFlag;

        /// <summary>
        ///     <c>PpsSliceChromaQpOffsetsPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsSliceChromaQpOffsetsPresentFlag;

        /// <summary>
        ///     <c>WeightedPredFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _weightedPredFlag;

        /// <summary>
        ///     <c>WeightedBipredFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _weightedBipredFlag;

        /// <summary>
        ///     <c>TransquantBypassEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _transquantBypassEnabledFlag;

        /// <summary>
        ///     <c>TilesEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _tilesEnabledFlag;

        /// <summary>
        ///     <c>EntropyCodingSyncEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _entropyCodingSyncEnabledFlag;

        /// <summary>
        ///     <c>UniformSpacingFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _uniformSpacingFlag;

        /// <summary>
        ///     <c>LoopFilterAcrossTilesEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _loopFilterAcrossTilesEnabledFlag;

        /// <summary>
        ///     <c>PpsLoopFilterAcrossSlicesEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsLoopFilterAcrossSlicesEnabledFlag;

        /// <summary>
        ///     <c>DeblockingFilterControlPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deblockingFilterControlPresentFlag;

        /// <summary>
        ///     <c>DeblockingFilterOverrideEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deblockingFilterOverrideEnabledFlag;

        /// <summary>
        ///     <c>PpsDeblockingFilterDisabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsDeblockingFilterDisabledFlag;

        /// <summary>
        ///     <c>PpsScalingListDataPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsScalingListDataPresentFlag;

        /// <summary>
        ///     <c>ListsModificationPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _listsModificationPresentFlag;

        /// <summary>
        ///     <c>SliceSegmentHeaderExtensionPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _sliceSegmentHeaderExtensionPresentFlag;

        /// <summary>
        ///     <c>PpsExtensionPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsExtensionPresentFlag;

        /// <summary>
        ///     <c>CrossComponentPredictionEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _crossComponentPredictionEnabledFlag;

        /// <summary>
        ///     <c>ChromaQpOffsetListEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _chromaQpOffsetListEnabledFlag;

        /// <summary>
        ///     <c>PpsCurrPicRefEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsCurrPicRefEnabledFlag;

        /// <summary>
        ///     <c>ResidualAdaptiveColourTransformEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _residualAdaptiveColourTransformEnabledFlag;

        /// <summary>
        ///     <c>PpsSliceActQpOffsetsPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsSliceActQpOffsetsPresentFlag;

        /// <summary>
        ///     <c>PpsPalettePredictorInitializersPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsPalettePredictorInitializersPresentFlag;

        /// <summary>
        ///     <c>MonochromePaletteFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _monochromePaletteFlag;

        /// <summary>
        ///     <c>PpsRangeExtensionFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ppsRangeExtensionFlag;
    }

    public partial struct StdVideoH265PpsFlags
    {
        /// <inheritdoc cref="_dependentSliceSegmentsEnabledFlag"/>
        public bool DependentSliceSegmentsEnabledFlag
        {
            get => BitFields.HasFlag(_dependentSliceSegmentsEnabledFlag, 0);
            set => BitFields.SetFlag(ref _dependentSliceSegmentsEnabledFlag, 0, value);
        }

        /// <inheritdoc cref="_outputFlagPresentFlag"/>
        public bool OutputFlagPresentFlag
        {
            get => BitFields.HasFlag(_outputFlagPresentFlag, 1);
            set => BitFields.SetFlag(ref _outputFlagPresentFlag, 1, value);
        }

        /// <inheritdoc cref="_signDataHidingEnabledFlag"/>
        public bool SignDataHidingEnabledFlag
        {
            get => BitFields.HasFlag(_signDataHidingEnabledFlag, 2);
            set => BitFields.SetFlag(ref _signDataHidingEnabledFlag, 2, value);
        }

        /// <inheritdoc cref="_cabacInitPresentFlag"/>
        public bool CabacInitPresentFlag
        {
            get => BitFields.HasFlag(_cabacInitPresentFlag, 3);
            set => BitFields.SetFlag(ref _cabacInitPresentFlag, 3, value);
        }

        /// <inheritdoc cref="_constrainedIntraPredFlag"/>
        public bool ConstrainedIntraPredFlag
        {
            get => BitFields.HasFlag(_constrainedIntraPredFlag, 4);
            set => BitFields.SetFlag(ref _constrainedIntraPredFlag, 4, value);
        }

        /// <inheritdoc cref="_transformSkipEnabledFlag"/>
        public bool TransformSkipEnabledFlag
        {
            get => BitFields.HasFlag(_transformSkipEnabledFlag, 5);
            set => BitFields.SetFlag(ref _transformSkipEnabledFlag, 5, value);
        }

        /// <inheritdoc cref="_cuQpDeltaEnabledFlag"/>
        public bool CuQpDeltaEnabledFlag
        {
            get => BitFields.HasFlag(_cuQpDeltaEnabledFlag, 6);
            set => BitFields.SetFlag(ref _cuQpDeltaEnabledFlag, 6, value);
        }

        /// <inheritdoc cref="_ppsSliceChromaQpOffsetsPresentFlag"/>
        public bool PpsSliceChromaQpOffsetsPresentFlag
        {
            get => BitFields.HasFlag(_ppsSliceChromaQpOffsetsPresentFlag, 7);
            set => BitFields.SetFlag(ref _ppsSliceChromaQpOffsetsPresentFlag, 7, value);
        }

        /// <inheritdoc cref="_weightedPredFlag"/>
        public bool WeightedPredFlag
        {
            get => BitFields.HasFlag(_weightedPredFlag, 8);
            set => BitFields.SetFlag(ref _weightedPredFlag, 8, value);
        }

        /// <inheritdoc cref="_weightedBipredFlag"/>
        public bool WeightedBipredFlag
        {
            get => BitFields.HasFlag(_weightedBipredFlag, 9);
            set => BitFields.SetFlag(ref _weightedBipredFlag, 9, value);
        }

        /// <inheritdoc cref="_transquantBypassEnabledFlag"/>
        public bool TransquantBypassEnabledFlag
        {
            get => BitFields.HasFlag(_transquantBypassEnabledFlag, 10);
            set => BitFields.SetFlag(ref _transquantBypassEnabledFlag, 10, value);
        }

        /// <inheritdoc cref="_tilesEnabledFlag"/>
        public bool TilesEnabledFlag
        {
            get => BitFields.HasFlag(_tilesEnabledFlag, 11);
            set => BitFields.SetFlag(ref _tilesEnabledFlag, 11, value);
        }

        /// <inheritdoc cref="_entropyCodingSyncEnabledFlag"/>
        public bool EntropyCodingSyncEnabledFlag
        {
            get => BitFields.HasFlag(_entropyCodingSyncEnabledFlag, 12);
            set => BitFields.SetFlag(ref _entropyCodingSyncEnabledFlag, 12, value);
        }

        /// <inheritdoc cref="_uniformSpacingFlag"/>
        public bool UniformSpacingFlag
        {
            get => BitFields.HasFlag(_uniformSpacingFlag, 13);
            set => BitFields.SetFlag(ref _uniformSpacingFlag, 13, value);
        }

        /// <inheritdoc cref="_loopFilterAcrossTilesEnabledFlag"/>
        public bool LoopFilterAcrossTilesEnabledFlag
        {
            get => BitFields.HasFlag(_loopFilterAcrossTilesEnabledFlag, 14);
            set => BitFields.SetFlag(ref _loopFilterAcrossTilesEnabledFlag, 14, value);
        }

        /// <inheritdoc cref="_ppsLoopFilterAcrossSlicesEnabledFlag"/>
        public bool PpsLoopFilterAcrossSlicesEnabledFlag
        {
            get => BitFields.HasFlag(_ppsLoopFilterAcrossSlicesEnabledFlag, 15);
            set => BitFields.SetFlag(ref _ppsLoopFilterAcrossSlicesEnabledFlag, 15, value);
        }

        /// <inheritdoc cref="_deblockingFilterControlPresentFlag"/>
        public bool DeblockingFilterControlPresentFlag
        {
            get => BitFields.HasFlag(_deblockingFilterControlPresentFlag, 16);
            set => BitFields.SetFlag(ref _deblockingFilterControlPresentFlag, 16, value);
        }

        /// <inheritdoc cref="_deblockingFilterOverrideEnabledFlag"/>
        public bool DeblockingFilterOverrideEnabledFlag
        {
            get => BitFields.HasFlag(_deblockingFilterOverrideEnabledFlag, 17);
            set => BitFields.SetFlag(ref _deblockingFilterOverrideEnabledFlag, 17, value);
        }

        /// <inheritdoc cref="_ppsDeblockingFilterDisabledFlag"/>
        public bool PpsDeblockingFilterDisabledFlag
        {
            get => BitFields.HasFlag(_ppsDeblockingFilterDisabledFlag, 18);
            set => BitFields.SetFlag(ref _ppsDeblockingFilterDisabledFlag, 18, value);
        }

        /// <inheritdoc cref="_ppsScalingListDataPresentFlag"/>
        public bool PpsScalingListDataPresentFlag
        {
            get => BitFields.HasFlag(_ppsScalingListDataPresentFlag, 19);
            set => BitFields.SetFlag(ref _ppsScalingListDataPresentFlag, 19, value);
        }

        /// <inheritdoc cref="_listsModificationPresentFlag"/>
        public bool ListsModificationPresentFlag
        {
            get => BitFields.HasFlag(_listsModificationPresentFlag, 20);
            set => BitFields.SetFlag(ref _listsModificationPresentFlag, 20, value);
        }

        /// <inheritdoc cref="_sliceSegmentHeaderExtensionPresentFlag"/>
        public bool SliceSegmentHeaderExtensionPresentFlag
        {
            get => BitFields.HasFlag(_sliceSegmentHeaderExtensionPresentFlag, 21);
            set => BitFields.SetFlag(ref _sliceSegmentHeaderExtensionPresentFlag, 21, value);
        }

        /// <inheritdoc cref="_ppsExtensionPresentFlag"/>
        public bool PpsExtensionPresentFlag
        {
            get => BitFields.HasFlag(_ppsExtensionPresentFlag, 22);
            set => BitFields.SetFlag(ref _ppsExtensionPresentFlag, 22, value);
        }

        /// <inheritdoc cref="_crossComponentPredictionEnabledFlag"/>
        public bool CrossComponentPredictionEnabledFlag
        {
            get => BitFields.HasFlag(_crossComponentPredictionEnabledFlag, 23);
            set => BitFields.SetFlag(ref _crossComponentPredictionEnabledFlag, 23, value);
        }

        /// <inheritdoc cref="_chromaQpOffsetListEnabledFlag"/>
        public bool ChromaQpOffsetListEnabledFlag
        {
            get => BitFields.HasFlag(_chromaQpOffsetListEnabledFlag, 24);
            set => BitFields.SetFlag(ref _chromaQpOffsetListEnabledFlag, 24, value);
        }

        /// <inheritdoc cref="_ppsCurrPicRefEnabledFlag"/>
        public bool PpsCurrPicRefEnabledFlag
        {
            get => BitFields.HasFlag(_ppsCurrPicRefEnabledFlag, 25);
            set => BitFields.SetFlag(ref _ppsCurrPicRefEnabledFlag, 25, value);
        }

        /// <inheritdoc cref="_residualAdaptiveColourTransformEnabledFlag"/>
        public bool ResidualAdaptiveColourTransformEnabledFlag
        {
            get => BitFields.HasFlag(_residualAdaptiveColourTransformEnabledFlag, 26);
            set => BitFields.SetFlag(ref _residualAdaptiveColourTransformEnabledFlag, 26, value);
        }

        /// <inheritdoc cref="_ppsSliceActQpOffsetsPresentFlag"/>
        public bool PpsSliceActQpOffsetsPresentFlag
        {
            get => BitFields.HasFlag(_ppsSliceActQpOffsetsPresentFlag, 27);
            set => BitFields.SetFlag(ref _ppsSliceActQpOffsetsPresentFlag, 27, value);
        }

        /// <inheritdoc cref="_ppsPalettePredictorInitializersPresentFlag"/>
        public bool PpsPalettePredictorInitializersPresentFlag
        {
            get => BitFields.HasFlag(_ppsPalettePredictorInitializersPresentFlag, 28);
            set => BitFields.SetFlag(ref _ppsPalettePredictorInitializersPresentFlag, 28, value);
        }

        /// <inheritdoc cref="_monochromePaletteFlag"/>
        public bool MonochromePaletteFlag
        {
            get => BitFields.HasFlag(_monochromePaletteFlag, 29);
            set => BitFields.SetFlag(ref _monochromePaletteFlag, 29, value);
        }

        /// <inheritdoc cref="_ppsRangeExtensionFlag"/>
        public bool PpsRangeExtensionFlag
        {
            get => BitFields.HasFlag(_ppsRangeExtensionFlag, 30);
            set => BitFields.SetFlag(ref _ppsRangeExtensionFlag, 30, value);
        }
    }
}
