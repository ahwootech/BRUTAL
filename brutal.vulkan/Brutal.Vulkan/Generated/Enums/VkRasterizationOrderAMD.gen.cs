namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRasterizationOrderAMD.html">VkRasterizationOrderAMD</see> - Specify rasterization order for a graphics pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPipelineRasterizationStateRasterizationOrderAMD::rasterizationOrder</c>,
    ///         specifying the primitive rasterization order, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_rasterization_order
    ///         typedef enum VkRasterizationOrderAMD {
    ///             VK_RASTERIZATION_ORDER_STRICT_AMD = 0,
    ///             VK_RASTERIZATION_ORDER_RELAXED_AMD = 1,
    ///         } VkRasterizationOrderAMD;
    ///     </code>
    /// </remarks>
    public enum VkRasterizationOrderAMD : int
    {
        /// <summary>
        ///     <c>StrictAMD</c> specifies that operations for each primitive in a subpass <i>must</i> occur in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-primitive-order">primitive order^</see>.
        /// </summary>
        StrictAMD = 0,

        /// <summary>
        ///     <c>RelaxedAMD</c> specifies that operations for each primitive in a subpass may: not occur in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-primitive-order">primitive order^</see>.
        /// </summary>
        RelaxedAMD = 1,

        /// <summary>
        ///     <c>MaxEnumAMD</c>
        /// </summary>
        MaxEnumAMD = 0x7FFFFFFF,
    }
}
