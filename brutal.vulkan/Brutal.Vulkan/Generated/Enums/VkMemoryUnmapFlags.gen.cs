namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryUnmapFlagBits.html">VkMemoryUnmapFlagBits</see> - Bitmask specifying additional parameters of a memory unmap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkMemoryUnmapInfo::flags</c>, specifying
    ///         additional properties of a memory unmap, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef enum VkMemoryUnmapFlagBits {
    ///             // Provided by VK_EXT_map_memory_placed
    ///             VK_MEMORY_UNMAP_RESERVE_BIT_EXT = 0x00000001,
    ///         } VkMemoryUnmapFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkMemoryUnmapFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ReserveBitEXT</c> requests that virtual address range currently occupied by the memory map remain reserved after the <c>vkUnmapMemory2</c> call completes. Future system memory map operations or calls to <c>vkMapMemory</c> or <c>vkMapMemory2</c> will not return addresses in that range unless the range has since been unreserved by the client or the mapping is explicitly placed in that range by calling <c>vkMapMemory2</c> with <c>VK_MEMORY_MAP_PLACED_BIT_EXT</c>, or doing the system memory map equivalent. When <c>VK_MEMORY_UNMAP_RESERVE_BIT_EXT</c> is set, the memory unmap operation may: fail, in which case the memory object will remain host mapped and <c>vkUnmapMemory2</c> will return <c>VK_ERROR_MEMORY_MAP_FAILED</c>.
        /// </summary>
        ReserveBitEXT = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
