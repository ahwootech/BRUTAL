namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VmaStatistics
    {
        [FieldOffset(0)]
        public uint BlockCount;

        [FieldOffset(4)]
        public uint AllocationCount;

        [FieldOffset(8)]
        public ByteSize BlockBytes;

        [FieldOffset(16)]
        public ByteSize AllocationBytes;
    }
}
