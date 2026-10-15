namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugReportFlagBitsEXT.html">VkDebugReportFlagBitsEXT</see> - Bitmask specifying events which cause a debug report callback
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDebugReportCallbackCreateInfoEXT::flags</c>, specifying events
    ///         which cause a debug report, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_report
    ///         typedef enum VkDebugReportFlagBitsEXT {
    ///             VK_DEBUG_REPORT_INFORMATION_BIT_EXT = 0x00000001,
    ///             VK_DEBUG_REPORT_WARNING_BIT_EXT = 0x00000002,
    ///             VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT = 0x00000004,
    ///             VK_DEBUG_REPORT_ERROR_BIT_EXT = 0x00000008,
    ///             VK_DEBUG_REPORT_DEBUG_BIT_EXT = 0x00000010,
    ///         } VkDebugReportFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDebugReportFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>InformationBitEXT</c> specifies an informational message such as resource details that may be handy when debugging an application.
        /// </summary>
        InformationBitEXT = 0x00000001,

        /// <summary>
        ///     <c>WarningBitEXT</c> specifies use of Vulkan that may: expose an application bug. Such cases may not be immediately harmful, such as a fragment shader outputting to a location with no attachment. Other cases may: point to behavior that is almost certainly bad when unintended such as using an image whose memory has not been filled. In general if you see a warning but you know that the behavior is intended/desired, then simply ignore the warning.
        /// </summary>
        WarningBitEXT = 0x00000002,

        /// <summary>
        ///     <c>PerformanceWarningBitEXT</c> specifies a potentially non-optimal use of Vulkan, e.g. using <c>vkCmdClearColorImage</c> when setting <c>VkAttachmentDescription::loadOp</c> to <c>VK_ATTACHMENT_LOAD_OP_CLEAR</c> would have worked.
        /// </summary>
        PerformanceWarningBitEXT = 0x00000004,

        /// <summary>
        ///     <c>ErrorBitEXT</c> specifies that the application has violated a valid usage condition of the specification.
        /// </summary>
        ErrorBitEXT = 0x00000008,

        /// <summary>
        ///     <c>DebugBitEXT</c> specifies diagnostic information from the implementation and layers.
        /// </summary>
        DebugBitEXT = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
