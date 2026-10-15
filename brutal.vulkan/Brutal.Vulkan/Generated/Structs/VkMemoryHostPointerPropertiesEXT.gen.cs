namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryHostPointerPropertiesEXT.html">VkMemoryHostPointerPropertiesEXT</see> - Properties of external memory host pointer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryHostPointerPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_external_memory_host
    ///         typedef struct VkMemoryHostPointerPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           memoryTypeBits;
    ///         } VkMemoryHostPointerPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryHostPointerPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryHostPointerPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryTypeBits</c> is a bitmask containing one bit set for every memory type which the specified host pointer <i>can</i> be imported as.
        /// </summary>
        [FieldOffset(16)]
        public int MemoryTypeBits;
    }
}
