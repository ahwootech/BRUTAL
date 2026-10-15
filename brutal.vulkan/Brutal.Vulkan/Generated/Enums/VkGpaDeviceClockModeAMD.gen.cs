namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaDeviceClockModeAMD.html">VkGpaDeviceClockModeAMD</see> - Enum providing the clock mode or query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which <i>can</i> be set in <c>VkGpaDeviceClockModeAMD</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef enum VkGpaDeviceClockModeAMD {
    ///             VK_GPA_DEVICE_CLOCK_MODE_DEFAULT_AMD = 0,
    ///             VK_GPA_DEVICE_CLOCK_MODE_QUERY_AMD = 1,
    ///             VK_GPA_DEVICE_CLOCK_MODE_PROFILING_AMD = 2,
    ///             VK_GPA_DEVICE_CLOCK_MODE_MIN_MEMORY_AMD = 3,
    ///             VK_GPA_DEVICE_CLOCK_MODE_MIN_ENGINE_AMD = 4,
    ///             VK_GPA_DEVICE_CLOCK_MODE_PEAK_AMD = 5,
    ///         } VkGpaDeviceClockModeAMD;
    ///     </code>
    /// </remarks>
    public enum VkGpaDeviceClockModeAMD : int
    {
        /// <summary>
        ///     <c>DefaultAMD</c> specifies that device clocks and other power settings are restored to their default values.
        /// </summary>
        DefaultAMD = 0,

        /// <summary>
        ///     <c>QueryAMD</c> specifies that the current clock values should be queried, with no new values set.
        /// </summary>
        QueryAMD = 1,

        /// <summary>
        ///     <c>ProfilingAMD</c> specifies that clocks are set to a constant amount which is known to be power and thermal sustainable. The engine/memory clock ratio will be kept the same as much as possible.
        /// </summary>
        ProfilingAMD = 2,

        /// <summary>
        ///     <c>MinMemoryAMD</c> specifies that the memory clock is set to the lowest available level and the engine clock is set to a thermal and power sustainable level.
        /// </summary>
        MinMemoryAMD = 3,

        /// <summary>
        ///     <c>MinEngineAMD</c> specifies that the engine clock is set to the lowest available level and the memory clock is set to a thermal and power sustainable level.
        /// </summary>
        MinEngineAMD = 4,

        /// <summary>
        ///     <c>PeakAMD</c> specifies that the clocks set to maximum when possible and fans set to maximum. Under power and thermal constraints device will clock down.
        /// </summary>
        PeakAMD = 5,

        /// <summary>
        ///     <c>MaxEnumAMD</c>
        /// </summary>
        MaxEnumAMD = 0x7FFFFFFF,
    }
}
