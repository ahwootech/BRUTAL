namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccessFlagBits2.html">VkAccessFlagBits2</see> - Access flags for VkAccessFlags2
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in the <c>srcAccessMask</c> and <c>dstAccessMask</c>
    ///         members of <c>VkMemoryBarrier2</c>, <c>VkImageMemoryBarrier2</c>, and
    ///         <c>VkBufferMemoryBarrier2</c>, specifying access behavior, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         // Flag bits for VkAccessFlagBits2
    ///         typedef VkFlags64 VkAccessFlagBits2;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_NONE = 0ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT = 0x00000001ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_INDEX_READ_BIT = 0x00000002ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT = 0x00000004ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_UNIFORM_READ_BIT = 0x00000008ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT = 0x00000010ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_READ_BIT = 0x00000020ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_WRITE_BIT = 0x00000040ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT = 0x00000080ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT = 0x00000100ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT = 0x00000200ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = 0x00000400ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_TRANSFER_READ_BIT = 0x00000800ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_TRANSFER_WRITE_BIT = 0x00001000ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_HOST_READ_BIT = 0x00002000ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_HOST_WRITE_BIT = 0x00004000ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_MEMORY_READ_BIT = 0x00008000ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_MEMORY_WRITE_BIT = 0x00010000ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_SAMPLED_READ_BIT = 0x100000000ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_STORAGE_READ_BIT = 0x200000000ULL;
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT = 0x400000000ULL;
    ///             // Provided by VK_KHR_video_decode_queue
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR = 0x800000000ULL;
    ///             // Provided by VK_KHR_video_decode_queue
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR = 0x1000000000ULL;
    ///             // Provided by VK_EXT_descriptor_heap
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SAMPLER_HEAP_READ_BIT_EXT = 0x200000000000000ULL;
    ///             // Provided by VK_EXT_descriptor_heap
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_RESOURCE_HEAP_READ_BIT_EXT = 0x400000000000000ULL;
    ///             // Provided by VK_KHR_video_encode_queue
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR = 0x2000000000ULL;
    ///             // Provided by VK_KHR_video_encode_queue
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR = 0x4000000000ULL;
    ///             // Provided by VK_QCOM_tile_shading
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_TILE_ATTACHMENT_READ_BIT_QCOM = 0x8000000000000ULL;
    ///             // Provided by VK_QCOM_tile_shading
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_TILE_ATTACHMENT_WRITE_BIT_QCOM = 0x10000000000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_NONE_KHR = 0ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR = 0x00000001ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_INDEX_READ_BIT_KHR = 0x00000002ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR = 0x00000004ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_UNIFORM_READ_BIT_KHR = 0x00000008ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR = 0x00000010ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_READ_BIT_KHR = 0x00000020ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_WRITE_BIT_KHR = 0x00000040ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR = 0x00000080ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR = 0x00000100ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR = 0x00000200ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR = 0x00000400ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_TRANSFER_READ_BIT_KHR = 0x00000800ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR = 0x00001000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_HOST_READ_BIT_KHR = 0x00002000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_HOST_WRITE_BIT_KHR = 0x00004000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_MEMORY_READ_BIT_KHR = 0x00008000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_MEMORY_WRITE_BIT_KHR = 0x00010000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR = 0x100000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR = 0x200000000ULL;
    ///             // Provided by VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR = 0x400000000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_transform_feedback
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = 0x02000000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_transform_feedback
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = 0x04000000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_transform_feedback
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = 0x08000000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_conditional_rendering
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT = 0x00100000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_device_generated_commands
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV = 0x00020000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_device_generated_commands
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV = 0x00040000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_device_generated_commands
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_EXT = 0x00020000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_device_generated_commands
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_EXT = 0x00040000ULL;
    ///             // Provided by VK_KHR_fragment_shading_rate with VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_shading_rate_image
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV = 0x00800000ULL;
    ///             // Provided by VK_KHR_acceleration_structure with VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR = 0x00200000ULL;
    ///             // Provided by VK_KHR_acceleration_structure with VK_KHR_synchronization2
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = 0x00400000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_ray_tracing
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV = 0x00200000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_NV_ray_tracing
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV = 0x00400000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_fragment_density_map
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = 0x01000000ULL;
    ///             // Provided by VK_KHR_synchronization2 with VK_EXT_blend_operation_advanced
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = 0x00080000ULL;
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_DESCRIPTOR_BUFFER_READ_BIT_EXT = 0x20000000000ULL;
    ///             // Provided by VK_HUAWEI_invocation_mask
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI = 0x8000000000ULL;
    ///             // Provided by VK_KHR_ray_tracing_maintenance1 with (VK_KHR_synchronization2 or VK_VERSION_1_3) and VK_KHR_ray_tracing_pipeline
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR = 0x10000000000ULL;
    ///             // Provided by VK_EXT_opacity_micromap
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_MICROMAP_READ_BIT_EXT = 0x100000000000ULL;
    ///             // Provided by VK_EXT_opacity_micromap
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_MICROMAP_WRITE_BIT_EXT = 0x200000000000ULL;
    ///             // Provided by VK_NV_optical_flow
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_OPTICAL_FLOW_READ_BIT_NV = 0x40000000000ULL;
    ///             // Provided by VK_NV_optical_flow
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_OPTICAL_FLOW_WRITE_BIT_NV = 0x80000000000ULL;
    ///             // Provided by VK_ARM_data_graph
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_DATA_GRAPH_READ_BIT_ARM = 0x800000000000ULL;
    ///             // Provided by VK_ARM_data_graph
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_DATA_GRAPH_WRITE_BIT_ARM = 0x1000000000000ULL;
    ///             // Provided by VK_EXT_memory_decompression
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_MEMORY_DECOMPRESSION_READ_BIT_EXT = 0x80000000000000ULL;
    ///             // Provided by VK_EXT_memory_decompression
    ///             static const VkAccessFlagBits2 VK_ACCESS_2_MEMORY_DECOMPRESSION_WRITE_BIT_EXT = 0x100000000000000ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkAccessFlags2 : ulong
    {
        /// <summary>
        ///     <c>None</c> specifies no accesses.
        /// </summary>
        None = 0,

        /// <summary>
        ///     <c>IndirectCommandReadBit</c> specifies read access to command data read from indirect buffers as part of an indirect drawing or dispatch command. Such access occurs in the <c>VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT</c> pipeline stage.
        /// </summary>
        IndirectCommandReadBit = 0x00000001,

        /// <summary>
        ///     <c>IndexReadBit</c> specifies read access to an index buffer as part of an indexed drawing command, bound by <c>vkCmdBindIndexBuffer</c>. Such access occurs in the <c>VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT</c> pipeline stage.
        /// </summary>
        IndexReadBit = 0x00000002,

        /// <summary>
        ///     <c>VertexAttributeReadBit</c> specifies read access to a vertex buffer as part of a drawing command, bound by <c>vkCmdBindVertexBuffers</c>. Such access occurs in the <c>VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT</c> pipeline stage.
        /// </summary>
        VertexAttributeReadBit = 0x00000004,

        /// <summary>
        ///     <c>UniformReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-uniformbuffer">uniform buffer^</see> in any shader pipeline stage.
        /// </summary>
        UniformReadBit = 0x00000008,

        /// <summary>
        ///     <c>InputAttachmentReadBit</c> specifies read access to an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">input attachment^</see> within a render pass during fragment shading. Such access occurs in the <c>VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT</c> pipeline stage.
        /// </summary>
        InputAttachmentReadBit = 0x00000010,

        /// <summary>
        ///     <c>ShaderReadBit</c>  is equivalent to the logical OR of: include::{generated}/sync/flagDefinitions/VK_ACCESS_2_SHADER_READ_BIT.adoc[]
        /// </summary>
        ShaderReadBit = 0x00000020,

        /// <summary>
        ///     <c>ShaderWriteBit</c> is equivalent to <c>VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT</c>.
        /// </summary>
        ShaderWriteBit = 0x00000040,

        /// <summary>
        ///     <c>ColorAttachmentReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">color attachment^</see>, such as via blending^], <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-logicop">logic operations^</see> or certain <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">render pass load operations^</see>. Such access occurs in the <c>VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT</c> pipeline stage.
        /// </summary>
        ColorAttachmentReadBit = 0x00000080,

        /// <summary>
        ///     <c>ColorAttachmentWriteBit</c> specifies write access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">color attachment^</see> during a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">render pass^</see> or via certain render pass <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">load^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-store-operations">store^</see>, and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-resolve-operations">multisample resolve^</see> operations. Such access occurs in the <c>VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT</c> pipeline stage.
        /// </summary>
        ColorAttachmentWriteBit = 0x00000100,

        /// <summary>
        ///     <c>DepthStencilAttachmentReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">depth/stencil attachment^</see>, via <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-ds-state">depth or stencil operations^</see> or certain <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">render pass load operations^</see>. Such access occurs in the <c>VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT</c> or <c>VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT</c> pipeline stages.
        /// </summary>
        DepthStencilAttachmentReadBit = 0x00000200,

        /// <summary>
        ///     <c>DepthStencilAttachmentWriteBit</c> specifies write access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">depth/stencil attachment^</see>, via <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-ds-state">depth or stencil operations^</see> or certain render pass <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">load^</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-store-operations">store^</see> operations. Such access occurs in the <c>VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT</c> or <c>VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT</c> pipeline stages.
        /// </summary>
        DepthStencilAttachmentWriteBit = 0x00000400,

        /// <summary>
        ///     <c>TransferReadBit</c> specifies read access to an image or buffer in a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#copies">copy^</see> operation. Such access occurs in the <c>VK_PIPELINE_STAGE_2_COPY_BIT</c>, <c>VK_PIPELINE_STAGE_2_BLIT_BIT</c>, or <c>VK_PIPELINE_STAGE_2_RESOLVE_BIT</c> pipeline stages.
        /// </summary>
        TransferReadBit = 0x00000800,

        /// <summary>
        ///     <c>TransferWriteBit</c> specifies write access to an image or buffer in a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#clears">clear^</see> or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#copies">copy^</see> operation. Such access occurs in the <c>VK_PIPELINE_STAGE_2_COPY_BIT</c>, <c>VK_PIPELINE_STAGE_2_BLIT_BIT</c>, <c>VK_PIPELINE_STAGE_2_CLEAR_BIT</c>, or <c>VK_PIPELINE_STAGE_2_RESOLVE_BIT</c> pipeline stages.
        /// </summary>
        TransferWriteBit = 0x00001000,

        /// <summary>
        ///     <c>HostReadBit</c> specifies read access by a host operation. Accesses of this type are not performed through a resource, but directly on memory. Such access occurs in the <c>VK_PIPELINE_STAGE_2_HOST_BIT</c> pipeline stage.
        /// </summary>
        HostReadBit = 0x00002000,

        /// <summary>
        ///     <c>HostWriteBit</c> specifies write access by a host operation. Accesses of this type are not performed through a resource, but directly on memory. Such access occurs in the <c>VK_PIPELINE_STAGE_2_HOST_BIT</c> pipeline stage.  Certain access types are only performed by a subset of pipeline stages, as described in more detail for <c>VkAccessFlags</c>. The <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-access-types-supported">Supported Access Types^</see> table lists, for each access flag, which pipeline stages <i>can</i> perform that type of access.  [NOTE]
        /// </summary>
        HostWriteBit = 0x00004000,

        /// <summary>
        ///     <c>MemoryReadBit</c> specifies all read accesses. It is always valid in any access mask, and is treated as equivalent to setting all etext:READ access flags that are valid where it is used.
        /// </summary>
        MemoryReadBit = 0x00008000,

        /// <summary>
        ///     <c>MemoryWriteBit</c> specifies all write accesses. It is always valid in any access mask, and is treated as equivalent to setting all etext:WRITE access flags that are valid where it is used.
        /// </summary>
        MemoryWriteBit = 0x00010000,

        /// <summary>
        ///     <c>ShaderSampledReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-uniformtexelbuffer">uniform texel buffer^</see> or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-sampledimage">sampled image^</see> in any shader pipeline stage.
        /// </summary>
        ShaderSampledReadBit = 0x100000000,

        /// <summary>
        ///     <c>ShaderStorageReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagebuffer">storage buffer^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagetexelbuffer">storage texel buffer^</see>, or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storageimage">storage image^</see> in any shader pipeline stage.
        /// </summary>
        ShaderStorageReadBit = 0x200000000,

        /// <summary>
        ///     <c>ShaderStorageWriteBit</c> specifies write access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagebuffer">storage buffer^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagetexelbuffer">storage texel buffer^</see>, or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storageimage">storage image^</see> in any shader pipeline stage.
        /// </summary>
        ShaderStorageWriteBit = 0x400000000,

        /// <summary>
        ///     <c>VideoDecodeReadBitKHR</c>
        /// </summary>
        VideoDecodeReadBitKHR = 0x800000000,

        /// <summary>
        ///     <c>VideoDecodeWriteBitKHR</c>
        /// </summary>
        VideoDecodeWriteBitKHR = 0x1000000000,

        /// <summary>
        ///     <c>SamplerHeapReadBitEXT</c>
        /// </summary>
        SamplerHeapReadBitEXT = 0x200000000000000,

        /// <summary>
        ///     <c>ResourceHeapReadBitEXT</c>
        /// </summary>
        ResourceHeapReadBitEXT = 0x400000000000000,

        /// <summary>
        ///     <c>VideoEncodeReadBitKHR</c>
        /// </summary>
        VideoEncodeReadBitKHR = 0x2000000000,

        /// <summary>
        ///     <c>VideoEncodeWriteBitKHR</c>
        /// </summary>
        VideoEncodeWriteBitKHR = 0x4000000000,

        /// <summary>
        ///     <c>ShaderTileAttachmentReadBitQCOM</c>
        /// </summary>
        ShaderTileAttachmentReadBitQCOM = 0x8000000000000,

        /// <summary>
        ///     <c>ShaderTileAttachmentWriteBitQCOM</c>
        /// </summary>
        ShaderTileAttachmentWriteBitQCOM = 0x10000000000000,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = 0,

        /// <summary>
        ///     <c>IndirectCommandReadBitKHR</c>
        /// </summary>
        IndirectCommandReadBitKHR = 0x00000001,

        /// <summary>
        ///     <c>IndexReadBitKHR</c>
        /// </summary>
        IndexReadBitKHR = 0x00000002,

        /// <summary>
        ///     <c>VertexAttributeReadBitKHR</c>
        /// </summary>
        VertexAttributeReadBitKHR = 0x00000004,

        /// <summary>
        ///     <c>UniformReadBitKHR</c>
        /// </summary>
        UniformReadBitKHR = 0x00000008,

        /// <summary>
        ///     <c>InputAttachmentReadBitKHR</c>
        /// </summary>
        InputAttachmentReadBitKHR = 0x00000010,

        /// <summary>
        ///     <c>ShaderReadBitKHR</c>
        /// </summary>
        ShaderReadBitKHR = 0x00000020,

        /// <summary>
        ///     <c>ShaderWriteBitKHR</c>
        /// </summary>
        ShaderWriteBitKHR = 0x00000040,

        /// <summary>
        ///     <c>ColorAttachmentReadBitKHR</c>
        /// </summary>
        ColorAttachmentReadBitKHR = 0x00000080,

        /// <summary>
        ///     <c>ColorAttachmentWriteBitKHR</c>
        /// </summary>
        ColorAttachmentWriteBitKHR = 0x00000100,

        /// <summary>
        ///     <c>DepthStencilAttachmentReadBitKHR</c>
        /// </summary>
        DepthStencilAttachmentReadBitKHR = 0x00000200,

        /// <summary>
        ///     <c>DepthStencilAttachmentWriteBitKHR</c>
        /// </summary>
        DepthStencilAttachmentWriteBitKHR = 0x00000400,

        /// <summary>
        ///     <c>TransferReadBitKHR</c>
        /// </summary>
        TransferReadBitKHR = 0x00000800,

        /// <summary>
        ///     <c>TransferWriteBitKHR</c>
        /// </summary>
        TransferWriteBitKHR = 0x00001000,

        /// <summary>
        ///     <c>HostReadBitKHR</c>
        /// </summary>
        HostReadBitKHR = 0x00002000,

        /// <summary>
        ///     <c>HostWriteBitKHR</c>
        /// </summary>
        HostWriteBitKHR = 0x00004000,

        /// <summary>
        ///     <c>MemoryReadBitKHR</c>
        /// </summary>
        MemoryReadBitKHR = 0x00008000,

        /// <summary>
        ///     <c>MemoryWriteBitKHR</c>
        /// </summary>
        MemoryWriteBitKHR = 0x00010000,

        /// <summary>
        ///     <c>ShaderSampledReadBitKHR</c>
        /// </summary>
        ShaderSampledReadBitKHR = 0x100000000,

        /// <summary>
        ///     <c>ShaderStorageReadBitKHR</c>
        /// </summary>
        ShaderStorageReadBitKHR = 0x200000000,

        /// <summary>
        ///     <c>ShaderStorageWriteBitKHR</c>
        /// </summary>
        ShaderStorageWriteBitKHR = 0x400000000,

        /// <summary>
        ///     <c>TransformFeedbackWriteBitEXT</c>
        /// </summary>
        TransformFeedbackWriteBitEXT = 0x02000000,

        /// <summary>
        ///     <c>TransformFeedbackCounterReadBitEXT</c>
        /// </summary>
        TransformFeedbackCounterReadBitEXT = 0x04000000,

        /// <summary>
        ///     <c>TransformFeedbackCounterWriteBitEXT</c>
        /// </summary>
        TransformFeedbackCounterWriteBitEXT = 0x08000000,

        /// <summary>
        ///     <c>ConditionalRenderingReadBitEXT</c>
        /// </summary>
        ConditionalRenderingReadBitEXT = 0x00100000,

        /// <summary>
        ///     <c>CommandPreprocessReadBitNV</c>
        /// </summary>
        CommandPreprocessReadBitNV = 0x00020000,

        /// <summary>
        ///     <c>CommandPreprocessWriteBitNV</c>
        /// </summary>
        CommandPreprocessWriteBitNV = 0x00040000,

        /// <summary>
        ///     <c>CommandPreprocessReadBitEXT</c>
        /// </summary>
        CommandPreprocessReadBitEXT = 0x00020000,

        /// <summary>
        ///     <c>CommandPreprocessWriteBitEXT</c>
        /// </summary>
        CommandPreprocessWriteBitEXT = 0x00040000,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentReadBitKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentReadBitKHR = 0x00800000,

        /// <summary>
        ///     <c>ShadingRateImageReadBitNV</c>
        /// </summary>
        ShadingRateImageReadBitNV = 0x00800000,

        /// <summary>
        ///     <c>AccelerationStructureReadBitKHR</c>
        /// </summary>
        AccelerationStructureReadBitKHR = 0x00200000,

        /// <summary>
        ///     <c>AccelerationStructureWriteBitKHR</c>
        /// </summary>
        AccelerationStructureWriteBitKHR = 0x00400000,

        /// <summary>
        ///     <c>AccelerationStructureReadBitNV</c>
        /// </summary>
        AccelerationStructureReadBitNV = 0x00200000,

        /// <summary>
        ///     <c>AccelerationStructureWriteBitNV</c>
        /// </summary>
        AccelerationStructureWriteBitNV = 0x00400000,

        /// <summary>
        ///     <c>FragmentDensityMapReadBitEXT</c>
        /// </summary>
        FragmentDensityMapReadBitEXT = 0x01000000,

        /// <summary>
        ///     <c>ColorAttachmentReadNoncoherentBitEXT</c>
        /// </summary>
        ColorAttachmentReadNoncoherentBitEXT = 0x00080000,

        /// <summary>
        ///     <c>DescriptorBufferReadBitEXT</c>
        /// </summary>
        DescriptorBufferReadBitEXT = 0x20000000000,

        /// <summary>
        ///     <c>InvocationMaskReadBitHUAWEI</c>
        /// </summary>
        InvocationMaskReadBitHUAWEI = 0x8000000000,

        /// <summary>
        ///     <c>ShaderBindingTableReadBitKHR</c>
        /// </summary>
        ShaderBindingTableReadBitKHR = 0x10000000000,

        /// <summary>
        ///     <c>MicromapReadBitEXT</c>
        /// </summary>
        MicromapReadBitEXT = 0x100000000000,

        /// <summary>
        ///     <c>MicromapWriteBitEXT</c>
        /// </summary>
        MicromapWriteBitEXT = 0x200000000000,

        /// <summary>
        ///     <c>OpticalFlowReadBitNV</c>
        /// </summary>
        OpticalFlowReadBitNV = 0x40000000000,

        /// <summary>
        ///     <c>OpticalFlowWriteBitNV</c>
        /// </summary>
        OpticalFlowWriteBitNV = 0x80000000000,

        /// <summary>
        ///     <c>DataGraphReadBitARM</c>
        /// </summary>
        DataGraphReadBitARM = 0x800000000000,

        /// <summary>
        ///     <c>DataGraphWriteBitARM</c>
        /// </summary>
        DataGraphWriteBitARM = 0x1000000000000,

        /// <summary>
        ///     <c>MemoryDecompressionReadBitEXT</c>
        /// </summary>
        MemoryDecompressionReadBitEXT = 0x80000000000000,

        /// <summary>
        ///     <c>MemoryDecompressionWriteBitEXT</c>
        /// </summary>
        MemoryDecompressionWriteBitEXT = 0x100000000000000,
    }
}
