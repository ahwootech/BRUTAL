namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseMemoryBind.html">VkSparseMemoryBind</see> - Structure specifying a sparse memory bind operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSparseMemoryBind</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSparseMemoryBind {
    ///             VkDeviceSize               resourceOffset;
    ///             VkDeviceSize               size;
    ///             VkDeviceMemory             memory;
    ///             VkDeviceSize               memoryOffset;
    ///             VkSparseMemoryBindFlags    flags;
    ///         } VkSparseMemoryBind;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct VkSparseMemoryBind()
    {
        /// <summary>
        ///     <c>ResourceOffset</c> is the offset into the resource.
        /// </summary>
        [FieldOffset(0)]
        public ByteSize64 ResourceOffset;

        /// <summary>
        ///     <c>Size</c> is the size of the memory region to be bound.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>Memory</c> is the <c>VkDeviceMemory</c> object that the range of the resource is bound to. If <c>memory</c> is <c>VK_NULL_HANDLE</c>, the range is unbound.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MemoryOffset</c> is the offset into the <c>VkDeviceMemory</c> object to bind the resource range to. If <c>memory</c> is <c>VK_NULL_HANDLE</c>, this value is ignored.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 MemoryOffset;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSparseMemoryBindFlags</c> specifying usage of the binding operation.
        /// </summary>
        [FieldOffset(32)]
        public VkSparseMemoryBindFlags Flags;
    }
}
