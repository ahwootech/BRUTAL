namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentRegionKHR.html">VkPresentRegionKHR</see> - Structure containing rectangular region changed by vkQueuePresentKHR for a given VkImage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         For a given image and swapchain, the region to present is specified by the
    ///         <c>VkPresentRegionKHR</c> structure, which is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_incremental_present
    ///         typedef struct VkPresentRegionKHR {
    ///             uint32_t                 rectangleCount;
    ///             const VkRectLayerKHR*    pRectangles;
    ///         } VkPresentRegionKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkPresentRegionKHR()
    {
        /// <summary>
        ///     <c>RectangleCount</c> is the number of rectangles in <c>pRectangles</c>, or zero if the entire image has changed and should be presented.
        /// </summary>
        [FieldOffset(0)]
        public int RectangleCount;

        /// <summary>
        ///     <c>Rectangles</c> is either `NULL` or a pointer to an array of <c>VkRectLayerKHR</c> structures. The <c>VkRectLayerKHR</c> structure is the framebuffer coordinates, plus layer, of a portion of a presentable image that has changed and <i>must</i> be presented. If non-`NULL`, each entry in <c>pRectangles</c> is a rectangle of the given image that has changed since the last image was presented to the given swapchain. The rectangles <i>must</i> be specified relative to <c>VkSurfaceCapabilitiesKHR::currentTransform</c>, regardless of the swapchain&apos;s <c>preTransform</c>. The presentation engine will apply the <c>preTransform</c> transformation to the rectangles, along with any further transformation it applies to the image content.
        /// </summary>
        [FieldOffset(8)]
        public VkRectLayerKHR* Rectangles;
    }
}
