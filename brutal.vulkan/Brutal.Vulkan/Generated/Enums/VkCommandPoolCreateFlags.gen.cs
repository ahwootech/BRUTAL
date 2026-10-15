namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandPoolCreateFlagBits.html">VkCommandPoolCreateFlagBits</see> - Bitmask specifying usage behavior for a command pool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkCommandPoolCreateInfo::flags</c>,
    ///         specifying usage behavior for a command pool, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkCommandPoolCreateFlagBits {
    ///             VK_COMMAND_POOL_CREATE_TRANSIENT_BIT = 0x00000001,
    ///             VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = 0x00000002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_COMMAND_POOL_CREATE_PROTECTED_BIT = 0x00000004,
    ///         } VkCommandPoolCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkCommandPoolCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>TransientBit</c> specifies that command buffers allocated from the pool will be short-lived, meaning that they will be reset or freed in a relatively short timeframe. This flag may: be used by the implementation to control memory allocation behavior within the pool.
        /// </summary>
        TransientBit = 0x00000001,

        /// <summary>
        ///     <c>ResetCommandBufferBit</c> allows any command buffer allocated from a pool to be individually reset to the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#commandbuffers-lifecycle">initial state^</see>; either by calling <c>vkResetCommandBuffer</c>, or via the implicit reset when calling <c>vkBeginCommandBuffer</c>. If this flag is not set on a pool, then <c>vkResetCommandBuffer</c> <i>must</i> not be called for any command buffer allocated from that pool.
        /// </summary>
        ResetCommandBufferBit = 0x00000002,

        /// <summary>
        ///     <c>ProtectedBit</c>
        /// </summary>
        ProtectedBit = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
