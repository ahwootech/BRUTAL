namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeContentFlagBitsKHR.html">VkVideoEncodeContentFlagBitsKHR</see> - Video encode content flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The following bits <i>can</i> be specified in
    ///         <c>VkVideoEncodeUsageInfoKHR::videoContentHints</c> as a hint about the
    ///         encoded video content:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef enum VkVideoEncodeContentFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_CONTENT_DEFAULT_KHR = 0,
    ///             VK_VIDEO_ENCODE_CONTENT_CAMERA_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_CONTENT_DESKTOP_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_CONTENT_RENDERED_BIT_KHR = 0x00000004,
    ///         } VkVideoEncodeContentFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeContentFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DefaultKHR</c>
        /// </summary>
        DefaultKHR = 0,

        /// <summary>
        ///     <c>CameraBitKHR</c> specifies that video encoding is intended to be used to encode camera content.
        /// </summary>
        CameraBitKHR = 0x00000001,

        /// <summary>
        ///     <c>DesktopBitKHR</c> specifies that video encoding is intended to be used to encode desktop content.
        /// </summary>
        DesktopBitKHR = 0x00000002,

        /// <summary>
        ///     <c>RenderedBitKHR</c> specified that video encoding is intended to be used to encode rendered (e.g. game) content.  [NOTE]
        /// </summary>
        RenderedBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
