namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VmaVirtualBlockCreateInfo
    {
        [FieldOffset(0)]
        public ByteSize Size;

        [FieldOffset(8)]
        public VmaVirtualBlockCreateFlags Flags;

        [FieldOffset(16)]
        public Ptr<VkAllocationCallbacks> PAllocationCallbacks;
    }
}
