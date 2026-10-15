namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct StdVideoAV1Quantization()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoAV1QuantizationFlags Flags;

        /// <summary>
        ///     <c>BaseQIdx</c>
        /// </summary>
        [FieldOffset(4)]
        public byte BaseQIdx;

        /// <summary>
        ///     <c>DeltaQYDc</c>
        /// </summary>
        [FieldOffset(5)]
        public byte DeltaQYDc;

        /// <summary>
        ///     <c>DeltaQUDc</c>
        /// </summary>
        [FieldOffset(6)]
        public byte DeltaQUDc;

        /// <summary>
        ///     <c>DeltaQUAc</c>
        /// </summary>
        [FieldOffset(7)]
        public byte DeltaQUAc;

        /// <summary>
        ///     <c>DeltaQVDc</c>
        /// </summary>
        [FieldOffset(8)]
        public byte DeltaQVDc;

        /// <summary>
        ///     <c>DeltaQVAc</c>
        /// </summary>
        [FieldOffset(9)]
        public byte DeltaQVAc;

        /// <summary>
        ///     <c>QmY</c>
        /// </summary>
        [FieldOffset(10)]
        public byte QmY;

        /// <summary>
        ///     <c>QmU</c>
        /// </summary>
        [FieldOffset(11)]
        public byte QmU;

        /// <summary>
        ///     <c>QmV</c>
        /// </summary>
        [FieldOffset(12)]
        public byte QmV;
    }
}
