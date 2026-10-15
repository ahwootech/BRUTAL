namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VmaVirtualAllocationInfo
    {
        [FieldOffset(0)]
        public ByteSize Offset;

        [FieldOffset(8)]
        public ByteSize Size;

        [FieldOffset(16)]
        public Ptr PUserData;
    }
}
