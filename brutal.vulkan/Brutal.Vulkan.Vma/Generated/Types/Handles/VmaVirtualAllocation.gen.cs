namespace Brutal.VulkanApi.Vma
{
    public readonly struct VmaVirtualAllocation : IVulkanHandle
    {
        public VkObjectType VkObjectType => VkObjectType.Unknown;
        public nint VkHandle { get; }

        public VmaVirtualAllocation(nint handle)
        {
            VkHandle = handle;
        }

        public bool IsNull()
        {
            return VkHandle == 0;
        }
    }
}
