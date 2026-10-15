namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreateInfo.html">VkRenderPassCreateInfo</see> - Structure specifying parameters of a newly created render pass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkRenderPassCreateInfo {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkRenderPassCreateFlags           flags;
    ///             uint32_t                          attachmentCount;
    ///             const VkAttachmentDescription*    pAttachments;
    ///             uint32_t                          subpassCount;
    ///             const VkSubpassDescription*       pSubpasses;
    ///             uint32_t                          dependencyCount;
    ///             const VkSubpassDependency*        pDependencies;
    ///         } VkRenderPassCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkRenderPassCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassCreateInfo;

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
        ///     <c>Attachments</c> is a pointer to an array of <c>attachmentCount</c> <c>VkAttachmentDescription</c> structures describing the attachments used by the render pass.
        /// </summary>
        [FieldOffset(24)]
        public VkAttachmentDescription* Attachments;

        /// <summary>
        ///     <c>SubpassCount</c> is the number of subpasses to create.
        /// </summary>
        [FieldOffset(32)]
        public int SubpassCount;

        /// <summary>
        ///     <c>Subpasses</c> is a pointer to an array of <c>subpassCount</c> <c>VkSubpassDescription</c> structures describing each subpass.
        /// </summary>
        [FieldOffset(40)]
        public VkSubpassDescription* Subpasses;

        /// <summary>
        ///     <c>DependencyCount</c> is the number of memory dependencies between pairs of subpasses.
        /// </summary>
        [FieldOffset(48)]
        public int DependencyCount;

        /// <summary>
        ///     <c>Dependencies</c> is a pointer to an array of <c>dependencyCount</c> <c>VkSubpassDependency</c> structures describing dependencies between pairs of subpasses.
        /// </summary>
        [FieldOffset(56)]
        public VkSubpassDependency* Dependencies;
    }
}
