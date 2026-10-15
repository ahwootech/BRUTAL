namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoAV1ColorConfigFlags()
    {
        /// <summary>
        ///     <c>MonoChrome</c>
        /// </summary>
        [FieldOffset(0)]
        private int _monoChrome;

        /// <summary>
        ///     <c>ColorRange</c>
        /// </summary>
        [FieldOffset(0)]
        private int _colorRange;

        /// <summary>
        ///     <c>SeparateUvDeltaQ</c>
        /// </summary>
        [FieldOffset(0)]
        private int _separateUvDeltaQ;

        /// <summary>
        ///     <c>ColorDescriptionPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _colorDescriptionPresentFlag;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoAV1ColorConfigFlags
    {
        /// <inheritdoc cref="_monoChrome"/>
        public bool MonoChrome
        {
            get => BitFields.HasFlag(_monoChrome, 0);
            set => BitFields.SetFlag(ref _monoChrome, 0, value);
        }

        /// <inheritdoc cref="_colorRange"/>
        public bool ColorRange
        {
            get => BitFields.HasFlag(_colorRange, 1);
            set => BitFields.SetFlag(ref _colorRange, 1, value);
        }

        /// <inheritdoc cref="_separateUvDeltaQ"/>
        public bool SeparateUvDeltaQ
        {
            get => BitFields.HasFlag(_separateUvDeltaQ, 2);
            set => BitFields.SetFlag(ref _separateUvDeltaQ, 2, value);
        }

        /// <inheritdoc cref="_colorDescriptionPresentFlag"/>
        public bool ColorDescriptionPresentFlag
        {
            get => BitFields.HasFlag(_colorDescriptionPresentFlag, 3);
            set => BitFields.SetFlag(ref _colorDescriptionPresentFlag, 3, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 4, length: 28);
            set => BitFields.SetRange(ref _reserved, start: 4, length: 28, value);
        }
    }
}
