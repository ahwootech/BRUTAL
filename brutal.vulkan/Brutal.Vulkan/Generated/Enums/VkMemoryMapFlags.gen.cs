namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryMapFlagBits.html">VkMemoryMapFlagBits</see> - Bitmask specifying additional parameters of a memory map
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>vkMapMemory::flags</c> and
    ///         <c>VkMemoryMapInfo::flags</c>, specifying additional properties of a
    ///         memory map, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkMemoryMapFlagBits {
    ///             // Provided by VK_EXT_map_memory_placed
    ///             VK_MEMORY_MAP_PLACED_BIT_EXT = 0x00000001,
    ///         } VkMemoryMapFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkMemoryMapFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>PlacedBitEXT</c> requests that the implementation place the memory map at the virtual address specified by the application via <c>VkMemoryMapPlacedInfoEXT::pPlacedAddress</c>, replacing any existing mapping at that address. This flag <i>must</i> not be used with <c>vkMapMemory</c> as there is no way to specify the placement address.
        /// </summary>
        PlacedBitEXT = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
