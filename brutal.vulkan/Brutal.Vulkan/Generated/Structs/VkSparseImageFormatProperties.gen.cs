namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseImageFormatProperties.html">VkSparseImageFormatProperties</see> - Structure specifying sparse image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSparseImageFormatProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSparseImageFormatProperties {
    ///             VkImageAspectFlags          aspectMask;
    ///             VkExtent3D                  imageGranularity;
    ///             VkSparseImageFormatFlags    flags;
    ///         } VkSparseImageFormatProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct VkSparseImageFormatProperties()
    {
        /// <summary>
        ///     <c>AspectMask</c> is a bitmask <c>VkImageAspectFlags</c> specifying which aspects of the image the properties apply to.
        /// </summary>
        [FieldOffset(0)]
        public VkImageAspectFlags AspectMask;

        /// <summary>
        ///     <c>ImageGranularity</c> is the width, height, and depth of the sparse image block in texels.
        /// </summary>
        [FieldOffset(4)]
        public VkExtent3D ImageGranularity;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSparseImageFormatFlags</c> specifying additional information about the sparse resource.
        /// </summary>
        [FieldOffset(16)]
        public VkSparseImageFormatFlags Flags;
    }
}
