namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct StdVideoAV1TimingInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoAV1TimingInfoFlags Flags;

        /// <summary>
        ///     <c>NumUnitsInDisplayTick</c>
        /// </summary>
        [FieldOffset(4)]
        public int NumUnitsInDisplayTick;

        /// <summary>
        ///     <c>TimeScale</c>
        /// </summary>
        [FieldOffset(8)]
        public int TimeScale;

        /// <summary>
        ///     <c>NumTicksPerPictureMinus_1</c>
        /// </summary>
        [FieldOffset(12)]
        public int NumTicksPerPictureMinus_1;
    }
}
