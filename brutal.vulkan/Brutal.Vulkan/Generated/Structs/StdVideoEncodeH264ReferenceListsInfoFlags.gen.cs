namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeH264ReferenceListsInfoFlags()
    {
        /// <summary>
        ///     <c>RefPicListModificationFlagL0</c>
        /// </summary>
        [FieldOffset(0)]
        private int _refPicListModificationFlagL0;

        /// <summary>
        ///     <c>RefPicListModificationFlagL1</c>
        /// </summary>
        [FieldOffset(0)]
        private int _refPicListModificationFlagL1;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeH264ReferenceListsInfoFlags
    {
        /// <inheritdoc cref="_refPicListModificationFlagL0"/>
        public bool RefPicListModificationFlagL0
        {
            get => BitFields.HasFlag(_refPicListModificationFlagL0, 0);
            set => BitFields.SetFlag(ref _refPicListModificationFlagL0, 0, value);
        }

        /// <inheritdoc cref="_refPicListModificationFlagL1"/>
        public bool RefPicListModificationFlagL1
        {
            get => BitFields.HasFlag(_refPicListModificationFlagL1, 1);
            set => BitFields.SetFlag(ref _refPicListModificationFlagL1, 1, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 2, length: 30);
            set => BitFields.SetRange(ref _reserved, start: 2, length: 30, value);
        }
    }
}
