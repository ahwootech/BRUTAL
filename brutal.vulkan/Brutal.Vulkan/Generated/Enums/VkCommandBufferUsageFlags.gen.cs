namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferUsageFlagBits.html">VkCommandBufferUsageFlagBits</see> - Bitmask specifying usage behavior for command buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkCommandBufferBeginInfo::flags</c>,
    ///         specifying usage behavior for a command buffer, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkCommandBufferUsageFlagBits {
    ///             VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT = 0x00000001,
    ///             VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT = 0x00000002,
    ///             VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT = 0x00000004,
    ///         } VkCommandBufferUsageFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkCommandBufferUsageFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>OneTimeSubmitBit</c> specifies that each recording of the command buffer will only be submitted once, and the command buffer will be reset and recorded again between each submission.
        /// </summary>
        OneTimeSubmitBit = 0x00000001,

        /// <summary>
        ///     <c>RenderPassContinueBit</c> specifies that a secondary command buffer is considered to be entirely inside a render pass. If this is a primary command buffer, then this bit is ignored.
        /// </summary>
        RenderPassContinueBit = 0x00000002,

        /// <summary>
        ///     <c>SimultaneousUseBit</c> specifies that a command buffer <i>can</i> be resubmitted to any queue of the same queue family while it is in the <i>pending state</i>, and recorded into multiple primary command buffers.
        /// </summary>
        SimultaneousUseBit = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
