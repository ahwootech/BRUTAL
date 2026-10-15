namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticFormatKHR.html">VkPipelineExecutableStatisticFormatKHR</see> - Enum describing a pipeline executable statistic
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineExecutableStatisticFormatKHR</c> enum is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_executable_properties
    ///         typedef enum VkPipelineExecutableStatisticFormatKHR {
    ///             VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR = 0,
    ///             VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR = 1,
    ///             VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR = 2,
    ///             VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR = 3,
    ///         } VkPipelineExecutableStatisticFormatKHR;
    ///     </code>
    /// </remarks>
    public enum VkPipelineExecutableStatisticFormatKHR : int
    {
        /// <summary>
        ///     <c>Bool32KHR</c> specifies that the statistic is returned as a 32-bit boolean value which <i>must</i> be either <c>VK_TRUE</c> or <c>VK_FALSE</c> and <i>should</i> be read from the <c>b32</c> field of <c>VkPipelineExecutableStatisticValueKHR</c>.
        /// </summary>
        Bool32KHR = 0,

        /// <summary>
        ///     <c>Int64KHR</c> specifies that the statistic is returned as a signed 64-bit integer and <i>should</i> be read from the <c>i64</c> field of <c>VkPipelineExecutableStatisticValueKHR</c>.
        /// </summary>
        Int64KHR = 1,

        /// <summary>
        ///     <c>UInt64KHR</c> specifies that the statistic is returned as an unsigned 64-bit integer and <i>should</i> be read from the <c>u64</c> field of <c>VkPipelineExecutableStatisticValueKHR</c>.
        /// </summary>
        UInt64KHR = 2,

        /// <summary>
        ///     <c>Float64KHR</c> specifies that the statistic is returned as a 64-bit floating-point value and <i>should</i> be read from the <c>f64</c> field of <c>VkPipelineExecutableStatisticValueKHR</c>.
        /// </summary>
        Float64KHR = 3,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
