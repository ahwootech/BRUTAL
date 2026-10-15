namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescriptionStencilLayout.html">VkAttachmentDescriptionStencilLayout</see> - Structure specifying an attachment description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAttachmentDescriptionStencilLayout</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkAttachmentDescriptionStencilLayout {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkImageLayout      stencilInitialLayout;
    ///             VkImageLayout      stencilFinalLayout;
    ///         } VkAttachmentDescriptionStencilLayout;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkAttachmentDescriptionStencilLayout()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AttachmentDescriptionStencilLayout;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StencilInitialLayout</c> is the layout the stencil aspect of the attachment image subresource will be in when a render pass instance begins.
        /// </summary>
        [FieldOffset(16)]
        public VkImageLayout StencilInitialLayout;

        /// <summary>
        ///     <c>StencilFinalLayout</c> is the layout the stencil aspect of the attachment image subresource will be transitioned to when a render pass instance ends.
        /// </summary>
        [FieldOffset(20)]
        public VkImageLayout StencilFinalLayout;
    }
}
