namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct StdVideoEncodeH265PictureInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH265PictureInfoFlags Flags;

        /// <summary>
        ///     <c>PicType</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH265PictureType PicType;

        /// <summary>
        ///     <c>SpsVideoParameterSetId</c>
        /// </summary>
        [FieldOffset(8)]
        public byte SpsVideoParameterSetId;

        /// <summary>
        ///     <c>PpsSeqParameterSetId</c>
        /// </summary>
        [FieldOffset(9)]
        public byte PpsSeqParameterSetId;

        /// <summary>
        ///     <c>PpsPicParameterSetId</c>
        /// </summary>
        [FieldOffset(10)]
        public byte PpsPicParameterSetId;

        /// <summary>
        ///     <c>ShortTermRefPicSetIdx</c>
        /// </summary>
        [FieldOffset(11)]
        public byte ShortTermRefPicSetIdx;

        /// <summary>
        ///     <c>PicOrderCntVal</c>
        /// </summary>
        [FieldOffset(12)]
        public int PicOrderCntVal;

        /// <summary>
        ///     <c>TemporalId</c>
        /// </summary>
        [FieldOffset(16)]
        public byte TemporalId;

        ///
        [FieldOffset(17)]
        public fixed byte Reserved1[7];

        /// <summary>
        ///     <c>RefLists</c>
        /// </summary>
        [FieldOffset(24)]
        public StdVideoEncodeH265ReferenceListsInfo* RefLists;

        /// <summary>
        ///     <c>ShortTermRefPicSet</c>
        /// </summary>
        [FieldOffset(32)]
        public StdVideoH265ShortTermRefPicSet* ShortTermRefPicSet;

        /// <summary>
        ///     <c>LongTermRefPics</c>
        /// </summary>
        [FieldOffset(40)]
        public StdVideoEncodeH265LongTermRefPics* LongTermRefPics;
    }
}
