namespace Brutal.VulkanApi.Vma
{
    public readonly struct VmaVirtualBlock : IVulkanHandle
    {
        public VkObjectType VkObjectType => VkObjectType.Unknown;
        public nint VkHandle { get; }

        public VmaVirtualBlock(nint handle)
        {
            VkHandle = handle;
        }

        public bool IsNull()
        {
            return VkHandle == 0;
        }
    }
}
