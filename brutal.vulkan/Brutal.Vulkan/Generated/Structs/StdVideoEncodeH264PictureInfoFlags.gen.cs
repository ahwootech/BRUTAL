namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeH264PictureInfoFlags()
    {
        /// <summary>
        ///     <c>IdrPicFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _idrPicFlag;

        /// <summary>
        ///     <c>IsReference</c>
        /// </summary>
        [FieldOffset(0)]
        private int _isReference;

        /// <summary>
        ///     <c>NoOutputOfPriorPicsFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _noOutputOfPriorPicsFlag;

        /// <summary>
        ///     <c>LongTermReferenceFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _longTermReferenceFlag;

        /// <summary>
        ///     <c>AdaptiveRefPicMarkingModeFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _adaptiveRefPicMarkingModeFlag;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeH264PictureInfoFlags
    {
        /// <inheritdoc cref="_idrPicFlag"/>
        public bool IdrPicFlag
        {
            get => BitFields.HasFlag(_idrPicFlag, 0);
            set => BitFields.SetFlag(ref _idrPicFlag, 0, value);
        }

        /// <inheritdoc cref="_isReference"/>
        public bool IsReference
        {
            get => BitFields.HasFlag(_isReference, 1);
            set => BitFields.SetFlag(ref _isReference, 1, value);
        }

        /// <inheritdoc cref="_noOutputOfPriorPicsFlag"/>
        public bool NoOutputOfPriorPicsFlag
        {
            get => BitFields.HasFlag(_noOutputOfPriorPicsFlag, 2);
            set => BitFields.SetFlag(ref _noOutputOfPriorPicsFlag, 2, value);
        }

        /// <inheritdoc cref="_longTermReferenceFlag"/>
        public bool LongTermReferenceFlag
        {
            get => BitFields.HasFlag(_longTermReferenceFlag, 3);
            set => BitFields.SetFlag(ref _longTermReferenceFlag, 3, value);
        }

        /// <inheritdoc cref="_adaptiveRefPicMarkingModeFlag"/>
        public bool AdaptiveRefPicMarkingModeFlag
        {
            get => BitFields.HasFlag(_adaptiveRefPicMarkingModeFlag, 4);
            set => BitFields.SetFlag(ref _adaptiveRefPicMarkingModeFlag, 4, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 5, length: 27);
            set => BitFields.SetRange(ref _reserved, start: 5, length: 27, value);
        }
    }
}
