namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH265SpsFlags()
    {
        /// <summary>
        ///     <c>SpsTemporalIdNestingFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsTemporalIdNestingFlag;

        /// <summary>
        ///     <c>SeparateColourPlaneFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _separateColourPlaneFlag;

        /// <summary>
        ///     <c>ConformanceWindowFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _conformanceWindowFlag;

        /// <summary>
        ///     <c>SpsSubLayerOrderingInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsSubLayerOrderingInfoPresentFlag;

        /// <summary>
        ///     <c>ScalingListEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _scalingListEnabledFlag;

        /// <summary>
        ///     <c>SpsScalingListDataPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsScalingListDataPresentFlag;

        /// <summary>
        ///     <c>AmpEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _ampEnabledFlag;

        /// <summary>
        ///     <c>SampleAdaptiveOffsetEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _sampleAdaptiveOffsetEnabledFlag;

        /// <summary>
        ///     <c>PcmEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _pcmEnabledFlag;

        /// <summary>
        ///     <c>PcmLoopFilterDisabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _pcmLoopFilterDisabledFlag;

        /// <summary>
        ///     <c>LongTermRefPicsPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _longTermRefPicsPresentFlag;

        /// <summary>
        ///     <c>SpsTemporalMvpEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsTemporalMvpEnabledFlag;

        /// <summary>
        ///     <c>StrongIntraSmoothingEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _strongIntraSmoothingEnabledFlag;

        /// <summary>
        ///     <c>VuiParametersPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vuiParametersPresentFlag;

        /// <summary>
        ///     <c>SpsExtensionPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsExtensionPresentFlag;

        /// <summary>
        ///     <c>SpsRangeExtensionFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsRangeExtensionFlag;

        /// <summary>
        ///     <c>TransformSkipRotationEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _transformSkipRotationEnabledFlag;

        /// <summary>
        ///     <c>TransformSkipContextEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _transformSkipContextEnabledFlag;

        /// <summary>
        ///     <c>ImplicitRdpcmEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _implicitRdpcmEnabledFlag;

        /// <summary>
        ///     <c>ExplicitRdpcmEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _explicitRdpcmEnabledFlag;

        /// <summary>
        ///     <c>ExtendedPrecisionProcessingFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _extendedPrecisionProcessingFlag;

        /// <summary>
        ///     <c>IntraSmoothingDisabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _intraSmoothingDisabledFlag;

        /// <summary>
        ///     <c>HighPrecisionOffsetsEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _highPrecisionOffsetsEnabledFlag;

        /// <summary>
        ///     <c>PersistentRiceAdaptationEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _persistentRiceAdaptationEnabledFlag;

        /// <summary>
        ///     <c>CabacBypassAlignmentEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _cabacBypassAlignmentEnabledFlag;

        /// <summary>
        ///     <c>SpsSccExtensionFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsSccExtensionFlag;

        /// <summary>
        ///     <c>SpsCurrPicRefEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsCurrPicRefEnabledFlag;

        /// <summary>
        ///     <c>PaletteModeEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _paletteModeEnabledFlag;

        /// <summary>
        ///     <c>SpsPalettePredictorInitializersPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _spsPalettePredictorInitializersPresentFlag;

        /// <summary>
        ///     <c>IntraBoundaryFilteringDisabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _intraBoundaryFilteringDisabledFlag;
    }

    public partial struct StdVideoH265SpsFlags
    {
        /// <inheritdoc cref="_spsTemporalIdNestingFlag"/>
        public bool SpsTemporalIdNestingFlag
        {
            get => BitFields.HasFlag(_spsTemporalIdNestingFlag, 0);
            set => BitFields.SetFlag(ref _spsTemporalIdNestingFlag, 0, value);
        }

        /// <inheritdoc cref="_separateColourPlaneFlag"/>
        public bool SeparateColourPlaneFlag
        {
            get => BitFields.HasFlag(_separateColourPlaneFlag, 1);
            set => BitFields.SetFlag(ref _separateColourPlaneFlag, 1, value);
        }

        /// <inheritdoc cref="_conformanceWindowFlag"/>
        public bool ConformanceWindowFlag
        {
            get => BitFields.HasFlag(_conformanceWindowFlag, 2);
            set => BitFields.SetFlag(ref _conformanceWindowFlag, 2, value);
        }

        /// <inheritdoc cref="_spsSubLayerOrderingInfoPresentFlag"/>
        public bool SpsSubLayerOrderingInfoPresentFlag
        {
            get => BitFields.HasFlag(_spsSubLayerOrderingInfoPresentFlag, 3);
            set => BitFields.SetFlag(ref _spsSubLayerOrderingInfoPresentFlag, 3, value);
        }

        /// <inheritdoc cref="_scalingListEnabledFlag"/>
        public bool ScalingListEnabledFlag
        {
            get => BitFields.HasFlag(_scalingListEnabledFlag, 4);
            set => BitFields.SetFlag(ref _scalingListEnabledFlag, 4, value);
        }

        /// <inheritdoc cref="_spsScalingListDataPresentFlag"/>
        public bool SpsScalingListDataPresentFlag
        {
            get => BitFields.HasFlag(_spsScalingListDataPresentFlag, 5);
            set => BitFields.SetFlag(ref _spsScalingListDataPresentFlag, 5, value);
        }

        /// <inheritdoc cref="_ampEnabledFlag"/>
        public bool AmpEnabledFlag
        {
            get => BitFields.HasFlag(_ampEnabledFlag, 6);
            set => BitFields.SetFlag(ref _ampEnabledFlag, 6, value);
        }

        /// <inheritdoc cref="_sampleAdaptiveOffsetEnabledFlag"/>
        public bool SampleAdaptiveOffsetEnabledFlag
        {
            get => BitFields.HasFlag(_sampleAdaptiveOffsetEnabledFlag, 7);
            set => BitFields.SetFlag(ref _sampleAdaptiveOffsetEnabledFlag, 7, value);
        }

        /// <inheritdoc cref="_pcmEnabledFlag"/>
        public bool PcmEnabledFlag
        {
            get => BitFields.HasFlag(_pcmEnabledFlag, 8);
            set => BitFields.SetFlag(ref _pcmEnabledFlag, 8, value);
        }

        /// <inheritdoc cref="_pcmLoopFilterDisabledFlag"/>
        public bool PcmLoopFilterDisabledFlag
        {
            get => BitFields.HasFlag(_pcmLoopFilterDisabledFlag, 9);
            set => BitFields.SetFlag(ref _pcmLoopFilterDisabledFlag, 9, value);
        }

        /// <inheritdoc cref="_longTermRefPicsPresentFlag"/>
        public bool LongTermRefPicsPresentFlag
        {
            get => BitFields.HasFlag(_longTermRefPicsPresentFlag, 10);
            set => BitFields.SetFlag(ref _longTermRefPicsPresentFlag, 10, value);
        }

        /// <inheritdoc cref="_spsTemporalMvpEnabledFlag"/>
        public bool SpsTemporalMvpEnabledFlag
        {
            get => BitFields.HasFlag(_spsTemporalMvpEnabledFlag, 11);
            set => BitFields.SetFlag(ref _spsTemporalMvpEnabledFlag, 11, value);
        }

        /// <inheritdoc cref="_strongIntraSmoothingEnabledFlag"/>
        public bool StrongIntraSmoothingEnabledFlag
        {
            get => BitFields.HasFlag(_strongIntraSmoothingEnabledFlag, 12);
            set => BitFields.SetFlag(ref _strongIntraSmoothingEnabledFlag, 12, value);
        }

        /// <inheritdoc cref="_vuiParametersPresentFlag"/>
        public bool VuiParametersPresentFlag
        {
            get => BitFields.HasFlag(_vuiParametersPresentFlag, 13);
            set => BitFields.SetFlag(ref _vuiParametersPresentFlag, 13, value);
        }

        /// <inheritdoc cref="_spsExtensionPresentFlag"/>
        public bool SpsExtensionPresentFlag
        {
            get => BitFields.HasFlag(_spsExtensionPresentFlag, 14);
            set => BitFields.SetFlag(ref _spsExtensionPresentFlag, 14, value);
        }

        /// <inheritdoc cref="_spsRangeExtensionFlag"/>
        public bool SpsRangeExtensionFlag
        {
            get => BitFields.HasFlag(_spsRangeExtensionFlag, 15);
            set => BitFields.SetFlag(ref _spsRangeExtensionFlag, 15, value);
        }

        /// <inheritdoc cref="_transformSkipRotationEnabledFlag"/>
        public bool TransformSkipRotationEnabledFlag
        {
            get => BitFields.HasFlag(_transformSkipRotationEnabledFlag, 16);
            set => BitFields.SetFlag(ref _transformSkipRotationEnabledFlag, 16, value);
        }

        /// <inheritdoc cref="_transformSkipContextEnabledFlag"/>
        public bool TransformSkipContextEnabledFlag
        {
            get => BitFields.HasFlag(_transformSkipContextEnabledFlag, 17);
            set => BitFields.SetFlag(ref _transformSkipContextEnabledFlag, 17, value);
        }

        /// <inheritdoc cref="_implicitRdpcmEnabledFlag"/>
        public bool ImplicitRdpcmEnabledFlag
        {
            get => BitFields.HasFlag(_implicitRdpcmEnabledFlag, 18);
            set => BitFields.SetFlag(ref _implicitRdpcmEnabledFlag, 18, value);
        }

        /// <inheritdoc cref="_explicitRdpcmEnabledFlag"/>
        public bool ExplicitRdpcmEnabledFlag
        {
            get => BitFields.HasFlag(_explicitRdpcmEnabledFlag, 19);
            set => BitFields.SetFlag(ref _explicitRdpcmEnabledFlag, 19, value);
        }

        /// <inheritdoc cref="_extendedPrecisionProcessingFlag"/>
        public bool ExtendedPrecisionProcessingFlag
        {
            get => BitFields.HasFlag(_extendedPrecisionProcessingFlag, 20);
            set => BitFields.SetFlag(ref _extendedPrecisionProcessingFlag, 20, value);
        }

        /// <inheritdoc cref="_intraSmoothingDisabledFlag"/>
        public bool IntraSmoothingDisabledFlag
        {
            get => BitFields.HasFlag(_intraSmoothingDisabledFlag, 21);
            set => BitFields.SetFlag(ref _intraSmoothingDisabledFlag, 21, value);
        }

        /// <inheritdoc cref="_highPrecisionOffsetsEnabledFlag"/>
        public bool HighPrecisionOffsetsEnabledFlag
        {
            get => BitFields.HasFlag(_highPrecisionOffsetsEnabledFlag, 22);
            set => BitFields.SetFlag(ref _highPrecisionOffsetsEnabledFlag, 22, value);
        }

        /// <inheritdoc cref="_persistentRiceAdaptationEnabledFlag"/>
        public bool PersistentRiceAdaptationEnabledFlag
        {
            get => BitFields.HasFlag(_persistentRiceAdaptationEnabledFlag, 23);
            set => BitFields.SetFlag(ref _persistentRiceAdaptationEnabledFlag, 23, value);
        }

        /// <inheritdoc cref="_cabacBypassAlignmentEnabledFlag"/>
        public bool CabacBypassAlignmentEnabledFlag
        {
            get => BitFields.HasFlag(_cabacBypassAlignmentEnabledFlag, 24);
            set => BitFields.SetFlag(ref _cabacBypassAlignmentEnabledFlag, 24, value);
        }

        /// <inheritdoc cref="_spsSccExtensionFlag"/>
        public bool SpsSccExtensionFlag
        {
            get => BitFields.HasFlag(_spsSccExtensionFlag, 25);
            set => BitFields.SetFlag(ref _spsSccExtensionFlag, 25, value);
        }

        /// <inheritdoc cref="_spsCurrPicRefEnabledFlag"/>
        public bool SpsCurrPicRefEnabledFlag
        {
            get => BitFields.HasFlag(_spsCurrPicRefEnabledFlag, 26);
            set => BitFields.SetFlag(ref _spsCurrPicRefEnabledFlag, 26, value);
        }

        /// <inheritdoc cref="_paletteModeEnabledFlag"/>
        public bool PaletteModeEnabledFlag
        {
            get => BitFields.HasFlag(_paletteModeEnabledFlag, 27);
            set => BitFields.SetFlag(ref _paletteModeEnabledFlag, 27, value);
        }

        /// <inheritdoc cref="_spsPalettePredictorInitializersPresentFlag"/>
        public bool SpsPalettePredictorInitializersPresentFlag
        {
            get => BitFields.HasFlag(_spsPalettePredictorInitializersPresentFlag, 28);
            set => BitFields.SetFlag(ref _spsPalettePredictorInitializersPresentFlag, 28, value);
        }

        /// <inheritdoc cref="_intraBoundaryFilteringDisabledFlag"/>
        public bool IntraBoundaryFilteringDisabledFlag
        {
            get => BitFields.HasFlag(_intraBoundaryFilteringDisabledFlag, 29);
            set => BitFields.SetFlag(ref _intraBoundaryFilteringDisabledFlag, 29, value);
        }
    }
}
