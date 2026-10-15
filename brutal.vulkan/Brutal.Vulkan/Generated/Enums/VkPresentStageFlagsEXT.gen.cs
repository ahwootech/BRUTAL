namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentStageFlagBitsEXT.html">VkPresentStageFlagBitsEXT</see> - Bitmask specifying stages of the image presentation process
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Presenting an image to the user typically involves multiple stages.
    ///         Bits which <i>can</i> be set to specify present stages are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef enum VkPresentStageFlagBitsEXT {
    ///             VK_PRESENT_STAGE_QUEUE_OPERATIONS_END_BIT_EXT = 0x00000001,
    ///             VK_PRESENT_STAGE_REQUEST_DEQUEUED_BIT_EXT = 0x00000002,
    ///             VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_OUT_BIT_EXT = 0x00000004,
    ///             VK_PRESENT_STAGE_IMAGE_FIRST_PIXEL_VISIBLE_BIT_EXT = 0x00000008,
    ///         } VkPresentStageFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPresentStageFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>QueueOperationsEndBitEXT</c> marks the end of the set of queue operations enqueued by <c>vkQueuePresentKHR</c> on the provided <c>VkQueue</c> for a presentation request.
        /// </summary>
        QueueOperationsEndBitEXT = 0x00000001,

        /// <summary>
        ///     <c>RequestDequeuedBitEXT</c> is the stage after which the presentation request has been dequeued from the swapchain&apos;s internal presentation request queue, if any, as specified by the present mode associated with that request.
        /// </summary>
        RequestDequeuedBitEXT = 0x00000002,

        /// <summary>
        ///     <c>ImageFirstPixelOutBitEXT</c> is the stage after which data for the first pixel of the presentation request associated with the image has left the presentation engine for a display hardware.
        /// </summary>
        ImageFirstPixelOutBitEXT = 0x00000004,

        /// <summary>
        ///     <c>ImageFirstPixelVisibleBitEXT</c> is the stage after which a display hardware has made the first pixel visible for the presentation request associated with the image to be presented.  [NOTE]
        /// </summary>
        ImageFirstPixelVisibleBitEXT = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
