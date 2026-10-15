namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct StdVideoAV1TileInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoAV1TileInfoFlags Flags;

        /// <summary>
        ///     <c>TileCols</c>
        /// </summary>
        [FieldOffset(4)]
        public byte TileCols;

        /// <summary>
        ///     <c>TileRows</c>
        /// </summary>
        [FieldOffset(5)]
        public byte TileRows;

        /// <summary>
        ///     <c>ContextUpdateTileId</c>
        /// </summary>
        [FieldOffset(6)]
        public ushort ContextUpdateTileId;

        /// <summary>
        ///     <c>TileSizeBytesMinus_1</c>
        /// </summary>
        [FieldOffset(8)]
        public byte TileSizeBytesMinus_1;

        ///
        [FieldOffset(9)]
        public fixed byte Reserved1[7];

        /// <summary>
        ///     <c>MiColStarts</c>
        /// </summary>
        [FieldOffset(16)]
        public ushort* MiColStarts;

        /// <summary>
        ///     <c>MiRowStarts</c>
        /// </summary>
        [FieldOffset(24)]
        public ushort* MiRowStarts;

        /// <summary>
        ///     <c>WidthInSbsMinus1</c>
        /// </summary>
        [FieldOffset(32)]
        public ushort* WidthInSbsMinus1;

        /// <summary>
        ///     <c>HeightInSbsMinus1</c>
        /// </summary>
        [FieldOffset(40)]
        public ushort* HeightInSbsMinus1;
    }
}
