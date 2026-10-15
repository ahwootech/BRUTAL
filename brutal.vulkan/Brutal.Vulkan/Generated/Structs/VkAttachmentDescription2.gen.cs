namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAttachmentDescription2.html">VkAttachmentDescription2</see> - Structure specifying an attachment description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAttachmentDescription2
    ///     </para>
    ///     <para>
    ///         The <c>VkAttachmentDescription2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkAttachmentDescription2 {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkAttachmentDescriptionFlags    flags;
    ///             VkFormat                        format;
    ///             VkSampleCountFlagBits           samples;
    ///             VkAttachmentLoadOp              loadOp;
    ///             VkAttachmentStoreOp             storeOp;
    ///             VkAttachmentLoadOp              stencilLoadOp;
    ///             VkAttachmentStoreOp             stencilStoreOp;
    ///             VkImageLayout                   initialLayout;
    ///             VkImageLayout                   finalLayout;
    ///         } VkAttachmentDescription2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkAttachmentDescription2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AttachmentDescription2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkAttachmentDescriptionFlags</c> specifying additional properties of the attachment.
        /// </summary>
        [FieldOffset(16)]
        public VkAttachmentDescriptionFlags Flags;

        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> value specifying the format of the image that will be used for the attachment.
        /// </summary>
        [FieldOffset(20)]
        public VkFormat Format;

        /// <summary>
        ///     <c>Samples</c> is a <c>VkSampleCountFlags</c> value specifying the number of samples of the image.
        /// </summary>
        [FieldOffset(24)]
        public VkSampleCountFlags Samples;

        /// <summary>
        ///     <c>LoadOp</c> is a <c>VkAttachmentLoadOp</c> value specifying how the contents of color and depth components of the attachment are treated at the beginning of the subpass where it is first used.
        /// </summary>
        [FieldOffset(28)]
        public VkAttachmentLoadOp LoadOp;

        /// <summary>
        ///     <c>StoreOp</c> is a <c>VkAttachmentStoreOp</c> value specifying how the contents of color and depth components of the attachment are treated at the end of the subpass where it is last used.
        /// </summary>
        [FieldOffset(32)]
        public VkAttachmentStoreOp StoreOp;

        /// <summary>
        ///     <c>StencilLoadOp</c> is a <c>VkAttachmentLoadOp</c> value specifying how the contents of stencil components of the attachment are treated at the beginning of the subpass where it is first used.
        /// </summary>
        [FieldOffset(36)]
        public VkAttachmentLoadOp StencilLoadOp;

        /// <summary>
        ///     <c>StencilStoreOp</c> is a <c>VkAttachmentStoreOp</c> value specifying how the contents of stencil components of the attachment are treated at the end of the last subpass where it is used.
        /// </summary>
        [FieldOffset(40)]
        public VkAttachmentStoreOp StencilStoreOp;

        /// <summary>
        ///     <c>InitialLayout</c> is the layout the attachment image subresource will be in when a render pass instance begins.
        /// </summary>
        [FieldOffset(44)]
        public VkImageLayout InitialLayout;

        /// <summary>
        ///     <c>FinalLayout</c> is the layout the attachment image subresource will be transitioned to when a render pass instance ends.
        /// </summary>
        [FieldOffset(48)]
        public VkImageLayout FinalLayout;
    }
}
