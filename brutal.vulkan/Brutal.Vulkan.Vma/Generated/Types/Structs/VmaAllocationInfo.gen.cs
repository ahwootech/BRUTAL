namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VmaAllocationInfo
    {
        [FieldOffset(0)]
        public uint MemoryType;

        [FieldOffset(8)]
        public VkDeviceMemory DeviceMemory;

        [FieldOffset(16)]
        public ByteSize Offset;

        [FieldOffset(24)]
        public ByteSize Size;

        [FieldOffset(32)]
        public Ptr PMappedData;

        [FieldOffset(40)]
        public Ptr PUserData;

        [FieldOffset(48)]
        public Ptr<byte> PName;
    }
}
