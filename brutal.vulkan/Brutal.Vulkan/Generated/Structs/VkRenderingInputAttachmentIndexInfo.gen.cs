namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingInputAttachmentIndexInfo.html">VkRenderingInputAttachmentIndexInfo</see> - Structure specifying input attachment indices
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderingInputAttachmentIndexInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkRenderingInputAttachmentIndexInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           colorAttachmentCount;
    ///             const uint32_t*    pColorAttachmentInputIndices;
    ///             const uint32_t*    pDepthInputAttachmentIndex;
    ///             const uint32_t*    pStencilInputAttachmentIndex;
    ///         } VkRenderingInputAttachmentIndexInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkRenderingInputAttachmentIndexInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingInputAttachmentIndexInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of elements in <c>pColorAttachmentInputIndices</c>.
        /// </summary>
        [FieldOffset(16)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachmentInputIndices</c> is a pointer to an array of <c>colorAttachmentCount</c> <c>uint32_t</c> values defining indices for color attachments to be used as input attachments.
        /// </summary>
        [FieldOffset(24)]
        public int* ColorAttachmentInputIndices;

        /// <summary>
        ///     <c>DepthInputAttachmentIndex</c> is either `NULL`, or a pointer to a <c>uint32_t</c> value defining the index for the depth attachment to be used as an input attachment.
        /// </summary>
        [FieldOffset(32)]
        public int* DepthInputAttachmentIndex;

        /// <summary>
        ///     <c>StencilInputAttachmentIndex</c> is either `NULL`, or a pointer to a <c>uint32_t</c> value defining the index for the stencil attachment to be used as an input attachment.
        /// </summary>
        [FieldOffset(40)]
        public int* StencilInputAttachmentIndex;
    }
}
