namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 3136)]
    public unsafe partial struct VmaTotalStatistics
    {
        [FieldOffset(0)]
        public VmaDetailedStatistics_32 MemoryType;

        [FieldOffset(2048)]
        public VmaDetailedStatistics_16 MemoryHeap;

        [FieldOffset(3072)]
        public VmaDetailedStatistics Total;
    }
}
