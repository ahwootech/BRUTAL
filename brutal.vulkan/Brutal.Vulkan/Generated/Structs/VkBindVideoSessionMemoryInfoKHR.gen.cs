namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindVideoSessionMemoryInfoKHR.html">VkBindVideoSessionMemoryInfoKHR</see> - Structure specifying memory bindings for a video session object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindVideoSessionMemoryInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkBindVideoSessionMemoryInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           memoryBindIndex;
    ///             VkDeviceMemory     memory;
    ///             VkDeviceSize       memoryOffset;
    ///             VkDeviceSize       memorySize;
    ///         } VkBindVideoSessionMemoryInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkBindVideoSessionMemoryInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindVideoSessionMemoryInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryBindIndex</c> is the memory binding index to bind memory to.
        /// </summary>
        [FieldOffset(16)]
        public int MemoryBindIndex;

        /// <summary>
        ///     <c>Memory</c> is the allocated device memory to be bound to the video session&apos;s memory binding with index <c>memoryBindIndex</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MemoryOffset</c> is the start offset of the region of <c>memory</c> which is to be bound.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 MemoryOffset;

        /// <summary>
        ///     <c>MemorySize</c> is the size in bytes of the region of <c>memory</c>, starting from <c>memoryOffset</c> bytes, to be bound.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 MemorySize;
    }
}
