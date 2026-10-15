namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VmaDefragmentationStats
    {
        [FieldOffset(0)]
        public ByteSize BytesMoved;

        [FieldOffset(8)]
        public ByteSize BytesFreed;

        [FieldOffset(16)]
        public uint AllocationsMoved;

        [FieldOffset(20)]
        public uint DeviceMemoryBlocksFreed;
    }
}
