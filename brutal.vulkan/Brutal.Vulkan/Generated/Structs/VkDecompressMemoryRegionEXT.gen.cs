namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDecompressMemoryRegionEXT.html">VkDecompressMemoryRegionEXT</see> - Structure specifying decompression region
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDecompressMemoryRegionEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDecompressMemoryRegionEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_memory_decompression
    ///         typedef struct VkDecompressMemoryRegionEXT {
    ///             VkDeviceAddress    srcAddress;
    ///             VkDeviceAddress    dstAddress;
    ///             VkDeviceSize       compressedSize;
    ///             VkDeviceSize       decompressedSize;
    ///         } VkDecompressMemoryRegionEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct VkDecompressMemoryRegionEXT()
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
    }
}
