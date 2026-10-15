namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceMarkerInfoINTEL.html">VkPerformanceMarkerInfoINTEL</see> - Structure specifying performance markers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceMarkerInfoINTEL</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_performance_query
    ///         typedef struct VkPerformanceMarkerInfoINTEL {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint64_t           marker;
    ///         } VkPerformanceMarkerInfoINTEL;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPerformanceMarkerInfoINTEL()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceMarkerInfoINTEL;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Marker</c> is the marker value that will be recorded into the opaque query results.
        /// </summary>
        [FieldOffset(16)]
        public nint Marker;
    }
}
