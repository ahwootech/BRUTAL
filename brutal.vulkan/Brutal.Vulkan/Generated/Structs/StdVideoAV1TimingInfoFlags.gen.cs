namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoAV1TimingInfoFlags()
    {
        /// <summary>
        ///     <c>EqualPictureInterval</c>
        /// </summary>
        [FieldOffset(0)]
        private int _equalPictureInterval;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoAV1TimingInfoFlags
    {
        /// <inheritdoc cref="_equalPictureInterval"/>
        public bool EqualPictureInterval
        {
            get => BitFields.HasFlag(_equalPictureInterval, 0);
            set => BitFields.SetFlag(ref _equalPictureInterval, 0, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 1, length: 31);
            set => BitFields.SetRange(ref _reserved, start: 1, length: 31, value);
        }
    }
}
