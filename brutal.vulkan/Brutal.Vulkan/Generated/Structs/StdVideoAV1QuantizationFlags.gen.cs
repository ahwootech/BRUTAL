namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoAV1QuantizationFlags()
    {
        /// <summary>
        ///     <c>UsingQmatrix</c>
        /// </summary>
        [FieldOffset(0)]
        private int _usingQmatrix;

        /// <summary>
        ///     <c>DiffUvDelta</c>
        /// </summary>
        [FieldOffset(0)]
        private int _diffUvDelta;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoAV1QuantizationFlags
    {
        /// <inheritdoc cref="_usingQmatrix"/>
        public bool UsingQmatrix
        {
            get => BitFields.HasFlag(_usingQmatrix, 0);
            set => BitFields.SetFlag(ref _usingQmatrix, 0, value);
        }

        /// <inheritdoc cref="_diffUvDelta"/>
        public bool DiffUvDelta
        {
            get => BitFields.HasFlag(_diffUvDelta, 1);
            set => BitFields.SetFlag(ref _diffUvDelta, 1, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 2, length: 30);
            set => BitFields.SetRange(ref _reserved, start: 2, length: 30, value);
        }
    }
}
