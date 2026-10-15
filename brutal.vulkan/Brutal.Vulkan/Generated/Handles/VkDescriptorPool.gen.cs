namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorPool.html">VkDescriptorPool</see> - Opaque handle to a descriptor pool object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A <i>descriptor pool</i> maintains a pool of descriptors, from which descriptor
    ///         sets are allocated.
    ///         Descriptor pools are externally synchronized, meaning that the application
    ///         <i>must</i> not allocate and/or free descriptor sets from the same pool in
    ///         multiple threads simultaneously.
    ///     </para>
    ///     <para>
    ///         Descriptor pools are represented by <c>VkDescriptorPool</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDescriptorPool)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDescriptorPool : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DescriptorPool;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDescriptorPool(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDescriptorPool NullHandle = new();
    }
}
