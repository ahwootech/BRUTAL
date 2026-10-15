namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFramebufferAttachmentsCreateInfo.html">VkFramebufferAttachmentsCreateInfo</see> - Structure specifying parameters of images that will be used with a framebuffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFramebufferAttachmentsCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkFramebufferAttachmentsCreateInfo {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             uint32_t                                   attachmentImageInfoCount;
    ///             const VkFramebufferAttachmentImageInfo*    pAttachmentImageInfos;
    ///         } VkFramebufferAttachmentsCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkFramebufferAttachmentsCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FramebufferAttachmentsCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AttachmentImageInfoCount</c> is the number of attachments being described.
        /// </summary>
        [FieldOffset(16)]
        public int AttachmentImageInfoCount;

        /// <summary>
        ///     <c>AttachmentImageInfos</c> is a pointer to an array of <c>VkFramebufferAttachmentImageInfo</c> structures, each structure describing a number of parameters of the corresponding attachment in a render pass instance.
        /// </summary>
        [FieldOffset(24)]
        public VkFramebufferAttachmentImageInfo* AttachmentImageInfos;
    }
}
