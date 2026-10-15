namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassDescriptionDepthStencilResolve.html">VkSubpassDescriptionDepthStencilResolve</see> - Structure specifying depth/stencil resolve operations for a subpass
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSubpassDescriptionDepthStencilResolve</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSubpassDescriptionDepthStencilResolve {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkResolveModeFlagBits            depthResolveMode;
    ///             VkResolveModeFlagBits            stencilResolveMode;
    ///             const VkAttachmentReference2*    pDepthStencilResolveAttachment;
    ///         } VkSubpassDescriptionDepthStencilResolve;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSubpassDescriptionDepthStencilResolve()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubpassDescriptionDepthStencilResolve;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DepthResolveMode</c> is a <c>VkResolveModeFlags</c> value describing the depth resolve mode.
        /// </summary>
        [FieldOffset(16)]
        public VkResolveModeFlags DepthResolveMode;

        /// <summary>
        ///     <c>StencilResolveMode</c> is a <c>VkResolveModeFlags</c> value describing the stencil resolve mode.
        /// </summary>
        [FieldOffset(20)]
        public VkResolveModeFlags StencilResolveMode;

        /// <summary>
        ///     <c>DepthStencilResolveAttachment</c> is `NULL` or a pointer to a <c>VkAttachmentReference2</c> structure defining the depth/stencil resolve attachment for this subpass and its layout.
        /// </summary>
        [FieldOffset(24)]
        public VkAttachmentReference2* DepthStencilResolveAttachment;
    }
}
