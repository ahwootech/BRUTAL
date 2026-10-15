namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct StdVideoEncodeH264ReferenceInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH264ReferenceInfoFlags Flags;

        /// <summary>
        ///     <c>PrimaryPicType</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH264PictureType PrimaryPicType;

        /// <summary>
        ///     <c>FrameNum</c>
        /// </summary>
        [FieldOffset(8)]
        public int FrameNum;

        /// <summary>
        ///     <c>PicOrderCnt</c>
        /// </summary>
        [FieldOffset(12)]
        public int PicOrderCnt;

        /// <summary>
        ///     <c>LongTermPicNum</c>
        /// </summary>
        [FieldOffset(16)]
        public ushort LongTermPicNum;

        /// <summary>
        ///     <c>LongTermFrameIdx</c>
        /// </summary>
        [FieldOffset(18)]
        public ushort LongTermFrameIdx;

        /// <summary>
        ///     <c>TemporalId</c>
        /// </summary>
        [FieldOffset(20)]
        public byte TemporalId;
    }
}
