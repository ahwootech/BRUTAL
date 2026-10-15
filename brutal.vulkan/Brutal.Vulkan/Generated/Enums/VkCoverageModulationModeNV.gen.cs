namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCoverageModulationModeNV.html">VkCoverageModulationModeNV</see> - Specify the coverage modulation mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPipelineCoverageModulationStateCreateInfoNV::coverageModulationMode</c>,
    ///         specifying which color components are modulated, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_framebuffer_mixed_samples
    ///         typedef enum VkCoverageModulationModeNV {
    ///             VK_COVERAGE_MODULATION_MODE_NONE_NV = 0,
    ///             VK_COVERAGE_MODULATION_MODE_RGB_NV = 1,
    ///             VK_COVERAGE_MODULATION_MODE_ALPHA_NV = 2,
    ///             VK_COVERAGE_MODULATION_MODE_RGBA_NV = 3,
    ///         } VkCoverageModulationModeNV;
    ///     </code>
    /// </remarks>
    public enum VkCoverageModulationModeNV : int
    {
        /// <summary>
        ///     <c>NoneNV</c> specifies that no components are multiplied by the modulation factor.
        /// </summary>
        NoneNV = 0,

        /// <summary>
        ///     <c>RGBNV</c> specifies that the red, green, and blue components are multiplied by the modulation factor.
        /// </summary>
        RGBNV = 1,

        /// <summary>
        ///     <c>AlphaNV</c> specifies that the alpha component is multiplied by the modulation factor.
        /// </summary>
        AlphaNV = 2,

        /// <summary>
        ///     <c>RGBANV</c> specifies that all components are multiplied by the modulation factor.
        /// </summary>
        RGBANV = 3,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
