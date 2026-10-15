namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryUnmapInfo.html">VkMemoryUnmapInfo</see> - Structure containing parameters of a memory unmap operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryUnmapInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkMemoryUnmapInfo {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkMemoryUnmapFlags    flags;
    ///             VkDeviceMemory        memory;
    ///         } VkMemoryUnmapInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMemoryUnmapInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryUnmapInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkMemoryUnmapFlags</c> specifying additional parameters of the memory map operation.
        /// </summary>
        [FieldOffset(16)]
        public VkMemoryUnmapFlags Flags;

        /// <summary>
        ///     <c>Memory</c> is the <c>VkDeviceMemory</c> object to be unmapped.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemory Memory;
    }
}
