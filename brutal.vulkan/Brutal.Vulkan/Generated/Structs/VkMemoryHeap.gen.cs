namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryHeap.html">VkMemoryHeap</see> - Structure specifying a memory heap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryHeap</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkMemoryHeap {
    ///             VkDeviceSize         size;
    ///             VkMemoryHeapFlags    flags;
    ///         } VkMemoryHeap;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkMemoryHeap()
    {
        /// <summary>
        ///     <c>Size</c> is the total memory size in bytes in the heap.
        /// </summary>
        [FieldOffset(0)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkMemoryHeapFlags</c> specifying attribute flags for the heap.
        /// </summary>
        [FieldOffset(8)]
        public VkMemoryHeapFlags Flags;
    }
}
