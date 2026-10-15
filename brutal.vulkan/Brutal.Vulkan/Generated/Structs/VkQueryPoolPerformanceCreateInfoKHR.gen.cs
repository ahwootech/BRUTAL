namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryPoolPerformanceCreateInfoKHR.html">VkQueryPoolPerformanceCreateInfoKHR</see> - Structure specifying parameters of a newly created performance query pool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueryPoolPerformanceCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef struct VkQueryPoolPerformanceCreateInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           queueFamilyIndex;
    ///             uint32_t           counterIndexCount;
    ///             const uint32_t*    pCounterIndices;
    ///         } VkQueryPoolPerformanceCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkQueryPoolPerformanceCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueryPoolPerformanceCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueueFamilyIndex</c> is the queue family index to create this performance query pool for.
        /// </summary>
        [FieldOffset(16)]
        public int QueueFamilyIndex;

        /// <summary>
        ///     <c>CounterIndexCount</c> is the length of the <c>pCounterIndices</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int CounterIndexCount;

        /// <summary>
        ///     <c>CounterIndices</c> is a pointer to an array of indices into the <c>vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR::pCounters</c> to enable in this performance query pool.
        /// </summary>
        [FieldOffset(24)]
        public int* CounterIndices;
    }
}
