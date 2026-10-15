namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkThrottleHintTypeSEC.html">VkThrottleHintTypeSEC</see> - Stub description of VkThrottleHintTypeSEC
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_SEC_throttle_hint
    ///         typedef enum VkThrottleHintTypeSEC {
    ///             VK_THROTTLE_HINT_TYPE_DEFAULT_SEC = 0,
    ///             VK_THROTTLE_HINT_TYPE_LOW_SEC = 1,
    ///             VK_THROTTLE_HINT_TYPE_HIGH_SEC = 2,
    ///         } VkThrottleHintTypeSEC;
    ///     </code>
    /// </remarks>
    public enum VkThrottleHintTypeSEC : int
    {
        /// <summary>
        ///     <c>DefaultSEC</c>
        /// </summary>
        DefaultSEC = 0,

        /// <summary>
        ///     <c>LowSEC</c>
        /// </summary>
        LowSEC = 1,

        /// <summary>
        ///     <c>HighSEC</c>
        /// </summary>
        HighSEC = 2,

        /// <summary>
        ///     <c>MaxEnumSEC</c>
        /// </summary>
        MaxEnumSEC = 0x7FFFFFFF,
    }
}
