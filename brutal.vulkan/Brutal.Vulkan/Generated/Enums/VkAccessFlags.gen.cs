namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccessFlagBits.html">VkAccessFlagBits</see> - Bitmask specifying memory access types that will participate in a memory dependency
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in the <c>srcAccessMask</c> and <c>dstAccessMask</c>
    ///         members of <c>VkSubpassDependency</c>,
    ///         <c>VkMemoryBarrier</c>, <c>VkBufferMemoryBarrier</c>, and
    ///         <c>VkImageMemoryBarrier</c>, specifying access behavior, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkAccessFlagBits {
    ///             VK_ACCESS_INDIRECT_COMMAND_READ_BIT = 0x00000001,
    ///             VK_ACCESS_INDEX_READ_BIT = 0x00000002,
    ///             VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT = 0x00000004,
    ///             VK_ACCESS_UNIFORM_READ_BIT = 0x00000008,
    ///             VK_ACCESS_INPUT_ATTACHMENT_READ_BIT = 0x00000010,
    ///             VK_ACCESS_SHADER_READ_BIT = 0x00000020,
    ///             VK_ACCESS_SHADER_WRITE_BIT = 0x00000040,
    ///             VK_ACCESS_COLOR_ATTACHMENT_READ_BIT = 0x00000080,
    ///             VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT = 0x00000100,
    ///             VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT = 0x00000200,
    ///             VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = 0x00000400,
    ///             VK_ACCESS_TRANSFER_READ_BIT = 0x00000800,
    ///             VK_ACCESS_TRANSFER_WRITE_BIT = 0x00001000,
    ///             VK_ACCESS_HOST_READ_BIT = 0x00002000,
    ///             VK_ACCESS_HOST_WRITE_BIT = 0x00004000,
    ///             VK_ACCESS_MEMORY_READ_BIT = 0x00008000,
    ///             VK_ACCESS_MEMORY_WRITE_BIT = 0x00010000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_ACCESS_NONE = 0,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = 0x02000000,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = 0x04000000,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = 0x08000000,
    ///             // Provided by VK_EXT_conditional_rendering
    ///             VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT = 0x00100000,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = 0x00080000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_KHR = 0x00200000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = 0x00400000,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = 0x01000000,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_ACCESS_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_EXT = 0x00020000,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_EXT = 0x00040000,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_ACCESS_SHADING_RATE_IMAGE_READ_BIT_NV = VK_ACCESS_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_NV = VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_NV = VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_KHR,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_NV = VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_EXT,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_NV = VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_EXT,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_ACCESS_NONE_KHR = VK_ACCESS_NONE,
    ///         } VkAccessFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkAccessFlags : int
    {
        /// <summary>
        ///     <c>IndirectCommandReadBit</c> specifies read access to indirect command data read as part of an indirect drawing or dispatching command. Such access occurs in the <c>VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT</c> pipeline stage.
        /// </summary>
        IndirectCommandReadBit = 0x00000001,

        /// <summary>
        ///     <c>IndexReadBit</c> specifies read access to an index buffer as part of an indexed drawing command, bound by <c>vkCmdBindIndexBuffer</c>. Such access occurs in the <c>VK_PIPELINE_STAGE_VERTEX_INPUT_BIT</c> pipeline stage.
        /// </summary>
        IndexReadBit = 0x00000002,

        /// <summary>
        ///     <c>VertexAttributeReadBit</c> specifies read access to a vertex buffer as part of a drawing command, bound by <c>vkCmdBindVertexBuffers</c>. Such access occurs in the <c>VK_PIPELINE_STAGE_VERTEX_INPUT_BIT</c> pipeline stage.
        /// </summary>
        VertexAttributeReadBit = 0x00000004,

        /// <summary>
        ///     <c>UniformReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-uniformbuffer">uniform buffer^</see> in any shader pipeline stage.
        /// </summary>
        UniformReadBit = 0x00000008,

        /// <summary>
        ///     <c>InputAttachmentReadBit</c> specifies read access to an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">input attachment^</see> within a render pass during fragment shading. Such access occurs in the <c>VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT</c> pipeline stage.
        /// </summary>
        InputAttachmentReadBit = 0x00000010,

        /// <summary>
        ///     <c>ShaderReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-uniformtexelbuffer">uniform texel buffer^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-sampledimage">sampled image^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagebuffer">storage buffer^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagetexelbuffer">storage texel buffer^</see>, or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storageimage">storage image^</see> in any shader pipeline stage.
        /// </summary>
        ShaderReadBit = 0x00000020,

        /// <summary>
        ///     <c>ShaderWriteBit</c> specifies write access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagebuffer">storage buffer^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storagetexelbuffer">storage texel buffer^</see>, or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-storageimage">storage image^</see> in any shader pipeline stage.
        /// </summary>
        ShaderWriteBit = 0x00000040,

        /// <summary>
        ///     <c>ColorAttachmentReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">color attachment^</see>, such as via blending^], <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-logicop">logic operations^</see> or certain <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">render pass load operations^</see>. Such access occurs in the <c>VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT</c> pipeline stage.
        /// </summary>
        ColorAttachmentReadBit = 0x00000080,

        /// <summary>
        ///     <c>ColorAttachmentWriteBit</c> specifies write access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">color attachment^</see> during a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">render pass^</see> or via certain render pass <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">load^</see>, <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-store-operations">store^</see>, and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-resolve-operations">multisample resolve^</see> operations. Such access occurs in the <c>VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT</c> pipeline stage.
        /// </summary>
        ColorAttachmentWriteBit = 0x00000100,

        /// <summary>
        ///     <c>DepthStencilAttachmentReadBit</c> specifies read access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">depth/stencil attachment^</see>, via <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-ds-state">depth or stencil operations^</see> or certain <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">render pass load operations^</see>. Such access occurs in the <c>VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT</c> or <c>VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT</c> pipeline stages.
        /// </summary>
        DepthStencilAttachmentReadBit = 0x00000200,

        /// <summary>
        ///     <c>DepthStencilAttachmentWriteBit</c> specifies write access to a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">depth/stencil attachment^</see>, via <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-ds-state">depth or stencil operations^</see> or certain render pass <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">load^</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-store-operations">store^</see> operations. Such access occurs in the <c>VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT</c> or <c>VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT</c> pipeline stages.
        /// </summary>
        DepthStencilAttachmentWriteBit = 0x00000400,

        /// <summary>
        ///     <c>TransferReadBit</c> specifies read access to an image or buffer in a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#copies">copy^</see> operation.
        /// </summary>
        TransferReadBit = 0x00000800,

        /// <summary>
        ///     <c>TransferWriteBit</c> specifies write access to an image or buffer in a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#clears">clear^</see> or <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#copies">copy^</see> operation.
        /// </summary>
        TransferWriteBit = 0x00001000,

        /// <summary>
        ///     <c>HostReadBit</c> specifies read access by a host operation. Accesses of this type are not performed through a resource, but directly on memory. Such access occurs in the <c>VK_PIPELINE_STAGE_HOST_BIT</c> pipeline stage.
        /// </summary>
        HostReadBit = 0x00002000,

        /// <summary>
        ///     <c>HostWriteBit</c> specifies write access by a host operation. Accesses of this type are not performed through a resource, but directly on memory. Such access occurs in the <c>VK_PIPELINE_STAGE_HOST_BIT</c> pipeline stage.  Certain access types are only performed by a subset of pipeline stages. Any synchronization command that takes both stage masks and access masks uses both to define the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-dependencies-access-scopes">access scopes^</see> - only the specified access types performed by the specified stages are included in the access scope. An application <i>must</i> not specify an access flag in a synchronization command if it does not include a pipeline stage in the corresponding stage mask that is able to perform accesses of that type. The following table lists, for each access flag, which pipeline stages <i>can</i> perform that type of access.  [[synchronization-access-types-supported]] .Supported Access Types [cols=&quot;50,50&quot;,options=&quot;header&quot;] |
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
        ///     <c>None</c>
        /// </summary>
        None = 0,

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
        ///     <c>ColorAttachmentReadNoncoherentBitEXT</c>
        /// </summary>
        ColorAttachmentReadNoncoherentBitEXT = 0x00080000,

        /// <summary>
        ///     <c>AccelerationStructureReadBitKHR</c>
        /// </summary>
        AccelerationStructureReadBitKHR = 0x00200000,

        /// <summary>
        ///     <c>AccelerationStructureWriteBitKHR</c>
        /// </summary>
        AccelerationStructureWriteBitKHR = 0x00400000,

        /// <summary>
        ///     <c>FragmentDensityMapReadBitEXT</c>
        /// </summary>
        FragmentDensityMapReadBitEXT = 0x01000000,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentReadBitKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentReadBitKHR = 0x00800000,

        /// <summary>
        ///     <c>CommandPreprocessReadBitEXT</c>
        /// </summary>
        CommandPreprocessReadBitEXT = 0x00020000,

        /// <summary>
        ///     <c>CommandPreprocessWriteBitEXT</c>
        /// </summary>
        CommandPreprocessWriteBitEXT = 0x00040000,

        /// <summary>
        ///     <c>ShadingRateImageReadBitNV</c>
        /// </summary>
        ShadingRateImageReadBitNV = FragmentShadingRateAttachmentReadBitKHR,

        /// <summary>
        ///     <c>AccelerationStructureReadBitNV</c>
        /// </summary>
        AccelerationStructureReadBitNV = AccelerationStructureReadBitKHR,

        /// <summary>
        ///     <c>AccelerationStructureWriteBitNV</c>
        /// </summary>
        AccelerationStructureWriteBitNV = AccelerationStructureWriteBitKHR,

        /// <summary>
        ///     <c>CommandPreprocessReadBitNV</c>
        /// </summary>
        CommandPreprocessReadBitNV = CommandPreprocessReadBitEXT,

        /// <summary>
        ///     <c>CommandPreprocessWriteBitNV</c>
        /// </summary>
        CommandPreprocessWriteBitNV = CommandPreprocessWriteBitEXT,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = None,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
