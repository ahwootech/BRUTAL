namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoDecodeH265PictureInfoFlags()
    {
        /// <summary>
        ///     <c>IrapPicFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _irapPicFlag;

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
        ///     <c>ShortTermRefPicSetSpsFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _shortTermRefPicSetSpsFlag;
    }

    public partial struct StdVideoDecodeH265PictureInfoFlags
    {
        /// <inheritdoc cref="_irapPicFlag"/>
        public bool IrapPicFlag
        {
            get => BitFields.HasFlag(_irapPicFlag, 0);
            set => BitFields.SetFlag(ref _irapPicFlag, 0, value);
        }

        /// <inheritdoc cref="_idrPicFlag"/>
        public bool IdrPicFlag
        {
            get => BitFields.HasFlag(_idrPicFlag, 1);
            set => BitFields.SetFlag(ref _idrPicFlag, 1, value);
        }

        /// <inheritdoc cref="_isReference"/>
        public bool IsReference
        {
            get => BitFields.HasFlag(_isReference, 2);
            set => BitFields.SetFlag(ref _isReference, 2, value);
        }

        /// <inheritdoc cref="_shortTermRefPicSetSpsFlag"/>
        public bool ShortTermRefPicSetSpsFlag
        {
            get => BitFields.HasFlag(_shortTermRefPicSetSpsFlag, 3);
            set => BitFields.SetFlag(ref _shortTermRefPicSetSpsFlag, 3, value);
        }
    }
}
