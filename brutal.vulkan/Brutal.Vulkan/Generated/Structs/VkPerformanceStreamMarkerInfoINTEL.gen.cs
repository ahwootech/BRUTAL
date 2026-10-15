namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceStreamMarkerInfoINTEL.html">VkPerformanceStreamMarkerInfoINTEL</see> - Structure specifying stream performance markers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceStreamMarkerInfoINTEL</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef struct VkPerformanceStreamMarkerInfoINTEL {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           marker;
    ///         } VkPerformanceStreamMarkerInfoINTEL;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPerformanceStreamMarkerInfoINTEL()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceStreamMarkerInfoINTEL;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Marker</c> is the marker value that will be recorded into the reports consumed by an external application.
        /// </summary>
        [FieldOffset(16)]
        public int Marker;
    }
}
