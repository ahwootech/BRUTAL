namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAcquireProfilingLockFlagBitsKHR.html">VkAcquireProfilingLockFlagBitsKHR</see> - Reserved for future use
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef enum VkAcquireProfilingLockFlagBitsKHR {
    ///         } VkAcquireProfilingLockFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkAcquireProfilingLockFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
