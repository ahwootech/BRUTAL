using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFullScreenExclusiveEXT.html">VkFullScreenExclusiveEXT</see> - Hint values an application can specify affecting full-screen transition behavior
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkSurfaceFullScreenExclusiveInfoEXT::fullScreenExclusive</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_full_screen_exclusive
    ///         typedef enum VkFullScreenExclusiveEXT {
    ///             VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT = 0,
    ///             VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT = 1,
    ///             VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT = 2,
    ///             VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT = 3,
    ///         } VkFullScreenExclusiveEXT;
    ///     </code>
    /// </remarks>
    [SupportedOSPlatform("windows")]
    public enum VkFullScreenExclusiveEXT : int
    {
        /// <summary>
        ///     <c>DefaultEXT</c> specifies that the implementation <i>should</i> determine the appropriate full-screen method by whatever means it deems appropriate.
        /// </summary>
        DefaultEXT = 0,

        /// <summary>
        ///     <c>AllowedEXT</c> specifies that the implementation may: use full-screen exclusive mechanisms when available. Such mechanisms may: result in better performance and/or the availability of different presentation capabilities, but may: require a more disruptive transition during swapchain initialization, first presentation and/or destruction.
        /// </summary>
        AllowedEXT = 1,

        /// <summary>
        ///     <c>DisallowedEXT</c> specifies that the implementation <i>should</i> avoid using full-screen mechanisms which rely on disruptive transitions.
        /// </summary>
        DisallowedEXT = 2,

        /// <summary>
        ///     <c>ApplicationControlledEXT</c> specifies that the application will manage full-screen exclusive mode by using the <c>vkAcquireFullScreenExclusiveModeEXT</c> and <c>vkReleaseFullScreenExclusiveModeEXT</c> commands.
        /// </summary>
        ApplicationControlledEXT = 3,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
