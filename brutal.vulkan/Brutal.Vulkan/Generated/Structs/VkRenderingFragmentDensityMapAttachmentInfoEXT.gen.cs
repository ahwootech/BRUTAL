namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingFragmentDensityMapAttachmentInfoEXT.html">VkRenderingFragmentDensityMapAttachmentInfoEXT</see> - Structure specifying fragment shading rate attachment information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderingFragmentDensityMapAttachmentInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_fragment_density_map with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///         typedef struct VkRenderingFragmentDensityMapAttachmentInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImageView        imageView;
    ///             VkImageLayout      imageLayout;
    ///         } VkRenderingFragmentDensityMapAttachmentInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkRenderingFragmentDensityMapAttachmentInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingFragmentDensityMapAttachmentInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageView</c> is the image view that will be used as a fragment density map attachment.
        /// </summary>
        [FieldOffset(16)]
        public VkImageView ImageView;

        /// <summary>
        ///     <c>ImageLayout</c> is the layout that <c>imageView</c> will be in during rendering.
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout ImageLayout;
    }
}
