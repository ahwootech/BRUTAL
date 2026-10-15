namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferCopy2.html">VkBufferCopy2</see> - Structure specifying a buffer copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBufferCopy2
    ///     </para>
    ///     <para>
    ///         The <c>VkBufferCopy2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkBufferCopy2 {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceSize       srcOffset;
    ///             VkDeviceSize       dstOffset;
    ///             VkDeviceSize       size;
    ///         } VkBufferCopy2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkBufferCopy2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferCopy2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcOffset</c> is the starting offset in bytes from the start of <c>srcBuffer</c>.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 SrcOffset;

        /// <summary>
        ///     <c>DstOffset</c> is the starting offset in bytes from the start of <c>dstBuffer</c>.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 DstOffset;

        /// <summary>
        ///     <c>Size</c> is the number of bytes to copy.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 Size;
    }
}
