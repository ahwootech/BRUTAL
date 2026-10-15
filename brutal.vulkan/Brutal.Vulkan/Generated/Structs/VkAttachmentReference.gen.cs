namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentReference.html">VkAttachmentReference</see> - Structure specifying an attachment reference
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAttachmentReference
    ///     </para>
    ///     <para>
    ///         The <c>VkAttachmentReference</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkAttachmentReference {
    ///             uint32_t         attachment;
    ///             VkImageLayout    layout;
    ///         } VkAttachmentReference;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkAttachmentReference()
    {
        /// <summary>
        ///     <c>Attachment</c> is either an integer value identifying an attachment at the corresponding index in <c>VkRenderPassCreateInfo::pAttachments</c>, or <c>VK_ATTACHMENT_UNUSED</c> to signify that this attachment is not used.
        /// </summary>
        [FieldOffset(0)]
        public int Attachment;

        /// <summary>
        ///     <c>Layout</c> is a <c>VkImageLayout</c> value specifying the layout the attachment uses during the subpass.
        /// </summary>
        [FieldOffset(4)]
        public VkImageLayout Layout;
    }
}
