namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentReferenceStencilLayout.html">VkAttachmentReferenceStencilLayout</see> - Structure specifying an attachment description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAttachmentReferenceStencilLayout</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkAttachmentReferenceStencilLayout {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkImageLayout      stencilLayout;
    ///         } VkAttachmentReferenceStencilLayout;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkAttachmentReferenceStencilLayout()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AttachmentReferenceStencilLayout;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StencilLayout</c> is a <c>VkImageLayout</c> value specifying the layout the stencil aspect of the attachment uses during the subpass.
        /// </summary>
        [FieldOffset(16)]
        public VkImageLayout StencilLayout;
    }
}
