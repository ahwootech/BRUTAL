namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorImageInfo.html">VkDescriptorImageInfo</see> - Structure specifying descriptor image information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDescriptorImageInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDescriptorImageInfo {
    ///             VkSampler        sampler;
    ///             VkImageView      imageView;
    ///             VkImageLayout    imageLayout;
    ///         } VkDescriptorImageInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkDescriptorImageInfo()
    {
        /// <summary>
        ///     <c>Sampler</c> is a sampler handle, and is used in descriptor updates for types <c>VK_DESCRIPTOR_TYPE_SAMPLER</c> and <c>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</c> if the binding being updated does not use immutable samplers.
        /// </summary>
        [FieldOffset(0)]
        public VkSampler Sampler;

        /// <summary>
        ///     <c>ImageView</c> is an image view handle, and is used in descriptor updates for types <c>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE</c>, <c>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE</c>, <c>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</c>, and <c>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT</c>.
        /// </summary>
        [FieldOffset(8)]
        public VkImageView ImageView;

        /// <summary>
        ///     <c>ImageLayout</c> is the layout that the image subresources accessible from <c>imageView</c> will be in at the time this descriptor is accessed. <c>imageLayout</c> is used in descriptor updates for types <c>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE</c>, <c>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE</c>, <c>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</c>, and <c>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkImageLayout ImageLayout;
    }
}
