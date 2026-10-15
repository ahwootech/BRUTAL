namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMapMemoryPlacedFeaturesEXT.html">VkPhysicalDeviceMapMemoryPlacedFeaturesEXT</see> - Structure describing placed memory map features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMapMemoryPlacedFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_map_memory_placed
    ///         typedef struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           memoryMapPlaced;
    ///             VkBool32           memoryMapRangePlaced;
    ///             VkBool32           memoryUnmapReserve;
    ///         } VkPhysicalDeviceMapMemoryPlacedFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMapMemoryPlacedFeaturesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryMapPlaced</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MemoryMapPlaced;

        /// <summary>
        ///     <c>MemoryMapRangePlaced</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 MemoryMapRangePlaced;

        /// <summary>
        ///     <c>MemoryUnmapReserve</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 MemoryUnmapReserve;
    }
}
