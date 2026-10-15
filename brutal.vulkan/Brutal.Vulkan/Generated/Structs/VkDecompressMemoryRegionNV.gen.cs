namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDecompressMemoryRegionNV.html">VkDecompressMemoryRegionNV</see> - Structure specifying decompression region parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDecompressMemoryRegionNV
    ///     </para>
    ///     <para>
    ///         The <c>VkDecompressMemoryRegionNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_memory_decompression
    ///         typedef struct VkDecompressMemoryRegionNV {
    ///             VkDeviceAddress                        srcAddress;
    ///             VkDeviceAddress                        dstAddress;
    ///             VkDeviceSize                           compressedSize;
    ///             VkDeviceSize                           decompressedSize;
    ///             VkMemoryDecompressionMethodFlagsEXT    decompressionMethod;
    ///         } VkDecompressMemoryRegionNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct VkDecompressMemoryRegionNV()
    {
        /// <summary>
        ///     <c>SrcAddress</c> is the address where compressed data is stored.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress SrcAddress;

        /// <summary>
        ///     <c>DstAddress</c> is the destination address where decompressed data will be written.
        /// </summary>
        [FieldOffset(8)]
        public VkDeviceAddress DstAddress;

        /// <summary>
        ///     <c>CompressedSize</c> is the size of compressed data in bytes.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 CompressedSize;

        /// <summary>
        ///     <c>DecompressedSize</c> is the size of decompressed data in bytes.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 DecompressedSize;

        /// <summary>
        ///     <c>DecompressionMethod</c> is a bitmask of <c>VkMemoryDecompressionMethodFlagsNV</c> with a single bit set specifying the method used to decompress data.
        /// </summary>
        [FieldOffset(32)]
        public VkMemoryDecompressionMethodFlagsEXT DecompressionMethod;
    }
}
