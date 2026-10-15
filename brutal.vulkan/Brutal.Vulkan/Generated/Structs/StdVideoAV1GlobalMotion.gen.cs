namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public unsafe partial struct StdVideoAV1GlobalMotion()
    {
        ///
        [FieldOffset(0)]
        public fixed byte GmType[8];

        /// <summary>
        ///     <c>GmParams</c>
        /// </summary>
        [FieldOffset(8)]
        public int_6_8 GmParams;
    }
}
