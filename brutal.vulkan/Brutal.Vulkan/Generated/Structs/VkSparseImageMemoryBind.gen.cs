namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseImageMemoryBind.html">VkSparseImageMemoryBind</see> - Structure specifying sparse image memory bind
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSparseImageMemoryBind</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSparseImageMemoryBind {
    ///             VkImageSubresource         subresource;
    ///             VkOffset3D                 offset;
    ///             VkExtent3D                 extent;
    ///             VkDeviceMemory             memory;
    ///             VkDeviceSize               memoryOffset;
    ///             VkSparseMemoryBindFlags    flags;
    ///         } VkSparseImageMemoryBind;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct VkSparseImageMemoryBind()
    {
        /// <summary>
        ///     <c>Subresource</c> is the image <i>aspect</i> and region of interest in the image.
        /// </summary>
        [FieldOffset(0)]
        public VkImageSubresource Subresource;

        /// <summary>
        ///     <c>Offset</c> are the coordinates of the first texel within the image subresource to bind.
        /// </summary>
        [FieldOffset(12)]
        public VkOffset3D Offset;

        /// <summary>
        ///     <c>Extent</c> is the size in texels of the region within the image subresource to bind. The extent <i>must</i> be a multiple of the sparse image block dimensions, except when binding sparse image blocks along the edge of an image subresource it <i>can</i> instead be such that any coordinate of <c><c>offset</c> {plus} <c>extent</c></c> equals the corresponding dimensions of the image subresource.
        /// </summary>
        [FieldOffset(24)]
        public VkExtent3D Extent;

        /// <summary>
        ///     <c>Memory</c> is the <c>VkDeviceMemory</c> object that the sparse image blocks of the image are bound to. If <c>memory</c> is <c>VK_NULL_HANDLE</c>, the sparse image blocks are unbound.
        /// </summary>
        [FieldOffset(40)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MemoryOffset</c> is an offset into <c>VkDeviceMemory</c> object. If <c>memory</c> is <c>VK_NULL_HANDLE</c>, this value is ignored.
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64 MemoryOffset;

        /// <summary>
        ///     <c>Flags</c> are sparse memory binding flags.
        /// </summary>
        [FieldOffset(56)]
        public VkSparseMemoryBindFlags Flags;
    }
}
