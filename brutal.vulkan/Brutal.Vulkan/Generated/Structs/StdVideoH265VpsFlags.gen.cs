namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH265VpsFlags()
    {
        /// <summary>
        ///     <c>VpsTemporalIdNestingFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vpsTemporalIdNestingFlag;

        /// <summary>
        ///     <c>VpsSubLayerOrderingInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vpsSubLayerOrderingInfoPresentFlag;

        /// <summary>
        ///     <c>VpsTimingInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vpsTimingInfoPresentFlag;

        /// <summary>
        ///     <c>VpsPocProportionalToTimingFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vpsPocProportionalToTimingFlag;
    }

    public partial struct StdVideoH265VpsFlags
    {
        /// <inheritdoc cref="_vpsTemporalIdNestingFlag"/>
        public bool VpsTemporalIdNestingFlag
        {
            get => BitFields.HasFlag(_vpsTemporalIdNestingFlag, 0);
            set => BitFields.SetFlag(ref _vpsTemporalIdNestingFlag, 0, value);
        }

        /// <inheritdoc cref="_vpsSubLayerOrderingInfoPresentFlag"/>
        public bool VpsSubLayerOrderingInfoPresentFlag
        {
            get => BitFields.HasFlag(_vpsSubLayerOrderingInfoPresentFlag, 1);
            set => BitFields.SetFlag(ref _vpsSubLayerOrderingInfoPresentFlag, 1, value);
        }

        /// <inheritdoc cref="_vpsTimingInfoPresentFlag"/>
        public bool VpsTimingInfoPresentFlag
        {
            get => BitFields.HasFlag(_vpsTimingInfoPresentFlag, 2);
            set => BitFields.SetFlag(ref _vpsTimingInfoPresentFlag, 2, value);
        }

        /// <inheritdoc cref="_vpsPocProportionalToTimingFlag"/>
        public bool VpsPocProportionalToTimingFlag
        {
            get => BitFields.HasFlag(_vpsPocProportionalToTimingFlag, 3);
            set => BitFields.SetFlag(ref _vpsPocProportionalToTimingFlag, 3, value);
        }
    }
}
