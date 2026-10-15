namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoAV1TileInfoFlags()
    {
        /// <summary>
        ///     <c>UniformTileSpacingFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _uniformTileSpacingFlag;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoAV1TileInfoFlags
    {
        /// <inheritdoc cref="_uniformTileSpacingFlag"/>
        public bool UniformTileSpacingFlag
        {
            get => BitFields.HasFlag(_uniformTileSpacingFlag, 0);
            set => BitFields.SetFlag(ref _uniformTileSpacingFlag, 0, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 1, length: 31);
            set => BitFields.SetRange(ref _reserved, start: 1, length: 31, value);
        }
    }
}
