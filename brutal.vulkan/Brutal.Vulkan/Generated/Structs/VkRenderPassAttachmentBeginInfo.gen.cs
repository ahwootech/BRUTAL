namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassAttachmentBeginInfo.html">VkRenderPassAttachmentBeginInfo</see> - Structure specifying images to be used as framebuffer attachments
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassAttachmentBeginInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkRenderPassAttachmentBeginInfo {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             uint32_t              attachmentCount;
    ///             const VkImageView*    pAttachments;
    ///         } VkRenderPassAttachmentBeginInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderPassAttachmentBeginInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassAttachmentBeginInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AttachmentCount</c> is the number of attachments.
        /// </summary>
        [FieldOffset(16)]
        public int AttachmentCount;

        /// <summary>
        ///     <c>Attachments</c> is a pointer to an array of <c>VkImageView</c> handles, each of which will be used as the corresponding attachment in the render pass instance.
        /// </summary>
        [FieldOffset(24)]
        public VkImageView* Attachments;
    }
}
