namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH264SpsVuiFlags()
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
        ///     <c>ColorDescriptionPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _colorDescriptionPresentFlag;

        /// <summary>
        ///     <c>ChromaLocInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _chromaLocInfoPresentFlag;

        /// <summary>
        ///     <c>TimingInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _timingInfoPresentFlag;

        /// <summary>
        ///     <c>FixedFrameRateFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _fixedFrameRateFlag;

        /// <summary>
        ///     <c>BitstreamRestrictionFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _bitstreamRestrictionFlag;

        /// <summary>
        ///     <c>NalHrdParametersPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _nalHrdParametersPresentFlag;

        /// <summary>
        ///     <c>VclHrdParametersPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vclHrdParametersPresentFlag;
    }

    public partial struct StdVideoH264SpsVuiFlags
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

        /// <inheritdoc cref="_colorDescriptionPresentFlag"/>
        public bool ColorDescriptionPresentFlag
        {
            get => BitFields.HasFlag(_colorDescriptionPresentFlag, 5);
            set => BitFields.SetFlag(ref _colorDescriptionPresentFlag, 5, value);
        }

        /// <inheritdoc cref="_chromaLocInfoPresentFlag"/>
        public bool ChromaLocInfoPresentFlag
        {
            get => BitFields.HasFlag(_chromaLocInfoPresentFlag, 6);
            set => BitFields.SetFlag(ref _chromaLocInfoPresentFlag, 6, value);
        }

        /// <inheritdoc cref="_timingInfoPresentFlag"/>
        public bool TimingInfoPresentFlag
        {
            get => BitFields.HasFlag(_timingInfoPresentFlag, 7);
            set => BitFields.SetFlag(ref _timingInfoPresentFlag, 7, value);
        }

        /// <inheritdoc cref="_fixedFrameRateFlag"/>
        public bool FixedFrameRateFlag
        {
            get => BitFields.HasFlag(_fixedFrameRateFlag, 8);
            set => BitFields.SetFlag(ref _fixedFrameRateFlag, 8, value);
        }

        /// <inheritdoc cref="_bitstreamRestrictionFlag"/>
        public bool BitstreamRestrictionFlag
        {
            get => BitFields.HasFlag(_bitstreamRestrictionFlag, 9);
            set => BitFields.SetFlag(ref _bitstreamRestrictionFlag, 9, value);
        }

        /// <inheritdoc cref="_nalHrdParametersPresentFlag"/>
        public bool NalHrdParametersPresentFlag
        {
            get => BitFields.HasFlag(_nalHrdParametersPresentFlag, 10);
            set => BitFields.SetFlag(ref _nalHrdParametersPresentFlag, 10, value);
        }

        /// <inheritdoc cref="_vclHrdParametersPresentFlag"/>
        public bool VclHrdParametersPresentFlag
        {
            get => BitFields.HasFlag(_vclHrdParametersPresentFlag, 11);
            set => BitFields.SetFlag(ref _vclHrdParametersPresentFlag, 11, value);
        }
    }
}
