namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeH265SliceSegmentHeaderFlags()
    {
        /// <summary>
        ///     <c>FirstSliceSegmentInPicFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _firstSliceSegmentInPicFlag;

        /// <summary>
        ///     <c>DependentSliceSegmentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _dependentSliceSegmentFlag;

        /// <summary>
        ///     <c>SliceSaoLumaFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _sliceSaoLumaFlag;

        /// <summary>
        ///     <c>SliceSaoChromaFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _sliceSaoChromaFlag;

        /// <summary>
        ///     <c>NumRefIdxActiveOverrideFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _numRefIdxActiveOverrideFlag;

        /// <summary>
        ///     <c>MvdL1ZeroFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _mvdL1ZeroFlag;

        /// <summary>
        ///     <c>CabacInitFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _cabacInitFlag;

        /// <summary>
        ///     <c>CuChromaQpOffsetEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _cuChromaQpOffsetEnabledFlag;

        /// <summary>
        ///     <c>DeblockingFilterOverrideFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deblockingFilterOverrideFlag;

        /// <summary>
        ///     <c>SliceDeblockingFilterDisabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _sliceDeblockingFilterDisabledFlag;

        /// <summary>
        ///     <c>CollocatedFromL0Flag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _collocatedFromL0Flag;

        /// <summary>
        ///     <c>SliceLoopFilterAcrossSlicesEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _sliceLoopFilterAcrossSlicesEnabledFlag;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeH265SliceSegmentHeaderFlags
    {
        /// <inheritdoc cref="_firstSliceSegmentInPicFlag"/>
        public bool FirstSliceSegmentInPicFlag
        {
            get => BitFields.HasFlag(_firstSliceSegmentInPicFlag, 0);
            set => BitFields.SetFlag(ref _firstSliceSegmentInPicFlag, 0, value);
        }

        /// <inheritdoc cref="_dependentSliceSegmentFlag"/>
        public bool DependentSliceSegmentFlag
        {
            get => BitFields.HasFlag(_dependentSliceSegmentFlag, 1);
            set => BitFields.SetFlag(ref _dependentSliceSegmentFlag, 1, value);
        }

        /// <inheritdoc cref="_sliceSaoLumaFlag"/>
        public bool SliceSaoLumaFlag
        {
            get => BitFields.HasFlag(_sliceSaoLumaFlag, 2);
            set => BitFields.SetFlag(ref _sliceSaoLumaFlag, 2, value);
        }

        /// <inheritdoc cref="_sliceSaoChromaFlag"/>
        public bool SliceSaoChromaFlag
        {
            get => BitFields.HasFlag(_sliceSaoChromaFlag, 3);
            set => BitFields.SetFlag(ref _sliceSaoChromaFlag, 3, value);
        }

        /// <inheritdoc cref="_numRefIdxActiveOverrideFlag"/>
        public bool NumRefIdxActiveOverrideFlag
        {
            get => BitFields.HasFlag(_numRefIdxActiveOverrideFlag, 4);
            set => BitFields.SetFlag(ref _numRefIdxActiveOverrideFlag, 4, value);
        }

        /// <inheritdoc cref="_mvdL1ZeroFlag"/>
        public bool MvdL1ZeroFlag
        {
            get => BitFields.HasFlag(_mvdL1ZeroFlag, 5);
            set => BitFields.SetFlag(ref _mvdL1ZeroFlag, 5, value);
        }

        /// <inheritdoc cref="_cabacInitFlag"/>
        public bool CabacInitFlag
        {
            get => BitFields.HasFlag(_cabacInitFlag, 6);
            set => BitFields.SetFlag(ref _cabacInitFlag, 6, value);
        }

        /// <inheritdoc cref="_cuChromaQpOffsetEnabledFlag"/>
        public bool CuChromaQpOffsetEnabledFlag
        {
            get => BitFields.HasFlag(_cuChromaQpOffsetEnabledFlag, 7);
            set => BitFields.SetFlag(ref _cuChromaQpOffsetEnabledFlag, 7, value);
        }

        /// <inheritdoc cref="_deblockingFilterOverrideFlag"/>
        public bool DeblockingFilterOverrideFlag
        {
            get => BitFields.HasFlag(_deblockingFilterOverrideFlag, 8);
            set => BitFields.SetFlag(ref _deblockingFilterOverrideFlag, 8, value);
        }

        /// <inheritdoc cref="_sliceDeblockingFilterDisabledFlag"/>
        public bool SliceDeblockingFilterDisabledFlag
        {
            get => BitFields.HasFlag(_sliceDeblockingFilterDisabledFlag, 9);
            set => BitFields.SetFlag(ref _sliceDeblockingFilterDisabledFlag, 9, value);
        }

        /// <inheritdoc cref="_collocatedFromL0Flag"/>
        public bool CollocatedFromL0Flag
        {
            get => BitFields.HasFlag(_collocatedFromL0Flag, 10);
            set => BitFields.SetFlag(ref _collocatedFromL0Flag, 10, value);
        }

        /// <inheritdoc cref="_sliceLoopFilterAcrossSlicesEnabledFlag"/>
        public bool SliceLoopFilterAcrossSlicesEnabledFlag
        {
            get => BitFields.HasFlag(_sliceLoopFilterAcrossSlicesEnabledFlag, 11);
            set => BitFields.SetFlag(ref _sliceLoopFilterAcrossSlicesEnabledFlag, 11, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 12, length: 20);
            set => BitFields.SetRange(ref _reserved, start: 12, length: 20, value);
        }
    }
}
