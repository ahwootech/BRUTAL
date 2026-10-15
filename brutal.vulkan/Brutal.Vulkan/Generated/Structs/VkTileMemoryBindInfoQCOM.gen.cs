namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTileMemoryBindInfoQCOM.html">VkTileMemoryBindInfoQCOM</see> - Structure specifying tile memory to bind
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTileMemoryBindInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_memory_heap
    ///         typedef struct VkTileMemoryBindInfoQCOM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceMemory     memory;
    ///         } VkTileMemoryBindInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkTileMemoryBindInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TileMemoryBindInfoQCOM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Memory</c> is the tile memory object to be bound.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;
    }
}
