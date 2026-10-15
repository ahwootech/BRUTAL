namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionMode.html">VkSamplerReductionMode</see> - Specify reduction mode for texture filtering
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Reduction modes are specified by <c>VkSamplerReductionMode</c>, which takes
    ///         values:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef enum VkSamplerReductionMode {
    ///             VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE = 0,
    ///             VK_SAMPLER_REDUCTION_MODE_MIN = 1,
    ///             VK_SAMPLER_REDUCTION_MODE_MAX = 2,
    ///             // Provided by VK_QCOM_filter_cubic_clamp
    ///             VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_RANGECLAMP_QCOM = 1000521000,
    ///             // Provided by VK_EXT_sampler_filter_minmax
    ///             VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT = VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE,
    ///             // Provided by VK_EXT_sampler_filter_minmax
    ///             VK_SAMPLER_REDUCTION_MODE_MIN_EXT = VK_SAMPLER_REDUCTION_MODE_MIN,
    ///             // Provided by VK_EXT_sampler_filter_minmax
    ///             VK_SAMPLER_REDUCTION_MODE_MAX_EXT = VK_SAMPLER_REDUCTION_MODE_MAX,
    ///         } VkSamplerReductionMode;
    ///     </code>
    /// </remarks>
    public enum VkSamplerReductionMode : int
    {
        /// <summary>
        ///     <c>WeightedAverage</c> specifies that texel values are combined by computing a weighted average of values in the footprint, using weights as specified in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-unnormalized-to-integer">the image operations chapter^</see>.
        /// </summary>
        WeightedAverage = 0,

        /// <summary>
        ///     <c>Min</c> specifies that texel values are combined by taking the component-wise minimum of values in the footprint with non-zero weights.
        /// </summary>
        Min = 1,

        /// <summary>
        ///     <c>Max</c> specifies that texel values are combined by taking the component-wise maximum of values in the footprint with non-zero weights.
        /// </summary>
        Max = 2,

        /// <summary>
        ///     <c>WeightedAverageRangeclampQCOM</c>
        /// </summary>
        WeightedAverageRangeclampQCOM = 1000521000,

        /// <summary>
        ///     <c>WeightedAverageEXT</c>
        /// </summary>
        WeightedAverageEXT = WeightedAverage,

        /// <summary>
        ///     <c>MinEXT</c>
        /// </summary>
        MinEXT = Min,

        /// <summary>
        ///     <c>MaxEXT</c>
        /// </summary>
        MaxEXT = Max,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
