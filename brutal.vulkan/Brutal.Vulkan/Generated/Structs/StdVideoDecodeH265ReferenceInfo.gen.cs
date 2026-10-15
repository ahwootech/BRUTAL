namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct StdVideoDecodeH265ReferenceInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoDecodeH265ReferenceInfoFlags Flags;

        /// <summary>
        ///     <c>PicOrderCntVal</c>
        /// </summary>
        [FieldOffset(4)]
        public int PicOrderCntVal;
    }
}
