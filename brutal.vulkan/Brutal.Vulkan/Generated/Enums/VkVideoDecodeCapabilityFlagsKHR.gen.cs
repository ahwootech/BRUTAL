namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeCapabilityFlagBitsKHR.html">VkVideoDecodeCapabilityFlagBitsKHR</see> - Video decode capability flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in <c>VkVideoDecodeCapabilitiesKHR::flags</c>,
    ///         indicating the decoding capabilities supported, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_queue
    ///         typedef enum VkVideoDecodeCapabilityFlagBitsKHR {
    ///             VK_VIDEO_DECODE_CAPABILITY_DPB_AND_OUTPUT_COINCIDE_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_DECODE_CAPABILITY_DPB_AND_OUTPUT_DISTINCT_BIT_KHR = 0x00000002,
    ///         } VkVideoDecodeCapabilityFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoDecodeCapabilityFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DpbAndOutputCoincideBitKHR</c>  specifies support for using the same video picture resource as the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#reconstructed-picture">reconstructed picture^</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-output-picture">decode output picture^</see> in a video decode operation.
        /// </summary>
        DpbAndOutputCoincideBitKHR = 0x00000001,

        /// <summary>
        ///     <c>DpbAndOutputDistinctBitKHR</c>  specifies support for using distinct video picture resources as the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#reconstructed-picture">reconstructed picture^</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-output-picture">decode output picture^</see> in a video decode operation.
        /// </summary>
        DpbAndOutputDistinctBitKHR = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
