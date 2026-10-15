namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 404)]
    public unsafe partial struct StdVideoEncodeH264WeightTable()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH264WeightTableFlags Flags;

        /// <summary>
        ///     <c>LumaLog2WeightDenom</c>
        /// </summary>
        [FieldOffset(16)]
        public byte LumaLog2WeightDenom;

        /// <summary>
        ///     <c>ChromaLog2WeightDenom</c>
        /// </summary>
        [FieldOffset(17)]
        public byte ChromaLog2WeightDenom;

        ///
        [FieldOffset(18)]
        public fixed byte LumaWeightL0[32];

        ///
        [FieldOffset(50)]
        public fixed byte LumaOffsetL0[32];

        /// <summary>
        ///     <c>ChromaWeightL0</c>
        /// </summary>
        [FieldOffset(82)]
        public byte_2_32 ChromaWeightL0;

        /// <summary>
        ///     <c>ChromaOffsetL0</c>
        /// </summary>
        [FieldOffset(146)]
        public byte_2_32 ChromaOffsetL0;

        ///
        [FieldOffset(210)]
        public fixed byte LumaWeightL1[32];

        ///
        [FieldOffset(242)]
        public fixed byte LumaOffsetL1[32];

        /// <summary>
        ///     <c>ChromaWeightL1</c>
        /// </summary>
        [FieldOffset(274)]
        public byte_2_32 ChromaWeightL1;

        /// <summary>
        ///     <c>ChromaOffsetL1</c>
        /// </summary>
        [FieldOffset(338)]
        public byte_2_32 ChromaOffsetL1;
    }
}
