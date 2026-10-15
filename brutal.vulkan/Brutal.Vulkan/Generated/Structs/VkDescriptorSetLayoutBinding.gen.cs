namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutBinding.html">VkDescriptorSetLayoutBinding</see> - Structure specifying a descriptor set layout binding
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDescriptorSetLayoutBinding</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDescriptorSetLayoutBinding {
    ///             uint32_t              binding;
    ///             VkDescriptorType      descriptorType;
    ///             uint32_t              descriptorCount;
    ///             VkShaderStageFlags    stageFlags;
    ///             const VkSampler*      pImmutableSamplers;
    ///         } VkDescriptorSetLayoutBinding;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDescriptorSetLayoutBinding()
    {
        /// <summary>
        ///     <c>Binding</c> is the binding number of this entry and corresponds to a resource of the same binding number in the shader stages.
        /// </summary>
        [FieldOffset(0)]
        public int Binding;

        /// <summary>
        ///     <c>DescriptorType</c> is a <c>VkDescriptorType</c> specifying which type of resource descriptors are used for this binding.
        /// </summary>
        [FieldOffset(4)]
        public VkDescriptorType DescriptorType;

        /// <summary>
        ///     <c>DescriptorCount</c> is the number of descriptors contained in the binding, accessed in a shader as an array. If <c>descriptorCount</c> is zero this binding entry is reserved and the resource <i>must</i> not be accessed from any stage via this binding within any pipeline using the set layout.
        /// </summary>
        [FieldOffset(8)]
        public int DescriptorCount;

        /// <summary>
        ///     <c>StageFlags</c> member is a bitmask of <c>VkShaderStageFlags</c> specifying which pipeline shader stages <i>can</i> access a resource for this binding. <c>VK_SHADER_STAGE_ALL</c> is a shorthand specifying that all defined shader stages, including any additional stages defined by extensions, <i>can</i> access the resource. + If a shader stage is not included in <c>stageFlags</c>, then a resource <i>must</i> not be accessed from that stage via this binding within any pipeline using the set layout. Other than input attachments which are limited to the fragment shader, there are no limitations on what combinations of stages <i>can</i> use a descriptor binding, and in particular a binding <i>can</i> be used by both graphics stages and the compute stage.
        /// </summary>
        [FieldOffset(12)]
        public VkShaderStageFlags StageFlags;

        /// <summary>
        ///     <c>ImmutableSamplers</c> affects initialization of samplers. If <c>descriptorType</c> specifies a <c>VK_DESCRIPTOR_TYPE_SAMPLER</c> or <c>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</c> type descriptor, then <c>pImmutableSamplers</c> <i>can</i> be used to initialize a set of <i>immutable samplers</i>. Immutable samplers are permanently bound into the set layout and <i>must</i> not be changed; updating a <c>VK_DESCRIPTOR_TYPE_SAMPLER</c> descriptor with immutable samplers is not allowed and updates to a <c>VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER</c> descriptor with immutable samplers does not modify the samplers (the image views are updated, but the sampler updates are ignored). If <c>pImmutableSamplers</c> is not `NULL`, then it is a pointer to an array of sampler handles that will be copied into the set layout and used for the corresponding binding. Only the sampler handles are copied; the sampler objects <i>must</i> not be destroyed before the final use of the set layout and any descriptor pools and sets created using it. If <c>pImmutableSamplers</c> is `NULL`, then the sampler slots are dynamic and sampler handles <i>must</i> be bound into descriptor sets using this layout. If <c>descriptorType</c> is not one of these descriptor types, then <c>pImmutableSamplers</c> is ignored.
        /// </summary>
        [FieldOffset(16)]
        public VkSampler* ImmutableSamplers;
    }
}
