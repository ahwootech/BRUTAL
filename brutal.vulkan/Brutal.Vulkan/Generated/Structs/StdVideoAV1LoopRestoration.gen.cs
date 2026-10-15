namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct StdVideoAV1LoopRestoration()
    {
        /// <summary>
        ///     <c>FrameRestorationType</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoAV1FrameRestorationType_3 FrameRestorationType;

        /// <summary>
        ///     <c>LoopRestorationSize</c>
        /// </summary>
        [FieldOffset(12)]
        public ushort3 LoopRestorationSize;
    }
}
