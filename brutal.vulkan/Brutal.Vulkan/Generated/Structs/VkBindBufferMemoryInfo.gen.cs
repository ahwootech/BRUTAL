namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindBufferMemoryInfo.html">VkBindBufferMemoryInfo</see> - Structure specifying how to bind a buffer to memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindBufferMemoryInfo
    ///     </para>
    ///     <para>
    ///         <c>VkBindBufferMemoryInfo</c> contains members corresponding to the
    ///         parameters of <c>vkBindBufferMemory</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkBindBufferMemoryInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkBindBufferMemoryInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBuffer           buffer;
    ///             VkDeviceMemory     memory;
    ///             VkDeviceSize       memoryOffset;
    ///         } VkBindBufferMemoryInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkBindBufferMemoryInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindBufferMemoryInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Buffer</c> is the buffer to be attached to memory.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Memory</c> is a <c>VkDeviceMemory</c> object describing the device memory to attach.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MemoryOffset</c> is the start offset of the region of <c>memory</c> which is to be bound to the buffer. The number of bytes returned in the <c>VkMemoryRequirements::size</c> member in <c>memory</c>, starting from <c>memoryOffset</c> bytes, will be bound to the specified buffer.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 MemoryOffset;
    }
}
