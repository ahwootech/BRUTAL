namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoAV1LoopFilterFlags()
    {
        /// <summary>
        ///     <c>LoopFilterDeltaEnabled</c>
        /// </summary>
        [FieldOffset(0)]
        private int _loopFilterDeltaEnabled;

        /// <summary>
        ///     <c>LoopFilterDeltaUpdate</c>
        /// </summary>
        [FieldOffset(0)]
        private int _loopFilterDeltaUpdate;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoAV1LoopFilterFlags
    {
        /// <inheritdoc cref="_loopFilterDeltaEnabled"/>
        public bool LoopFilterDeltaEnabled
        {
            get => BitFields.HasFlag(_loopFilterDeltaEnabled, 0);
            set => BitFields.SetFlag(ref _loopFilterDeltaEnabled, 0, value);
        }

        /// <inheritdoc cref="_loopFilterDeltaUpdate"/>
        public bool LoopFilterDeltaUpdate
        {
            get => BitFields.HasFlag(_loopFilterDeltaUpdate, 1);
            set => BitFields.SetFlag(ref _loopFilterDeltaUpdate, 1, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 2, length: 30);
            set => BitFields.SetRange(ref _reserved, start: 2, length: 30, value);
        }
    }
}
