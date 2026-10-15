namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingAttachmentInfo.html">VkRenderingAttachmentInfo</see> - Structure specifying attachment information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderingAttachmentInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkRenderingAttachmentInfo {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkImageView              imageView;
    ///             VkImageLayout            imageLayout;
    ///             VkResolveModeFlagBits    resolveMode;
    ///             VkImageView              resolveImageView;
    ///             VkImageLayout            resolveImageLayout;
    ///             VkAttachmentLoadOp       loadOp;
    ///             VkAttachmentStoreOp      storeOp;
    ///             VkClearValue             clearValue;
    ///         } VkRenderingAttachmentInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkRenderingAttachmentInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingAttachmentInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageView</c> is the image view that will be used for rendering.
        /// </summary>
        [FieldOffset(16)]
        public VkImageView ImageView;

        /// <summary>
        ///     <c>ImageLayout</c> is the layout that <c>imageView</c> will be in during rendering.
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout ImageLayout;

        /// <summary>
        ///     <c>ResolveMode</c> is a <c>VkResolveModeFlags</c> value defining how data written to <c>imageView</c> will be resolved into <c>resolveImageView</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkResolveModeFlags ResolveMode;

        /// <summary>
        ///     <c>ResolveImageView</c> is an image view used to write resolved data at the end of rendering.
        /// </summary>
        [FieldOffset(32)]
        public VkImageView ResolveImageView;

        /// <summary>
        ///     <c>ResolveImageLayout</c> is the layout that <c>resolveImageView</c> will be in during rendering.
        /// </summary>
        [FieldOffset(40)]
        public VkImageLayout ResolveImageLayout;

        /// <summary>
        ///     <c>LoadOp</c> is a <c>VkAttachmentLoadOp</c> value defining the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-load-operations">load operation^</see> for the attachment.
        /// </summary>
        [FieldOffset(44)]
        public VkAttachmentLoadOp LoadOp;

        /// <summary>
        ///     <c>StoreOp</c> is a <c>VkAttachmentStoreOp</c> value defining the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-store-operations">store operation^</see> for the attachment.
        /// </summary>
        [FieldOffset(48)]
        public VkAttachmentStoreOp StoreOp;

        /// <summary>
        ///     <c>ClearValue</c> is a <c>VkClearValue</c> structure defining values used to clear <c>imageView</c> when <c>loadOp</c> is <c>VK_ATTACHMENT_LOAD_OP_CLEAR</c>.
        /// </summary>
        [FieldOffset(52)]
        public VkClearValue ClearValue;
    }
}
