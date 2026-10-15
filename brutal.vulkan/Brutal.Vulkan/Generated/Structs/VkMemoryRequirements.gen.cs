namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryRequirements.html">VkMemoryRequirements</see> - Structure specifying memory requirements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryRequirements</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkMemoryRequirements {
    ///             VkDeviceSize    size;
    ///             VkDeviceSize    alignment;
    ///             uint32_t        memoryTypeBits;
    ///         } VkMemoryRequirements;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkMemoryRequirements()
    {
        /// <summary>
        ///     <c>Size</c> is the size, in bytes, of the memory allocation required: for the resource.
        /// </summary>
        [FieldOffset(0)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>Alignment</c> is the alignment, in bytes, of the offset within the allocation required: for the resource.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Alignment;

        /// <summary>
        ///     <c>MemoryTypeBits</c> is a bitmask and contains one bit set for every supported memory type for the resource. Bit `i` is set if and only if the memory type `i` in the <c>VkPhysicalDeviceMemoryProperties</c> structure for the physical device is supported for the resource.
        /// </summary>
        [FieldOffset(16)]
        public int MemoryTypeBits;
    }
}
