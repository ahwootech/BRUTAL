namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClearRect.html">VkClearRect</see> - Structure specifying a clear rectangle
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkClearRect</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkClearRect {
    ///             VkRect2D    rect;
    ///             uint32_t    baseArrayLayer;
    ///             uint32_t    layerCount;
    ///         } VkClearRect;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkClearRect()
    {
        /// <summary>
        ///     <c>Rect</c> is the two-dimensional region to be cleared.
        /// </summary>
        [FieldOffset(0)]
        public VkRect2D Rect;

        /// <summary>
        ///     <c>BaseArrayLayer</c> is the first layer to be cleared.
        /// </summary>
        [FieldOffset(16)]
        public int BaseArrayLayer;

        /// <summary>
        ///     <c>LayerCount</c> is the number of layers to clear.
        /// </summary>
        [FieldOffset(20)]
        public int LayerCount;
    }
}
