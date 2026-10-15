namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VmaAllocationCreateInfo
    {
        [FieldOffset(0)]
        public VmaAllocationCreateFlags Flags;

        [FieldOffset(4)]
        public VmaMemoryUsage Usage;

        [FieldOffset(8)]
        public VkMemoryPropertyFlags RequiredFlags;

        [FieldOffset(12)]
        public VkMemoryPropertyFlags PreferredFlags;

        [FieldOffset(16)]
        public uint MemoryTypeBits;

        [FieldOffset(24)]
        public VmaPool Pool;

        [FieldOffset(32)]
        public Ptr PUserData;

        [FieldOffset(40)]
        public float Priority;

        [FieldOffset(48)]
        public ByteSize MinAlignment;
    }
}
