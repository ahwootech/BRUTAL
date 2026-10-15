namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleOrderTypeNV.html">VkCoarseSampleOrderTypeNV</see> - Shading rate image sample ordering types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The type <c>VkCoarseSampleOrderTypeNV</c> specifies the technique used to
    ///         order coverage samples in fragments larger than one pixel, and is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef enum VkCoarseSampleOrderTypeNV {
    ///             VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV = 0,
    ///             VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV = 1,
    ///             VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV = 2,
    ///             VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV = 3,
    ///         } VkCoarseSampleOrderTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkCoarseSampleOrderTypeNV : int
    {
        /// <summary>
        ///     <c>DefaultNV</c> specifies that coverage samples will be ordered in an implementation-dependent manner.
        /// </summary>
        DefaultNV = 0,

        /// <summary>
        ///     <c>CustomNV</c> specifies that coverage samples will be ordered according to the array of custom orderings provided in either the <c>pCustomSampleOrders</c> member of <c>VkPipelineViewportCoarseSampleOrderStateCreateInfoNV</c> or the <c>pCustomSampleOrders</c> member of <c>vkCmdSetCoarseSampleOrderNV</c>.
        /// </summary>
        CustomNV = 1,

        /// <summary>
        ///     <c>PixelMajorNV</c> specifies that coverage samples will be ordered sequentially, sorted first by pixel coordinate (in row-major order) and then by <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-multisampling-coverage-mask">sample index^</see>.
        /// </summary>
        PixelMajorNV = 2,

        /// <summary>
        ///     <c>SampleMajorNV</c> specifies that coverage samples will be ordered sequentially, sorted first by <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-multisampling-coverage-mask">sample index^</see> and then by pixel coordinate (in row-major order).
        /// </summary>
        SampleMajorNV = 3,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
