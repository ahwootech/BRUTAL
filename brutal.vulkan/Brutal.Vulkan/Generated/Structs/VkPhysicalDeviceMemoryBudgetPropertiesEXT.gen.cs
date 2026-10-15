namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryBudgetPropertiesEXT.html">VkPhysicalDeviceMemoryBudgetPropertiesEXT</see> - Structure specifying physical device memory budget and usage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>VkPhysicalDeviceMemoryBudgetPropertiesEXT</c> structure is included
    ///         in the <c>pNext</c> chain of <c>VkPhysicalDeviceMemoryProperties2</c>, it is
    ///         filled with the current memory budgets and usages.
    ///     </para>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMemoryBudgetPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_memory_budget
    ///         typedef struct VkPhysicalDeviceMemoryBudgetPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       heapBudget[VK_MAX_MEMORY_HEAPS];
    ///             VkDeviceSize       heapUsage[VK_MAX_MEMORY_HEAPS];
    ///         } VkPhysicalDeviceMemoryBudgetPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public unsafe partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMemoryBudgetPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HeapBudget</c> is an array of <c>VK_MAX_MEMORY_HEAPS</c> basetype:VkDeviceSize values in which memory budgets are returned, with one element for each memory heap. A heap&apos;s budget is a rough estimate of how much memory the process <i>can</i> allocate from that heap before allocations may: fail or cause performance degradation. The budget includes any currently allocated device memory.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64_16 HeapBudget;

        /// <summary>
        ///     <c>HeapUsage</c> is an array of <c>VK_MAX_MEMORY_HEAPS</c> basetype:VkDeviceSize values in which memory usages are returned, with one element for each memory heap. A heap&apos;s usage is an estimate of how much memory the process is currently using in that heap.
        /// </summary>
        [FieldOffset(144)]
        public ByteSize64_16 HeapUsage;
    }
}
