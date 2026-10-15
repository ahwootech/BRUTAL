namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBuildMicromapFlagBitsEXT.html">VkBuildMicromapFlagBitsEXT</see> - Bitmask specifying additional parameters for micromap builds
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBuildMicromapFlagBitsEXT
    ///     </para>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkMicromapBuildInfoEXT::flags</c>
    ///         specifying additional parameters for micromap builds, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef enum VkBuildMicromapFlagBitsEXT {
    ///             VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT = 0x00000001,
    ///             VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT = 0x00000002,
    ///             VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT = 0x00000004,
    ///         } VkBuildMicromapFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkBuildMicromapFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PreferFastTraceBitEXT</c> specifies that the given micromap build <i>should</i> prioritize trace performance over build time.
        /// </summary>
        PreferFastTraceBitEXT = 0x00000001,

        /// <summary>
        ///     <c>PreferFastBuildBitEXT</c> specifies that the given micromap build <i>should</i> prioritize build time over trace performance.
        /// </summary>
        PreferFastBuildBitEXT = 0x00000002,

        /// <summary>
        ///     <c>AllowCompactionBitEXT</c> specifies that the micromap <i>can</i> act as the source for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#micromap-copying">copy micromap command^</see> with <c>mode</c> of <c>VK_COPY_MICROMAP_MODE_COMPACT_EXT</c> to produce a compacted micromap.
        /// </summary>
        AllowCompactionBitEXT = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
