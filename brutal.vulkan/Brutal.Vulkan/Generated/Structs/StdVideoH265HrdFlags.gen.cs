namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH265HrdFlags()
    {
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

        /// <summary>
        ///     <c>SubPicHrdParamsPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _subPicHrdParamsPresentFlag;

        /// <summary>
        ///     <c>SubPicCpbParamsInPicTimingSeiFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _subPicCpbParamsInPicTimingSeiFlag;

        /// <summary>
        ///     <c>FixedPicRateGeneralFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _fixedPicRateGeneralFlag;

        /// <summary>
        ///     <c>FixedPicRateWithinCvsFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _fixedPicRateWithinCvsFlag;

        /// <summary>
        ///     <c>LowDelayHrdFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _lowDelayHrdFlag;
    }

    public partial struct StdVideoH265HrdFlags
    {
        /// <inheritdoc cref="_nalHrdParametersPresentFlag"/>
        public bool NalHrdParametersPresentFlag
        {
            get => BitFields.HasFlag(_nalHrdParametersPresentFlag, 0);
            set => BitFields.SetFlag(ref _nalHrdParametersPresentFlag, 0, value);
        }

        /// <inheritdoc cref="_vclHrdParametersPresentFlag"/>
        public bool VclHrdParametersPresentFlag
        {
            get => BitFields.HasFlag(_vclHrdParametersPresentFlag, 1);
            set => BitFields.SetFlag(ref _vclHrdParametersPresentFlag, 1, value);
        }

        /// <inheritdoc cref="_subPicHrdParamsPresentFlag"/>
        public bool SubPicHrdParamsPresentFlag
        {
            get => BitFields.HasFlag(_subPicHrdParamsPresentFlag, 2);
            set => BitFields.SetFlag(ref _subPicHrdParamsPresentFlag, 2, value);
        }

        /// <inheritdoc cref="_subPicCpbParamsInPicTimingSeiFlag"/>
        public bool SubPicCpbParamsInPicTimingSeiFlag
        {
            get => BitFields.HasFlag(_subPicCpbParamsInPicTimingSeiFlag, 3);
            set => BitFields.SetFlag(ref _subPicCpbParamsInPicTimingSeiFlag, 3, value);
        }

        /// <inheritdoc cref="_fixedPicRateGeneralFlag"/>
        public int FixedPicRateGeneralFlag
        {
            get => BitFields.ExtractRange(_fixedPicRateGeneralFlag, start: 4, length: 8);
            set => BitFields.SetRange(ref _fixedPicRateGeneralFlag, start: 4, length: 8, value);
        }

        /// <inheritdoc cref="_fixedPicRateWithinCvsFlag"/>
        public int FixedPicRateWithinCvsFlag
        {
            get => BitFields.ExtractRange(_fixedPicRateWithinCvsFlag, start: 12, length: 8);
            set => BitFields.SetRange(ref _fixedPicRateWithinCvsFlag, start: 12, length: 8, value);
        }

        /// <inheritdoc cref="_lowDelayHrdFlag"/>
        public int LowDelayHrdFlag
        {
            get => BitFields.ExtractRange(_lowDelayHrdFlag, start: 20, length: 8);
            set => BitFields.SetRange(ref _lowDelayHrdFlag, start: 20, length: 8, value);
        }
    }
}
