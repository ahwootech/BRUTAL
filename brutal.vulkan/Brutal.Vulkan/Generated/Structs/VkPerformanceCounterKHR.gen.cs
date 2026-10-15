namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterKHR.html">VkPerformanceCounterKHR</see> - Structure providing information about a counter
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerformanceCounterKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef struct VkPerformanceCounterKHR {
    ///             VkStructureType                   sType;
    ///             void*                             pNext;
    ///             VkPerformanceCounterUnitKHR       unit;
    ///             VkPerformanceCounterScopeKHR      scope;
    ///             VkPerformanceCounterStorageKHR    storage;
    ///             uint8_t                           uuid[VK_UUID_SIZE];
    ///         } VkPerformanceCounterKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPerformanceCounterKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerformanceCounterKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Unit</c> is a <c>VkPerformanceCounterUnitKHR</c> specifying the unit that the counter data will record.
        /// </summary>
        [FieldOffset(16)]
        public VkPerformanceCounterUnitKHR Unit;

        /// <summary>
        ///     <c>Scope</c> is a <c>VkPerformanceCounterScopeKHR</c> specifying the scope that the counter belongs to.
        /// </summary>
        [FieldOffset(20)]
        public VkPerformanceCounterScopeKHR Scope;

        /// <summary>
        ///     <c>Storage</c> is a <c>VkPerformanceCounterStorageKHR</c> specifying the storage type that the counter&apos;s data uses.
        /// </summary>
        [FieldOffset(24)]
        public VkPerformanceCounterStorageKHR Storage;

        ///
        [FieldOffset(28)]
        public fixed byte Uuid[16];
    }
}
