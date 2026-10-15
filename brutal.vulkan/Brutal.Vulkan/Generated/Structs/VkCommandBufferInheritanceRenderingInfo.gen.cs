namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceRenderingInfo.html">VkCommandBufferInheritanceRenderingInfo</see> - Structure specifying command buffer inheritance info for dynamic render pass instances
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCommandBufferInheritanceRenderingInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkCommandBufferInheritanceRenderingInfo {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkRenderingFlags         flags;
    ///             uint32_t                 viewMask;
    ///             uint32_t                 colorAttachmentCount;
    ///             const VkFormat*          pColorAttachmentFormats;
    ///             VkFormat                 depthAttachmentFormat;
    ///             VkFormat                 stencilAttachmentFormat;
    ///             VkSampleCountFlagBits    rasterizationSamples;
    ///         } VkCommandBufferInheritanceRenderingInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkCommandBufferInheritanceRenderingInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferInheritanceRenderingInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkRenderingFlags</c> used by the render pass instance.
        /// </summary>
        [FieldOffset(16)]
        public VkRenderingFlags Flags;

        /// <summary>
        ///     <c>ViewMask</c> is the view mask used for rendering.
        /// </summary>
        [FieldOffset(20)]
        public int ViewMask;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of color attachments specified in the render pass instance.
        /// </summary>
        [FieldOffset(24)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachmentFormats</c> is a pointer to an array of <c>VkFormat</c> values defining the format of color attachments.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat* ColorAttachmentFormats;

        /// <summary>
        ///     <c>DepthAttachmentFormat</c> is a <c>VkFormat</c> value defining the format of the depth attachment.
        /// </summary>
        [FieldOffset(40)]
        public VkFormat DepthAttachmentFormat;

        /// <summary>
        ///     <c>StencilAttachmentFormat</c> is a <c>VkFormat</c> value defining the format of the stencil attachment.
        /// </summary>
        [FieldOffset(44)]
        public VkFormat StencilAttachmentFormat;

        /// <summary>
        ///     <c>RasterizationSamples</c> is a <c>VkSampleCountFlags</c> specifying the number of samples used in rasterization.
        /// </summary>
        [FieldOffset(48)]
        public VkSampleCountFlags RasterizationSamples;
    }
}
