namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryDecompressionMethodFlagBitsEXT.html">VkMemoryDecompressionMethodFlagBitsEXT</see> - List the supported memory decompression methods
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDecompressMemoryRegionEXT::decompressionMethod</c>
    ///         specifying the decompression method to select, or returned in
    ///         <c>VkPhysicalDeviceMemoryDecompressionPropertiesEXT::decompressionMethods</c>
    ///         specifying the available decompression methods are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_memory_decompression
    ///         // Flag bits for VkMemoryDecompressionMethodFlagBitsEXT
    ///         typedef VkFlags64 VkMemoryDecompressionMethodFlagBitsEXT;
    ///             static const VkMemoryDecompressionMethodFlagBitsEXT VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_EXT = 0x00000001ULL;
    ///             static const VkMemoryDecompressionMethodFlagBitsEXT VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_NV = 0x00000001ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkMemoryDecompressionMethodFlagsEXT : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>Gdeflate10BitEXT</c> specifies that the GDeflate 1.0 algorithm is used to decompress data.
        /// </summary>
        Gdeflate10BitEXT = 0x00000001,

        /// <summary>
        ///     <c>Gdeflate10BitNV</c>
        /// </summary>
        Gdeflate10BitNV = 0x00000001,
    }
}
