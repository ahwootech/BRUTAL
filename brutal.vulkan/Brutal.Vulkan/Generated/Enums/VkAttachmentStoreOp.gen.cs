namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentStoreOp.html">VkAttachmentStoreOp</see> - Specify how contents of an attachment are treated at the end of the subpass where it is last used
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkAttachmentDescription::storeOp</c> and
    ///         <c>stencilStoreOp</c>, specifying how the contents of the attachment are
    ///         treated, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkAttachmentStoreOp {
    ///             VK_ATTACHMENT_STORE_OP_STORE = 0,
    ///             VK_ATTACHMENT_STORE_OP_DONT_CARE = 1,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_ATTACHMENT_STORE_OP_NONE = 1000301000,
    ///             // Provided by VK_KHR_dynamic_rendering, VK_KHR_load_store_op_none
    ///             VK_ATTACHMENT_STORE_OP_NONE_KHR = VK_ATTACHMENT_STORE_OP_NONE,
    ///             // Provided by VK_QCOM_render_pass_store_ops
    ///             VK_ATTACHMENT_STORE_OP_NONE_QCOM = VK_ATTACHMENT_STORE_OP_NONE,
    ///             // Provided by VK_EXT_load_store_op_none
    ///             VK_ATTACHMENT_STORE_OP_NONE_EXT = VK_ATTACHMENT_STORE_OP_NONE,
    ///         } VkAttachmentStoreOp;
    ///     </code>
    /// </remarks>
    public enum VkAttachmentStoreOp : int
    {
        /// <summary>
        ///     <c>Store</c> specifies the contents generated during the render pass and within the render area are written to memory. For attachments with a depth/stencil format, this uses the access type <c>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</c>. For attachments with a color format, this uses the access type <c>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</c>.
        /// </summary>
        Store = 0,

        /// <summary>
        ///     <c>DontCare</c> specifies the contents within the render area are not needed after rendering, and may: be discarded; the contents of the attachment will be undefined: inside the render area. For attachments with a depth/stencil format, this uses the access type <c>VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT</c>. For attachments with a color format, this uses the access type <c>VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT</c>.  [NOTE]
        /// </summary>
        DontCare = 1,

        /// <summary>
        ///     <c>None</c>
        /// </summary>
        None = 1000301000,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = None,

        /// <summary>
        ///     <c>NoneQCOM</c>
        /// </summary>
        NoneQCOM = None,

        /// <summary>
        ///     <c>NoneEXT</c>
        /// </summary>
        NoneEXT = None,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
