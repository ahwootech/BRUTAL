namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMapMemoryPlacedPropertiesEXT.html">VkPhysicalDeviceMapMemoryPlacedPropertiesEXT</see> - Structure describing the alignment requirements of placed memory maps for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMapMemoryPlacedPropertiesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_map_memory_placed
    ///         typedef struct VkPhysicalDeviceMapMemoryPlacedPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       minPlacedMemoryMapAlignment;
    ///         } VkPhysicalDeviceMapMemoryPlacedPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMapMemoryPlacedPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMapMemoryPlacedPropertiesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinPlacedMemoryMapAlignment</c>
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 MinPlacedMemoryMapAlignment;
    }
}
