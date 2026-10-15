namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpacityMicromapFormatKHR.html">VkOpacityMicromapFormatKHR</see> - Format enum for opacity micromaps
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkOpacityMicromapFormatKHR
    ///     </para>
    ///     <para>
    ///         Formats which <i>can</i> be set in <c>VkMicromapUsageKHR::format</c> and
    ///         <c>VkMicromapTriangleKHR::format</c> for micromap builds, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_opacity_micromap
    ///         typedef enum VkOpacityMicromapFormatKHR {
    ///             VK_OPACITY_MICROMAP_FORMAT_2_STATE_KHR = 1,
    ///             VK_OPACITY_MICROMAP_FORMAT_4_STATE_KHR = 2,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_OPACITY_MICROMAP_FORMAT_2_STATE_EXT = VK_OPACITY_MICROMAP_FORMAT_2_STATE_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_OPACITY_MICROMAP_FORMAT_4_STATE_EXT = VK_OPACITY_MICROMAP_FORMAT_4_STATE_KHR,
    ///         } VkOpacityMicromapFormatKHR;
    ///     </code>
    /// </remarks>
    public enum VkOpacityMicromapFormatKHR : int
    {
        /// <summary>
        ///     <c>_2StateKHR</c> specifies that the given micromap format has one bit per subtriangle encoding either fully opaque or fully transparent.
        /// </summary>
        _2StateKHR = 1,

        /// <summary>
        ///     <c>_4StateKHR</c> specifies that the given micromap format has two bits per subtriangle encoding four modes which can be interpreted as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ray-opacity-micromap">Ray Opacity Micromap^</see>.  [NOTE]
        /// </summary>
        _4StateKHR = 2,

        /// <summary>
        ///     <c>_2StateEXT</c>
        /// </summary>
        _2StateEXT = _2StateKHR,

        /// <summary>
        ///     <c>_4StateEXT</c>
        /// </summary>
        _4StateEXT = _4StateKHR,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
