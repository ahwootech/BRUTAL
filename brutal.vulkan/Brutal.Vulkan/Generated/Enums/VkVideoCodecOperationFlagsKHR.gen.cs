namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoCodecOperationFlagBitsKHR.html">VkVideoCodecOperationFlagBitsKHR</see> - Video codec operation bits
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkVideoProfileInfoKHR::videoCodecOperation</c>,
    ///         specifying the type of video coding operation and video compression standard
    ///         used by a video profile, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef enum VkVideoCodecOperationFlagBitsKHR {
    ///             VK_VIDEO_CODEC_OPERATION_NONE_KHR = 0,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR = 0x00010000,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR = 0x00020000,
    ///             // Provided by VK_KHR_video_decode_h264
    ///             VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR = 0x00000001,
    ///             // Provided by VK_KHR_video_decode_h265
    ///             VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR = 0x00000002,
    ///             // Provided by VK_KHR_video_decode_av1
    ///             VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR = 0x00000004,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_VIDEO_CODEC_OPERATION_ENCODE_AV1_BIT_KHR = 0x00040000,
    ///             // Provided by VK_KHR_video_decode_vp9
    ///             VK_VIDEO_CODEC_OPERATION_DECODE_VP9_BIT_KHR = 0x00000008,
    ///         } VkVideoCodecOperationFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoCodecOperationFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>NoneKHR</c> specifies that no video codec operations are supported.
        /// </summary>
        NoneKHR = 0,

        /// <summary>
        ///     <c>EncodeH264BitKHR</c>
        /// </summary>
        EncodeH264BitKHR = 0x00010000,

        /// <summary>
        ///     <c>EncodeH265BitKHR</c>
        /// </summary>
        EncodeH265BitKHR = 0x00020000,

        /// <summary>
        ///     <c>DecodeH264BitKHR</c>
        /// </summary>
        DecodeH264BitKHR = 0x00000001,

        /// <summary>
        ///     <c>DecodeH265BitKHR</c>
        /// </summary>
        DecodeH265BitKHR = 0x00000002,

        /// <summary>
        ///     <c>DecodeAV1BitKHR</c>
        /// </summary>
        DecodeAV1BitKHR = 0x00000004,

        /// <summary>
        ///     <c>EncodeAV1BitKHR</c>
        /// </summary>
        EncodeAV1BitKHR = 0x00040000,

        /// <summary>
        ///     <c>DecodeVP9BitKHR</c>
        /// </summary>
        DecodeVP9BitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
