namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkComputeOccupancyPriorityParametersNV.html">VkComputeOccupancyPriorityParametersNV</see> - Structure specifying compute occupancy priority parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkComputeOccupancyPriorityParametersNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_compute_occupancy_priority
    ///         typedef struct VkComputeOccupancyPriorityParametersNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             float              occupancyPriority;
    ///             float              occupancyThrottling;
    ///         } VkComputeOccupancyPriorityParametersNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkComputeOccupancyPriorityParametersNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ComputeOccupancyPriorityParametersNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OccupancyPriority</c> is a value specifying the occupancy priority for subsequent compute workloads, with a valid range of [0.0, 1.0]. A value of 0.0 represents the lowest priority, while a value of 1.0 is the maximum priority. Default priority is specified by a value of 0.5.
        /// </summary>
        [FieldOffset(16)]
        public float OccupancyPriority;

        /// <summary>
        ///     <c>OccupancyThrottling</c> is a value specifying the level of occupancy throttling applied to subsequent workloads, with a valid range of [0.0, 1.0]. A value of 0.0 (the default) means no throttling is applied, allowing workloads to use the full available compute capacity. Non-zero values represent increasing levels of throttling, with higher values resulting in more restrictive occupancy limits. A value of 1.0 represents the maximum level of throttling supported by the implementation.
        /// </summary>
        [FieldOffset(20)]
        public float OccupancyThrottling;
    }
}
