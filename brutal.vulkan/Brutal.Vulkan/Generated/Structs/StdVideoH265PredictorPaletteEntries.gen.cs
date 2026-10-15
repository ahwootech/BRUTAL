namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 768)]
    public partial struct StdVideoH265PredictorPaletteEntries()
    {
        /// <summary>
        ///     <c>PredictorPaletteEntries</c>
        /// </summary>
        [FieldOffset(0)]
        public ushort_128_3 PredictorPaletteEntries;
    }
}
