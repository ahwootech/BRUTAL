namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBuildMicromapModeEXT.html">VkBuildMicromapModeEXT</see> - Enum specifying the type of build operation to perform
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBuildMicromapModeEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkBuildMicromapModeEXT</c> enumeration is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef enum VkBuildMicromapModeEXT {
    ///             VK_BUILD_MICROMAP_MODE_BUILD_EXT = 0,
    ///         } VkBuildMicromapModeEXT;
    ///     </code>
    /// </remarks>
    public enum VkBuildMicromapModeEXT : int
    {
        /// <summary>
        ///     <c>BuildEXT</c> specifies that the destination micromap will be built using the specified data.
        /// </summary>
        BuildEXT = 0,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
