namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaSampleTypeAMD.html">VkGpaSampleTypeAMD</see> - Enum providing the sample type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which <i>can</i> be set in <c>VkGpaSampleBeginInfoAMD::sampleType</c>
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef enum VkGpaSampleTypeAMD {
    ///             VK_GPA_SAMPLE_TYPE_CUMULATIVE_AMD = 0,
    ///             VK_GPA_SAMPLE_TYPE_TRACE_AMD = 1,
    ///             VK_GPA_SAMPLE_TYPE_TIMING_AMD = 2,
    ///         } VkGpaSampleTypeAMD;
    ///     </code>
    /// </remarks>
    public enum VkGpaSampleTypeAMD : int
    {
        /// <summary>
        ///     <c>CumulativeAMD</c> specifies that one 64-bit result will be returned per global performance counter, representing the cumulative delta for that counter over the sample period. Cumulative samples <i>must</i> begin and end in the same command buffer.
        /// </summary>
        CumulativeAMD = 0,

        /// <summary>
        ///     <c>TraceAMD</c> specifies that a buffer will be filled with SQTT results data in RGP file format, and/or streaming performance monitor data. Trace samples may: span multiple command buffers.
        /// </summary>
        TraceAMD = 1,

        /// <summary>
        ///     <c>TimingAMD</c> specifies that two 64-bit results will be recorded to gather timestamp data.
        /// </summary>
        TimingAMD = 2,

        /// <summary>
        ///     <c>MaxEnumAMD</c>
        /// </summary>
        MaxEnumAMD = 0x7FFFFFFF,
    }
}
