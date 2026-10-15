namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateNV.html">VkFragmentShadingRateNV</see> - Enumeration with fragment shading rates
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-fragmentShadingRateEnums"><c>fragmentShadingRateEnums</c>^</see>
    ///         feature is enabled, fragment shading rates may be specified using the
    ///         <c>VkFragmentShadingRateNV</c> enumerated type defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_fragment_shading_rate_enums
    ///         typedef enum VkFragmentShadingRateNV {
    ///             VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = 0,
    ///             VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = 1,
    ///             VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = 4,
    ///             VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = 5,
    ///             VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = 6,
    ///             VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = 9,
    ///             VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = 10,
    ///             VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = 11,
    ///             VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = 12,
    ///             VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = 13,
    ///             VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = 14,
    ///             VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV = 15,
    ///         } VkFragmentShadingRateNV;
    ///     </code>
    /// </remarks>
    public enum VkFragmentShadingRateNV : int
    {
        /// <summary>
        ///     <c>_1InvocationPerPixelNV</c> specifies a fragment size of 1x1 pixels.
        /// </summary>
        _1InvocationPerPixelNV = 0,

        /// <summary>
        ///     <c>_1InvocationPer1X2PixelsNV</c> specifies a fragment size of 1x2 pixels.
        /// </summary>
        _1InvocationPer1X2PixelsNV = 1,

        /// <summary>
        ///     <c>_1InvocationPer2X1PixelsNV</c> specifies a fragment size of 2x1 pixels.
        /// </summary>
        _1InvocationPer2X1PixelsNV = 4,

        /// <summary>
        ///     <c>_1InvocationPer2X2PixelsNV</c> specifies a fragment size of 2x2 pixels.
        /// </summary>
        _1InvocationPer2X2PixelsNV = 5,

        /// <summary>
        ///     <c>_1InvocationPer2X4PixelsNV</c> specifies a fragment size of 2x4 pixels.
        /// </summary>
        _1InvocationPer2X4PixelsNV = 6,

        /// <summary>
        ///     <c>_1InvocationPer4X2PixelsNV</c> specifies a fragment size of 4x2 pixels.
        /// </summary>
        _1InvocationPer4X2PixelsNV = 9,

        /// <summary>
        ///     <c>_1InvocationPer4X4PixelsNV</c> specifies a fragment size of 4x4 pixels.
        /// </summary>
        _1InvocationPer4X4PixelsNV = 10,

        /// <summary>
        ///     <c>_2InvocationsPerPixelNV</c> specifies a fragment size of 1x1 pixels, with two fragment shader invocations per fragment.
        /// </summary>
        _2InvocationsPerPixelNV = 11,

        /// <summary>
        ///     <c>_4InvocationsPerPixelNV</c> specifies a fragment size of 1x1 pixels, with four fragment shader invocations per fragment.
        /// </summary>
        _4InvocationsPerPixelNV = 12,

        /// <summary>
        ///     <c>_8InvocationsPerPixelNV</c> specifies a fragment size of 1x1 pixels, with eight fragment shader invocations per fragment.
        /// </summary>
        _8InvocationsPerPixelNV = 13,

        /// <summary>
        ///     <c>_16InvocationsPerPixelNV</c> specifies a fragment size of 1x1 pixels, with sixteen fragment shader invocations per fragment.
        /// </summary>
        _16InvocationsPerPixelNV = 14,

        /// <summary>
        ///     <c>NoInvocationsNV</c> specifies that any portions of a primitive that use that shading rate should be discarded without invoking any fragment shader.  To use the shading rates <c>VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV</c>, <c>VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV</c>, <c>VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV</c>, and <c>VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV</c> as a pipeline, primitive, or attachment shading rate, the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-supersampleFragmentShadingRates"><c>supersampleFragmentShadingRates</c>^</see> feature <i>must</i> be enabled. To use the shading rate <c>VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV</c> as a pipeline, primitive, or attachment shading rate, the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-noInvocationFragmentShadingRates"><c>noInvocationFragmentShadingRates</c>^</see> feature <i>must</i> be enabled.
        /// </summary>
        NoInvocationsNV = 15,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
