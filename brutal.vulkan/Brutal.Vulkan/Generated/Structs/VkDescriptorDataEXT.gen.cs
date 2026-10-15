namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorDataEXT.html">VkDescriptorDataEXT</see> - Structure specifying descriptor data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Data describing the descriptor is passed in a <c>VkDescriptorDataEXT</c>
    ///         structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef union VkDescriptorDataEXT {
    ///             const VkSampler*                     pSampler;
    ///             const VkDescriptorImageInfo*         pCombinedImageSampler;
    ///             const VkDescriptorImageInfo*         pInputAttachmentImage;
    ///             const VkDescriptorImageInfo*         pSampledImage;
    ///             const VkDescriptorImageInfo*         pStorageImage;
    ///             const VkDescriptorAddressInfoEXT*    pUniformTexelBuffer;
    ///             const VkDescriptorAddressInfoEXT*    pStorageTexelBuffer;
    ///             const VkDescriptorAddressInfoEXT*    pUniformBuffer;
    ///             const VkDescriptorAddressInfoEXT*    pStorageBuffer;
    ///             VkDeviceAddress                      accelerationStructure;
    ///         } VkDescriptorDataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkDescriptorDataEXT()
    {
        /// <summary>
        ///     <c>Sampler</c> is a pointer to a <c>VkSampler</c> handle specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_SAMPLER</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkSampler* Sampler;

        /// <summary>
        ///     <c>CombinedImageSampler</c> is a pointer to a <c>VkDescriptorImageInfo</c> structure specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorImageInfo* CombinedImageSampler;

        /// <summary>
        ///     <c>InputAttachmentImage</c> is a pointer to a <c>VkDescriptorImageInfo</c> structure specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorImageInfo* InputAttachmentImage;

        /// <summary>
        ///     <c>SampledImage</c> is a pointer to a <c>VkDescriptorImageInfo</c> structure specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorImageInfo* SampledImage;

        /// <summary>
        ///     <c>StorageImage</c> is a pointer to a <c>VkDescriptorImageInfo</c> structure specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_STORAGE_IMAGE</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorImageInfo* StorageImage;

        /// <summary>
        ///     <c>UniformTexelBuffer</c> is a pointer to a <c>VkDescriptorAddressInfoEXT</c> structure specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* UniformTexelBuffer;

        /// <summary>
        ///     <c>StorageTexelBuffer</c> is a pointer to a <c>VkDescriptorAddressInfoEXT</c> structure specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* StorageTexelBuffer;

        /// <summary>
        ///     <c>UniformBuffer</c> is a pointer to a <c>VkDescriptorAddressInfoEXT</c> structure specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* UniformBuffer;

        /// <summary>
        ///     <c>StorageBuffer</c> is a pointer to a <c>VkDescriptorAddressInfoEXT</c> structure specifying the parameters of a <c>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER</c> descriptor.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* StorageBuffer;

        /// <summary>
        ///     <c>AccelerationStructure</c> is reserved for future use and is ignored.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress AccelerationStructure;
    }
}
