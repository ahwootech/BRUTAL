namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassDescription.html">VkSubpassDescription</see> - Structure specifying a subpass description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkSubpassDescription
    ///     </para>
    ///     <para>
    ///         The <c>VkSubpassDescription</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSubpassDescription {
    ///             VkSubpassDescriptionFlags       flags;
    ///             VkPipelineBindPoint             pipelineBindPoint;
    ///             uint32_t                        inputAttachmentCount;
    ///             const VkAttachmentReference*    pInputAttachments;
    ///             uint32_t                        colorAttachmentCount;
    ///             const VkAttachmentReference*    pColorAttachments;
    ///             const VkAttachmentReference*    pResolveAttachments;
    ///             const VkAttachmentReference*    pDepthStencilAttachment;
    ///             uint32_t                        preserveAttachmentCount;
    ///             const uint32_t*                 pPreserveAttachments;
    ///         } VkSubpassDescription;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkSubpassDescription()
    {
        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSubpassDescriptionFlags</c> specifying usage of the subpass.
        /// </summary>
        [FieldOffset(0)]
        public VkSubpassDescriptionFlags Flags;

        /// <summary>
        ///     <c>PipelineBindPoint</c> is a <c>VkPipelineBindPoint</c> value specifying the pipeline type supported for this subpass.
        /// </summary>
        [FieldOffset(4)]
        public VkPipelineBindPoint PipelineBindPoint;

        /// <summary>
        ///     <c>InputAttachmentCount</c> is the number of input attachments.
        /// </summary>
        [FieldOffset(8)]
        public int InputAttachmentCount;

        /// <summary>
        ///     <c>InputAttachments</c> is a pointer to an array of <c>VkAttachmentReference</c> structures defining the input attachments for this subpass and their layouts.
        /// </summary>
        [FieldOffset(16)]
        public VkAttachmentReference* InputAttachments;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of color attachments.
        /// </summary>
        [FieldOffset(24)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachments</c> is a pointer to an array of <c>colorAttachmentCount</c> <c>VkAttachmentReference</c> structures defining the color attachments for this subpass and their layouts.
        /// </summary>
        [FieldOffset(32)]
        public VkAttachmentReference* ColorAttachments;

        /// <summary>
        ///     <c>ResolveAttachments</c> is `NULL` or a pointer to an array of <c>colorAttachmentCount</c> <c>VkAttachmentReference</c> structures defining the resolve attachments for this subpass and their layouts.
        /// </summary>
        [FieldOffset(40)]
        public VkAttachmentReference* ResolveAttachments;

        /// <summary>
        ///     <c>DepthStencilAttachment</c> is a pointer to a <c>VkAttachmentReference</c> structure specifying the depth/stencil attachment for this subpass and its layout.
        /// </summary>
        [FieldOffset(48)]
        public VkAttachmentReference* DepthStencilAttachment;

        /// <summary>
        ///     <c>PreserveAttachmentCount</c> is the number of preserved attachments.
        /// </summary>
        [FieldOffset(56)]
        public int PreserveAttachmentCount;

        /// <summary>
        ///     <c>PreserveAttachments</c> is a pointer to an array of <c>preserveAttachmentCount</c> render pass attachment indices identifying attachments that are not used by this subpass, but whose contents <i>must</i> be preserved throughout the subpass.
        /// </summary>
        [FieldOffset(64)]
        public int* PreserveAttachments;
    }
}
