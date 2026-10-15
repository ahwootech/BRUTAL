namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryAllocateInfo.html">VkMemoryAllocateInfo</see> - Structure containing parameters of a memory allocation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryAllocateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkMemoryAllocateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceSize       allocationSize;
    ///             uint32_t           memoryTypeIndex;
    ///         } VkMemoryAllocateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMemoryAllocateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryAllocateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AllocationSize</c> is the size of the allocation in bytes.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 AllocationSize;

        /// <summary>
        ///     <c>MemoryTypeIndex</c> is an index identifying a memory type from the <c>memoryTypes</c> array of the <c>VkPhysicalDeviceMemoryProperties</c> structure.
        /// </summary>
        [FieldOffset(24)]
        public int MemoryTypeIndex;
    }
}
