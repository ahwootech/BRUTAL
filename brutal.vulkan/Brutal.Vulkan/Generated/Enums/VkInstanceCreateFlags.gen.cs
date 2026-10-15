namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkInstanceCreateFlagBits.html">VkInstanceCreateFlagBits</see> - Bitmask specifying behavior of the instance
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkInstanceCreateFlagBits {
    ///             // Provided by VK_KHR_portability_enumeration
    ///             VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR = 0x00000001,
    ///         } VkInstanceCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkInstanceCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>EnumeratePortabilityBitKHR</c>
        /// </summary>
        EnumeratePortabilityBitKHR = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
