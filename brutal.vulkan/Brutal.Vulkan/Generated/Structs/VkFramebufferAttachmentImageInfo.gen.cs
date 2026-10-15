namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFramebufferAttachmentImageInfo.html">VkFramebufferAttachmentImageInfo</see> - Structure specifying parameters of an image that will be used with a framebuffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFramebufferAttachmentImageInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkFramebufferAttachmentImageInfo {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkImageCreateFlags    flags;
    ///             VkImageUsageFlags     usage;
    ///             uint32_t              width;
    ///             uint32_t              height;
    ///             uint32_t              layerCount;
    ///             uint32_t              viewFormatCount;
    ///             const VkFormat*       pViewFormats;
    ///         } VkFramebufferAttachmentImageInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkFramebufferAttachmentImageInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FramebufferAttachmentImageInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkImageCreateFlags</c>, matching the value of <c>VkImageCreateInfo::flags</c> used to create an image that will be used with this framebuffer.
        /// </summary>
        [FieldOffset(16)]
        public VkImageCreateFlags Flags;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkImageUsageFlags</c>, matching the value of <c>VkImageCreateInfo::usage</c> used to create an image used with this framebuffer.
        /// </summary>
        [FieldOffset(20)]
        public VkImageUsageFlags Usage;

        /// <summary>
        ///     <c>Width</c> is the width of the image view used for rendering.
        /// </summary>
        [FieldOffset(24)]
        public int Width;

        /// <summary>
        ///     <c>Height</c> is the height of the image view used for rendering.
        /// </summary>
        [FieldOffset(28)]
        public int Height;

        /// <summary>
        ///     <c>LayerCount</c> is the number of array layers of the image view used for rendering.
        /// </summary>
        [FieldOffset(32)]
        public int LayerCount;

        /// <summary>
        ///     <c>ViewFormatCount</c> is the number of entries in the <c>pViewFormats</c> array, matching the value of <c>VkImageFormatListCreateInfo::viewFormatCount</c> used to create an image used with this framebuffer.
        /// </summary>
        [FieldOffset(36)]
        public int ViewFormatCount;

        /// <summary>
        ///     <c>ViewFormats</c> is a pointer to an array of <c>VkFormat</c> values specifying all of the formats which <i>can</i> be used when creating views of the image, matching the value of <c>VkImageFormatListCreateInfo::pViewFormats</c> used to create an image used with this framebuffer.
        /// </summary>
        [FieldOffset(40)]
        public VkFormat* ViewFormats;
    }
}
