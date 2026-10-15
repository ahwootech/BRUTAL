namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFormatProperties.html">VkFormatProperties</see> - Structure specifying image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFormatProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkFormatProperties {
    ///             VkFormatFeatureFlags    linearTilingFeatures;
    ///             VkFormatFeatureFlags    optimalTilingFeatures;
    ///             VkFormatFeatureFlags    bufferFeatures;
    ///         } VkFormatProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkFormatProperties()
    {
        /// <summary>
        ///     <c>LinearTilingFeatures</c> is a bitmask of <c>VkFormatFeatureFlags</c> specifying features supported by images created with a <c>tiling</c> parameter of <c>VK_IMAGE_TILING_LINEAR</c>.
        /// </summary>
        [FieldOffset(0)]
        public VkFormatFeatureFlags LinearTilingFeatures;

        /// <summary>
        ///     <c>OptimalTilingFeatures</c> is a bitmask of <c>VkFormatFeatureFlags</c> specifying features supported by images created with a <c>tiling</c> parameter of <c>VK_IMAGE_TILING_OPTIMAL</c>.
        /// </summary>
        [FieldOffset(4)]
        public VkFormatFeatureFlags OptimalTilingFeatures;

        /// <summary>
        ///     <c>BufferFeatures</c> is a bitmask of <c>VkFormatFeatureFlags</c> specifying features supported by buffers.
        /// </summary>
        [FieldOffset(8)]
        public VkFormatFeatureFlags BufferFeatures;
    }
}
