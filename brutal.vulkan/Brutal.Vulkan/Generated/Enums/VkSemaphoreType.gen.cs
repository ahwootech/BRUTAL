namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreType.html">VkSemaphoreType</see> - Specifies the type of a semaphore object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkSemaphoreTypeCreateInfo::semaphoreType</c>,
    ///         specifying the type of a semaphore, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef enum VkSemaphoreType {
    ///             VK_SEMAPHORE_TYPE_BINARY = 0,
    ///             VK_SEMAPHORE_TYPE_TIMELINE = 1,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_SEMAPHORE_TYPE_BINARY_KHR = VK_SEMAPHORE_TYPE_BINARY,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_SEMAPHORE_TYPE_TIMELINE_KHR = VK_SEMAPHORE_TYPE_TIMELINE,
    ///         } VkSemaphoreType;
    ///     </code>
    /// </remarks>
    public enum VkSemaphoreType : int
    {
        /// <summary>
        ///     <c>Binary</c> specifies a <i>binary semaphore</i> type that has a boolean payload indicating whether the semaphore is currently signaled or unsignaled. When created, the semaphore is in the unsignaled state.
        /// </summary>
        Binary = 0,

        /// <summary>
        ///     <c>Timeline</c> specifies a <i>timeline semaphore</i> type that has a strictly increasing 64-bit unsigned integer payload indicating whether the semaphore is signaled with respect to a particular reference value. When created, the semaphore payload has the value given by the <c>initialValue</c> field of <c>VkSemaphoreTypeCreateInfo</c>.
        /// </summary>
        Timeline = 1,

        /// <summary>
        ///     <c>BinaryKHR</c>
        /// </summary>
        BinaryKHR = Binary,

        /// <summary>
        ///     <c>TimelineKHR</c>
        /// </summary>
        TimelineKHR = Timeline,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
