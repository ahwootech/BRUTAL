namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSet.html">VkDescriptorSet</see> - Opaque handle to a descriptor set object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Descriptor sets are allocated from descriptor pool objects, and are
    ///         represented by <c>VkDescriptorSet</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDescriptorSet)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDescriptorSet : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DescriptorSet;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDescriptorSet(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDescriptorSet NullHandle = new();
    }
}
