namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateTypeNV.html">VkFragmentShadingRateTypeNV</see> - Enumeration with fragment shading rate types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFragmentShadingRateTypeNV</c> enumerated type specifies whether a
    ///         graphics pipeline gets its pipeline fragment shading rates and combiners
    ///         from the <c>VkPipelineFragmentShadingRateEnumStateCreateInfoNV</c> structure
    ///         or the <c>VkPipelineFragmentShadingRateStateCreateInfoKHR</c> structure.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_fragment_shading_rate_enums
    ///         typedef enum VkFragmentShadingRateTypeNV {
    ///             VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV = 0,
    ///             VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV = 1,
    ///         } VkFragmentShadingRateTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkFragmentShadingRateTypeNV : int
    {
        /// <summary>
        ///     <c>FragmentSizeNV</c> specifies that a graphics pipeline should obtain its pipeline fragment shading rate and shading rate combiner state from the <c>VkPipelineFragmentShadingRateStateCreateInfoKHR</c> structure and that any state specified by the <c>VkPipelineFragmentShadingRateEnumStateCreateInfoNV</c> structure should be ignored.
        /// </summary>
        FragmentSizeNV = 0,

        /// <summary>
        ///     <c>EnumsNV</c> specifies that a graphics pipeline should obtain its pipeline fragment shading rate and shading rate combiner state from the <c>VkPipelineFragmentShadingRateEnumStateCreateInfoNV</c> structure and that any state specified by the <c>VkPipelineFragmentShadingRateStateCreateInfoKHR</c> structure should be ignored.
        /// </summary>
        EnumsNV = 1,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
