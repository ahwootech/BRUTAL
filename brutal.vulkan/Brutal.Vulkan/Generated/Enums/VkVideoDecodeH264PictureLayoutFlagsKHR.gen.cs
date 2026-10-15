namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureLayoutFlagBitsKHR.html">VkVideoDecodeH264PictureLayoutFlagBitsKHR</see> - H.264 video decode picture layout flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The H.264 video decode picture layout flags are defined as follows:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h264
    ///         typedef enum VkVideoDecodeH264PictureLayoutFlagBitsKHR {
    ///             VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_KHR = 0,
    ///             VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR = 0x00000002,
    ///         } VkVideoDecodeH264PictureLayoutFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoDecodeH264PictureLayoutFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ProgressiveKHR</c> specifies support for progressive content. This flag has the value `0`.
        /// </summary>
        ProgressiveKHR = 0,

        /// <summary>
        ///     <c>InterlacedInterleavedLinesBitKHR</c>  specifies support for or use of a picture layout for interlaced content where all lines belonging to the top field are decoded to the even-numbered lines within the picture resource, and all lines belonging to the bottom field are decoded to the odd-numbered lines within the picture resource.
        /// </summary>
        InterlacedInterleavedLinesBitKHR = 0x00000001,

        /// <summary>
        ///     <c>InterlacedSeparatePlanesBitKHR</c>  specifies support for or use of a picture layout for interlaced content where all lines belonging to a field are grouped together in a single image subregion, and the two fields comprising the frame <i>can</i> be stored in separate image subregions of the same image subresource or in separate image subresources.
        /// </summary>
        InterlacedSeparatePlanesBitKHR = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
