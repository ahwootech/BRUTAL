namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFenceCreateFlagBits.html">VkFenceCreateFlagBits</see> - Bitmask specifying initial state and behavior of a fence
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkFenceCreateFlagBits {
    ///             VK_FENCE_CREATE_SIGNALED_BIT = 0x00000001,
    ///         } VkFenceCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkFenceCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SignaledBit</c> specifies that the fence object is created in the signaled state. Otherwise, it is created in the unsignaled state.
        /// </summary>
        SignaledBit = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
