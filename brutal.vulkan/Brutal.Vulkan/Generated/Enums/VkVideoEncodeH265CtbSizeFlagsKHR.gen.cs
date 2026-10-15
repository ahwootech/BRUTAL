namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CtbSizeFlagBitsKHR.html">VkVideoEncodeH265CtbSizeFlagBitsKHR</see> - Supported CTB sizes for H.265 video encode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeH265CapabilitiesKHR::ctbSizes</c>, indicating the CTB
    ///         sizes supported by the implementation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef enum VkVideoEncodeH265CtbSizeFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_KHR = 0x00000004,
    ///         } VkVideoEncodeH265CtbSizeFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeH265CtbSizeFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>_16BitKHR</c> specifies that a CTB size of 16x16 is supported.
        /// </summary>
        _16BitKHR = 0x00000001,

        /// <summary>
        ///     <c>_32BitKHR</c> specifies that a CTB size of 32x32 is supported.
        /// </summary>
        _32BitKHR = 0x00000002,

        /// <summary>
        ///     <c>_64BitKHR</c> specifies that a CTB size of 64x64 is supported.
        /// </summary>
        _64BitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
