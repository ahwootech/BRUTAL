namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreWaitFlagBits.html">VkSemaphoreWaitFlagBits</see> - Bitmask specifying additional parameters of a semaphore wait operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkSemaphoreWaitInfo::flags</c>, specifying
    ///         additional parameters of a semaphore wait operation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef enum VkSemaphoreWaitFlagBits {
    ///             VK_SEMAPHORE_WAIT_ANY_BIT = 0x00000001,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_SEMAPHORE_WAIT_ANY_BIT_KHR = VK_SEMAPHORE_WAIT_ANY_BIT,
    ///         } VkSemaphoreWaitFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSemaphoreWaitFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>AnyBit</c> specifies that the semaphore wait condition is that at least one of the semaphores in <c>VkSemaphoreWaitInfo::pSemaphores</c> has reached the value specified by the corresponding element of <c>VkSemaphoreWaitInfo::pValues</c>. If <c>VK_SEMAPHORE_WAIT_ANY_BIT</c> is not set, the semaphore wait condition is that all of the semaphores in <c>VkSemaphoreWaitInfo::pSemaphores</c> have reached the value specified by the corresponding element of <c>VkSemaphoreWaitInfo::pValues</c>.
        /// </summary>
        AnyBit = 0x00000001,

        /// <summary>
        ///     <c>AnyBitKHR</c>
        /// </summary>
        AnyBitKHR = AnyBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
