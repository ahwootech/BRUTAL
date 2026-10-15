namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VmaAllocatorCreateInfo
    {
        [FieldOffset(0)]
        public VmaAllocatorCreateFlags Flags;

        [FieldOffset(8)]
        public VkPhysicalDevice PhysicalDevice;

        [FieldOffset(16)]
        public VkDevice Device;

        [FieldOffset(24)]
        public ByteSize PreferredLargeHeapBlockSize;

        [FieldOffset(32)]
        public Ptr<VkAllocationCallbacks> PAllocationCallbacks;

        [FieldOffset(40)]
        public Ptr<VmaDeviceMemoryCallbacks> PDeviceMemoryCallbacks;

        [FieldOffset(48)]
        public Ptr<ByteSize> PHeapSizeLimit;

        [FieldOffset(56)]
        public Ptr<VmaVulkanFunctions> PVulkanFunctions;

        [FieldOffset(64)]
        public VkInstance Instance;

        [FieldOffset(72)]
        public uint VulkanApiVersion;

        [FieldOffset(80)]
        public Ptr<Brutal.VulkanApi.VkFlags> PTypeExternalMemoryHandleTypes;
    }
}
