namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDecompressMemoryInfoEXT.html">VkDecompressMemoryInfoEXT</see> - Structure specifying decompression memory info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDecompressMemoryInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDecompressMemoryInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_memory_decompression
    ///         typedef struct VkDecompressMemoryInfoEXT {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             VkMemoryDecompressionMethodFlagsEXT    decompressionMethod;
    ///             uint32_t                               regionCount;
    ///             const VkDecompressMemoryRegionEXT*     pRegions;
    ///         } VkDecompressMemoryInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDecompressMemoryInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DecompressMemoryInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DecompressionMethod</c> is a bitmask of <c>VkMemoryDecompressionMethodFlagsEXT</c> with a single bit set specifying the method used to decompress data.
        /// </summary>
        [FieldOffset(16)]
        public VkMemoryDecompressionMethodFlagsEXT DecompressionMethod;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions to decompress.
        /// </summary>
        [FieldOffset(24)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkDecompressMemoryRegionEXT</c> structures specifying the regions to decompress.
        /// </summary>
        [FieldOffset(32)]
        public VkDecompressMemoryRegionEXT* Regions;
    }
}
