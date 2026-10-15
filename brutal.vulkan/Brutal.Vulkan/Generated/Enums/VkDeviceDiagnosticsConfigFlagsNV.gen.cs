namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceDiagnosticsConfigFlagBitsNV.html">VkDeviceDiagnosticsConfigFlagBitsNV</see> - Bitmask specifying diagnostics flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDeviceDiagnosticsConfigCreateInfoNV::flags</c> include:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_diagnostics_config
    ///         typedef enum VkDeviceDiagnosticsConfigFlagBitsNV {
    ///             VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV = 0x00000001,
    ///             VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV = 0x00000002,
    ///             VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV = 0x00000004,
    ///             VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV = 0x00000008,
    ///         } VkDeviceDiagnosticsConfigFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDeviceDiagnosticsConfigFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>EnableShaderDebugInfoBitNV</c>  enables the generation of debug information for shaders.
        /// </summary>
        EnableShaderDebugInfoBitNV = 0x00000001,

        /// <summary>
        ///     <c>EnableResourceTrackingBitNV</c>  enables driver side tracking of resources (images, buffers, etc.) used to augment the device fault information.
        /// </summary>
        EnableResourceTrackingBitNV = 0x00000002,

        /// <summary>
        ///     <c>EnableAutomaticCheckpointsBitNV</c>  enables automatic insertion of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#device-diagnostic-checkpoints">diagnostic checkpoints^</see> for draw calls, dispatches, and copies. The CPU call stack at the time of the command will be associated as the marker data for the automatically inserted checkpoints.
        /// </summary>
        EnableAutomaticCheckpointsBitNV = 0x00000004,

        /// <summary>
        ///     <c>EnableShaderErrorReportingBitNV</c>  enables shader error reporting.
        /// </summary>
        EnableShaderErrorReportingBitNV = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
