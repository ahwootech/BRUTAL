namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentReference2.html">VkAttachmentReference2</see> - Structure specifying an attachment reference
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAttachmentReference2
    ///     </para>
    ///     <para>
    ///         The <c>VkAttachmentReference2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkAttachmentReference2 {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             uint32_t              attachment;
    ///             VkImageLayout         layout;
    ///             VkImageAspectFlags    aspectMask;
    ///         } VkAttachmentReference2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAttachmentReference2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AttachmentReference2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Attachment</c> is either an integer value identifying an attachment at the corresponding index in <c>VkRenderPassCreateInfo2::pAttachments</c>, or <c>VK_ATTACHMENT_UNUSED</c> to signify that this attachment is not used.
        /// </summary>
        [FieldOffset(16)]
        public int Attachment;

        /// <summary>
        ///     <c>Layout</c> is a <c>VkImageLayout</c> value specifying the layout the attachment uses during the subpass.
        /// </summary>
        [FieldOffset(20)]
        public VkImageLayout Layout;

        /// <summary>
        ///     <c>AspectMask</c> is a mask of which aspect(s) <i>can</i> be accessed within the specified subpass as an input attachment.
        /// </summary>
        [FieldOffset(24)]
        public VkImageAspectFlags AspectMask;
    }
}
