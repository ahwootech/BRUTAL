namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlagBits.html">VkBufferUsageFlagBits</see> - Bitmask specifying allowed usage of a buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkBufferCreateInfo::usage</c>, specifying
    ///         usage behavior of a buffer, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkBufferUsageFlagBits {
    ///             VK_BUFFER_USAGE_TRANSFER_SRC_BIT = 0x00000001,
    ///             VK_BUFFER_USAGE_TRANSFER_DST_BIT = 0x00000002,
    ///             VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = 0x00000004,
    ///             VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = 0x00000008,
    ///             VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = 0x00000010,
    ///             VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = 0x00000020,
    ///             VK_BUFFER_USAGE_INDEX_BUFFER_BIT = 0x00000040,
    ///             VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = 0x00000080,
    ///             VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = 0x00000100,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT = 0x00020000,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_BUFFER_USAGE_VIDEO_DECODE_SRC_BIT_KHR = 0x00002000,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_BUFFER_USAGE_VIDEO_DECODE_DST_BIT_KHR = 0x00004000,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = 0x00000800,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = 0x00001000,
    ///             // Provided by VK_EXT_conditional_rendering
    ///             VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT = 0x00000200,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_shader_enqueue
    ///             VK_BUFFER_USAGE_EXECUTION_GRAPH_SCRATCH_BIT_AMDX = 0x02000000,
    ///             #endif
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_BUFFER_USAGE_DESCRIPTOR_HEAP_BIT_EXT = 0x10000000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = 0x00080000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = 0x00100000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR = 0x00000400,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_BUFFER_USAGE_VIDEO_ENCODE_DST_BIT_KHR = 0x00008000,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_BUFFER_USAGE_VIDEO_ENCODE_SRC_BIT_KHR = 0x00010000,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT = 0x00200000,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT = 0x00400000,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_BUFFER_USAGE_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT = 0x04000000,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_BUFFER_USAGE_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT = 0x00800000,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_BUFFER_USAGE_MICROMAP_STORAGE_BIT_EXT = 0x01000000,
    ///             // Provided by VK_QCOM_tile_memory_heap
    ///             VK_BUFFER_USAGE_TILE_MEMORY_BIT_QCOM = 0x08000000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_BUFFER_USAGE_RAY_TRACING_BIT_NV = VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR,
    ///             // Provided by VK_EXT_buffer_device_address
    ///             VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_EXT = VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT_KHR = VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT,
    ///         } VkBufferUsageFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkBufferUsageFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>TransferSrcBit</c> specifies that the buffer <i>can</i> be used as the source of a <i>transfer command</i> (see the definition of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-pipeline-stages-transfer"><c>VK_PIPELINE_STAGE_TRANSFER_BIT</c>^</see>).
        /// </summary>
        TransferSrcBit = 0x00000001,

        /// <summary>
        ///     <c>TransferDstBit</c> specifies that the buffer <i>can</i> be used as the destination of a transfer command.
        /// </summary>
        TransferDstBit = 0x00000002,

        /// <summary>
        ///     <c>UniformTexelBufferBit</c> specifies that the buffer <i>can</i> be used to create a <c>VkBufferView</c> suitable for occupying a <c>VkDescriptorSet</c> slot of type <c>VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER</c>.
        /// </summary>
        UniformTexelBufferBit = 0x00000004,

        /// <summary>
        ///     <c>StorageTexelBufferBit</c> specifies that the buffer <i>can</i> be used to create a <c>VkBufferView</c> suitable for occupying a <c>VkDescriptorSet</c> slot of type <c>VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER</c>.
        /// </summary>
        StorageTexelBufferBit = 0x00000008,

        /// <summary>
        ///     <c>UniformBufferBit</c> specifies that the buffer <i>can</i> be used in a <c>VkDescriptorBufferInfo</c> suitable for occupying a <c>VkDescriptorSet</c> slot either of type <c>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER</c> or <c>VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC</c>.
        /// </summary>
        UniformBufferBit = 0x00000010,

        /// <summary>
        ///     <c>StorageBufferBit</c> specifies that the buffer <i>can</i> be used in a <c>VkDescriptorBufferInfo</c> suitable for occupying a <c>VkDescriptorSet</c> slot either of type <c>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER</c> or <c>VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC</c>.
        /// </summary>
        StorageBufferBit = 0x00000020,

        /// <summary>
        ///     <c>IndexBufferBit</c> specifies that the buffer is suitable for passing as the <c>buffer</c> parameter to <c>vkCmdBindIndexBuffer</c>.
        /// </summary>
        IndexBufferBit = 0x00000040,

        /// <summary>
        ///     <c>VertexBufferBit</c> specifies that the buffer is suitable for passing as an element of the <c>pBuffers</c> array to <c>vkCmdBindVertexBuffers</c>.
        /// </summary>
        VertexBufferBit = 0x00000080,

        /// <summary>
        ///     <c>IndirectBufferBit</c> specifies that the buffer is suitable for passing as the <c>buffer</c> parameter to <c>vkCmdDrawIndirect</c>, <c>vkCmdDrawIndexedIndirect</c>, or <c>vkCmdDispatchIndirect</c>.
        /// </summary>
        IndirectBufferBit = 0x00000100,

        /// <summary>
        ///     <c>ShaderDeviceAddressBit</c>
        /// </summary>
        ShaderDeviceAddressBit = 0x00020000,

        /// <summary>
        ///     <c>VideoDecodeSrcBitKHR</c>
        /// </summary>
        VideoDecodeSrcBitKHR = 0x00002000,

        /// <summary>
        ///     <c>VideoDecodeDstBitKHR</c>
        /// </summary>
        VideoDecodeDstBitKHR = 0x00004000,

        /// <summary>
        ///     <c>TransformFeedbackBufferBitEXT</c>
        /// </summary>
        TransformFeedbackBufferBitEXT = 0x00000800,

        /// <summary>
        ///     <c>TransformFeedbackCounterBufferBitEXT</c>
        /// </summary>
        TransformFeedbackCounterBufferBitEXT = 0x00001000,

        /// <summary>
        ///     <c>ConditionalRenderingBitEXT</c>
        /// </summary>
        ConditionalRenderingBitEXT = 0x00000200,

        /// <summary>
        ///     <c>ExecutionGraphScratchBitAMDX</c>
        /// </summary>
        ExecutionGraphScratchBitAMDX = 0x02000000,

        /// <summary>
        ///     <c>DescriptorHeapBitEXT</c>
        /// </summary>
        DescriptorHeapBitEXT = 0x10000000,

        /// <summary>
        ///     <c>AccelerationStructureBuildInputReadOnlyBitKHR</c>
        /// </summary>
        AccelerationStructureBuildInputReadOnlyBitKHR = 0x00080000,

        /// <summary>
        ///     <c>AccelerationStructureStorageBitKHR</c>
        /// </summary>
        AccelerationStructureStorageBitKHR = 0x00100000,

        /// <summary>
        ///     <c>ShaderBindingTableBitKHR</c>
        /// </summary>
        ShaderBindingTableBitKHR = 0x00000400,

        /// <summary>
        ///     <c>VideoEncodeDstBitKHR</c>
        /// </summary>
        VideoEncodeDstBitKHR = 0x00008000,

        /// <summary>
        ///     <c>VideoEncodeSrcBitKHR</c>
        /// </summary>
        VideoEncodeSrcBitKHR = 0x00010000,

        /// <summary>
        ///     <c>SamplerDescriptorBufferBitEXT</c>
        /// </summary>
        SamplerDescriptorBufferBitEXT = 0x00200000,

        /// <summary>
        ///     <c>ResourceDescriptorBufferBitEXT</c>
        /// </summary>
        ResourceDescriptorBufferBitEXT = 0x00400000,

        /// <summary>
        ///     <c>PushDescriptorsDescriptorBufferBitEXT</c>
        /// </summary>
        PushDescriptorsDescriptorBufferBitEXT = 0x04000000,

        /// <summary>
        ///     <c>MicromapBuildInputReadOnlyBitEXT</c>
        /// </summary>
        MicromapBuildInputReadOnlyBitEXT = 0x00800000,

        /// <summary>
        ///     <c>MicromapStorageBitEXT</c>
        /// </summary>
        MicromapStorageBitEXT = 0x01000000,

        /// <summary>
        ///     <c>TileMemoryBitQCOM</c>
        /// </summary>
        TileMemoryBitQCOM = 0x08000000,

        /// <summary>
        ///     <c>RayTracingBitNV</c>
        /// </summary>
        RayTracingBitNV = ShaderBindingTableBitKHR,

        /// <summary>
        ///     <c>ShaderDeviceAddressBitEXT</c>
        /// </summary>
        ShaderDeviceAddressBitEXT = ShaderDeviceAddressBit,

        /// <summary>
        ///     <c>ShaderDeviceAddressBitKHR</c>
        /// </summary>
        ShaderDeviceAddressBitKHR = ShaderDeviceAddressBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
