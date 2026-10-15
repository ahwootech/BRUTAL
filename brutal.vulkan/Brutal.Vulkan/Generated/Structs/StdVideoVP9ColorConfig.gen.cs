namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct StdVideoVP9ColorConfig()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoVP9ColorConfigFlags Flags;

        /// <summary>
        ///     <c>BitDepth</c>
        /// </summary>
        [FieldOffset(4)]
        public byte BitDepth;

        /// <summary>
        ///     <c>SubsamplingX</c>
        /// </summary>
        [FieldOffset(5)]
        public byte SubsamplingX;

        /// <summary>
        ///     <c>SubsamplingY</c>
        /// </summary>
        [FieldOffset(6)]
        public byte SubsamplingY;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(7)]
        public byte Reserved1;

        /// <summary>
        ///     <c>ColorSpace</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoVP9ColorSpace ColorSpace;
    }
}
