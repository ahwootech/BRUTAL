namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueCreateFlagBits.html">VkDeviceQueueCreateFlagBits</see> - Bitmask specifying behavior of the queue
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkDeviceQueueCreateInfo::flags</c>,
    ///         specifying usage behavior of a queue, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkDeviceQueueCreateFlagBits {
    ///             // Provided by VK_VERSION_1_1
    ///             VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT = 0x00000001,
    ///             // Provided by VK_KHR_internally_synchronized_queues
    ///             VK_DEVICE_QUEUE_CREATE_INTERNALLY_SYNCHRONIZED_BIT_KHR = 0x00000004,
    ///         } VkDeviceQueueCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDeviceQueueCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ProtectedBit</c> specifies that the device queue is a protected-capable queue.
        /// </summary>
        ProtectedBit = 0x00000001,

        /// <summary>
        ///     <c>InternallySynchronizedBitKHR</c>
        /// </summary>
        InternallySynchronizedBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
