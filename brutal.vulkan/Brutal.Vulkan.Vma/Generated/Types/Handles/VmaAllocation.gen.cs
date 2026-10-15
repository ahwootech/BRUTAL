namespace Brutal.VulkanApi.Vma
{
    public readonly struct VmaAllocation : IVulkanHandle
    {
        public VkObjectType VkObjectType => VkObjectType.Unknown;
        public nint VkHandle { get; }

        public VmaAllocation(nint handle)
        {
            VkHandle = handle;
        }

        public bool IsNull()
        {
            return VkHandle == 0;
        }
    }
}
