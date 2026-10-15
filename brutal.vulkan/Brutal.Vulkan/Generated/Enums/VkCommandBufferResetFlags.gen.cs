namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferResetFlagBits.html">VkCommandBufferResetFlagBits</see> - Bitmask controlling behavior of a command buffer reset
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>vkResetCommandBuffer::flags</c>,
    ///         controlling the reset operation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkCommandBufferResetFlagBits {
    ///             VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT = 0x00000001,
    ///         } VkCommandBufferResetFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkCommandBufferResetFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ReleaseResourcesBit</c> specifies that most or all memory resources currently owned by the command buffer <i>should</i> be returned to the parent command pool. If this flag is not set, then the command buffer may: hold onto memory resources and reuse them when recording commands. <c>commandBuffer</c> is moved to the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#commandbuffers-lifecycle">initial state^</see>.
        /// </summary>
        ReleaseResourcesBit = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
