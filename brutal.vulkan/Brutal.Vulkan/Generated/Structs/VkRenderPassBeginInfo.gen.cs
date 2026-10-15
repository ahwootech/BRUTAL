namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassBeginInfo.html">VkRenderPassBeginInfo</see> - Structure specifying render pass begin information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassBeginInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkRenderPassBeginInfo {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkRenderPass           renderPass;
    ///             VkFramebuffer          framebuffer;
    ///             VkRect2D               renderArea;
    ///             uint32_t               clearValueCount;
    ///             const VkClearValue*    pClearValues;
    ///         } VkRenderPassBeginInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkRenderPassBeginInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassBeginInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RenderPass</c> is the render pass to begin an instance of.
        /// </summary>
        [FieldOffset(16)]
        public VkRenderPass RenderPass;

        /// <summary>
        ///     <c>Framebuffer</c> is the framebuffer containing the attachments that are used with the render pass.
        /// </summary>
        [FieldOffset(24)]
        public VkFramebuffer Framebuffer;

        /// <summary>
        ///     <c>RenderArea</c> is the render area that is affected by the render pass instance, and is described in more detail below.
        /// </summary>
        [FieldOffset(32)]
        public VkRect2D RenderArea;

        /// <summary>
        ///     <c>ClearValueCount</c> is the number of elements in <c>pClearValues</c>.
        /// </summary>
        [FieldOffset(48)]
        public int ClearValueCount;

        /// <summary>
        ///     <c>ClearValues</c> is a pointer to an array of <c>clearValueCount</c> <c>VkClearValue</c> structures containing clear values for each attachment, if the attachment uses a <c>loadOp</c> value of <c>VK_ATTACHMENT_LOAD_OP_CLEAR</c> or if the attachment has a depth/stencil format and uses a <c>stencilLoadOp</c> value of <c>VK_ATTACHMENT_LOAD_OP_CLEAR</c>. The array is indexed by attachment number. Only elements corresponding to cleared attachments are used. Other elements of <c>pClearValues</c> are ignored.
        /// </summary>
        [FieldOffset(56)]
        public VkClearValue* ClearValues;
    }
}
