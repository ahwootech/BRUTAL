namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryFdPropertiesKHR.html">VkMemoryFdPropertiesKHR</see> - Properties of External Memory File Descriptors
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryFdPropertiesKHR</c> structure returned is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_memory_fd
    ///         typedef struct VkMemoryFdPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           memoryTypeBits;
    ///         } VkMemoryFdPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryFdPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryFdPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryTypeBits</c> is a bitmask containing one bit set for every memory type which the specified file descriptor <i>can</i> be imported as.
        /// </summary>
        [FieldOffset(16)]
        public int MemoryTypeBits;
    }
}
