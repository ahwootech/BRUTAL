namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewCreateInfo.html">VkImageViewCreateInfo</see> - Structure specifying parameters of a newly created image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageViewCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageViewCreateInfo {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkImageViewCreateFlags     flags;
    ///             VkImage                    image;
    ///             VkImageViewType            viewType;
    ///             VkFormat                   format;
    ///             VkComponentMapping         components;
    ///             VkImageSubresourceRange    subresourceRange;
    ///         } VkImageViewCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkImageViewCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkImageViewCreateFlags</c> specifying additional parameters of the image view.
        /// </summary>
        [FieldOffset(16)]
        public VkImageViewCreateFlags Flags;

        /// <summary>
        ///     <c>Image</c> is a <c>VkImage</c> on which the view will be created.
        /// </summary>
        [FieldOffset(24)]
        public VkImage Image;

        /// <summary>
        ///     <c>ViewType</c> is a <c>VkImageViewType</c> value specifying the type of the image view.
        /// </summary>
        [FieldOffset(32)]
        public VkImageViewType ViewType;

        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> specifying the format and type used to interpret texel blocks of the image.
        /// </summary>
        [FieldOffset(36)]
        public VkFormat Format;

        /// <summary>
        ///     <c>Components</c> is a <c>VkComponentMapping</c> structure specifying a remapping of color components (or of depth or stencil components after they have been converted into color components).
        /// </summary>
        [FieldOffset(40)]
        public VkComponentMapping Components;

        /// <summary>
        ///     <c>SubresourceRange</c> is a <c>VkImageSubresourceRange</c> structure selecting the set of mipmap levels and array layers to be accessible to the view.
        /// </summary>
        [FieldOffset(56)]
        public VkImageSubresourceRange SubresourceRange;
    }
}
