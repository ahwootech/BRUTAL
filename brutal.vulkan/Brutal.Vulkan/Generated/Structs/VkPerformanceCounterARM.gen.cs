namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterARM.html">VkPerformanceCounterARM</see> - Structure providing information about a counter
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceCounterARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_performance_counters_by_region
    ///         typedef struct VkPerformanceCounterARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           counterID;
    ///         } VkPerformanceCounterARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPerformanceCounterARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceCounterARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CounterID</c> is an identifier for the counter of the physical device.
        /// </summary>
        [FieldOffset(16)]
        public int CounterID;
    }
}
