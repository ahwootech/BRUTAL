namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassDescription2.html">VkSubpassDescription2</see> - Structure specifying a subpass description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkSubpassDescription2
    ///     </para>
    ///     <para>
    ///         The <c>VkSubpassDescription2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSubpassDescription2 {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkSubpassDescriptionFlags        flags;
    ///             VkPipelineBindPoint              pipelineBindPoint;
    ///             uint32_t                         viewMask;
    ///             uint32_t                         inputAttachmentCount;
    ///             const VkAttachmentReference2*    pInputAttachments;
    ///             uint32_t                         colorAttachmentCount;
    ///             const VkAttachmentReference2*    pColorAttachments;
    ///             const VkAttachmentReference2*    pResolveAttachments;
    ///             const VkAttachmentReference2*    pDepthStencilAttachment;
    ///             uint32_t                         preserveAttachmentCount;
    ///             const uint32_t*                  pPreserveAttachments;
    ///         } VkSubpassDescription2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkSubpassDescription2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubpassDescription2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSubpassDescriptionFlags</c> specifying usage of the subpass.
        /// </summary>
        [FieldOffset(16)]
        public VkSubpassDescriptionFlags Flags;

        /// <summary>
        ///     <c>PipelineBindPoint</c> is a <c>VkPipelineBindPoint</c> value specifying the pipeline type supported for this subpass.
        /// </summary>
        [FieldOffset(20)]
        public VkPipelineBindPoint PipelineBindPoint;

        /// <summary>
        ///     <c>ViewMask</c> is a bitfield of view indices describing which views rendering is broadcast to in this subpass, when multiview is enabled.
        /// </summary>
        [FieldOffset(24)]
        public int ViewMask;

        /// <summary>
        ///     <c>InputAttachmentCount</c> is the number of input attachments.
        /// </summary>
        [FieldOffset(28)]
        public int InputAttachmentCount;

        /// <summary>
        ///     <c>InputAttachments</c> is a pointer to an array of <c>VkAttachmentReference2</c> structures defining the input attachments for this subpass and their layouts.
        /// </summary>
        [FieldOffset(32)]
        public VkAttachmentReference2* InputAttachments;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of color attachments.
        /// </summary>
        [FieldOffset(40)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachments</c> is a pointer to an array of <c>colorAttachmentCount</c> <c>VkAttachmentReference2</c> structures defining the color attachments for this subpass and their layouts.
        /// </summary>
        [FieldOffset(48)]
        public VkAttachmentReference2* ColorAttachments;

        /// <summary>
        ///     <c>ResolveAttachments</c> is `NULL` or a pointer to an array of <c>colorAttachmentCount</c> <c>VkAttachmentReference2</c> structures defining the resolve attachments for this subpass and their layouts.
        /// </summary>
        [FieldOffset(56)]
        public VkAttachmentReference2* ResolveAttachments;

        /// <summary>
        ///     <c>DepthStencilAttachment</c> is a pointer to a <c>VkAttachmentReference2</c> structure specifying the depth/stencil attachment for this subpass and its layout.
        /// </summary>
        [FieldOffset(64)]
        public VkAttachmentReference2* DepthStencilAttachment;

        /// <summary>
        ///     <c>PreserveAttachmentCount</c> is the number of preserved attachments.
        /// </summary>
        [FieldOffset(72)]
        public int PreserveAttachmentCount;

        /// <summary>
        ///     <c>PreserveAttachments</c> is a pointer to an array of <c>preserveAttachmentCount</c> render pass attachment indices identifying attachments that are not used by this subpass, but whose contents <i>must</i> be preserved throughout the subpass.
        /// </summary>
        [FieldOffset(80)]
        public int* PreserveAttachments;
    }
}
