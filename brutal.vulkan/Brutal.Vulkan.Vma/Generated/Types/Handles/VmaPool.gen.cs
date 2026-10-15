namespace Brutal.VulkanApi.Vma
{
    public readonly struct VmaPool : IVulkanHandle
    {
        public VkObjectType VkObjectType => VkObjectType.Unknown;
        public nint VkHandle { get; }

        public VmaPool(nint handle)
        {
            VkHandle = handle;
        }

        public bool IsNull()
        {
            return VkHandle == 0;
        }
    }
}
