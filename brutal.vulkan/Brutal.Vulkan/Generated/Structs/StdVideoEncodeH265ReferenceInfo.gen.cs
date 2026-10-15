namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct StdVideoEncodeH265ReferenceInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH265ReferenceInfoFlags Flags;

        /// <summary>
        ///     <c>PicType</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH265PictureType PicType;

        /// <summary>
        ///     <c>PicOrderCntVal</c>
        /// </summary>
        [FieldOffset(8)]
        public int PicOrderCntVal;

        /// <summary>
        ///     <c>TemporalId</c>
        /// </summary>
        [FieldOffset(12)]
        public byte TemporalId;
    }
}
