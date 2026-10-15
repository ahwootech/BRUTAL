namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryPriorityAllocateInfoEXT.html">VkMemoryPriorityAllocateInfoEXT</see> - Specify a memory allocation priority
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain includes a <c>VkMemoryPriorityAllocateInfoEXT</c>
    ///         structure, then that structure includes a priority for the memory.
    ///     </para>
    ///     <para>
    ///         The <c>VkMemoryPriorityAllocateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_memory_priority
    ///         typedef struct VkMemoryPriorityAllocateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             float              priority;
    ///         } VkMemoryPriorityAllocateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryPriorityAllocateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryPriorityAllocateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Priority</c> is a floating-point value between `0` and `1`, indicating the priority of the allocation relative to other memory allocations. Larger values are higher priority. The granularity of the priorities is implementation-dependent.
        /// </summary>
        [FieldOffset(16)]
        public float Priority;
    }
}
