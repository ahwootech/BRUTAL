namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplate.html">VkDescriptorUpdateTemplate</see> - Opaque handle to a descriptor update template
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A descriptor update template specifies a mapping from descriptor update
    ///         information in host memory to descriptors in a descriptor set.
    ///         It is designed to avoid passing redundant information to the driver when
    ///         frequently updating the same set of descriptors in descriptor sets.
    ///     </para>
    ///     <para>
    ///         Descriptor update template objects are represented by
    ///         <c>VkDescriptorUpdateTemplate</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDescriptorUpdateTemplate)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDescriptorUpdateTemplate : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DescriptorUpdateTemplate;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDescriptorUpdateTemplate(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDescriptorUpdateTemplate NullHandle = new();
    }
}
