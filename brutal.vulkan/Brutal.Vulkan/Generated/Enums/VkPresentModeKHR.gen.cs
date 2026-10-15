namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentModeKHR.html">VkPresentModeKHR</see> - Presentation mode supported for a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of elements of the
    ///         <c>vkGetPhysicalDeviceSurfacePresentModesKHR::pPresentModes</c> array,
    ///         indicating the supported presentation modes for a surface, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface
    ///         typedef enum VkPresentModeKHR {
    ///             VK_PRESENT_MODE_IMMEDIATE_KHR = 0,
    ///             VK_PRESENT_MODE_MAILBOX_KHR = 1,
    ///             VK_PRESENT_MODE_FIFO_KHR = 2,
    ///             VK_PRESENT_MODE_FIFO_RELAXED_KHR = 3,
    ///             // Provided by VK_KHR_shared_presentable_image
    ///             VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR = 1000111000,
    ///             // Provided by VK_KHR_shared_presentable_image
    ///             VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR = 1000111001,
    ///             // Provided by VK_KHR_present_mode_fifo_latest_ready
    ///             VK_PRESENT_MODE_FIFO_LATEST_READY_KHR = 1000361000,
    ///             // Provided by VK_EXT_present_mode_fifo_latest_ready
    ///             VK_PRESENT_MODE_FIFO_LATEST_READY_EXT = VK_PRESENT_MODE_FIFO_LATEST_READY_KHR,
    ///         } VkPresentModeKHR;
    ///     </code>
    /// </remarks>
    public enum VkPresentModeKHR : int
    {
        /// <summary>
        ///     <c>ImmediateKHR</c> specifies that the presentation engine does not wait for a vertical blanking period to update the current image, meaning this mode may: result in visible tearing. No internal queuing of presentation requests is needed, as the requests are applied immediately.
        /// </summary>
        ImmediateKHR = 0,

        /// <summary>
        ///     <c>MailboxKHR</c> specifies that the presentation engine waits for the next vertical blanking period to update the current image. Tearing cannot: be observed. An internal single-entry queue is used to hold pending presentation requests. If the queue is full when a new presentation request is received, the new request replaces the existing entry, and any images associated with the prior entry become available for reuse by the application. One request is removed from the queue and processed during each vertical blanking period in which the queue is non-empty.
        /// </summary>
        MailboxKHR = 1,

        /// <summary>
        ///     <c>FifoKHR</c> specifies that the presentation engine waits for the next vertical blanking period to update the current image. Tearing cannot: be observed. An internal queue is used to hold pending presentation requests. New requests are appended to the end of the queue, and one request is removed from the beginning of the queue and processed during each vertical blanking period in which the queue is non-empty. This is the only value of <c>presentMode</c> that is required: to be supported.
        /// </summary>
        FifoKHR = 2,

        /// <summary>
        ///     <c>FifoRelaxedKHR</c> specifies that the presentation engine generally waits for the next vertical blanking period to update the current image. If a vertical blanking period has already passed since the last update of the current image then the presentation engine does not wait for another vertical blanking period for the update, meaning this mode may: result in visible tearing in this case. This mode is useful for reducing visual stutter with an application that will mostly present a new image before the next vertical blanking period, but may occasionally be late, and present a new image just after the next vertical blanking period. An internal queue is used to hold pending presentation requests. New requests are appended to the end of the queue, and one request is removed from the beginning of the queue and processed during or after each vertical blanking period in which the queue is non-empty.
        /// </summary>
        FifoRelaxedKHR = 3,

        /// <summary>
        ///     <c>SharedDemandRefreshKHR</c>
        /// </summary>
        SharedDemandRefreshKHR = 1000111000,

        /// <summary>
        ///     <c>SharedContinuousRefreshKHR</c>
        /// </summary>
        SharedContinuousRefreshKHR = 1000111001,

        /// <summary>
        ///     <c>FifoLatestReadyKHR</c>
        /// </summary>
        FifoLatestReadyKHR = 1000361000,

        /// <summary>
        ///     <c>FifoLatestReadyEXT</c>
        /// </summary>
        FifoLatestReadyEXT = FifoLatestReadyKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
