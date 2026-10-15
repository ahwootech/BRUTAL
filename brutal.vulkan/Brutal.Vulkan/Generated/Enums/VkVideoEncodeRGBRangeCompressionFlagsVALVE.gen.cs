namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRgbRangeCompressionFlagBitsVALVE.html">VkVideoEncodeRgbRangeCompressionFlagBitsVALVE</see> - Range compression operation to perform for encode rgb conversion
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The video encode {RGBprime} range compression to be applied to color
    ///         component values of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-input-picture">encode input picture^</see> before
    ///         video coding is defined by the <c>rgbRange</c> member of the
    ///         <c>VkVideoEncodeSessionRgbConversionCreateInfoVALVE</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeRgbRangeCompressionFlagsVALVE</c> enum describes
    ///         whether color components are encoded using the full range of numerical
    ///         values or whether values are reserved for headroom and foot room:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_video_encode_rgb_conversion
    ///         typedef enum VkVideoEncodeRgbRangeCompressionFlagBitsVALVE {
    ///             VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_FULL_RANGE_BIT_VALVE = 0x00000001,
    ///             VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_NARROW_RANGE_BIT_VALVE = 0x00000002,
    ///         } VkVideoEncodeRgbRangeCompressionFlagBitsVALVE;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeRGBRangeCompressionFlagsVALVE : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FullRangeBitVALVE</c>  specifies the following transformations are applied: + [latexmath] ++++ \begin{aligned} Y&apos; &amp;= C&apos;_{rgba}[G] \\ C_B &amp;= C&apos;_{rgba}[B] - {{2^{(n-1)}}\over{(2^n) - 1}} \\ C_R &amp;= C&apos;_{rgba}[R] - {{2^{(n-1)}}\over{(2^n) - 1}} \end{aligned} ++++ + [NOTE]
        /// </summary>
        FullRangeBitVALVE = 0x00000001,

        /// <summary>
        ///     <c>NarrowRangeBitVALVE</c>
        /// </summary>
        NarrowRangeBitVALVE = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumVALVE</c>
        /// </summary>
        FlagBitsMaxEnumVALVE = 0x7FFFFFFF,
    }
}
