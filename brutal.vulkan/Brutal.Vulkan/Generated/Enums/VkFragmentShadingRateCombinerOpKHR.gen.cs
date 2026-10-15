namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateCombinerOpKHR.html">VkFragmentShadingRateCombinerOpKHR</see> - Control how fragment shading rates are combined
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The equation used for each combiner operation is defined by
    ///         <c>VkFragmentShadingRateCombinerOpKHR</c>:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_fragment_shading_rate
    ///         typedef enum VkFragmentShadingRateCombinerOpKHR {
    ///             VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR = 0,
    ///             VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR = 1,
    ///             VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_KHR = 2,
    ///             VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_KHR = 3,
    ///             VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR = 4,
    ///         } VkFragmentShadingRateCombinerOpKHR;
    ///     </code>
    /// </remarks>
    public enum VkFragmentShadingRateCombinerOpKHR : int
    {
        /// <summary>
        ///     <c>KeepKHR</c> specifies a combiner operation of <c>combine(A~xy~,B~xy~) = A~xy~</c>.
        /// </summary>
        KeepKHR = 0,

        /// <summary>
        ///     <c>ReplaceKHR</c> specifies a combiner operation of <c>combine(A~xy~,B~xy~) = B~xy~</c>.
        /// </summary>
        ReplaceKHR = 1,

        /// <summary>
        ///     <c>MinKHR</c> specifies a combiner operation of <c>combine(A~xy~,B~xy~) = min(A~xy~,B~xy~)</c>.
        /// </summary>
        MinKHR = 2,

        /// <summary>
        ///     <c>MaxKHR</c> specifies a combiner operation of <c>combine(A~xy~,B~xy~) = max(A~xy~,B~xy~)</c>.
        /// </summary>
        MaxKHR = 3,

        /// <summary>
        ///     <c>MulKHR</c> specifies a combiner operation of <c>combine(A~xy~,B~xy~) = A~xy~*B~xy~</c>.  where <c>combine(A~xy~,B~xy~)</c> is the combine operation, and <c>A~xy~</c> and <c>B~xy~</c> are the inputs to the operation.  If <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#limits-fragmentShadingRateStrictMultiplyCombiner"><c>fragmentShadingRateStrictMultiplyCombiner</c>^</see> is <c>VK_FALSE</c>, using <c>VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR</c> with values of 1 for both A and B in the same dimension results in the value 2 being produced for that dimension. See the definition of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#limits-fragmentShadingRateStrictMultiplyCombiner"><c>fragmentShadingRateStrictMultiplyCombiner</c>^</see> for more information.  These operations are performed in a component-wise fashion.
        /// </summary>
        MulKHR = 4,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
