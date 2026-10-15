namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkEventCreateFlagBits.html">VkEventCreateFlagBits</see> - Event creation flag bits
    /// </summary>
    /// <remarks>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkEventCreateFlagBits {
    ///             // Provided by VK_VERSION_1_3
    ///             VK_EVENT_CREATE_DEVICE_ONLY_BIT = 0x00000001,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_EVENT_CREATE_DEVICE_ONLY_BIT_KHR = VK_EVENT_CREATE_DEVICE_ONLY_BIT,
    ///         } VkEventCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkEventCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DeviceOnlyBit</c>
        /// </summary>
        DeviceOnlyBit = 0x00000001,

        /// <summary>
        ///     <c>DeviceOnlyBitKHR</c>
        /// </summary>
        DeviceOnlyBitKHR = DeviceOnlyBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
