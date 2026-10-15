namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateFlagsInfo.html">VkMemoryAllocateFlagsInfo</see> - Structure controlling how many instances of memory will be allocated
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkMemoryAllocateInfo</c> includes a
    ///         <c>VkMemoryAllocateFlagsInfo</c> structure, then that structure includes
    ///         flags and a device mask controlling how many instances of the memory will be
    ///         allocated.
    ///     </para>
    ///     <para>
    ///         The <c>VkMemoryAllocateFlagsInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkMemoryAllocateFlagsInfo {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkMemoryAllocateFlags    flags;
    ///             uint32_t                 deviceMask;
    ///         } VkMemoryAllocateFlagsInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryAllocateFlagsInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryAllocateFlagsInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkMemoryAllocateFlags</c> controlling the allocation.
        /// </summary>
        [FieldOffset(16)]
        public VkMemoryAllocateFlags Flags;

        /// <summary>
        ///     <c>DeviceMask</c> is a mask of physical devices in the logical device, indicating that memory <i>must</i> be allocated on each device in the mask, if <c>VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT</c> is set in <c>flags</c>.
        /// </summary>
        [FieldOffset(20)]
        public int DeviceMask;
    }
}
