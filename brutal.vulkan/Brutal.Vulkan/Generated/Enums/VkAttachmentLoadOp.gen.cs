namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentLoadOp.html">VkAttachmentLoadOp</see> - Specify how contents of an attachment are treated at the beginning of the subpass where it is first used
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Load operations that <i>can</i> be used for a render pass are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkAttachmentLoadOp {
    ///             VK_ATTACHMENT_LOAD_OP_LOAD = 0,
    ///             VK_ATTACHMENT_LOAD_OP_CLEAR = 1,
    ///             VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_ATTACHMENT_LOAD_OP_NONE = 1000400000,
    ///             // Provided by VK_EXT_load_store_op_none
    ///             VK_ATTACHMENT_LOAD_OP_NONE_EXT = VK_ATTACHMENT_LOAD_OP_NONE,
    ///             // Provided by VK_KHR_load_store_op_none
    ///             VK_ATTACHMENT_LOAD_OP_NONE_KHR = VK_ATTACHMENT_LOAD_OP_NONE,
    ///         } VkAttachmentLoadOp;
    ///     </code>
    /// </remarks>
    public enum VkAttachmentLoadOp : int
    {
        /// <summary>
        ///     <c>Load</c> specifies that the previous contents of the image within the render area will be preserved as the initial values. For attachments with a depth/stencil format, this uses the access type <c>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT</c>. For attachments with a color format, this uses the access type <c>VK_ACCESS_COLOR_ATTACHMENT_READ_BIT</c>.
        /// </summary>
        Load = 0,

        /// <summary>
        ///     <c>Clear</c> specifies that the contents within the render area will be cleared to a uniform value, which is specified when a render pass instance is begun. For attachments with a depth/stencil format, this uses the access type <c>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</c>. For attachments with a color format, this uses the access type <c>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</c>.
        /// </summary>
        Clear = 1,

        /// <summary>
        ///     <c>DontCare</c> specifies that the previous contents within the area need not be preserved; the contents of the attachment will be undefined: inside the render area. For attachments with a depth/stencil format, this uses the access type <c>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</c>. For attachments with a color format, this uses the access type <c>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</c>.
        /// </summary>
        DontCare = 2,

        /// <summary>
        ///     <c>None</c>
        /// </summary>
        None = 1000400000,

        /// <summary>
        ///     <c>NoneEXT</c>
        /// </summary>
        NoneEXT = None,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = None,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
