namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlModeFlagBitsKHR.html">VkVideoEncodeRateControlModeFlagBitsKHR</see> - Video encode rate control modes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The rate control modes are defined with the following enums:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef enum VkVideoEncodeRateControlModeFlagBitsKHR {
    ///             VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DEFAULT_KHR = 0,
    ///             VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR = 0x00000001,
    ///             VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR = 0x00000002,
    ///             VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR = 0x00000004,
    ///         } VkVideoEncodeRateControlModeFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeRateControlModeFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DefaultKHR</c> specifies the use of implementation-specific rate control.
        /// </summary>
        DefaultKHR = 0,

        /// <summary>
        ///     <c>DisabledBitKHR</c> specifies that rate control is disabled and the application will specify per-operation rate control parameters controlling the encoding quality. In this mode implementations will encode pictures independently of the output bitrate of prior video encode operations.
        /// </summary>
        DisabledBitKHR = 0x00000001,

        /// <summary>
        ///     <c>CbrBitKHR</c> specifies the use of constant bitrate (CBR) rate control mode. In this mode the implementation will attempt to produce the encoded bitstream at a constant bitrate while conforming to the constraints of other rate control parameters.
        /// </summary>
        CbrBitKHR = 0x00000002,

        /// <summary>
        ///     <c>VbrBitKHR</c> specifies the use of variable bitrate (VBR) rate control mode. In this mode the implementation will produce the encoded bitstream at a variable bitrate according to the constraints of other rate control parameters.
        /// </summary>
        VbrBitKHR = 0x00000004,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
