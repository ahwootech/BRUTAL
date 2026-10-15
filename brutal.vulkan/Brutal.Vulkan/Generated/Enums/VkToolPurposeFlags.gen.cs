namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkToolPurposeFlagBits.html">VkToolPurposeFlagBits</see> - Bitmask specifying the purposes of an active tool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkPhysicalDeviceToolProperties::purposes</c>, specifying the
    ///         purposes of an active tool, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef enum VkToolPurposeFlagBits {
    ///             VK_TOOL_PURPOSE_VALIDATION_BIT = 0x00000001,
    ///             VK_TOOL_PURPOSE_PROFILING_BIT = 0x00000002,
    ///             VK_TOOL_PURPOSE_TRACING_BIT = 0x00000004,
    ///             VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT = 0x00000008,
    ///             VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT = 0x00000010,
    ///             // Provided by VK_EXT_debug_report with VK_EXT_tooling_info, VK_EXT_debug_utils with VK_EXT_tooling_info
    ///             VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT = 0x00000020,
    ///             // Provided by VK_EXT_debug_marker with VK_EXT_tooling_info, VK_EXT_debug_utils with VK_EXT_tooling_info
    ///             VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT = 0x00000040,
    ///             // Provided by VK_EXT_tooling_info
    ///             VK_TOOL_PURPOSE_VALIDATION_BIT_EXT = VK_TOOL_PURPOSE_VALIDATION_BIT,
    ///             // Provided by VK_EXT_tooling_info
    ///             VK_TOOL_PURPOSE_PROFILING_BIT_EXT = VK_TOOL_PURPOSE_PROFILING_BIT,
    ///             // Provided by VK_EXT_tooling_info
    ///             VK_TOOL_PURPOSE_TRACING_BIT_EXT = VK_TOOL_PURPOSE_TRACING_BIT,
    ///             // Provided by VK_EXT_tooling_info
    ///             VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT = VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT,
    ///             // Provided by VK_EXT_tooling_info
    ///             VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT = VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT,
    ///         } VkToolPurposeFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkToolPurposeFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ValidationBit</c> specifies that the tool provides validation of API usage.
        /// </summary>
        ValidationBit = 0x00000001,

        /// <summary>
        ///     <c>ProfilingBit</c> specifies that the tool provides profiling of API usage.
        /// </summary>
        ProfilingBit = 0x00000002,

        /// <summary>
        ///     <c>TracingBit</c> specifies that the tool is capturing data about the application&apos;s API usage, including anything from simple logging to capturing data for later replay.
        /// </summary>
        TracingBit = 0x00000004,

        /// <summary>
        ///     <c>AdditionalFeaturesBit</c> specifies that the tool provides additional API features/extensions on top of the underlying implementation.
        /// </summary>
        AdditionalFeaturesBit = 0x00000008,

        /// <summary>
        ///     <c>ModifyingFeaturesBit</c> specifies that the tool modifies the API features/limits/extensions presented to the application.
        /// </summary>
        ModifyingFeaturesBit = 0x00000010,

        /// <summary>
        ///     <c>DebugReportingBitEXT</c>
        /// </summary>
        DebugReportingBitEXT = 0x00000020,

        /// <summary>
        ///     <c>DebugMarkersBitEXT</c>
        /// </summary>
        DebugMarkersBitEXT = 0x00000040,

        /// <summary>
        ///     <c>ValidationBitEXT</c>
        /// </summary>
        ValidationBitEXT = ValidationBit,

        /// <summary>
        ///     <c>ProfilingBitEXT</c>
        /// </summary>
        ProfilingBitEXT = ProfilingBit,

        /// <summary>
        ///     <c>TracingBitEXT</c>
        /// </summary>
        TracingBitEXT = TracingBit,

        /// <summary>
        ///     <c>AdditionalFeaturesBitEXT</c>
        /// </summary>
        AdditionalFeaturesBitEXT = AdditionalFeaturesBit,

        /// <summary>
        ///     <c>ModifyingFeaturesBitEXT</c>
        /// </summary>
        ModifyingFeaturesBitEXT = ModifyingFeaturesBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
