namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayout.html">VkDescriptorSetLayout</see> - Opaque handle to a descriptor set layout object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A descriptor set layout object is defined by an array of zero or more
    ///         descriptor bindings.
    ///         Each individual descriptor binding is specified by a descriptor type, a
    ///         count (array size) of the number of descriptors in the binding, a set of
    ///         shader stages that <i>can</i> access the binding, and (if using immutable
    ///         samplers) an array of sampler descriptors.
    ///     </para>
    ///     <para>
    ///         Descriptor set layout objects are represented by <c>VkDescriptorSetLayout</c>
    ///         handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDescriptorSetLayout)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDescriptorSetLayout : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DescriptorSetLayout;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDescriptorSetLayout(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDescriptorSetLayout NullHandle = new();
    }
}
