namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct StdVideoDecodeH264ReferenceInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoDecodeH264ReferenceInfoFlags Flags;

        /// <summary>
        ///     <c>FrameNum</c>
        /// </summary>
        [FieldOffset(4)]
        public ushort FrameNum;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(6)]
        public ushort Reserved;

        /// <summary>
        ///     <c>PicOrderCnt</c>
        /// </summary>
        [FieldOffset(8)]
        public int2 PicOrderCnt;
    }
}
