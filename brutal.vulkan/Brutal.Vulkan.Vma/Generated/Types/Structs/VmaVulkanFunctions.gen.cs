namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public unsafe partial struct VmaVulkanFunctions
    {
        [FieldOffset(0)]
        public VkGetInstanceProcAddr VkGetInstanceProcAddr;

        [FieldOffset(8)]
        public VkGetDeviceProcAddr VkGetDeviceProcAddr;

        [FieldOffset(16)]
        public VkGetPhysicalDeviceProperties VkGetPhysicalDeviceProperties;

        [FieldOffset(24)]
        public VkGetPhysicalDeviceMemoryProperties VkGetPhysicalDeviceMemoryProperties;

        [FieldOffset(32)]
        public VkAllocateMemory VkAllocateMemory;

        [FieldOffset(40)]
        public VkFreeMemory VkFreeMemory;

        [FieldOffset(48)]
        public VkMapMemory VkMapMemory;

        [FieldOffset(56)]
        public VkUnmapMemory VkUnmapMemory;

        [FieldOffset(64)]
        public VkFlushMappedMemoryRanges VkFlushMappedMemoryRanges;

        [FieldOffset(72)]
        public VkInvalidateMappedMemoryRanges VkInvalidateMappedMemoryRanges;

        [FieldOffset(80)]
        public VkBindBufferMemory VkBindBufferMemory;

        [FieldOffset(88)]
        public VkBindImageMemory VkBindImageMemory;

        [FieldOffset(96)]
        public VkGetBufferMemoryRequirements VkGetBufferMemoryRequirements;

        [FieldOffset(104)]
        public VkGetImageMemoryRequirements VkGetImageMemoryRequirements;

        [FieldOffset(112)]
        public VkCreateBuffer VkCreateBuffer;

        [FieldOffset(120)]
        public VkDestroyBuffer VkDestroyBuffer;

        [FieldOffset(128)]
        public VkCreateImage VkCreateImage;

        [FieldOffset(136)]
        public VkDestroyImage VkDestroyImage;

        [FieldOffset(144)]
        public VkCmdCopyBuffer VkCmdCopyBuffer;

        [FieldOffset(152)]
        public VkGetBufferMemoryRequirements2KHR VkGetBufferMemoryRequirements2KHR;

        [FieldOffset(160)]
        public VkGetImageMemoryRequirements2KHR VkGetImageMemoryRequirements2KHR;

        [FieldOffset(168)]
        public VkBindBufferMemory2KHR VkBindBufferMemory2KHR;

        [FieldOffset(176)]
        public VkBindImageMemory2KHR VkBindImageMemory2KHR;

        [FieldOffset(184)]
        public VkGetPhysicalDeviceMemoryProperties2KHR VkGetPhysicalDeviceMemoryProperties2KHR;

        [FieldOffset(192)]
        public VkGetDeviceBufferMemoryRequirementsKHR VkGetDeviceBufferMemoryRequirements;

        [FieldOffset(200)]
        public VkGetDeviceImageMemoryRequirementsKHR VkGetDeviceImageMemoryRequirements;

        [FieldOffset(208)]
        public Ptr VkGetMemoryWin32HandleKHR;

        [FieldOffset(216)]
        public VkGetPhysicalDeviceProperties2KHR VkGetPhysicalDeviceProperties2KHR;
    }
}
