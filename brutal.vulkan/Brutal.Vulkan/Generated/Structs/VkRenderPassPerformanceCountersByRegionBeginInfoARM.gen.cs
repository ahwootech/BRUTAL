namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassPerformanceCountersByRegionBeginInfoARM.html">VkRenderPassPerformanceCountersByRegionBeginInfoARM</see> - Structure specifying per region performance counters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderPassPerformanceCountersByRegionBeginInfoARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_performance_counters_by_region
    ///         typedef struct VkRenderPassPerformanceCountersByRegionBeginInfoARM {
    ///             VkStructureType           sType;
    ///             void*                     pNext;
    ///             uint32_t                  counterAddressCount;
    ///             const VkDeviceAddress*    pCounterAddresses;
    ///             VkBool32                  serializeRegions;
    ///             uint32_t                  counterIndexCount;
    ///             uint32_t*                 pCounterIndices;
    ///         } VkRenderPassPerformanceCountersByRegionBeginInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkRenderPassPerformanceCountersByRegionBeginInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassPerformanceCountersByRegionBeginInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CounterAddressCount</c> is the number of entries in the <c>pCounterAddresses</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int CounterAddressCount;

        /// <summary>
        ///     <c>CounterAddresses</c> is a pointer to an array of basetype:VkDeviceAddress where performance counter data will be written.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceAddress* CounterAddresses;

        /// <summary>
        ///     <c>SerializeRegions</c> controls whether the implementation serializes the execution of each region.
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 SerializeRegions;

        /// <summary>
        ///     <c>CounterIndexCount</c> is the number of entries in the <c>pCounterIndices</c> array.
        /// </summary>
        [FieldOffset(36)]
        public int CounterIndexCount;

        /// <summary>
        ///     <c>CounterIndices</c> is a pointer to an array of <c>VkPerformanceCounterARM::counterID</c> values, as enumerated by <c>vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM</c>, to enable in this render pass instance.
        /// </summary>
        [FieldOffset(40)]
        public int* CounterIndices;
    }
}
