namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct StdVideoEncodeH264WeightTableFlags()
    {
        /// <summary>
        ///     <c>LumaWeightL0Flag</c>
        /// </summary>
        [FieldOffset(0)]
        public int LumaWeightL0Flag;

        /// <summary>
        ///     <c>ChromaWeightL0Flag</c>
        /// </summary>
        [FieldOffset(4)]
        public int ChromaWeightL0Flag;

        /// <summary>
        ///     <c>LumaWeightL1Flag</c>
        /// </summary>
        [FieldOffset(8)]
        public int LumaWeightL1Flag;

        /// <summary>
        ///     <c>ChromaWeightL1Flag</c>
        /// </summary>
        [FieldOffset(12)]
        public int ChromaWeightL1Flag;
    }
}
