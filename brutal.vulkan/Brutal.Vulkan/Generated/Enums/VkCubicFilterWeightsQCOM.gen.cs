namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCubicFilterWeightsQCOM.html">VkCubicFilterWeightsQCOM</see> - Specify cubic weights for texture filtering
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the
    ///         <c>VkSamplerCubicWeightsCreateInfoQCOM::cubicWeights</c>, specifying
    ///         cubic weights used in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-texel-cubic-filtering">Texel Cubic
    ///         Filtering^</see> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_filter_cubic_weights
    ///         typedef enum VkCubicFilterWeightsQCOM {
    ///             VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM = 0,
    ///             VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM = 1,
    ///             VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM = 2,
    ///             VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM = 3,
    ///         } VkCubicFilterWeightsQCOM;
    ///     </code>
    /// </remarks>
    public enum VkCubicFilterWeightsQCOM : int
    {
        /// <summary>
        ///     <c>CatmullRomQCOM</c> specifies Catmull-Rom weights.
        /// </summary>
        CatmullRomQCOM = 0,

        /// <summary>
        ///     <c>ZeroTangentCardinalQCOM</c> specifies Zero Tangent Cardinal weights.
        /// </summary>
        ZeroTangentCardinalQCOM = 1,

        /// <summary>
        ///     <c>BSplineQCOM</c> specifies B-Spline weights.
        /// </summary>
        BSplineQCOM = 2,

        /// <summary>
        ///     <c>MitchellNetravaliQCOM</c> specifies Mitchell-Netravali weights.
        /// </summary>
        MitchellNetravaliQCOM = 3,

        /// <summary>
        ///     <c>MaxEnumQCOM</c>
        /// </summary>
        MaxEnumQCOM = 0x7FFFFFFF,
    }
}
