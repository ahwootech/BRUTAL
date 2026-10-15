namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandPoolResetFlagBits.html">VkCommandPoolResetFlagBits</see> - Bitmask controlling behavior of a command pool reset
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>vkResetCommandPool::flags</c>, controlling
    ///         the reset operation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkCommandPoolResetFlagBits {
    ///             VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT = 0x00000001,
    ///         } VkCommandPoolResetFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkCommandPoolResetFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ReleaseResourcesBit</c>  specifies that resetting a command pool recycles all of the resources from the command pool back to the system.
        /// </summary>
        ReleaseResourcesBit = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
