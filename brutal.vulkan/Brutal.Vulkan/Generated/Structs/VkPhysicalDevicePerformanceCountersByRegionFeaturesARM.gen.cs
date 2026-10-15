namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePerformanceCountersByRegionFeaturesARM.html">VkPhysicalDevicePerformanceCountersByRegionFeaturesARM</see> - Structure describing support for VK_ARM_performance_counters_by_region by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePerformanceCountersByRegionFeaturesARM</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_performance_counters_by_region
    ///         typedef struct VkPhysicalDevicePerformanceCountersByRegionFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           performanceCountersByRegion;
    ///         } VkPhysicalDevicePerformanceCountersByRegionFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePerformanceCountersByRegionFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePerformanceCountersByRegionFeaturesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PerformanceCountersByRegion</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PerformanceCountersByRegion;
    }
}
