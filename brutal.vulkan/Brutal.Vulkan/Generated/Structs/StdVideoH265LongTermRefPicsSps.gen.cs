namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 132)]
    public unsafe partial struct StdVideoH265LongTermRefPicsSps()
    {
        /// <summary>
        ///     <c>UsedByCurrPicLtSpsFlag</c>
        /// </summary>
        [FieldOffset(0)]
        public int UsedByCurrPicLtSpsFlag;

        ///
        [FieldOffset(4)]
        public fixed int LtRefPicPocLsbSps[32];
    }
}
