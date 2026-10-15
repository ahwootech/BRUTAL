namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendStateCreateFlagBits.html">VkPipelineColorBlendStateCreateFlagBits</see> - Bitmask specifying additional parameters of an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in the
    ///         <c>VkPipelineColorBlendStateCreateInfo::flags</c> parameter are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0, VK_EXT_rasterization_order_attachment_access
    ///         typedef enum VkPipelineColorBlendStateCreateFlagBits {
    ///             // Provided by VK_EXT_rasterization_order_attachment_access
    ///             VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXT = 0x00000001,
    ///             // Provided by VK_ARM_rasterization_order_attachment_access
    ///             VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_ARM = VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXT,
    ///         } VkPipelineColorBlendStateCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineColorBlendStateCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentAccessBitEXT</c>
        /// </summary>
        RasterizationOrderAttachmentAccessBitEXT = 0x00000001,

        /// <summary>
        ///     <c>RasterizationOrderAttachmentAccessBitARM</c>
        /// </summary>
        RasterizationOrderAttachmentAccessBitARM = RasterizationOrderAttachmentAccessBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
