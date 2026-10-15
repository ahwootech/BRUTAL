namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryMapInfo.html">VkMemoryMapInfo</see> - Structure containing parameters of a memory map operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryMapInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkMemoryMapInfo {
    ///             VkStructureType     sType;
    ///             const void*         pNext;
    ///             VkMemoryMapFlags    flags;
    ///             VkDeviceMemory      memory;
    ///             VkDeviceSize        offset;
    ///             VkDeviceSize        size;
    ///         } VkMemoryMapInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkMemoryMapInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryMapInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkMemoryMapFlags</c> specifying additional parameters of the memory map operation.
        /// </summary>
        [FieldOffset(16)]
        public VkMemoryMapFlags Flags;

        /// <summary>
        ///     <c>Memory</c> is the <c>VkDeviceMemory</c> object to be mapped.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>Offset</c> is a zero-based byte offset from the beginning of the memory object.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Size</c> is the size of the memory range to map, or <c>VK_WHOLE_SIZE</c> to map from <c>offset</c> to the end of the allocation.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 Size;
    }
}
