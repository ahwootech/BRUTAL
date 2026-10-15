namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VmaPoolCreateInfo
    {
        [FieldOffset(0)]
        public uint MemoryTypeIndex;

        [FieldOffset(4)]
        public VmaPoolCreateFlags Flags;

        [FieldOffset(8)]
        public ByteSize BlockSize;

        [FieldOffset(16)]
        public nuint MinBlockCount;

        [FieldOffset(24)]
        public nuint MaxBlockCount;

        [FieldOffset(32)]
        public float Priority;

        [FieldOffset(40)]
        public ByteSize MinAllocationAlignment;

        [FieldOffset(48)]
        public Ptr PMemoryAllocateNext;
    }
}
