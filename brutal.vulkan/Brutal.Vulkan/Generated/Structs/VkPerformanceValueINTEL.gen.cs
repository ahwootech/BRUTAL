namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceValueINTEL.html">VkPerformanceValueINTEL</see> - Container for value and types of parameters that can be queried
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceValueINTEL</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef struct VkPerformanceValueINTEL {
    ///             VkPerformanceValueTypeINTEL    type;
    ///             VkPerformanceValueDataINTEL    data;
    ///         } VkPerformanceValueINTEL;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkPerformanceValueINTEL()
    {
        /// <summary>
        ///     <c>Type</c> is a <c>VkPerformanceValueTypeINTEL</c> value specifying the type of the returned data.
        /// </summary>
        [FieldOffset(0)]
        public VkPerformanceValueTypeINTEL Type;

        /// <summary>
        ///     <c>Data</c> is a <c>VkPerformanceValueDataINTEL</c> union specifying the value of the returned data.
        /// </summary>
        [FieldOffset(8)]
        public VkPerformanceValueDataINTEL Data;
    }
}
