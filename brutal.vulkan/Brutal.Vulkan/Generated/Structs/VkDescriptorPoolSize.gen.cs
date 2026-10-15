namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolSize.html">VkDescriptorPoolSize</see> - Structure specifying descriptor pool size
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDescriptorPoolSize</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDescriptorPoolSize {
    ///             VkDescriptorType    type;
    ///             uint32_t            descriptorCount;
    ///         } VkDescriptorPoolSize;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkDescriptorPoolSize()
    {
        /// <summary>
        ///     <c>Type</c> is the type of descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorType Type;

        /// <summary>
        ///     <c>DescriptorCount</c> is the number of descriptors of that type to allocate.
        /// </summary>
        [FieldOffset(4)]
        public int DescriptorCount;
    }
}
