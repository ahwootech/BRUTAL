namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryPoolPerformanceQueryCreateInfoINTEL.html">VkQueryPoolPerformanceQueryCreateInfoINTEL</see> - Structure specifying parameters to create a pool of performance queries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueryPoolPerformanceQueryCreateInfoINTEL</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef struct VkQueryPoolPerformanceQueryCreateInfoINTEL {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkQueryPoolSamplingModeINTEL    performanceCountersSampling;
    ///         } VkQueryPoolPerformanceQueryCreateInfoINTEL;
    ///     </code>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         // Equivalent to VkQueryPoolPerformanceQueryCreateInfoINTEL
    ///         typedef VkQueryPoolPerformanceQueryCreateInfoINTEL VkQueryPoolCreateInfoINTEL;
    ///         </code>
    ///     </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueryPoolPerformanceQueryCreateInfoINTEL()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueryPoolPerformanceQueryCreateInfoINTEL;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PerformanceCountersSampling</c>
        /// </summary>
        [FieldOffset(16)]
        public VkQueryPoolSamplingModeINTEL PerformanceCountersSampling;
    }
}
