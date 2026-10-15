namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueGlobalPriority.html">VkQueueGlobalPriority</see> - Values specifying a system-wide queue priority
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkDeviceQueueGlobalPriorityCreateInfo::globalPriority</c>,
    ///         specifying a system-wide priority level are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef enum VkQueueGlobalPriority {
    ///             VK_QUEUE_GLOBAL_PRIORITY_LOW = 128,
    ///             VK_QUEUE_GLOBAL_PRIORITY_MEDIUM = 256,
    ///             VK_QUEUE_GLOBAL_PRIORITY_HIGH = 512,
    ///             VK_QUEUE_GLOBAL_PRIORITY_REALTIME = 1024,
    ///             // Provided by VK_EXT_global_priority
    ///             VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT = VK_QUEUE_GLOBAL_PRIORITY_LOW,
    ///             // Provided by VK_EXT_global_priority
    ///             VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT = VK_QUEUE_GLOBAL_PRIORITY_MEDIUM,
    ///             // Provided by VK_EXT_global_priority
    ///             VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT = VK_QUEUE_GLOBAL_PRIORITY_HIGH,
    ///             // Provided by VK_EXT_global_priority
    ///             VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT = VK_QUEUE_GLOBAL_PRIORITY_REALTIME,
    ///             // Provided by VK_KHR_global_priority
    ///             VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR = VK_QUEUE_GLOBAL_PRIORITY_LOW,
    ///             // Provided by VK_KHR_global_priority
    ///             VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR = VK_QUEUE_GLOBAL_PRIORITY_MEDIUM,
    ///             // Provided by VK_KHR_global_priority
    ///             VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR = VK_QUEUE_GLOBAL_PRIORITY_HIGH,
    ///             // Provided by VK_KHR_global_priority
    ///             VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR = VK_QUEUE_GLOBAL_PRIORITY_REALTIME,
    ///         } VkQueueGlobalPriority;
    ///     </code>
    /// </remarks>
    public enum VkQueueGlobalPriority : int
    {
        /// <summary>
        ///     <c>Low</c> is below the system default. Useful for non-interactive tasks.
        /// </summary>
        Low = 128,

        /// <summary>
        ///     <c>Medium</c> is the system default priority.
        /// </summary>
        Medium = 256,

        /// <summary>
        ///     <c>High</c> is above the system default.
        /// </summary>
        High = 512,

        /// <summary>
        ///     <c>Realtime</c> is the highest priority. Useful for critical tasks.
        /// </summary>
        Realtime = 1024,

        /// <summary>
        ///     <c>LowEXT</c>
        /// </summary>
        LowEXT = Low,

        /// <summary>
        ///     <c>MediumEXT</c>
        /// </summary>
        MediumEXT = Medium,

        /// <summary>
        ///     <c>HighEXT</c>
        /// </summary>
        HighEXT = High,

        /// <summary>
        ///     <c>RealtimeEXT</c>
        /// </summary>
        RealtimeEXT = Realtime,

        /// <summary>
        ///     <c>LowKHR</c>
        /// </summary>
        LowKHR = Low,

        /// <summary>
        ///     <c>MediumKHR</c>
        /// </summary>
        MediumKHR = Medium,

        /// <summary>
        ///     <c>HighKHR</c>
        /// </summary>
        HighKHR = High,

        /// <summary>
        ///     <c>RealtimeKHR</c>
        /// </summary>
        RealtimeKHR = Realtime,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
