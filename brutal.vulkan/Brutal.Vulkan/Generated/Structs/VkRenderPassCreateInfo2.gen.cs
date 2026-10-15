namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreateInfo2.html">VkRenderPassCreateInfo2</see> - Structure specifying parameters of a newly created render pass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassCreateInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkRenderPassCreateInfo2 {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkRenderPassCreateFlags            flags;
    ///             uint32_t                           attachmentCount;
    ///             const VkAttachmentDescription2*    pAttachments;
    ///             uint32_t                           subpassCount;
    ///             const VkSubpassDescription2*       pSubpasses;
    ///             uint32_t                           dependencyCount;
    ///             const VkSubpassDependency2*        pDependencies;
    ///             uint32_t                           correlatedViewMaskCount;
    ///             const uint32_t*                    pCorrelatedViewMasks;
    ///         } VkRenderPassCreateInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkRenderPassCreateInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassCreateInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkRenderPassCreateFlags Flags;

        /// <summary>
        ///     <c>AttachmentCount</c> is the number of attachments used by this render pass.
        /// </summary>
        [FieldOffset(20)]
        public int AttachmentCount;

        /// <summary>
        ///     <c>Attachments</c> is a pointer to an array of <c>attachmentCount</c> <c>VkAttachmentDescription2</c> structures describing the attachments used by the render pass.
        /// </summary>
        [FieldOffset(24)]
        public VkAttachmentDescription2* Attachments;

        /// <summary>
        ///     <c>SubpassCount</c> is the number of subpasses to create.
        /// </summary>
        [FieldOffset(32)]
        public int SubpassCount;

        /// <summary>
        ///     <c>Subpasses</c> is a pointer to an array of <c>subpassCount</c> <c>VkSubpassDescription2</c> structures describing each subpass.
        /// </summary>
        [FieldOffset(40)]
        public VkSubpassDescription2* Subpasses;

        /// <summary>
        ///     <c>DependencyCount</c> is the number of dependencies between pairs of subpasses.
        /// </summary>
        [FieldOffset(48)]
        public int DependencyCount;

        /// <summary>
        ///     <c>Dependencies</c> is a pointer to an array of <c>dependencyCount</c> <c>VkSubpassDependency2</c> structures describing dependencies between pairs of subpasses.
        /// </summary>
        [FieldOffset(56)]
        public VkSubpassDependency2* Dependencies;

        /// <summary>
        ///     <c>CorrelatedViewMaskCount</c> is the number of correlation masks.
        /// </summary>
        [FieldOffset(64)]
        public int CorrelatedViewMaskCount;

        /// <summary>
        ///     <c>CorrelatedViewMasks</c> is a pointer to an array of view masks indicating sets of views that may: be more efficient to render concurrently.
        /// </summary>
        [FieldOffset(72)]
        public int* CorrelatedViewMasks;
    }
}
