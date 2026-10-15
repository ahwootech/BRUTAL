namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoDecodeH264ReferenceInfoFlags()
    {
        /// <summary>
        ///     <c>TopFieldFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _topFieldFlag;

        /// <summary>
        ///     <c>BottomFieldFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _bottomFieldFlag;

        /// <summary>
        ///     <c>UsedForLongTermReference</c>
        /// </summary>
        [FieldOffset(0)]
        private int _usedForLongTermReference;

        /// <summary>
        ///     <c>IsNonExisting</c>
        /// </summary>
        [FieldOffset(0)]
        private int _isNonExisting;
    }

    public partial struct StdVideoDecodeH264ReferenceInfoFlags
    {
        /// <inheritdoc cref="_topFieldFlag"/>
        public bool TopFieldFlag
        {
            get => BitFields.HasFlag(_topFieldFlag, 0);
            set => BitFields.SetFlag(ref _topFieldFlag, 0, value);
        }

        /// <inheritdoc cref="_bottomFieldFlag"/>
        public bool BottomFieldFlag
        {
            get => BitFields.HasFlag(_bottomFieldFlag, 1);
            set => BitFields.SetFlag(ref _bottomFieldFlag, 1, value);
        }

        /// <inheritdoc cref="_usedForLongTermReference"/>
        public bool UsedForLongTermReference
        {
            get => BitFields.HasFlag(_usedForLongTermReference, 2);
            set => BitFields.SetFlag(ref _usedForLongTermReference, 2, value);
        }

        /// <inheritdoc cref="_isNonExisting"/>
        public bool IsNonExisting
        {
            get => BitFields.HasFlag(_isNonExisting, 3);
            set => BitFields.SetFlag(ref _isNonExisting, 3, value);
        }
    }
}
