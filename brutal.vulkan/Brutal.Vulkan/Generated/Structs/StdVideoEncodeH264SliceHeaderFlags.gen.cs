namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeH264SliceHeaderFlags()
    {
        /// <summary>
        ///     <c>DirectSpatialMvPredFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _directSpatialMvPredFlag;

        /// <summary>
        ///     <c>NumRefIdxActiveOverrideFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _numRefIdxActiveOverrideFlag;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeH264SliceHeaderFlags
    {
        /// <inheritdoc cref="_directSpatialMvPredFlag"/>
        public bool DirectSpatialMvPredFlag
        {
            get => BitFields.HasFlag(_directSpatialMvPredFlag, 0);
            set => BitFields.SetFlag(ref _directSpatialMvPredFlag, 0, value);
        }

        /// <inheritdoc cref="_numRefIdxActiveOverrideFlag"/>
        public bool NumRefIdxActiveOverrideFlag
        {
            get => BitFields.HasFlag(_numRefIdxActiveOverrideFlag, 1);
            set => BitFields.SetFlag(ref _numRefIdxActiveOverrideFlag, 1, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 2, length: 30);
            set => BitFields.SetRange(ref _reserved, start: 2, length: 30, value);
        }
    }
}
