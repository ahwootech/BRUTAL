namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersCreateFlagBitsKHR.html">VkVideoSessionParametersCreateFlagBitsKHR</see> - Video session parameters creation flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkVideoSessionParametersCreateInfoKHR::flags</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_quantization_map
    ///         typedef enum VkVideoSessionParametersCreateFlagBitsKHR {
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_VIDEO_SESSION_PARAMETERS_CREATE_QUANTIZATION_MAP_COMPATIBLE_BIT_KHR = 0x00000001,
    ///         } VkVideoSessionParametersCreateFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoSessionParametersCreateFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>QuantizationMapCompatibleBitKHR</c>  specifies that the created video session parameters object <i>can</i> be used with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-quantization-map">quantization maps^</see>.
        /// </summary>
        QuantizationMapCompatibleBitKHR = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
