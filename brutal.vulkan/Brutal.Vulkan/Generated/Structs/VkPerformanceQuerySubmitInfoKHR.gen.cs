namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceQuerySubmitInfoKHR.html">VkPerformanceQuerySubmitInfoKHR</see> - Structure indicating which counter pass index is active for performance queries
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceQuerySubmitInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef struct VkPerformanceQuerySubmitInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           counterPassIndex;
    ///         } VkPerformanceQuerySubmitInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPerformanceQuerySubmitInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceQuerySubmitInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CounterPassIndex</c> specifies which counter pass index is active.
        /// </summary>
        [FieldOffset(16)]
        public int CounterPassIndex;
    }
}
