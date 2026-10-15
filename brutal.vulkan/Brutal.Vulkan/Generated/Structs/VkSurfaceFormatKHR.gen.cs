namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceFormatKHR.html">VkSurfaceFormatKHR</see> - Structure describing a supported swapchain format-color space pair
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceFormatKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface
    ///         typedef struct VkSurfaceFormatKHR {
    ///             VkFormat           format;
    ///             VkColorSpaceKHR    colorSpace;
    ///         } VkSurfaceFormatKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkSurfaceFormatKHR()
    {
        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> that is compatible with the specified surface.
        /// </summary>
        [FieldOffset(0)]
        public VkFormat Format;

        /// <summary>
        ///     <c>ColorSpace</c> is a presentation <c>VkColorSpaceKHR</c> that is compatible with the surface.
        /// </summary>
        [FieldOffset(4)]
        public VkColorSpaceKHR ColorSpace;
    }
}
