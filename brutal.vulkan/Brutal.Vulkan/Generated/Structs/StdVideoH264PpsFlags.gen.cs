namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH264PpsFlags()
    {
        /// <summary>
        ///     <c>Transform_8x8ModeFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _transform_8x8ModeFlag;

        /// <summary>
        ///     <c>RedundantPicCntPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _redundantPicCntPresentFlag;

        /// <summary>
        ///     <c>ConstrainedIntraPredFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _constrainedIntraPredFlag;

        /// <summary>
        ///     <c>DeblockingFilterControlPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deblockingFilterControlPresentFlag;

        /// <summary>
        ///     <c>WeightedPredFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _weightedPredFlag;

        /// <summary>
        ///     <c>BottomFieldPicOrderInFramePresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _bottomFieldPicOrderInFramePresentFlag;

        /// <summary>
        ///     <c>EntropyCodingModeFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _entropyCodingModeFlag;

        /// <summary>
        ///     <c>PicScalingMatrixPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _picScalingMatrixPresentFlag;
    }

    public partial struct StdVideoH264PpsFlags
    {
        /// <inheritdoc cref="_transform_8x8ModeFlag"/>
        public bool Transform_8x8ModeFlag
        {
            get => BitFields.HasFlag(_transform_8x8ModeFlag, 0);
            set => BitFields.SetFlag(ref _transform_8x8ModeFlag, 0, value);
        }

        /// <inheritdoc cref="_redundantPicCntPresentFlag"/>
        public bool RedundantPicCntPresentFlag
        {
            get => BitFields.HasFlag(_redundantPicCntPresentFlag, 1);
            set => BitFields.SetFlag(ref _redundantPicCntPresentFlag, 1, value);
        }

        /// <inheritdoc cref="_constrainedIntraPredFlag"/>
        public bool ConstrainedIntraPredFlag
        {
            get => BitFields.HasFlag(_constrainedIntraPredFlag, 2);
            set => BitFields.SetFlag(ref _constrainedIntraPredFlag, 2, value);
        }

        /// <inheritdoc cref="_deblockingFilterControlPresentFlag"/>
        public bool DeblockingFilterControlPresentFlag
        {
            get => BitFields.HasFlag(_deblockingFilterControlPresentFlag, 3);
            set => BitFields.SetFlag(ref _deblockingFilterControlPresentFlag, 3, value);
        }

        /// <inheritdoc cref="_weightedPredFlag"/>
        public bool WeightedPredFlag
        {
            get => BitFields.HasFlag(_weightedPredFlag, 4);
            set => BitFields.SetFlag(ref _weightedPredFlag, 4, value);
        }

        /// <inheritdoc cref="_bottomFieldPicOrderInFramePresentFlag"/>
        public bool BottomFieldPicOrderInFramePresentFlag
        {
            get => BitFields.HasFlag(_bottomFieldPicOrderInFramePresentFlag, 5);
            set => BitFields.SetFlag(ref _bottomFieldPicOrderInFramePresentFlag, 5, value);
        }

        /// <inheritdoc cref="_entropyCodingModeFlag"/>
        public bool EntropyCodingModeFlag
        {
            get => BitFields.HasFlag(_entropyCodingModeFlag, 6);
            set => BitFields.SetFlag(ref _entropyCodingModeFlag, 6, value);
        }

        /// <inheritdoc cref="_picScalingMatrixPresentFlag"/>
        public bool PicScalingMatrixPresentFlag
        {
            get => BitFields.HasFlag(_picScalingMatrixPresentFlag, 7);
            set => BitFields.SetFlag(ref _picScalingMatrixPresentFlag, 7, value);
        }
    }
}
