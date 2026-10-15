namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageLayout.html">VkImageLayout</see> - Layout of image and image subresources
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The set of image layouts consists of:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkImageLayout {
    ///             VK_IMAGE_LAYOUT_UNDEFINED = 0,
    ///             VK_IMAGE_LAYOUT_GENERAL = 1,
    ///             VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = 2,
    ///             VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = 3,
    ///             VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = 4,
    ///             VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = 5,
    ///             VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL = 6,
    ///             VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL = 7,
    ///             VK_IMAGE_LAYOUT_PREINITIALIZED = 8,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL = 1000117000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL = 1000117001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL = 1000241000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL = 1000241001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL = 1000241002,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL = 1000241003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL = 1000314000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL = 1000314001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ = 1000232000,
    ///             // Provided by VK_KHR_swapchain
    ///             VK_IMAGE_LAYOUT_PRESENT_SRC_KHR = 1000001002,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_IMAGE_LAYOUT_VIDEO_DECODE_DST_KHR = 1000024000,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_IMAGE_LAYOUT_VIDEO_DECODE_SRC_KHR = 1000024001,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_IMAGE_LAYOUT_VIDEO_DECODE_DPB_KHR = 1000024002,
    ///             // Provided by VK_KHR_shared_presentable_image
    ///             VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR = 1000111000,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT = 1000218000,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR = 1000164003,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_IMAGE_LAYOUT_VIDEO_ENCODE_DST_KHR = 1000299000,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_IMAGE_LAYOUT_VIDEO_ENCODE_SRC_KHR = 1000299001,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_IMAGE_LAYOUT_VIDEO_ENCODE_DPB_KHR = 1000299002,
    ///             // Provided by VK_EXT_attachment_feedback_loop_layout
    ///             VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT = 1000339000,
    ///             // Provided by VK_ARM_tensors
    ///             VK_IMAGE_LAYOUT_TENSOR_ALIASING_ARM = 1000460000,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_IMAGE_LAYOUT_VIDEO_ENCODE_QUANTIZATION_MAP_KHR = 1000553000,
    ///             // Provided by VK_EXT_zero_initialize_device_memory
    ///             VK_IMAGE_LAYOUT_ZERO_INITIALIZED_EXT = 1000620000,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV = VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR,
    ///             // Provided by VK_KHR_dynamic_rendering_local_read
    ///             VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ_KHR = VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ,
    ///             // Provided by VK_KHR_separate_depth_stencil_layouts
    ///             VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL,
    ///             // Provided by VK_KHR_separate_depth_stencil_layouts
    ///             VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL,
    ///             // Provided by VK_KHR_separate_depth_stencil_layouts
    ///             VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL,
    ///             // Provided by VK_KHR_separate_depth_stencil_layouts
    ///             VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL_KHR = VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL_KHR = VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL,
    ///         } VkImageLayout;
    ///     </code>
    /// </remarks>
    public enum VkImageLayout : int
    {
        /// <summary>
        ///     <c>Undefined</c> specifies that the layout is unknown. Image memory cannot: be transitioned into this layout. This layout <i>can</i> be used as the <c>initialLayout</c> member of <c>VkImageCreateInfo</c>. This layout <i>can</i> be used in place of the current image layout in a layout transition, but doing so will cause the contents of the image&apos;s memory to be undefined:.
        /// </summary>
        Undefined = 0,

        /// <summary>
        ///     <c>General</c> supports all types of device access, unless specified otherwise.
        /// </summary>
        General = 1,

        /// <summary>
        ///     <c>ColorAttachmentOptimal</c> <i>must</i> only be used as a color or resolve attachment in a <c>VkFramebuffer</c>. This layout is valid only for image subresources of images created with the <c>VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT</c> usage flag set.
        /// </summary>
        ColorAttachmentOptimal = 2,

        /// <summary>
        ///     <c>DepthStencilAttachmentOptimal</c> specifies a layout for both the depth and stencil aspects of a depth/stencil format image allowing read and write access as a depth/stencil attachment.
        /// </summary>
        DepthStencilAttachmentOptimal = 3,

        /// <summary>
        ///     <c>DepthStencilReadOnlyOptimal</c> specifies a layout for both the depth and stencil aspects of a depth/stencil format image allowing read only access as a depth/stencil attachment or in shaders as a sampled image, combined image/sampler, or input attachment.
        /// </summary>
        DepthStencilReadOnlyOptimal = 4,

        /// <summary>
        ///     <c>ShaderReadOnlyOptimal</c> specifies a layout allowing read-only access in a shader as a sampled image, combined image/sampler, or input attachment. This layout is valid only for image subresources of images created with the <c>VK_IMAGE_USAGE_SAMPLED_BIT</c> or <c>VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT</c> usage bits enabled.
        /// </summary>
        ShaderReadOnlyOptimal = 5,

        /// <summary>
        ///     <c>TransferSrcOptimal</c> <i>must</i> only be used as a source image of a transfer command (see the definition of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-pipeline-stages-transfer"><c>VK_PIPELINE_STAGE_TRANSFER_BIT</c>^</see>). This layout is valid only for image subresources of images created with the <c>VK_IMAGE_USAGE_TRANSFER_SRC_BIT</c> usage flag set.
        /// </summary>
        TransferSrcOptimal = 6,

        /// <summary>
        ///     <c>TransferDstOptimal</c> <i>must</i> only be used as a destination image of a transfer command. This layout is valid only for image subresources of images created with the <c>VK_IMAGE_USAGE_TRANSFER_DST_BIT</c> usage flag set.  The layout of each image subresource is not a state of the image subresource itself, but is rather a property of how the data in memory is organized, and thus for each mechanism of accessing an image in the API the application <i>must</i> specify a parameter or structure member that indicates which image layout the image subresource(s) are considered to be in when the image will be accessed. For transfer commands, this is a parameter to the command (see <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#clears">here</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#copies">here</see>). For use as a framebuffer attachment, this is a member in the substructures of the <c>VkRenderPassCreateInfo</c> (see <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass">Render Pass^</see>). For use in a descriptor set, this is a member in the <c>VkDescriptorImageInfo</c> structure (see <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#descriptors-sets-updates">here</see>).
        /// </summary>
        TransferDstOptimal = 7,

        /// <summary>
        ///     <c>Preinitialized</c> specifies that an image&apos;s memory is in a defined layout and <i>can</i> be populated by data, but that it has not yet been initialized by the driver. Image memory cannot: be transitioned into this layout. This layout <i>can</i> be used as the <c>initialLayout</c> member of <c>VkImageCreateInfo</c>. This layout is intended to be used as the initial layout for an image whose contents are written by the host, and hence the data <i>can</i> be written to memory immediately, without first executing a layout transition. Currently, <c>VK_IMAGE_LAYOUT_PREINITIALIZED</c> is only useful with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#glossary-linear-resource">linear^</see> images because there is not a standard layout defined for <c>VK_IMAGE_TILING_OPTIMAL</c> images.
        /// </summary>
        Preinitialized = 8,

        /// <summary>
        ///     <c>DepthReadOnlyStencilAttachmentOptimal</c>
        /// </summary>
        DepthReadOnlyStencilAttachmentOptimal = 1000117000,

        /// <summary>
        ///     <c>DepthAttachmentStencilReadOnlyOptimal</c>
        /// </summary>
        DepthAttachmentStencilReadOnlyOptimal = 1000117001,

        /// <summary>
        ///     <c>DepthAttachmentOptimal</c>
        /// </summary>
        DepthAttachmentOptimal = 1000241000,

        /// <summary>
        ///     <c>DepthReadOnlyOptimal</c>
        /// </summary>
        DepthReadOnlyOptimal = 1000241001,

        /// <summary>
        ///     <c>StencilAttachmentOptimal</c>
        /// </summary>
        StencilAttachmentOptimal = 1000241002,

        /// <summary>
        ///     <c>StencilReadOnlyOptimal</c>
        /// </summary>
        StencilReadOnlyOptimal = 1000241003,

        /// <summary>
        ///     <c>ReadOnlyOptimal</c>
        /// </summary>
        ReadOnlyOptimal = 1000314000,

        /// <summary>
        ///     <c>AttachmentOptimal</c>
        /// </summary>
        AttachmentOptimal = 1000314001,

        /// <summary>
        ///     <c>RenderingLocalRead</c>
        /// </summary>
        RenderingLocalRead = 1000232000,

        /// <summary>
        ///     <c>PresentSrcKHR</c>
        /// </summary>
        PresentSrcKHR = 1000001002,

        /// <summary>
        ///     <c>VideoDecodeDstKHR</c>
        /// </summary>
        VideoDecodeDstKHR = 1000024000,

        /// <summary>
        ///     <c>VideoDecodeSrcKHR</c>
        /// </summary>
        VideoDecodeSrcKHR = 1000024001,

        /// <summary>
        ///     <c>VideoDecodeDpbKHR</c>
        /// </summary>
        VideoDecodeDpbKHR = 1000024002,

        /// <summary>
        ///     <c>SharedPresentKHR</c>
        /// </summary>
        SharedPresentKHR = 1000111000,

        /// <summary>
        ///     <c>FragmentDensityMapOptimalEXT</c>
        /// </summary>
        FragmentDensityMapOptimalEXT = 1000218000,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentOptimalKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentOptimalKHR = 1000164003,

        /// <summary>
        ///     <c>VideoEncodeDstKHR</c>
        /// </summary>
        VideoEncodeDstKHR = 1000299000,

        /// <summary>
        ///     <c>VideoEncodeSrcKHR</c>
        /// </summary>
        VideoEncodeSrcKHR = 1000299001,

        /// <summary>
        ///     <c>VideoEncodeDpbKHR</c>
        /// </summary>
        VideoEncodeDpbKHR = 1000299002,

        /// <summary>
        ///     <c>AttachmentFeedbackLoopOptimalEXT</c>
        /// </summary>
        AttachmentFeedbackLoopOptimalEXT = 1000339000,

        /// <summary>
        ///     <c>TensorAliasingARM</c>
        /// </summary>
        TensorAliasingARM = 1000460000,

        /// <summary>
        ///     <c>VideoEncodeQuantizationMapKHR</c>
        /// </summary>
        VideoEncodeQuantizationMapKHR = 1000553000,

        /// <summary>
        ///     <c>ZeroInitializedEXT</c>
        /// </summary>
        ZeroInitializedEXT = 1000620000,

        /// <summary>
        ///     <c>DepthReadOnlyStencilAttachmentOptimalKHR</c>
        /// </summary>
        DepthReadOnlyStencilAttachmentOptimalKHR = DepthReadOnlyStencilAttachmentOptimal,

        /// <summary>
        ///     <c>DepthAttachmentStencilReadOnlyOptimalKHR</c>
        /// </summary>
        DepthAttachmentStencilReadOnlyOptimalKHR = DepthAttachmentStencilReadOnlyOptimal,

        /// <summary>
        ///     <c>ShadingRateOptimalNV</c>
        /// </summary>
        ShadingRateOptimalNV = FragmentShadingRateAttachmentOptimalKHR,

        /// <summary>
        ///     <c>RenderingLocalReadKHR</c>
        /// </summary>
        RenderingLocalReadKHR = RenderingLocalRead,

        /// <summary>
        ///     <c>DepthAttachmentOptimalKHR</c>
        /// </summary>
        DepthAttachmentOptimalKHR = DepthAttachmentOptimal,

        /// <summary>
        ///     <c>DepthReadOnlyOptimalKHR</c>
        /// </summary>
        DepthReadOnlyOptimalKHR = DepthReadOnlyOptimal,

        /// <summary>
        ///     <c>StencilAttachmentOptimalKHR</c>
        /// </summary>
        StencilAttachmentOptimalKHR = StencilAttachmentOptimal,

        /// <summary>
        ///     <c>StencilReadOnlyOptimalKHR</c>
        /// </summary>
        StencilReadOnlyOptimalKHR = StencilReadOnlyOptimal,

        /// <summary>
        ///     <c>ReadOnlyOptimalKHR</c>
        /// </summary>
        ReadOnlyOptimalKHR = ReadOnlyOptimal,

        /// <summary>
        ///     <c>AttachmentOptimalKHR</c>
        /// </summary>
        AttachmentOptimalKHR = AttachmentOptimal,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
