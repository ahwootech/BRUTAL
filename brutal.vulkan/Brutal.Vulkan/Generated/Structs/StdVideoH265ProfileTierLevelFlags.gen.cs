namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH265ProfileTierLevelFlags()
    {
        /// <summary>
        ///     <c>GeneralTierFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _generalTierFlag;

        /// <summary>
        ///     <c>GeneralProgressiveSourceFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _generalProgressiveSourceFlag;

        /// <summary>
        ///     <c>GeneralInterlacedSourceFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _generalInterlacedSourceFlag;

        /// <summary>
        ///     <c>GeneralNonPackedConstraintFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _generalNonPackedConstraintFlag;

        /// <summary>
        ///     <c>GeneralFrameOnlyConstraintFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _generalFrameOnlyConstraintFlag;
    }

    public partial struct StdVideoH265ProfileTierLevelFlags
    {
        /// <inheritdoc cref="_generalTierFlag"/>
        public bool GeneralTierFlag
        {
            get => BitFields.HasFlag(_generalTierFlag, 0);
            set => BitFields.SetFlag(ref _generalTierFlag, 0, value);
        }

        /// <inheritdoc cref="_generalProgressiveSourceFlag"/>
        public bool GeneralProgressiveSourceFlag
        {
            get => BitFields.HasFlag(_generalProgressiveSourceFlag, 1);
            set => BitFields.SetFlag(ref _generalProgressiveSourceFlag, 1, value);
        }

        /// <inheritdoc cref="_generalInterlacedSourceFlag"/>
        public bool GeneralInterlacedSourceFlag
        {
            get => BitFields.HasFlag(_generalInterlacedSourceFlag, 2);
            set => BitFields.SetFlag(ref _generalInterlacedSourceFlag, 2, value);
        }

        /// <inheritdoc cref="_generalNonPackedConstraintFlag"/>
        public bool GeneralNonPackedConstraintFlag
        {
            get => BitFields.HasFlag(_generalNonPackedConstraintFlag, 3);
            set => BitFields.SetFlag(ref _generalNonPackedConstraintFlag, 3, value);
        }

        /// <inheritdoc cref="_generalFrameOnlyConstraintFlag"/>
        public bool GeneralFrameOnlyConstraintFlag
        {
            get => BitFields.HasFlag(_generalFrameOnlyConstraintFlag, 4);
            set => BitFields.SetFlag(ref _generalFrameOnlyConstraintFlag, 4, value);
        }
    }
}
