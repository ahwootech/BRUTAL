namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePerformanceQueryFeaturesKHR.html">VkPhysicalDevicePerformanceQueryFeaturesKHR</see> - Structure describing performance query support for an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePerformanceQueryFeaturesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef struct VkPhysicalDevicePerformanceQueryFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           performanceCounterQueryPools;
    ///             VkBool32           performanceCounterMultipleQueryPools;
    ///         } VkPhysicalDevicePerformanceQueryFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePerformanceQueryFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePerformanceQueryFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure. // tag::VK_KHR_performance_query-features[]
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PerformanceCounterQueryPools</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PerformanceCounterQueryPools;

        /// <summary>
        ///     <c>PerformanceCounterMultipleQueryPools</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PerformanceCounterMultipleQueryPools;
    }
}
