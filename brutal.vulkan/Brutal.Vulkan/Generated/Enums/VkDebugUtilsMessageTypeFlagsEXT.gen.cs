namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessageTypeFlagBitsEXT.html">VkDebugUtilsMessageTypeFlagBitsEXT</see> - Bitmask specifying which types of events cause a debug messenger callback
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDebugUtilsMessengerCreateInfoEXT::messageType</c>, specifying
    ///         event types which cause a debug messenger to call the callback, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_utils
    ///         typedef enum VkDebugUtilsMessageTypeFlagBitsEXT {
    ///             VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT = 0x00000001,
    ///             VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT = 0x00000002,
    ///             VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT = 0x00000004,
    ///             // Provided by VK_EXT_device_address_binding_report
    ///             VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT = 0x00000008,
    ///         } VkDebugUtilsMessageTypeFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDebugUtilsMessageTypeFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>GeneralBitEXT</c> specifies that some general event has occurred. This is typically a non-specification, non-performance event.
        /// </summary>
        GeneralBitEXT = 0x00000001,

        /// <summary>
        ///     <c>ValidationBitEXT</c> specifies that something has occurred during validation against the Vulkan specification that may indicate invalid behavior.
        /// </summary>
        ValidationBitEXT = 0x00000002,

        /// <summary>
        ///     <c>PerformanceBitEXT</c> specifies a potentially non-optimal use of Vulkan, e.g. using <c>vkCmdClearColorImage</c> when setting <c>VkAttachmentDescription::loadOp</c> to <c>VK_ATTACHMENT_LOAD_OP_CLEAR</c> would have worked.
        /// </summary>
        PerformanceBitEXT = 0x00000004,

        /// <summary>
        ///     <c>DeviceAddressBindingBitEXT</c>
        /// </summary>
        DeviceAddressBindingBitEXT = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
