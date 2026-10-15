namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VmaVirtualAllocationCreateInfo
    {
        [FieldOffset(0)]
        public ByteSize Size;

        [FieldOffset(8)]
        public ByteSize Alignment;

        [FieldOffset(16)]
        public VmaVirtualAllocationCreateFlags Flags;

        [FieldOffset(24)]
        public Ptr PUserData;
    }
}
