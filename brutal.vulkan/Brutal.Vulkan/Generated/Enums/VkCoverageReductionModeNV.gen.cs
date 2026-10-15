namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCoverageReductionModeNV.html">VkCoverageReductionModeNV</see> - Specify the coverage reduction mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPipelineCoverageReductionStateCreateInfoNV::coverageReductionMode</c>,
    ///         specifying how color sample coverage is generated from pixel coverage, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_coverage_reduction_mode
    ///         typedef enum VkCoverageReductionModeNV {
    ///             VK_COVERAGE_REDUCTION_MODE_MERGE_NV = 0,
    ///             VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV = 1,
    ///         } VkCoverageReductionModeNV;
    ///     </code>
    /// </remarks>
    public enum VkCoverageReductionModeNV : int
    {
        /// <summary>
        ///     <c>MergeNV</c> specifies that each color sample will be associated with an implementation-dependent subset of samples in the pixel coverage. If any of those associated samples are covered, the color sample is covered.
        /// </summary>
        MergeNV = 0,

        /// <summary>
        ///     <c>TruncateNV</c> specifies that for color samples present in the color attachments, a color sample is covered if the pixel coverage sample with the same <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-multisampling-coverage-mask">sample index^</see> <c>i</c> is covered; other pixel coverage samples are discarded.
        /// </summary>
        TruncateNV = 1,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
