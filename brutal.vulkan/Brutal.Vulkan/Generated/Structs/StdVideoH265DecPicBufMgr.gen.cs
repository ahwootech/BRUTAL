namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public unsafe partial struct StdVideoH265DecPicBufMgr()
    {
        ///
        [FieldOffset(0)]
        public fixed int MaxLatencyIncreasePlus1[7];

        ///
        [FieldOffset(28)]
        public fixed byte MaxDecPicBufferingMinus1[7];

        ///
        [FieldOffset(35)]
        public fixed byte MaxNumReorderPics[7];
    }
}
