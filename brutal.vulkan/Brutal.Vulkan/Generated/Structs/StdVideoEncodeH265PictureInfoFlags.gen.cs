namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeH265PictureInfoFlags()
    {
        /// <summary>
        ///     <c>IsReference</c>
        /// </summary>
        [FieldOffset(0)]
        private int _isReference;

        /// <summary>
        ///     <c>IrapPicFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _irapPicFlag;

        /// <summary>
        ///     <c>UsedForLongTermReference</c>
        /// </summary>
        [FieldOffset(0)]
        private int _usedForLongTermReference;

        /// <summary>
        ///     <c>DiscardableFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _discardableFlag;

        /// <summary>
        ///     <c>CrossLayerBlaFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _crossLayerBlaFlag;

        /// <summary>
        ///     <c>PicOutputFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _picOutputFlag;

        /// <summary>
        ///     <c>NoOutputOfPriorPicsFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _noOutputOfPriorPicsFlag;

        /// <summary>
        ///     <c>ShortTermRefPicSetSpsFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _shortTermRefPicSetSpsFlag;

        /// <summary>
        ///     <c>SliceTemporalMvpEnabledFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _sliceTemporalMvpEnabledFlag;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeH265PictureInfoFlags
    {
        /// <inheritdoc cref="_isReference"/>
        public bool IsReference
        {
            get => BitFields.HasFlag(_isReference, 0);
            set => BitFields.SetFlag(ref _isReference, 0, value);
        }

        /// <inheritdoc cref="_irapPicFlag"/>
        public bool IrapPicFlag
        {
            get => BitFields.HasFlag(_irapPicFlag, 1);
            set => BitFields.SetFlag(ref _irapPicFlag, 1, value);
        }

        /// <inheritdoc cref="_usedForLongTermReference"/>
        public bool UsedForLongTermReference
        {
            get => BitFields.HasFlag(_usedForLongTermReference, 2);
            set => BitFields.SetFlag(ref _usedForLongTermReference, 2, value);
        }

        /// <inheritdoc cref="_discardableFlag"/>
        public bool DiscardableFlag
        {
            get => BitFields.HasFlag(_discardableFlag, 3);
            set => BitFields.SetFlag(ref _discardableFlag, 3, value);
        }

        /// <inheritdoc cref="_crossLayerBlaFlag"/>
        public bool CrossLayerBlaFlag
        {
            get => BitFields.HasFlag(_crossLayerBlaFlag, 4);
            set => BitFields.SetFlag(ref _crossLayerBlaFlag, 4, value);
        }

        /// <inheritdoc cref="_picOutputFlag"/>
        public bool PicOutputFlag
        {
            get => BitFields.HasFlag(_picOutputFlag, 5);
            set => BitFields.SetFlag(ref _picOutputFlag, 5, value);
        }

        /// <inheritdoc cref="_noOutputOfPriorPicsFlag"/>
        public bool NoOutputOfPriorPicsFlag
        {
            get => BitFields.HasFlag(_noOutputOfPriorPicsFlag, 6);
            set => BitFields.SetFlag(ref _noOutputOfPriorPicsFlag, 6, value);
        }

        /// <inheritdoc cref="_shortTermRefPicSetSpsFlag"/>
        public bool ShortTermRefPicSetSpsFlag
        {
            get => BitFields.HasFlag(_shortTermRefPicSetSpsFlag, 7);
            set => BitFields.SetFlag(ref _shortTermRefPicSetSpsFlag, 7, value);
        }

        /// <inheritdoc cref="_sliceTemporalMvpEnabledFlag"/>
        public bool SliceTemporalMvpEnabledFlag
        {
            get => BitFields.HasFlag(_sliceTemporalMvpEnabledFlag, 8);
            set => BitFields.SetFlag(ref _sliceTemporalMvpEnabledFlag, 8, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 9, length: 23);
            set => BitFields.SetRange(ref _reserved, start: 9, length: 23, value);
        }
    }
}
