namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableStatisticValueKHR.html">VkPipelineExecutableStatisticValueKHR</see> - A union describing a pipeline executable statistic
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineExecutableStatisticValueKHR</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_executable_properties
    ///         typedef union VkPipelineExecutableStatisticValueKHR {
    ///             VkBool32    b32;
    ///             int64_t     i64;
    ///             uint64_t    u64;
    ///             double      f64;
    ///         } VkPipelineExecutableStatisticValueKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkPipelineExecutableStatisticValueKHR()
    {
        /// <summary>
        ///     <c>B32</c> is the 32-bit boolean value if the <c>VkPipelineExecutableStatisticFormatKHR</c> is <c>VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR</c>.
        /// </summary>
        [FieldOffset(0)]
        public Brutal.Bool32 B32;

        /// <summary>
        ///     <c>I64</c> is the signed 64-bit integer value if the <c>VkPipelineExecutableStatisticFormatKHR</c> is <c>VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR</c>.
        /// </summary>
        [FieldOffset(0)]
        public long I64;

        /// <summary>
        ///     <c>U64</c> is the unsigned 64-bit integer value if the <c>VkPipelineExecutableStatisticFormatKHR</c> is <c>VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR</c>.
        /// </summary>
        [FieldOffset(0)]
        public nint U64;

        /// <summary>
        ///     <c>F64</c> is the 64-bit floating-point value if the <c>VkPipelineExecutableStatisticFormatKHR</c> is <c>VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR</c>.
        /// </summary>
        [FieldOffset(0)]
        public double F64;
    }
}
