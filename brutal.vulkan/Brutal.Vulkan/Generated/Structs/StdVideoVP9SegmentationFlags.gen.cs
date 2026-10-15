namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoVP9SegmentationFlags()
    {
        /// <summary>
        ///     <c>SegmentationUpdateMap</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationUpdateMap;

        /// <summary>
        ///     <c>SegmentationTemporalUpdate</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationTemporalUpdate;

        /// <summary>
        ///     <c>SegmentationUpdateData</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationUpdateData;

        /// <summary>
        ///     <c>SegmentationAbsOrDeltaUpdate</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationAbsOrDeltaUpdate;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoVP9SegmentationFlags
    {
        /// <inheritdoc cref="_segmentationUpdateMap"/>
        public bool SegmentationUpdateMap
        {
            get => BitFields.HasFlag(_segmentationUpdateMap, 0);
            set => BitFields.SetFlag(ref _segmentationUpdateMap, 0, value);
        }

        /// <inheritdoc cref="_segmentationTemporalUpdate"/>
        public bool SegmentationTemporalUpdate
        {
            get => BitFields.HasFlag(_segmentationTemporalUpdate, 1);
            set => BitFields.SetFlag(ref _segmentationTemporalUpdate, 1, value);
        }

        /// <inheritdoc cref="_segmentationUpdateData"/>
        public bool SegmentationUpdateData
        {
            get => BitFields.HasFlag(_segmentationUpdateData, 2);
            set => BitFields.SetFlag(ref _segmentationUpdateData, 2, value);
        }

        /// <inheritdoc cref="_segmentationAbsOrDeltaUpdate"/>
        public bool SegmentationAbsOrDeltaUpdate
        {
            get => BitFields.HasFlag(_segmentationAbsOrDeltaUpdate, 3);
            set => BitFields.SetFlag(ref _segmentationAbsOrDeltaUpdate, 3, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 4, length: 28);
            set => BitFields.SetRange(ref _reserved, start: 4, length: 28, value);
        }
    }
}
