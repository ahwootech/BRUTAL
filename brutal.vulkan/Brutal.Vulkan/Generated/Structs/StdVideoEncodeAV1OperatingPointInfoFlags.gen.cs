namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeAV1OperatingPointInfoFlags()
    {
        /// <summary>
        ///     <c>DecoderModelPresentForThisOp</c>
        /// </summary>
        [FieldOffset(0)]
        private int _decoderModelPresentForThisOp;

        /// <summary>
        ///     <c>LowDelayModeFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _lowDelayModeFlag;

        /// <summary>
        ///     <c>InitialDisplayDelayPresentForThisOp</c>
        /// </summary>
        [FieldOffset(0)]
        private int _initialDisplayDelayPresentForThisOp;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeAV1OperatingPointInfoFlags
    {
        /// <inheritdoc cref="_decoderModelPresentForThisOp"/>
        public bool DecoderModelPresentForThisOp
        {
            get => BitFields.HasFlag(_decoderModelPresentForThisOp, 0);
            set => BitFields.SetFlag(ref _decoderModelPresentForThisOp, 0, value);
        }

        /// <inheritdoc cref="_lowDelayModeFlag"/>
        public bool LowDelayModeFlag
        {
            get => BitFields.HasFlag(_lowDelayModeFlag, 1);
            set => BitFields.SetFlag(ref _lowDelayModeFlag, 1, value);
        }

        /// <inheritdoc cref="_initialDisplayDelayPresentForThisOp"/>
        public bool InitialDisplayDelayPresentForThisOp
        {
            get => BitFields.HasFlag(_initialDisplayDelayPresentForThisOp, 2);
            set => BitFields.SetFlag(ref _initialDisplayDelayPresentForThisOp, 2, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 3, length: 29);
            set => BitFields.SetRange(ref _reserved, start: 3, length: 29, value);
        }
    }
}
