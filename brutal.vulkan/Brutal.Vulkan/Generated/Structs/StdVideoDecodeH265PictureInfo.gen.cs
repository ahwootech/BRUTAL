namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct StdVideoDecodeH265PictureInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoDecodeH265PictureInfoFlags Flags;

        /// <summary>
        ///     <c>SpsVideoParameterSetId</c>
        /// </summary>
        [FieldOffset(4)]
        public byte SpsVideoParameterSetId;

        /// <summary>
        ///     <c>PpsSeqParameterSetId</c>
        /// </summary>
        [FieldOffset(5)]
        public byte PpsSeqParameterSetId;

        /// <summary>
        ///     <c>PpsPicParameterSetId</c>
        /// </summary>
        [FieldOffset(6)]
        public byte PpsPicParameterSetId;

        /// <summary>
        ///     <c>NumDeltaPocsOfRefRpsIdx</c>
        /// </summary>
        [FieldOffset(7)]
        public byte NumDeltaPocsOfRefRpsIdx;

        /// <summary>
        ///     <c>PicOrderCntVal</c>
        /// </summary>
        [FieldOffset(8)]
        public int PicOrderCntVal;

        /// <summary>
        ///     <c>NumBitsForSTRefPicSetInSlice</c>
        /// </summary>
        [FieldOffset(12)]
        public ushort NumBitsForSTRefPicSetInSlice;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(14)]
        public ushort Reserved;

        ///
        [FieldOffset(16)]
        public fixed byte RefPicSetStCurrBefore[8];

        ///
        [FieldOffset(24)]
        public fixed byte RefPicSetStCurrAfter[8];

        ///
        [FieldOffset(32)]
        public fixed byte RefPicSetLtCurr[8];
    }
}
