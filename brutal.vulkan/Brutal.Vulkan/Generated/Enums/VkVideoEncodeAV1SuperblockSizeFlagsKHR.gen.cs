namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SuperblockSizeFlagBitsKHR.html">VkVideoEncodeAV1SuperblockSizeFlagBitsKHR</see> - Supported superblock sizes for AV1 video encode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in
    ///         <c>VkVideoEncodeAV1CapabilitiesKHR::superblockSizes</c>, indicating the
    ///         superblock sizes supported by the implementation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef enum VkVideoEncodeAV1SuperblockSizeFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_64_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_128_BIT_KHR = 0x00000002,
    ///         } VkVideoEncodeAV1SuperblockSizeFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeAV1SuperblockSizeFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>_64BitKHR</c> specifies that a superblock size of 64x64 is supported.
        /// </summary>
        _64BitKHR = 0x00000001,

        /// <summary>
        ///     <c>_128BitKHR</c> specifies that a superblock size of 128x128 is supported.
        /// </summary>
        _128BitKHR = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
