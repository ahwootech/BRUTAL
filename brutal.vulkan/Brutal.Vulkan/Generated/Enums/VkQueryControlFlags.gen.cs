namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryControlFlagBits.html">VkQueryControlFlagBits</see> - Bitmask specifying constraints on a query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>vkCmdBeginQuery::flags</c>, specifying
    ///         constraints on the types of queries that <i>can</i> be performed, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkQueryControlFlagBits {
    ///             VK_QUERY_CONTROL_PRECISE_BIT = 0x00000001,
    ///         } VkQueryControlFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkQueryControlFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PreciseBit</c> specifies the precision of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#queries-occlusion">occlusion queries^</see>.
        /// </summary>
        PreciseBit = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
