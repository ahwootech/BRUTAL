namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageSubresource.html">VkImageSubresource</see> - Structure specifying an image subresource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageSubresource</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageSubresource {
    ///             VkImageAspectFlags    aspectMask;
    ///             uint32_t              mipLevel;
    ///             uint32_t              arrayLayer;
    ///         } VkImageSubresource;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkImageSubresource()
    {
        /// <summary>
        ///     <c>AspectMask</c> is a <c>VkImageAspectFlags</c> value selecting the image <i>aspect</i>.
        /// </summary>
        [FieldOffset(0)]
        public VkImageAspectFlags AspectMask;

        /// <summary>
        ///     <c>MipLevel</c> selects the mipmap level.
        /// </summary>
        [FieldOffset(4)]
        public int MipLevel;

        /// <summary>
        ///     <c>ArrayLayer</c> selects the array layer.
        /// </summary>
        [FieldOffset(8)]
        public int ArrayLayer;
    }
}
