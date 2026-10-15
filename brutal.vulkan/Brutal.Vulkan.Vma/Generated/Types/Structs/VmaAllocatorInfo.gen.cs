namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VmaAllocatorInfo
    {
        [FieldOffset(0)]
        public VkInstance Instance;

        [FieldOffset(8)]
        public VkPhysicalDevice PhysicalDevice;

        [FieldOffset(16)]
        public VkDevice Device;
    }
}
