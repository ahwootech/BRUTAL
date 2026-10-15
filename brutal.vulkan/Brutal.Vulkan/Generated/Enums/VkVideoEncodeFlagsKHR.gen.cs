namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeFlagBitsKHR.html">VkVideoEncodeFlagBitsKHR</see> - Video encode flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkVideoEncodeInfoKHR::flags</c>,
    ///         specifying video encode flags, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_quantization_map
    ///         typedef enum VkVideoEncodeFlagBitsKHR {
    ///             // Provided by VK_KHR_video_encode_intra_refresh
    ///             VK_VIDEO_ENCODE_INTRA_REFRESH_BIT_KHR = 0x00000004,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_ENCODE_WITH_QUANTIZATION_DELTA_MAP_BIT_KHR = 0x00000001,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_ENCODE_WITH_EMPHASIS_MAP_BIT_KHR = 0x00000002,
    ///         } VkVideoEncodeFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>IntraRefreshBitKHR</c>
        /// </summary>
        IntraRefreshBitKHR = 0x00000004,

        /// <summary>
        ///     <c>WithQuantizationDeltaMapBitKHR</c>
        /// </summary>
        WithQuantizationDeltaMapBitKHR = 0x00000001,

        /// <summary>
        ///     <c>WithEmphasisMapBitKHR</c>
        /// </summary>
        WithEmphasisMapBitKHR = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
