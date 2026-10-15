namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTileMemoryHeapFeaturesQCOM.html">VkPhysicalDeviceTileMemoryHeapFeaturesQCOM</see> - Structure describing whether the tile memory heap features can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTileMemoryHeapFeaturesQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_memory_heap
    ///         typedef struct VkPhysicalDeviceTileMemoryHeapFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           tileMemoryHeap;
    ///         } VkPhysicalDeviceTileMemoryHeapFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceTileMemoryHeapFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTileMemoryHeapFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TileMemoryHeap</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TileMemoryHeap;
    }
}
