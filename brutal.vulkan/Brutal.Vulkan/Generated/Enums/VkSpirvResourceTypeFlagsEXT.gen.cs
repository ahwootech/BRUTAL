namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSpirvResourceTypeFlagBitsEXT.html">VkSpirvResourceTypeFlagBitsEXT</see> - Bitmask specifying different SPIR-V resource declarations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDescriptorSetAndBindingMappingEXT::resourceMask</c>, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef enum VkSpirvResourceTypeFlagBitsEXT {
    ///             VK_SPIRV_RESOURCE_TYPE_ALL_EXT = 0x7FFFFFFF,
    ///             VK_SPIRV_RESOURCE_TYPE_SAMPLER_BIT_EXT = 0x00000001,
    ///             VK_SPIRV_RESOURCE_TYPE_SAMPLED_IMAGE_BIT_EXT = 0x00000002,
    ///             VK_SPIRV_RESOURCE_TYPE_READ_ONLY_IMAGE_BIT_EXT = 0x00000004,
    ///             VK_SPIRV_RESOURCE_TYPE_READ_WRITE_IMAGE_BIT_EXT = 0x00000008,
    ///             VK_SPIRV_RESOURCE_TYPE_COMBINED_SAMPLED_IMAGE_BIT_EXT = 0x00000010,
    ///             VK_SPIRV_RESOURCE_TYPE_UNIFORM_BUFFER_BIT_EXT = 0x00000020,
    ///             VK_SPIRV_RESOURCE_TYPE_READ_ONLY_STORAGE_BUFFER_BIT_EXT = 0x00000040,
    ///             VK_SPIRV_RESOURCE_TYPE_READ_WRITE_STORAGE_BUFFER_BIT_EXT = 0x00000080,
    ///             // Provided by VK_EXT_descriptor_heap with VK_KHR_ray_tracing_pipeline or VK_NV_ray_tracing
    ///             VK_SPIRV_RESOURCE_TYPE_ACCELERATION_STRUCTURE_BIT_EXT = 0x00000100,
    ///             // Provided by VK_EXT_descriptor_heap with VK_ARM_tensors
    ///             VK_SPIRV_RESOURCE_TYPE_TENSOR_BIT_ARM = 0x00000200,
    ///         } VkSpirvResourceTypeFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSpirvResourceTypeFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>AllEXT</c> specifies that all resource declarations are included.
        /// </summary>
        AllEXT = 0x7FFFFFFF,

        /// <summary>
        ///     <c>SamplerBitEXT</c> specifies <c>OpTypeSampler</c> variables.
        /// </summary>
        SamplerBitEXT = 0x00000001,

        /// <summary>
        ///     <c>SampledImageBitEXT</c> specifies <c>OpTypeImage</c> variables with a <c>Sampled</c> parameter of 1.
        /// </summary>
        SampledImageBitEXT = 0x00000002,

        /// <summary>
        ///     <c>ReadOnlyImageBitEXT</c> specifies <c>OpTypeImage</c> variables with a <c>Sampled</c> parameter of 2 and decorated with <c>NonWritable</c>.
        /// </summary>
        ReadOnlyImageBitEXT = 0x00000004,

        /// <summary>
        ///     <c>ReadWriteImageBitEXT</c> specifies <c>OpTypeImage</c> variables with a <c>Sampled</c> parameter of 2 and not decorated with <c>NonWritable</c>.
        /// </summary>
        ReadWriteImageBitEXT = 0x00000008,

        /// <summary>
        ///     <c>CombinedSampledImageBitEXT</c> specifies <c>OpTypeSampledImage</c> variables.
        /// </summary>
        CombinedSampledImageBitEXT = 0x00000010,

        /// <summary>
        ///     <c>UniformBufferBitEXT</c> specifies <c>OpTypeStruct</c> variables in the <c>Uniform</c> storage class decorated with <c>Block</c>
        /// </summary>
        UniformBufferBitEXT = 0x00000020,

        /// <summary>
        ///     <c>ReadOnlyStorageBufferBitEXT</c> specifies <c>OpTypeStruct</c> variables either in the <c>StorageBuffer</c> storage class decorated with <c>Block</c> or in the <c>Uniform</c> storage class decorated with <c>BufferBlock</c>, and decorated with <c>NonWritable</c>
        /// </summary>
        ReadOnlyStorageBufferBitEXT = 0x00000040,

        /// <summary>
        ///     <c>ReadWriteStorageBufferBitEXT</c> specifies <c>OpTypeStruct</c> variables either in the <c>StorageBuffer</c> storage class decorated with <c>Block</c> or in the <c>Uniform</c> storage class decorated with <c>BufferBlock</c>, but not decorated with <c>NonWritable</c>
        /// </summary>
        ReadWriteStorageBufferBitEXT = 0x00000080,

        /// <summary>
        ///     <c>AccelerationStructureBitEXT</c>
        /// </summary>
        AccelerationStructureBitEXT = 0x00000100,

        /// <summary>
        ///     <c>TensorBitARM</c>
        /// </summary>
        TensorBitARM = 0x00000200,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
