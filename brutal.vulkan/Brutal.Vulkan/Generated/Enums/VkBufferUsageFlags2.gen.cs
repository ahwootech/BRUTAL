namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlagBits2.html">VkBufferUsageFlagBits2</see> - Bitmask controlling how a pipeline is created
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkBufferUsageFlags2CreateInfo::usage</c>,
    ///         specifying usage behavior of a buffer, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         // Flag bits for VkBufferUsageFlagBits2
    ///         typedef VkFlags64 VkBufferUsageFlagBits2;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT = 0x00000001ULL;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_TRANSFER_DST_BIT = 0x00000002ULL;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT = 0x00000004ULL;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT = 0x00000008ULL;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT = 0x00000010ULL;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT = 0x00000020ULL;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT = 0x00000040ULL;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT = 0x00000080ULL;
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT = 0x00000100ULL;
    ///             // Provided by VK_VERSION_1_4
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT = 0x00020000ULL;
    ///             // Provided by VK_AMDX_shader_enqueue with VK_VERSION_1_4 or VK_KHR_extended_flags or VK_KHR_maintenance5
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_EXECUTION_GRAPH_SCRATCH_BIT_AMDX = 0x02000000ULL;
    ///             #endif
    ///             // Provided by VK_EXT_descriptor_heap
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_DESCRIPTOR_HEAP_BIT_EXT = 0x10000000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_opacity_micromap, VK_EXT_opacity_micromap with VK_KHR_maintenance5 or VK_VERSION_1_4
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT = 0x00800000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_opacity_micromap, VK_EXT_opacity_micromap with VK_KHR_maintenance5 or VK_VERSION_1_4
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT = 0x01000000ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR = 0x00000001ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR = 0x00000002ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR = 0x00000004ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR = 0x00000008ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR = 0x00000010ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR = 0x00000020ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR = 0x00000040ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR = 0x00000080ULL;
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR = 0x00000100ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_conditional_rendering, VK_KHR_maintenance5 with VK_EXT_conditional_rendering
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 0x00000200ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_ray_tracing_pipeline, VK_KHR_maintenance5 with VK_KHR_ray_tracing_pipeline
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR = 0x00000400ULL;
    ///             // Provided by VK_KHR_maintenance5 with VK_NV_ray_tracing
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_RAY_TRACING_BIT_NV = 0x00000400ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_transform_feedback, VK_KHR_maintenance5 with VK_EXT_transform_feedback
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = 0x00000800ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_transform_feedback, VK_KHR_maintenance5 with VK_EXT_transform_feedback
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = 0x00001000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_decode_queue, VK_KHR_maintenance5 with VK_KHR_video_decode_queue
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR = 0x00002000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_decode_queue, VK_KHR_maintenance5 with VK_KHR_video_decode_queue
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR = 0x00004000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_encode_queue, VK_KHR_maintenance5 with VK_KHR_video_encode_queue
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR = 0x00008000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_video_encode_queue, VK_KHR_maintenance5 with VK_KHR_video_encode_queue
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR = 0x00010000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_VERSION_1_2 or VK_KHR_buffer_device_address or VK_EXT_buffer_device_address, VK_KHR_maintenance5 with VK_VERSION_1_2 or VK_KHR_buffer_device_address or VK_EXT_buffer_device_address
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR = 0x00020000ULL;
    ///             // Provided by VK_KHR_acceleration_structure with VK_KHR_extended_flags, VK_KHR_acceleration_structure with VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = 0x00080000ULL;
    ///             // Provided by VK_KHR_acceleration_structure with VK_KHR_extended_flags, VK_KHR_acceleration_structure with VK_KHR_maintenance5
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = 0x00100000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_descriptor_buffer, VK_KHR_maintenance5 with VK_EXT_descriptor_buffer
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT = 0x00200000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_descriptor_buffer, VK_KHR_maintenance5 with VK_EXT_descriptor_buffer
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT = 0x00400000ULL;
    ///             // Provided by VK_KHR_extended_flags with VK_EXT_descriptor_buffer, VK_KHR_maintenance5 with VK_EXT_descriptor_buffer
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT = 0x04000000ULL;
    ///             // Provided by VK_AMDX_dense_geometry_format
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_COMPRESSED_DATA_DGF1_BIT_AMDX = 0x200000000ULL;
    ///             #endif
    ///             // Provided by VK_ARM_data_graph
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_DATA_GRAPH_FOREIGN_DESCRIPTOR_BIT_ARM = 0x20000000ULL;
    ///             // Provided by VK_QCOM_tile_memory_heap
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_TILE_MEMORY_BIT_QCOM = 0x08000000ULL;
    ///             // Provided by VK_EXT_memory_decompression
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_MEMORY_DECOMPRESSION_BIT_EXT = 0x100000000ULL;
    ///             // Provided by VK_EXT_device_generated_commands
    ///             static const VkBufferUsageFlagBits2 VK_BUFFER_USAGE_2_PREPROCESS_BUFFER_BIT_EXT = 0x80000000ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkBufferUsageFlags2 : ulong
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
        ///     <c>ExecutionGraphScratchBitAMDX</c>
        /// </summary>
        ExecutionGraphScratchBitAMDX = 0x02000000,

        /// <summary>
        ///     <c>DescriptorHeapBitEXT</c>
        /// </summary>
        DescriptorHeapBitEXT = 0x10000000,

        /// <summary>
        ///     <c>MicromapBuildInputReadOnlyBitEXT</c>
        /// </summary>
        MicromapBuildInputReadOnlyBitEXT = 0x00800000,

        /// <summary>
        ///     <c>MicromapStorageBitEXT</c>
        /// </summary>
        MicromapStorageBitEXT = 0x01000000,

        /// <summary>
        ///     <c>TransferSrcBitKHR</c>
        /// </summary>
        TransferSrcBitKHR = 0x00000001,

        /// <summary>
        ///     <c>TransferDstBitKHR</c>
        /// </summary>
        TransferDstBitKHR = 0x00000002,

        /// <summary>
        ///     <c>UniformTexelBufferBitKHR</c>
        /// </summary>
        UniformTexelBufferBitKHR = 0x00000004,

        /// <summary>
        ///     <c>StorageTexelBufferBitKHR</c>
        /// </summary>
        StorageTexelBufferBitKHR = 0x00000008,

        /// <summary>
        ///     <c>UniformBufferBitKHR</c>
        /// </summary>
        UniformBufferBitKHR = 0x00000010,

        /// <summary>
        ///     <c>StorageBufferBitKHR</c>
        /// </summary>
        StorageBufferBitKHR = 0x00000020,

        /// <summary>
        ///     <c>IndexBufferBitKHR</c>
        /// </summary>
        IndexBufferBitKHR = 0x00000040,

        /// <summary>
        ///     <c>VertexBufferBitKHR</c>
        /// </summary>
        VertexBufferBitKHR = 0x00000080,

        /// <summary>
        ///     <c>IndirectBufferBitKHR</c>
        /// </summary>
        IndirectBufferBitKHR = 0x00000100,

        /// <summary>
        ///     <c>ConditionalRenderingBitEXT</c>
        /// </summary>
        ConditionalRenderingBitEXT = 0x00000200,

        /// <summary>
        ///     <c>ShaderBindingTableBitKHR</c>
        /// </summary>
        ShaderBindingTableBitKHR = 0x00000400,

        /// <summary>
        ///     <c>RayTracingBitNV</c>
        /// </summary>
        RayTracingBitNV = 0x00000400,

        /// <summary>
        ///     <c>TransformFeedbackBufferBitEXT</c>
        /// </summary>
        TransformFeedbackBufferBitEXT = 0x00000800,

        /// <summary>
        ///     <c>TransformFeedbackCounterBufferBitEXT</c>
        /// </summary>
        TransformFeedbackCounterBufferBitEXT = 0x00001000,

        /// <summary>
        ///     <c>VideoDecodeSrcBitKHR</c>
        /// </summary>
        VideoDecodeSrcBitKHR = 0x00002000,

        /// <summary>
        ///     <c>VideoDecodeDstBitKHR</c>
        /// </summary>
        VideoDecodeDstBitKHR = 0x00004000,

        /// <summary>
        ///     <c>VideoEncodeDstBitKHR</c>
        /// </summary>
        VideoEncodeDstBitKHR = 0x00008000,

        /// <summary>
        ///     <c>VideoEncodeSrcBitKHR</c>
        /// </summary>
        VideoEncodeSrcBitKHR = 0x00010000,

        /// <summary>
        ///     <c>ShaderDeviceAddressBitKHR</c>
        /// </summary>
        ShaderDeviceAddressBitKHR = 0x00020000,

        /// <summary>
        ///     <c>AccelerationStructureBuildInputReadOnlyBitKHR</c>
        /// </summary>
        AccelerationStructureBuildInputReadOnlyBitKHR = 0x00080000,

        /// <summary>
        ///     <c>AccelerationStructureStorageBitKHR</c>
        /// </summary>
        AccelerationStructureStorageBitKHR = 0x00100000,

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
        ///     <c>CompressedDataDgf1BitAMDX</c>
        /// </summary>
        CompressedDataDgf1BitAMDX = 0x200000000,

        /// <summary>
        ///     <c>DataGraphForeignDescriptorBitARM</c>
        /// </summary>
        DataGraphForeignDescriptorBitARM = 0x20000000,

        /// <summary>
        ///     <c>TileMemoryBitQCOM</c>
        /// </summary>
        TileMemoryBitQCOM = 0x08000000,

        /// <summary>
        ///     <c>MemoryDecompressionBitEXT</c>
        /// </summary>
        MemoryDecompressionBitEXT = 0x100000000,

        /// <summary>
        ///     <c>PreprocessBufferBitEXT</c>
        /// </summary>
        PreprocessBufferBitEXT = 0x80000000,
    }
}
