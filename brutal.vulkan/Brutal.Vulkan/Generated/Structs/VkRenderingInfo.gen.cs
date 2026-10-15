namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingInfo.html">VkRenderingInfo</see> - Structure specifying render pass instance begin info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderingInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkRenderingInfo {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkRenderingFlags                    flags;
    ///             VkRect2D                            renderArea;
    ///             uint32_t                            layerCount;
    ///             uint32_t                            viewMask;
    ///             uint32_t                            colorAttachmentCount;
    ///             const VkRenderingAttachmentInfo*    pColorAttachments;
    ///             const VkRenderingAttachmentInfo*    pDepthAttachment;
    ///             const VkRenderingAttachmentInfo*    pStencilAttachment;
    ///         } VkRenderingInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkRenderingInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkRenderingFlags</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkRenderingFlags Flags;

        /// <summary>
        ///     <c>RenderArea</c> is the render area that is affected by the render pass instance.
        /// </summary>
        [FieldOffset(20)]
        public VkRect2D RenderArea;

        /// <summary>
        ///     <c>LayerCount</c> is the number of layers rendered to in each attachment when <c>viewMask</c> is `0`.
        /// </summary>
        [FieldOffset(36)]
        public int LayerCount;

        /// <summary>
        ///     <c>ViewMask</c> is a bitfield of view indices describing which views are active during rendering, when it is not `0`.
        /// </summary>
        [FieldOffset(40)]
        public int ViewMask;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of elements in <c>pColorAttachments</c>.
        /// </summary>
        [FieldOffset(44)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachments</c> is a pointer to an array of <c>colorAttachmentCount</c> <c>VkRenderingAttachmentInfo</c> structures describing any color attachments used.
        /// </summary>
        [FieldOffset(48)]
        public VkRenderingAttachmentInfo* ColorAttachments;

        /// <summary>
        ///     <c>DepthAttachment</c> is a pointer to a <c>VkRenderingAttachmentInfo</c> structure describing a depth attachment.
        /// </summary>
        [FieldOffset(56)]
        public VkRenderingAttachmentInfo* DepthAttachment;

        /// <summary>
        ///     <c>StencilAttachment</c> is a pointer to a <c>VkRenderingAttachmentInfo</c> structure describing a stencil attachment.
        /// </summary>
        [FieldOffset(64)]
        public VkRenderingAttachmentInfo* StencilAttachment;
    }
}
