namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOutOfBandQueueTypeNV.html">VkOutOfBandQueueTypeNV</see> - Type of out of band queue
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkOutOfBandQueueTypeNV</c> enum is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef enum VkOutOfBandQueueTypeNV {
    ///             VK_OUT_OF_BAND_QUEUE_TYPE_RENDER_NV = 0,
    ///             VK_OUT_OF_BAND_QUEUE_TYPE_PRESENT_NV = 1,
    ///         } VkOutOfBandQueueTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkOutOfBandQueueTypeNV : int
    {
        /// <summary>
        ///     <c>RenderNV</c> specifies that work will be submitted to this queue.
        /// </summary>
        RenderNV = 0,

        /// <summary>
        ///     <c>PresentNV</c> specifies that this queue will be presented from.
        /// </summary>
        PresentNV = 1,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
