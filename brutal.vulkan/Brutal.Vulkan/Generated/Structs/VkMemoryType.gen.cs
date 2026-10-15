namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryType.html">VkMemoryType</see> - Structure specifying memory type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryType</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkMemoryType {
    ///             VkMemoryPropertyFlags    propertyFlags;
    ///             uint32_t                 heapIndex;
    ///         } VkMemoryType;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkMemoryType()
    {
        /// <summary>
        ///     <c>PropertyFlags</c> is a bitmask of <c>VkMemoryPropertyFlags</c> of properties for this memory type.
        /// </summary>
        [FieldOffset(0)]
        public VkMemoryPropertyFlags PropertyFlags;

        /// <summary>
        ///     <c>HeapIndex</c> describes which memory heap this memory type corresponds to, and <i>must</i> be less than <c>memoryHeapCount</c> from the <c>VkPhysicalDeviceMemoryProperties</c> structure.
        /// </summary>
        [FieldOffset(4)]
        public int HeapIndex;
    }
}
