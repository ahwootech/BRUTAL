namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoChromaSubsamplingFlagBitsKHR.html">VkVideoChromaSubsamplingFlagBitsKHR</see> - Video format chroma subsampling bits
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The video format chroma subsampling is defined with the following enums:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef enum VkVideoChromaSubsamplingFlagBitsKHR {
    ///             VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR = 0,
    ///             VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR = 0x00000008,
    ///         } VkVideoChromaSubsamplingFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoChromaSubsamplingFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>InvalidKHR</c>
        /// </summary>
        InvalidKHR = 0,

        /// <summary>
        ///     <c>MonochromeBitKHR</c> specifies that the format is monochrome.
        /// </summary>
        MonochromeBitKHR = 0x00000001,

        /// <summary>
        ///     <c>_420BitKHR</c> specified that the format is 4:2:0 chroma subsampled, i.e. the two chroma components are sampled horizontally and vertically at half the sample rate of the luma component.
        /// </summary>
        _420BitKHR = 0x00000002,

        /// <summary>
        ///     <c>_422BitKHR</c> - the format is 4:2:2 chroma subsampled, i.e. the two chroma components are sampled horizontally at half the sample rate of luma component.
        /// </summary>
        _422BitKHR = 0x00000004,

        /// <summary>
        ///     <c>_444BitKHR</c> - the format is 4:4:4 chroma sampled, i.e. all three components of the {YCbCr} format are sampled at the same rate, thus there is no chroma subsampling.
        /// </summary>
        _444BitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
