namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoAV1FilmGrainFlags()
    {
        /// <summary>
        ///     <c>ChromaScalingFromLuma</c>
        /// </summary>
        [FieldOffset(0)]
        private int _chromaScalingFromLuma;

        /// <summary>
        ///     <c>OverlapFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _overlapFlag;

        /// <summary>
        ///     <c>ClipToRestrictedRange</c>
        /// </summary>
        [FieldOffset(0)]
        private int _clipToRestrictedRange;

        /// <summary>
        ///     <c>UpdateGrain</c>
        /// </summary>
        [FieldOffset(0)]
        private int _updateGrain;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoAV1FilmGrainFlags
    {
        /// <inheritdoc cref="_chromaScalingFromLuma"/>
        public bool ChromaScalingFromLuma
        {
            get => BitFields.HasFlag(_chromaScalingFromLuma, 0);
            set => BitFields.SetFlag(ref _chromaScalingFromLuma, 0, value);
        }

        /// <inheritdoc cref="_overlapFlag"/>
        public bool OverlapFlag
        {
            get => BitFields.HasFlag(_overlapFlag, 1);
            set => BitFields.SetFlag(ref _overlapFlag, 1, value);
        }

        /// <inheritdoc cref="_clipToRestrictedRange"/>
        public bool ClipToRestrictedRange
        {
            get => BitFields.HasFlag(_clipToRestrictedRange, 2);
            set => BitFields.SetFlag(ref _clipToRestrictedRange, 2, value);
        }

        /// <inheritdoc cref="_updateGrain"/>
        public bool UpdateGrain
        {
            get => BitFields.HasFlag(_updateGrain, 3);
            set => BitFields.SetFlag(ref _updateGrain, 3, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 4, length: 28);
            set => BitFields.SetRange(ref _reserved, start: 4, length: 28, value);
        }
    }
}
