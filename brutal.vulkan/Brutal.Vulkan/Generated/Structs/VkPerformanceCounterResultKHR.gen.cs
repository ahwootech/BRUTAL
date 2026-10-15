namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterResultKHR.html">VkPerformanceCounterResultKHR</see> - Union containing a performance counter result
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceCounterResultKHR</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef union VkPerformanceCounterResultKHR {
    ///             int32_t     int32;
    ///             int64_t     int64;
    ///             uint32_t    uint32;
    ///             uint64_t    uint64;
    ///             float       float32;
    ///             double      float64;
    ///         } VkPerformanceCounterResultKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkPerformanceCounterResultKHR()
    {
        /// <summary>
        ///     <c>Int32</c> is a 32-bit signed integer value.
        /// </summary>
        [FieldOffset(0)]
        public int Int32;

        /// <summary>
        ///     <c>Int64</c> is a 64-bit signed integer value.
        /// </summary>
        [FieldOffset(0)]
        public long Int64;

        /// <summary>
        ///     <c>Uint32</c> is a 32-bit unsigned integer value.
        /// </summary>
        [FieldOffset(0)]
        public int Uint32;

        /// <summary>
        ///     <c>Uint64</c> is a 64-bit unsigned integer value.
        /// </summary>
        [FieldOffset(0)]
        public nint Uint64;

        /// <summary>
        ///     <c>Float32</c> is a 32-bit floating-point value.
        /// </summary>
        [FieldOffset(0)]
        public float Float32;

        /// <summary>
        ///     <c>Float64</c> is a 64-bit floating-point value.
        /// </summary>
        [FieldOffset(0)]
        public double Float64;
    }
}
