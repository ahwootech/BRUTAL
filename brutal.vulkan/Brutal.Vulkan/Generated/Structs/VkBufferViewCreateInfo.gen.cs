namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferViewCreateInfo.html">VkBufferViewCreateInfo</see> - Structure specifying parameters of a newly created buffer view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBufferViewCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkBufferViewCreateInfo {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkBufferViewCreateFlags    flags;
    ///             VkBuffer                   buffer;
    ///             VkFormat                   format;
    ///             VkDeviceSize               offset;
    ///             VkDeviceSize               range;
    ///         } VkBufferViewCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkBufferViewCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferViewCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkBufferViewCreateFlags Flags;

        /// <summary>
        ///     <c>Buffer</c> is a <c>VkBuffer</c> on which the view will be created.
        /// </summary>
        [FieldOffset(24)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> describing the format of the data elements in the buffer.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat Format;

        /// <summary>
        ///     <c>Offset</c> is an offset in bytes from the base address of the buffer. Accesses to the buffer view from shaders use addressing that is relative to this starting offset.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Range</c> is a size in bytes of the buffer view. If <c>range</c> is equal to <c>VK_WHOLE_SIZE</c>, the range from <c>offset</c> to the end of the buffer is used. If <c>VK_WHOLE_SIZE</c> is used and the remaining size of the buffer is not a multiple of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#texel-block-size">texel block size^</see> of <c>format</c>, the nearest smaller multiple is used.
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64 Range;
    }
}
