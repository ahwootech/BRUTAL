namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFramebufferCreateInfo.html">VkFramebufferCreateInfo</see> - Structure specifying parameters of a newly created framebuffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFramebufferCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkFramebufferCreateInfo {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkFramebufferCreateFlags    flags;
    ///             VkRenderPass                renderPass;
    ///             uint32_t                    attachmentCount;
    ///             const VkImageView*          pAttachments;
    ///             uint32_t                    width;
    ///             uint32_t                    height;
    ///             uint32_t                    layers;
    ///         } VkFramebufferCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkFramebufferCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FramebufferCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkFramebufferCreateFlags</c>
        /// </summary>
        [FieldOffset(16)]
        public VkFramebufferCreateFlags Flags;

        /// <summary>
        ///     <c>RenderPass</c> is a render pass defining what render passes the framebuffer will be compatible with. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-compatibility">Render Pass Compatibility^</see> for details. The implementation <i>must</i> not access this object outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(24)]
        public VkRenderPass RenderPass;

        /// <summary>
        ///     <c>AttachmentCount</c> is the number of attachments.
        /// </summary>
        [FieldOffset(32)]
        public int AttachmentCount;

        /// <summary>
        ///     <c>Attachments</c> is a pointer to an array of <c>VkImageView</c> handles, each of which will be used as the corresponding attachment in a render pass instance.
        /// </summary>
        [FieldOffset(40)]
        public VkImageView* Attachments;

        /// <summary>
        ///     <c>Width</c>
        /// </summary>
        [FieldOffset(48)]
        public int Width;

        /// <summary>
        ///     <c>Height</c>
        /// </summary>
        [FieldOffset(52)]
        public int Height;

        /// <summary>
        ///     <c>Layers</c>
        /// </summary>
        [FieldOffset(56)]
        public int Layers;
    }
}
