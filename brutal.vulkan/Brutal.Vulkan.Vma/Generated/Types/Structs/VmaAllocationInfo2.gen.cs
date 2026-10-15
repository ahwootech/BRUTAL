namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VmaAllocationInfo2
    {
        [FieldOffset(0)]
        public VmaAllocationInfo AllocationInfo;

        [FieldOffset(56)]
        public ByteSize BlockSize;

        [FieldOffset(64)]
        public Bool32 DedicatedMemory;
    }
}
