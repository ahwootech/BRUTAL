namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRgbModelConversionFlagBitsVALVE.html">VkVideoEncodeRgbModelConversionFlagBitsVALVE</see> - Color model conversions for encode RGB conversion
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The range-compressed values are converted between color models, according to
    ///         the color model conversion specified in the <c>rgbModel</c> member of the
    ///         <c>VkVideoEncodeSessionRgbConversionCreateInfoVALVE</c> structure.
    ///     </para>
    ///     <para>
    ///         <c>VkVideoEncodeRgbModelConversionFlagsVALVE</c> defines the conversion
    ///         from the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-input-picture-info">encode input picture^</see>&apos;s color model to
    ///         the encode color model.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_video_encode_rgb_conversion
    ///         typedef enum VkVideoEncodeRgbModelConversionFlagBitsVALVE {
    ///             VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_RGB_IDENTITY_BIT_VALVE = 0x00000001,
    ///             VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_IDENTITY_BIT_VALVE = 0x00000002,
    ///             VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_709_BIT_VALVE = 0x00000004,
    ///             VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_601_BIT_VALVE = 0x00000008,
    ///             VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_2020_BIT_VALVE = 0x00000010,
    ///         } VkVideoEncodeRgbModelConversionFlagBitsVALVE;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkVideoEncodeRGBModelConversionFlagsVALVE : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>RGBIdentityBitVALVE</c>  specifies the color components are not modified by the color model conversion since they are assumed to represent the desired color model for video coding; {RGBprime} range compression is applied to the components.
        /// </summary>
        RGBIdentityBitVALVE = 0x00000001,

        /// <summary>
        ///     <c>YCbCrIdentityBitVALVE</c>  specifies the color components are not modified by the color model conversion are assumed to be treated as though in {YCbCr} form; video encode {RGBprime} range compression and video encode {RGBprime} chroma subsampling is also ignored.
        /// </summary>
        YCbCrIdentityBitVALVE = 0x00000002,

        /// <summary>
        ///     <c>YCbCr709BitVALVE</c> specifies the color components are transformed from an {RGBprime} representation to a {YCbCr} representation as described in the &quot;`BT.709 {YCbCr} conversion`&quot; section of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#data-format">Khronos Data Format Specification^</see>.
        /// </summary>
        YCbCr709BitVALVE = 0x00000004,

        /// <summary>
        ///     <c>YCbCr601BitVALVE</c> specifies the color components are transformed from an {RGBprime} representation to a {YCbCr} representation as described in the &quot;`BT.601 {YCbCr} conversion`&quot; section of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#data-format">Khronos Data Format Specification^</see>.
        /// </summary>
        YCbCr601BitVALVE = 0x00000008,

        /// <summary>
        ///     <c>YCbCr2020BitVALVE</c>  specifies the color components are transformed from an {RGBprime} representation to a {YCbCr} representation as described in the &quot;`BT.2020 {YCbCr} conversion`&quot; section of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#data-format">Khronos Data Format Specification^</see>.  [NOTE]
        /// </summary>
        YCbCr2020BitVALVE = 0x00000010,

        /// <summary>
        ///     <c>FlagBitsMaxEnumVALVE</c>
        /// </summary>
        FlagBitsMaxEnumVALVE = 0x7FFFFFFF,
    }
}
