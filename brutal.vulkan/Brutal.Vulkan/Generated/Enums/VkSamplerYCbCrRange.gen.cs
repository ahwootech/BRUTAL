namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrRange.html">VkSamplerYcbcrRange</see> - Range of encoded values in a color space
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSamplerYcbcrRange</c> enum describes whether color components are
    ///         encoded using the full range of numerical values or whether values are
    ///         reserved for headroom and foot room.
    ///         <c>VkSamplerYcbcrRange</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkSamplerYcbcrRange {
    ///             VK_SAMPLER_YCBCR_RANGE_ITU_FULL = 0,
    ///             VK_SAMPLER_YCBCR_RANGE_ITU_NARROW = 1,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_SAMPLER_YCBCR_RANGE_ITU_FULL_KHR = VK_SAMPLER_YCBCR_RANGE_ITU_FULL,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_SAMPLER_YCBCR_RANGE_ITU_NARROW_KHR = VK_SAMPLER_YCBCR_RANGE_ITU_NARROW,
    ///         } VkSamplerYcbcrRange;
    ///     </code>
    /// </remarks>
    public enum VkSamplerYCbCrRange : int
    {
        /// <summary>
        ///     <c>ItuFull</c> specifies that the full range of the encoded values are valid and interpreted according to the ITU &quot;`full range`&quot; quantization rules.
        /// </summary>
        ItuFull = 0,

        /// <summary>
        ///     <c>ItuNarrow</c> specifies that headroom and foot room are reserved in the numerical range of encoded values, and the remaining values are expanded according to the ITU &quot;`narrow range`&quot; quantization rules.  The formulae for these conversions is described in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-sampler-YCbCr-conversion-rangeexpand">Sampler {YCbCr} Range Expansion^</see> section of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures">Image Operations^</see> chapter.  No range modification takes place if <c>ycbcrModel</c> is <c>VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY</c>; the <c>ycbcrRange</c> field of <c>VkSamplerYcbcrConversionCreateInfo</c> is ignored in this case.
        /// </summary>
        ItuNarrow = 1,

        /// <summary>
        ///     <c>ItuFullKHR</c>
        /// </summary>
        ItuFullKHR = ItuFull,

        /// <summary>
        ///     <c>ItuNarrowKHR</c>
        /// </summary>
        ItuNarrowKHR = ItuNarrow,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
