namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryMapPlacedInfoEXT.html">VkMemoryMapPlacedInfoEXT</see> - Structure containing memory map placement parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If <c>VK_MEMORY_MAP_PLACED_BIT_EXT</c> is set in
    ///         <c>VkMemoryMapInfo::flags</c> and the <c>pNext</c> chain of
    ///         <c>VkMemoryMapInfo</c> includes a <c>VkMemoryMapPlacedInfoEXT</c> structure,
    ///         then that structure specifies the placement address of the memory map.
    ///         The implementation will place the memory map at the specified address,
    ///         replacing any existing maps in the specified memory range.
    ///         Replacing memory maps in this way does not implicitly unmap Vulkan memory
    ///         objects.
    ///         Instead, the application <i>must</i> ensure no other Vulkan memory objects are
    ///         mapped anywhere in the specified virtual address range.
    ///         If successful, <c>ppData</c> will be set to the same value as
    ///         <c>VkMemoryMapPlacedInfoEXT::pPlacedAddress</c> and <c>vkMapMemory2</c>
    ///         will return <c>VK_SUCCESS</c>.
    ///         If it cannot place the map at the requested address for any reason, the
    ///         memory object is left unmapped and <c>vkMapMemory2</c> will return
    ///         <c>VK_ERROR_MEMORY_MAP_FAILED</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkMemoryMapPlacedInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_map_memory_placed
    ///         typedef struct VkMemoryMapPlacedInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             void*              pPlacedAddress;
    ///         } VkMemoryMapPlacedInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryMapPlacedInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryMapPlacedInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PlacedAddress</c> is the virtual address at which to place the address. If <c>VkMemoryMapInfo::flags</c> does not contain <c>VK_MEMORY_MAP_PLACED_BIT_EXT</c>, this value is ignored.
        /// </summary>
        [FieldOffset(16)]
        public void* PlacedAddress;
    }
}
