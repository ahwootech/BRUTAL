namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessageSeverityFlagBitsEXT.html">VkDebugUtilsMessageSeverityFlagBitsEXT</see> - Bitmask specifying which severities of events cause a debug messenger callback
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDebugUtilsMessengerCreateInfoEXT::messageSeverity</c>, specifying
    ///         event severities which cause a debug messenger to call the callback, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_utils
    ///         typedef enum VkDebugUtilsMessageSeverityFlagBitsEXT {
    ///             VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT = 0x00000001,
    ///             VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT = 0x00000010,
    ///             VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT = 0x00000100,
    ///             VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT = 0x00001000,
    ///         } VkDebugUtilsMessageSeverityFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDebugUtilsMessageSeverityFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>VerboseBitEXT</c> specifies the most verbose output indicating all diagnostic messages from the Vulkan loader, layers, and drivers should be captured.
        /// </summary>
        VerboseBitEXT = 0x00000001,

        /// <summary>
        ///     <c>InfoBitEXT</c> specifies an informational message such as resource details that may be handy when debugging an application.
        /// </summary>
        InfoBitEXT = 0x00000010,

        /// <summary>
        ///     <c>WarningBitEXT</c> specifies use of Vulkan that may: expose an application bug. Such cases may not be immediately harmful, such as a fragment shader outputting to a location with no attachment. Other cases may: point to behavior that is almost certainly bad when unintended such as using an image whose memory has not been filled. In general if you see a warning but you know that the behavior is intended/desired, then simply ignore the warning.
        /// </summary>
        WarningBitEXT = 0x00000100,

        /// <summary>
        ///     <c>ErrorBitEXT</c> specifies that the application has violated a valid usage condition of the specification.  [NOTE]
        /// </summary>
        ErrorBitEXT = 0x00001000,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
