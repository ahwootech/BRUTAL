namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public unsafe partial struct StdVideoAV1Segmentation()
    {
        ///
        [FieldOffset(0)]
        public fixed byte FeatureEnabled[8];

        /// <summary>
        ///     <c>FeatureData</c>
        /// </summary>
        [FieldOffset(8)]
        public short_8_8 FeatureData;
    }
}
