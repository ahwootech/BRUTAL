namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateFlagBits.html">VkPipelineDepthStencilStateCreateFlagBits</see> - Bitmask specifying additional depth/stencil state information.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in the
    ///         <c>VkPipelineDepthStencilStateCreateInfo::flags</c> parameter are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0, VK_EXT_rasterization_order_attachment_access
    ///         typedef enum VkPipelineDepthStencilStateCreateFlagBits {
    ///             // Provided by VK_EXT_rasterization_order_attachment_access
    ///             VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT = 0x00000001,
    ///             // Provided by VK_EXT_rasterization_order_attachment_access
    ///             VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT = 0x00000002,
    ///             // Provided by VK_ARM_rasterization_order_attachment_access
    ///             VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM = VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT,
    ///             // Provided by VK_ARM_rasterization_order_attachment_access
    ///             VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM = VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT,
    ///         } VkPipelineDepthStencilStateCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineDepthStencilStateCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentDepthAccessBitEXT</c>
        /// </summary>
        RasterizationOrderAttachmentDepthAccessBitEXT = 0x00000001,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentStencilAccessBitEXT</c>
        /// </summary>
        RasterizationOrderAttachmentStencilAccessBitEXT = 0x00000002,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentDepthAccessBitARM</c>
        /// </summary>
        RasterizationOrderAttachmentDepthAccessBitARM = RasterizationOrderAttachmentDepthAccessBitEXT,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentStencilAccessBitARM</c>
        /// </summary>
        RasterizationOrderAttachmentStencilAccessBitARM = RasterizationOrderAttachmentStencilAccessBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
