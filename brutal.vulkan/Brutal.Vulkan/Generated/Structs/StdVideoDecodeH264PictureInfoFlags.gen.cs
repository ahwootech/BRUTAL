namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoDecodeH264PictureInfoFlags()
    {
        /// <summary>
        ///     <c>FieldPicFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _fieldPicFlag;

        /// <summary>
        ///     <c>IsIntra</c>
        /// </summary>
        [FieldOffset(0)]
        private int _isIntra;

        /// <summary>
        ///     <c>IdrPicFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _idrPicFlag;

        /// <summary>
        ///     <c>BottomFieldFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _bottomFieldFlag;

        /// <summary>
        ///     <c>IsReference</c>
        /// </summary>
        [FieldOffset(0)]
        private int _isReference;

        /// <summary>
        ///     <c>ComplementaryFieldPair</c>
        /// </summary>
        [FieldOffset(0)]
        private int _complementaryFieldPair;
    }

    public partial struct StdVideoDecodeH264PictureInfoFlags
    {
        /// <inheritdoc cref="_fieldPicFlag"/>
        public bool FieldPicFlag
        {
            get => BitFields.HasFlag(_fieldPicFlag, 0);
            set => BitFields.SetFlag(ref _fieldPicFlag, 0, value);
        }

        /// <inheritdoc cref="_isIntra"/>
        public bool IsIntra
        {
            get => BitFields.HasFlag(_isIntra, 1);
            set => BitFields.SetFlag(ref _isIntra, 1, value);
        }

        /// <inheritdoc cref="_idrPicFlag"/>
        public bool IdrPicFlag
        {
            get => BitFields.HasFlag(_idrPicFlag, 2);
            set => BitFields.SetFlag(ref _idrPicFlag, 2, value);
        }

        /// <inheritdoc cref="_bottomFieldFlag"/>
        public bool BottomFieldFlag
        {
            get => BitFields.HasFlag(_bottomFieldFlag, 3);
            set => BitFields.SetFlag(ref _bottomFieldFlag, 3, value);
        }

        /// <inheritdoc cref="_isReference"/>
        public bool IsReference
        {
            get => BitFields.HasFlag(_isReference, 4);
            set => BitFields.SetFlag(ref _isReference, 4, value);
        }

        /// <inheritdoc cref="_complementaryFieldPair"/>
        public bool ComplementaryFieldPair
        {
            get => BitFields.HasFlag(_complementaryFieldPair, 5);
            set => BitFields.SetFlag(ref _complementaryFieldPair, 5, value);
        }
    }
}
