namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoDecodeAV1ReferenceInfoFlags()
    {
        /// <summary>
        ///     <c>DisableFrameEndUpdateCdf</c>
        /// </summary>
        [FieldOffset(0)]
        private int _disableFrameEndUpdateCdf;

        /// <summary>
        ///     <c>SegmentationEnabled</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationEnabled;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoDecodeAV1ReferenceInfoFlags
    {
        /// <inheritdoc cref="_disableFrameEndUpdateCdf"/>
        public bool DisableFrameEndUpdateCdf
        {
            get => BitFields.HasFlag(_disableFrameEndUpdateCdf, 0);
            set => BitFields.SetFlag(ref _disableFrameEndUpdateCdf, 0, value);
        }

        /// <inheritdoc cref="_segmentationEnabled"/>
        public bool SegmentationEnabled
        {
            get => BitFields.HasFlag(_segmentationEnabled, 1);
            set => BitFields.SetFlag(ref _segmentationEnabled, 1, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 2, length: 30);
            set => BitFields.SetRange(ref _reserved, start: 2, length: 30, value);
        }
    }
}
