namespace Brutal.VulkanApi.Vma
{
    public readonly struct VmaDefragmentationContext : IVulkanHandle
    {
        public VkObjectType VkObjectType => VkObjectType.Unknown;
        public nint VkHandle { get; }

        public VmaDefragmentationContext(nint handle)
        {
            VkHandle = handle;
        }

        public bool IsNull()
        {
            return VkHandle == 0;
        }
    }
}
