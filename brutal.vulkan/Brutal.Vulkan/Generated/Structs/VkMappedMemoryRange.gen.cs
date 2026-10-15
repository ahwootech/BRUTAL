namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMappedMemoryRange.html">VkMappedMemoryRange</see> - Structure specifying a mapped memory range
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMappedMemoryRange</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkMappedMemoryRange {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceMemory     memory;
    ///             VkDeviceSize       offset;
    ///             VkDeviceSize       size;
    ///         } VkMappedMemoryRange;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkMappedMemoryRange()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MappedMemoryRange;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Memory</c> is the memory object to which this range belongs.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>Offset</c> is the zero-based byte offset from the beginning of the memory object.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Size</c> is either the size of range, or <c>VK_WHOLE_SIZE</c> to affect the range from <c>offset</c> to the end of the current mapping of the allocation.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 Size;
    }
}
