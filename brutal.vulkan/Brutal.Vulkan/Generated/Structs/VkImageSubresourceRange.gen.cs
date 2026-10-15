namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageSubresourceRange.html">VkImageSubresourceRange</see> - Structure specifying an image subresource range
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageSubresourceRange</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageSubresourceRange {
    ///             VkImageAspectFlags    aspectMask;
    ///             uint32_t              baseMipLevel;
    ///             uint32_t              levelCount;
    ///             uint32_t              baseArrayLayer;
    ///             uint32_t              layerCount;
    ///         } VkImageSubresourceRange;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct VkImageSubresourceRange()
    {
        /// <summary>
        ///     <c>AspectMask</c> is a bitmask of <c>VkImageAspectFlags</c> specifying which aspect(s) of the image are included in the view.
        /// </summary>
        [FieldOffset(0)]
        public VkImageAspectFlags AspectMask;

        /// <summary>
        ///     <c>BaseMipLevel</c> is the first mipmap level accessible to the view.
        /// </summary>
        [FieldOffset(4)]
        public int BaseMipLevel;

        /// <summary>
        ///     <c>LevelCount</c> is the number of mipmap levels (starting from <c>baseMipLevel</c>) accessible to the view.
        /// </summary>
        [FieldOffset(8)]
        public int LevelCount;

        /// <summary>
        ///     <c>BaseArrayLayer</c> is the first array layer accessible to the view.
        /// </summary>
        [FieldOffset(12)]
        public int BaseArrayLayer;

        /// <summary>
        ///     <c>LayerCount</c> is the number of array layers (starting from <c>baseArrayLayer</c>) accessible to the view.
        /// </summary>
        [FieldOffset(16)]
        public int LayerCount;
    }
}
