namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageSubresourceLayers.html">VkImageSubresourceLayers</see> - Structure specifying an image subresource layers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageSubresourceLayers</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageSubresourceLayers {
    ///             VkImageAspectFlags    aspectMask;
    ///             uint32_t              mipLevel;
    ///             uint32_t              baseArrayLayer;
    ///             uint32_t              layerCount;
    ///         } VkImageSubresourceLayers;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkImageSubresourceLayers()
    {
        /// <summary>
        ///     <c>AspectMask</c> is a combination of <c>VkImageAspectFlags</c>, selecting the color, depth and/or stencil aspects to be copied.
        /// </summary>
        [FieldOffset(0)]
        public VkImageAspectFlags AspectMask;

        /// <summary>
        ///     <c>MipLevel</c> is the mipmap level to copy
        /// </summary>
        [FieldOffset(4)]
        public int MipLevel;

        /// <summary>
        ///     <c>BaseArrayLayer</c> and <c>layerCount</c> are the starting layer and number of layers to copy.
        /// </summary>
        [FieldOffset(8)]
        public int BaseArrayLayer;

        /// <summary>
        ///     <c>LayerCount</c>
        /// </summary>
        [FieldOffset(12)]
        public int LayerCount;
    }
}
