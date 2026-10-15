namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 190)]
    public unsafe partial struct StdVideoEncodeH265WeightTable()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH265WeightTableFlags Flags;

        /// <summary>
        ///     <c>LumaLog2WeightDenom</c>
        /// </summary>
        [FieldOffset(8)]
        public byte LumaLog2WeightDenom;

        /// <summary>
        ///     <c>DeltaChromaLog2WeightDenom</c>
        /// </summary>
        [FieldOffset(9)]
        public byte DeltaChromaLog2WeightDenom;

        ///
        [FieldOffset(10)]
        public fixed byte DeltaLumaWeightL0[15];

        ///
        [FieldOffset(25)]
        public fixed byte LumaOffsetL0[15];

        /// <summary>
        ///     <c>DeltaChromaWeightL0</c>
        /// </summary>
        [FieldOffset(40)]
        public byte_2_15 DeltaChromaWeightL0;

        /// <summary>
        ///     <c>DeltaChromaOffsetL0</c>
        /// </summary>
        [FieldOffset(70)]
        public byte_2_15 DeltaChromaOffsetL0;

        ///
        [FieldOffset(100)]
        public fixed byte DeltaLumaWeightL1[15];

        ///
        [FieldOffset(115)]
        public fixed byte LumaOffsetL1[15];

        /// <summary>
        ///     <c>DeltaChromaWeightL1</c>
        /// </summary>
        [FieldOffset(130)]
        public byte_2_15 DeltaChromaWeightL1;

        /// <summary>
        ///     <c>DeltaChromaOffsetL1</c>
        /// </summary>
        [FieldOffset(160)]
        public byte_2_15 DeltaChromaOffsetL1;
    }
}
