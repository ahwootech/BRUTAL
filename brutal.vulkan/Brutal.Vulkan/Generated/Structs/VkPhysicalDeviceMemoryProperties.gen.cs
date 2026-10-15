namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryProperties.html">VkPhysicalDeviceMemoryProperties</see> - Structure specifying physical device memory properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMemoryProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPhysicalDeviceMemoryProperties {
    ///             uint32_t        memoryTypeCount;
    ///             VkMemoryType    memoryTypes[VK_MAX_MEMORY_TYPES];
    ///             uint32_t        memoryHeapCount;
    ///             VkMemoryHeap    memoryHeaps[VK_MAX_MEMORY_HEAPS];
    ///         } VkPhysicalDeviceMemoryProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 520)]
    public partial struct VkPhysicalDeviceMemoryProperties()
    {
        /// <summary>
        ///     <c>MemoryTypeCount</c> is the number of valid elements in the <c>memoryTypes</c> array.
        /// </summary>
        [FieldOffset(0)]
        public int MemoryTypeCount;

        /// <summary>
        ///     <c>MemoryTypes</c> is an array of <c>VK_MAX_MEMORY_TYPES</c> <c>VkMemoryType</c> structures describing the <i>memory types</i> that <i>can</i> be used to access memory allocated from the heaps specified by <c>memoryHeaps</c>.
        /// </summary>
        [FieldOffset(4)]
        public VkMemoryType_32 MemoryTypes;

        /// <summary>
        ///     <c>MemoryHeapCount</c> is the number of valid elements in the <c>memoryHeaps</c> array.
        /// </summary>
        [FieldOffset(260)]
        public int MemoryHeapCount;

        /// <summary>
        ///     <c>MemoryHeaps</c> is an array of <c>VK_MAX_MEMORY_HEAPS</c> <c>VkMemoryHeap</c> structures describing the <i>memory heaps</i> from which memory <i>can</i> be allocated.
        /// </summary>
        [FieldOffset(264)]
        public VkMemoryHeap_16 MemoryHeaps;
    }
}
