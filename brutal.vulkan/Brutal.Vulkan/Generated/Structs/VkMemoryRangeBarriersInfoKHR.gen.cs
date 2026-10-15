namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryRangeBarriersInfoKHR.html">VkMemoryRangeBarriersInfoKHR</see> - Structure specifying memory range barriers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMemoryRangeBarriersInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkMemoryRangeBarriersInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_address_commands
    ///         typedef struct VkMemoryRangeBarriersInfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             uint32_t                          memoryRangeBarrierCount;
    ///             const VkMemoryRangeBarrierKHR*    pMemoryRangeBarriers;
    ///         } VkMemoryRangeBarriersInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMemoryRangeBarriersInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryRangeBarriersInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryRangeBarrierCount</c> is the length of the <c>pMemoryRangeBarriers</c> array
        /// </summary>
        [FieldOffset(16)]
        public int MemoryRangeBarrierCount;

        /// <summary>
        ///     <c>MemoryRangeBarriers</c> is a pointer to an array of <c>VkMemoryRangeBarrierKHR</c> structures defining memory dependencies between accesses to specified memory ranges.
        /// </summary>
        [FieldOffset(24)]
        public VkMemoryRangeBarrierKHR* MemoryRangeBarriers;
    }
}
