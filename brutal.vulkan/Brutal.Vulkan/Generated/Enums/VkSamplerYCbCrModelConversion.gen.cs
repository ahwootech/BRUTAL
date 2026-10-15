namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrModelConversion.html">VkSamplerYcbcrModelConversion</see> - Color model component of a color space
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkSamplerYcbcrModelConversion</c> defines the conversion from the source
    ///         color model to the shader color model.
    ///         Possible values are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkSamplerYcbcrModelConversion {
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY = 0,
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY = 1,
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 = 2,
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 = 3,
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 = 4,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020_KHR = VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020,
    ///         } VkSamplerYcbcrModelConversion;
    ///     </code>
    /// </remarks>
    public enum VkSamplerYCbCrModelConversion : int
    {
        /// <summary>
        ///     <c>RGBIdentity</c> specifies that the input values to the conversion are unmodified.
        /// </summary>
        RGBIdentity = 0,

        /// <summary>
        ///     <c>YCbCrIdentity</c> specifies no model conversion but the inputs are range expanded as for {YCbCr}.
        /// </summary>
        YCbCrIdentity = 1,

        /// <summary>
        ///     <c>YCbCr709</c> specifies the color model conversion from {YCbCr} to {RGBprime} defined in BT.709 and described in the &quot;`BT.709 {YCbCr} conversion`&quot; section of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#data-format">Khronos Data Format Specification^</see>.
        /// </summary>
        YCbCr709 = 2,

        /// <summary>
        ///     <c>YCbCr601</c> specifies the color model conversion from {YCbCr} to {RGBprime} defined in BT.601 and described in the &quot;`BT.601 {YCbCr} conversion`&quot; section of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#data-format">Khronos Data Format Specification^</see>.
        /// </summary>
        YCbCr601 = 3,

        /// <summary>
        ///     <c>YCbCr2020</c> specifies the color model conversion from {YCbCr} to {RGBprime} defined in BT.2020 and described in the &quot;`BT.2020 {YCbCr} conversion`&quot; section of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#data-format">Khronos Data Format Specification^</see>.  In the etext:VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_* color models, for the input to the sampler {YCbCr} range expansion and model conversion:
        /// </summary>
        YCbCr2020 = 4,

        /// <summary>
        ///     <c>RGBIdentityKHR</c>
        /// </summary>
        RGBIdentityKHR = RGBIdentity,

        /// <summary>
        ///     <c>YCbCrIdentityKHR</c>
        /// </summary>
        YCbCrIdentityKHR = YCbCrIdentity,

        /// <summary>
        ///     <c>YCbCr709KHR</c>
        /// </summary>
        YCbCr709KHR = YCbCr709,

        /// <summary>
        ///     <c>YCbCr601KHR</c>
        /// </summary>
        YCbCr601KHR = YCbCr601,

        /// <summary>
        ///     <c>YCbCr2020KHR</c>
        /// </summary>
        YCbCr2020KHR = YCbCr2020,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
