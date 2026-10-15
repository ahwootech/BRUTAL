namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePerformanceCountersByRegionPropertiesARM.html">VkPhysicalDevicePerformanceCountersByRegionPropertiesARM</see> - Structure describing per region performance counter properties for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePerformanceCountersByRegionPropertiesARM</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_performance_counters_by_region
    ///         typedef struct VkPhysicalDevicePerformanceCountersByRegionPropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxPerRegionPerformanceCounters;
    ///             VkExtent2D         performanceCounterRegionSize;
    ///             uint32_t           rowStrideAlignment;
    ///             uint32_t           regionAlignment;
    ///             VkBool32           identityTransformOrder;
    ///         } VkPhysicalDevicePerformanceCountersByRegionPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDevicePerformanceCountersByRegionPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDevicePerformanceCountersByRegionPropertiesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxPerRegionPerformanceCounters</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxPerRegionPerformanceCounters;

        /// <summary>
        ///     <c>PerformanceCounterRegionSize</c>
        /// </summary>
        [FieldOffset(20)]
        public VkExtent2D PerformanceCounterRegionSize;

        /// <summary>
        ///     <c>RowStrideAlignment</c>
        /// </summary>
        [FieldOffset(28)]
        public int RowStrideAlignment;

        /// <summary>
        ///     <c>RegionAlignment</c>
        /// </summary>
        [FieldOffset(32)]
        public int RegionAlignment;

        /// <summary>
        ///     <c>IdentityTransformOrder</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 IdentityTransformOrder;
    }
}
