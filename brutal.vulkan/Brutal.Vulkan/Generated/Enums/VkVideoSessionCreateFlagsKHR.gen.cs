namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoSessionCreateFlagBitsKHR.html">VkVideoSessionCreateFlagBitsKHR</see> - Video session creation flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkVideoSessionCreateInfoKHR::flags</c>
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef enum VkVideoSessionCreateFlagBitsKHR {
    ///             VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR = 0x00000001,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_PARAMETER_OPTIMIZATIONS_BIT_KHR = 0x00000002,
    ///             // Provided by VK_KHR_video_maintenance1
    ///             VK_VIDEO_SESSION_CREATE_INLINE_QUERIES_BIT_KHR = 0x00000004,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR = 0x00000008,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_EMPHASIS_MAP_BIT_KHR = 0x00000010,
    ///             // Provided by VK_KHR_video_decode_queue with VK_KHR_video_maintenance2
    ///             VK_VIDEO_SESSION_CREATE_INLINE_SESSION_PARAMETERS_BIT_KHR = 0x00000020,
    ///         } VkVideoSessionCreateFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoSessionCreateFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ProtectedContentBitKHR</c> specifies that the video session uses protected video content.
        /// </summary>
        ProtectedContentBitKHR = 0x00000001,

        /// <summary>
        ///     <c>AllowEncodeParameterOptimizationsBitKHR</c>
        /// </summary>
        AllowEncodeParameterOptimizationsBitKHR = 0x00000002,

        /// <summary>
        ///     <c>InlineQueriesBitKHR</c>
        /// </summary>
        InlineQueriesBitKHR = 0x00000004,

        /// <summary>
        ///     <c>AllowEncodeQuantizationDeltaMapBitKHR</c>
        /// </summary>
        AllowEncodeQuantizationDeltaMapBitKHR = 0x00000008,

        /// <summary>
        ///     <c>AllowEncodeEmphasisMapBitKHR</c>
        /// </summary>
        AllowEncodeEmphasisMapBitKHR = 0x00000010,

        /// <summary>
        ///     <c>InlineSessionParametersBitKHR</c>
        /// </summary>
        InlineSessionParametersBitKHR = 0x00000020,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
