namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryDecompressionFeaturesEXT.html">VkPhysicalDeviceMemoryDecompressionFeaturesEXT</see> - Structure describing if memory decompression is supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMemoryDecompressionFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_memory_decompression
    ///         typedef struct VkPhysicalDeviceMemoryDecompressionFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           memoryDecompression;
    ///         } VkPhysicalDeviceMemoryDecompressionFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMemoryDecompressionFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMemoryDecompressionFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryDecompression</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MemoryDecompression;
    }
}
