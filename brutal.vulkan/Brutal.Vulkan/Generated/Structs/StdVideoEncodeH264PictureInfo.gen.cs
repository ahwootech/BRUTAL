namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct StdVideoEncodeH264PictureInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH264PictureInfoFlags Flags;

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
        ///     <c>IdrPicId</c>
        /// </summary>
        [FieldOffset(6)]
        public ushort IdrPicId;

        /// <summary>
        ///     <c>PrimaryPicType</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoH264PictureType PrimaryPicType;

        /// <summary>
        ///     <c>FrameNum</c>
        /// </summary>
        [FieldOffset(12)]
        public int FrameNum;

        /// <summary>
        ///     <c>PicOrderCnt</c>
        /// </summary>
        [FieldOffset(16)]
        public int PicOrderCnt;

        /// <summary>
        ///     <c>TemporalId</c>
        /// </summary>
        [FieldOffset(20)]
        public byte TemporalId;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(21)]
        public byte3 Reserved1;

        /// <summary>
        ///     <c>RefLists</c>
        /// </summary>
        [FieldOffset(24)]
        public StdVideoEncodeH264ReferenceListsInfo* RefLists;
    }
}
