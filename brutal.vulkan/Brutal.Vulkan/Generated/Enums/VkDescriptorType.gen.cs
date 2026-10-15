namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorType.html">VkDescriptorType</see> - Specifies the type of a descriptor in a descriptor set
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible descriptor types are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkDescriptorType {
    ///             VK_DESCRIPTOR_TYPE_SAMPLER = 0,
    ///             VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER = 1,
    ///             VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE = 2,
    ///             VK_DESCRIPTOR_TYPE_STORAGE_IMAGE = 3,
    ///             VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER = 4,
    ///             VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER = 5,
    ///             VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER = 6,
    ///             VK_DESCRIPTOR_TYPE_STORAGE_BUFFER = 7,
    ///             VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC = 8,
    ///             VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC = 9,
    ///             VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT = 10,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK = 1000138000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR = 1000150000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV = 1000165000,
    ///             // Provided by VK_QCOM_image_processing
    ///             VK_DESCRIPTOR_TYPE_SAMPLE_WEIGHT_IMAGE_QCOM = 1000440000,
    ///             // Provided by VK_QCOM_image_processing
    ///             VK_DESCRIPTOR_TYPE_BLOCK_MATCH_IMAGE_QCOM = 1000440001,
    ///             // Provided by VK_ARM_tensors
    ///             VK_DESCRIPTOR_TYPE_TENSOR_ARM = 1000460000,
    ///             // Provided by VK_EXT_mutable_descriptor_type
    ///             VK_DESCRIPTOR_TYPE_MUTABLE_EXT = 1000351000,
    ///             // Provided by VK_NV_partitioned_acceleration_structure
    ///             VK_DESCRIPTOR_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_NV = 1000570000,
    ///             // Provided by VK_EXT_inline_uniform_block
    ///             VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK_EXT = VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK,
    ///             // Provided by VK_VALVE_mutable_descriptor_type
    ///             VK_DESCRIPTOR_TYPE_MUTABLE_VALVE = VK_DESCRIPTOR_TYPE_MUTABLE_EXT,
    ///         } VkDescriptorType;
    ///     </code>
    /// </remarks>
    public enum VkDescriptorType : int
    {
        /// <summary>
        ///     <c>Sampler</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-sampler">sampler descriptor^</see>.
        /// </summary>
        Sampler = 0,

        /// <summary>
        ///     <c>CombinedImageSampler</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-combinedimagesampler">combined image sampler descriptor^</see>.
        /// </summary>
        CombinedImageSampler = 1,

        /// <summary>
        ///     <c>SampledImage</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-sampledimage">sampled image descriptor^</see>.
        /// </summary>
        SampledImage = 2,

        /// <summary>
        ///     <c>StorageImage</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storageimage">storage image descriptor^</see>.
        /// </summary>
        StorageImage = 3,

        /// <summary>
        ///     <c>UniformTexelBuffer</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-uniformtexelbuffer">uniform texel buffer descriptor^</see>.
        /// </summary>
        UniformTexelBuffer = 4,

        /// <summary>
        ///     <c>StorageTexelBuffer</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagetexelbuffer">storage texel buffer descriptor^</see>.
        /// </summary>
        StorageTexelBuffer = 5,

        /// <summary>
        ///     <c>UniformBuffer</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-uniformbuffer">uniform buffer descriptor^</see>.
        /// </summary>
        UniformBuffer = 6,

        /// <summary>
        ///     <c>StorageBuffer</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagebuffer">storage buffer descriptor^</see>.
        /// </summary>
        StorageBuffer = 7,

        /// <summary>
        ///     <c>UniformBufferDynamic</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-uniformbufferdynamic">dynamic uniform buffer descriptor^</see>.
        /// </summary>
        UniformBufferDynamic = 8,

        /// <summary>
        ///     <c>StorageBufferDynamic</c> specifies a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagebufferdynamic">dynamic storage buffer descriptor^</see>.
        /// </summary>
        StorageBufferDynamic = 9,

        /// <summary>
        ///     <c>InputAttachment</c> specifies an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-inputattachment">input attachment descriptor^</see>.
        /// </summary>
        InputAttachment = 10,

        /// <summary>
        ///     <c>InlineUniformBlock</c>
        /// </summary>
        InlineUniformBlock = 1000138000,

        /// <summary>
        ///     <c>AccelerationStructureKHR</c>
        /// </summary>
        AccelerationStructureKHR = 1000150000,

        /// <summary>
        ///     <c>AccelerationStructureNV</c>
        /// </summary>
        AccelerationStructureNV = 1000165000,

        /// <summary>
        ///     <c>SampleWeightImageQCOM</c>
        /// </summary>
        SampleWeightImageQCOM = 1000440000,

        /// <summary>
        ///     <c>BlockMatchImageQCOM</c>
        /// </summary>
        BlockMatchImageQCOM = 1000440001,

        /// <summary>
        ///     <c>TensorARM</c>
        /// </summary>
        TensorARM = 1000460000,

        /// <summary>
        ///     <c>MutableEXT</c>
        /// </summary>
        MutableEXT = 1000351000,

        /// <summary>
        ///     <c>PartitionedAccelerationStructureNV</c>
        /// </summary>
        PartitionedAccelerationStructureNV = 1000570000,

        /// <summary>
        ///     <c>InlineUniformBlockEXT</c>
        /// </summary>
        InlineUniformBlockEXT = InlineUniformBlock,

        /// <summary>
        ///     <c>MutableVALVE</c>
        /// </summary>
        MutableVALVE = MutableEXT,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
