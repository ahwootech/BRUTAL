namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingAreaInfo.html">VkRenderingAreaInfo</see> - Structure describing rendering area granularity query info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderingAreaInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkRenderingAreaInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           viewMask;
    ///             uint32_t           colorAttachmentCount;
    ///             const VkFormat*    pColorAttachmentFormats;
    ///             VkFormat           depthAttachmentFormat;
    ///             VkFormat           stencilAttachmentFormat;
    ///         } VkRenderingAreaInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkRenderingAreaInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingAreaInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ViewMask</c> is the viewMask used for rendering.
        /// </summary>
        [FieldOffset(16)]
        public int ViewMask;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of entries in <c>pColorAttachmentFormats</c>
        /// </summary>
        [FieldOffset(20)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachmentFormats</c> is a pointer to an array of <c>VkFormat</c> values defining the format of color attachments used in the render pass instance.
        /// </summary>
        [FieldOffset(24)]
        public VkFormat* ColorAttachmentFormats;

        /// <summary>
        ///     <c>DepthAttachmentFormat</c> is a <c>VkFormat</c> value defining the format of the depth attachment used in the render pass instance.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat DepthAttachmentFormat;

        /// <summary>
        ///     <c>StencilAttachmentFormat</c> is a <c>VkFormat</c> value defining the format of the stencil attachment used in the render pass instance.
        /// </summary>
        [FieldOffset(36)]
        public VkFormat StencilAttachmentFormat;
    }
}
