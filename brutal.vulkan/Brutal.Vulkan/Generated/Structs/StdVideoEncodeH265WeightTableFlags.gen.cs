namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct StdVideoEncodeH265WeightTableFlags()
    {
        /// <summary>
        ///     <c>LumaWeightL0Flag</c>
        /// </summary>
        [FieldOffset(0)]
        public ushort LumaWeightL0Flag;

        /// <summary>
        ///     <c>ChromaWeightL0Flag</c>
        /// </summary>
        [FieldOffset(2)]
        public ushort ChromaWeightL0Flag;

        /// <summary>
        ///     <c>LumaWeightL1Flag</c>
        /// </summary>
        [FieldOffset(4)]
        public ushort LumaWeightL1Flag;

        /// <summary>
        ///     <c>ChromaWeightL1Flag</c>
        /// </summary>
        [FieldOffset(6)]
        public ushort ChromaWeightL1Flag;
    }
}
