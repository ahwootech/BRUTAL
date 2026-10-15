namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265TransformBlockSizeFlagBitsKHR.html">VkVideoEncodeH265TransformBlockSizeFlagBitsKHR</see> - Supported transform block sizes for H.265 video encode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeH265CapabilitiesKHR::transformBlockSizes</c>,
    ///         indicating the transform block sizes supported by the implementation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef enum VkVideoEncodeH265TransformBlockSizeFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_KHR = 0x00000004,
    ///             VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_KHR = 0x00000008,
    ///         } VkVideoEncodeH265TransformBlockSizeFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeH265TransformBlockSizeFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>_4BitKHR</c> specifies that a transform block size of 4x4 is supported.
        /// </summary>
        _4BitKHR = 0x00000001,

        /// <summary>
        ///     <c>_8BitKHR</c> specifies that a transform block size of 8x8 is supported.
        /// </summary>
        _8BitKHR = 0x00000002,

        /// <summary>
        ///     <c>_16BitKHR</c> specifies that a transform block size of 16x16 is supported.
        /// </summary>
        _16BitKHR = 0x00000004,

        /// <summary>
        ///     <c>_32BitKHR</c> specifies that a transform block size of 32x32 is supported.
        /// </summary>
        _32BitKHR = 0x00000008,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
