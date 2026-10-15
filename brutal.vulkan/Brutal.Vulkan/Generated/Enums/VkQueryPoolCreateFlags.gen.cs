namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryPoolCreateFlagBits.html">VkQueryPoolCreateFlagBits</see> - Bitmask specifying query pool properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkQueryPoolCreateInfo::flags</c>,
    ///         specifying options for query pools, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkQueryPoolCreateFlagBits {
    ///             // Provided by VK_KHR_maintenance9
    ///             VK_QUERY_POOL_CREATE_RESET_BIT_KHR = 0x00000001,
    ///         } VkQueryPoolCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkQueryPoolCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ResetBitKHR</c>
        /// </summary>
        ResetBitKHR = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
