namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct StdVideoVP9Segmentation()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoVP9SegmentationFlags Flags;

        ///
        [FieldOffset(4)]
        public fixed byte SegmentationTreeProbs[7];

        /// <summary>
        ///     <c>SegmentationPredProb</c>
        /// </summary>
        [FieldOffset(11)]
        public byte3 SegmentationPredProb;

        ///
        [FieldOffset(14)]
        public fixed byte FeatureEnabled[8];

        /// <summary>
        ///     <c>FeatureData</c>
        /// </summary>
        [FieldOffset(22)]
        public short_4_8 FeatureData;
    }
}
