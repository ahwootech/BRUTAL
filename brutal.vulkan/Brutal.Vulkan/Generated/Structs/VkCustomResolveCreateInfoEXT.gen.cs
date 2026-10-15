namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCustomResolveCreateInfoEXT.html">VkCustomResolveCreateInfoEXT</see> - Structure specifying format info for custom resolves
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCustomResolveCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_custom_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///         typedef struct VkCustomResolveCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           customResolve;
    ///             uint32_t           colorAttachmentCount;
    ///             const VkFormat*    pColorAttachmentFormats;
    ///             VkFormat           depthAttachmentFormat;
    ///             VkFormat           stencilAttachmentFormat;
    ///         } VkCustomResolveCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCustomResolveCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CustomResolveCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CustomResolve</c> indicates whether this pipeline will be used for a resolve operation.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CustomResolve;

        /// <summary>
        ///     <c>ColorAttachmentCount</c> is the number of entries in <c>pColorAttachmentFormats</c>.
        /// </summary>
        [FieldOffset(20)]
        public int ColorAttachmentCount;

        /// <summary>
        ///     <c>ColorAttachmentFormats</c> is a pointer to an array of <c>VkFormat</c> values defining the format of color resolve attachments used in custom resolves in the same render pass.
        /// </summary>
        [FieldOffset(24)]
        public VkFormat* ColorAttachmentFormats;

        /// <summary>
        ///     <c>DepthAttachmentFormat</c> is a <c>VkFormat</c> value defining the format of the depth resolve attachment used in custom resolves in the same render pass.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat DepthAttachmentFormat;

        /// <summary>
        ///     <c>StencilAttachmentFormat</c> is a <c>VkFormat</c> value defining the format of the stencil resolve attachment used in custom resolves in the same render pass.
        /// </summary>
        [FieldOffset(36)]
        public VkFormat StencilAttachmentFormat;
    }
}
