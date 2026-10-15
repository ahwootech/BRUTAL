namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct StdVideoDecodeH264PictureInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoDecodeH264PictureInfoFlags Flags;

        /// <summary>
        ///     <c>SeqParameterSetId</c>
        /// </summary>
        [FieldOffset(4)]
        public byte SeqParameterSetId;

        /// <summary>
        ///     <c>PicParameterSetId</c>
        /// </summary>
        [FieldOffset(5)]
        public byte PicParameterSetId;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(6)]
        public byte Reserved1;

        /// <summary>
        ///     <c>Reserved2</c>
        /// </summary>
        [FieldOffset(7)]
        public byte Reserved2;

        /// <summary>
        ///     <c>FrameNum</c>
        /// </summary>
        [FieldOffset(8)]
        public ushort FrameNum;

        /// <summary>
        ///     <c>IdrPicId</c>
        /// </summary>
        [FieldOffset(10)]
        public ushort IdrPicId;

        /// <summary>
        ///     <c>PicOrderCnt</c>
        /// </summary>
        [FieldOffset(12)]
        public int2 PicOrderCnt;
    }
}
