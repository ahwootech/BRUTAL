namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindImageMemoryInfo.html">VkBindImageMemoryInfo</see> - Structure specifying how to bind an image to memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindImageMemoryInfo
    ///     </para>
    ///     <para>
    ///         <c>VkBindImageMemoryInfo</c> contains members corresponding to the parameters
    ///         of <c>vkBindImageMemory</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkBindImageMemoryInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkBindImageMemoryInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImage            image;
    ///             VkDeviceMemory     memory;
    ///             VkDeviceSize       memoryOffset;
    ///         } VkBindImageMemoryInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkBindImageMemoryInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindImageMemoryInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image</c> is the image to be attached to memory.
        /// </summary>
        [FieldOffset(16)]
        public VkImage Image;

        /// <summary>
        ///     <c>Memory</c> is a <c>VkDeviceMemory</c> object describing the device memory to attach.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MemoryOffset</c> is the start offset of the region of <c>memory</c> which is to be bound to the image. The number of bytes returned in the <c>VkMemoryRequirements::size</c> member in <c>memory</c>, starting from <c>memoryOffset</c> bytes, will be bound to the specified image.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 MemoryOffset;
    }
}
