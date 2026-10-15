namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRectLayerKHR.html">VkRectLayerKHR</see> - Structure containing a rectangle, including layer, changed by vkQueuePresentKHR for a given VkImage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRectLayerKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_incremental_present
    ///         typedef struct VkRectLayerKHR {
    ///             VkOffset2D    offset;
    ///             VkExtent2D    extent;
    ///             uint32_t      layer;
    ///         } VkRectLayerKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct VkRectLayerKHR()
    {
        /// <summary>
        ///     <c>Offset</c> is the origin of the rectangle, in pixels.
        /// </summary>
        [FieldOffset(0)]
        public VkOffset2D Offset;

        /// <summary>
        ///     <c>Extent</c> is the size of the rectangle, in pixels.
        /// </summary>
        [FieldOffset(8)]
        public VkExtent2D Extent;

        /// <summary>
        ///     <c>Layer</c> is the layer of the image. For images with only one layer, the value of <c>layer</c> <i>must</i> be 0.
        /// </summary>
        [FieldOffset(16)]
        public int Layer;
    }
}
