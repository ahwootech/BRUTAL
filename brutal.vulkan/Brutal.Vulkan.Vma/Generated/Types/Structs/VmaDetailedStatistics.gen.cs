namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VmaDetailedStatistics
    {
        [FieldOffset(0)]
        public VmaStatistics Statistics;

        [FieldOffset(24)]
        public uint UnusedRangeCount;

        [FieldOffset(32)]
        public ByteSize AllocationSizeMin;

        [FieldOffset(40)]
        public ByteSize AllocationSizeMax;

        [FieldOffset(48)]
        public ByteSize UnusedRangeSizeMin;

        [FieldOffset(56)]
        public ByteSize UnusedRangeSizeMax;
    }
}
