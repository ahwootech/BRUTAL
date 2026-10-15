namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferUsageFlags2CreateInfo.html">VkBufferUsageFlags2CreateInfo</see> - Extended buffer usage flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBufferUsageFlags2CreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkBufferUsageFlags2CreateInfo {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkBufferUsageFlags2    usage;
    ///         } VkBufferUsageFlags2CreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBufferUsageFlags2CreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferUsageFlags2CreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkBufferUsageFlags2</c> specifying allowed usages of the buffer.
        /// </summary>
        [FieldOffset(16)]
        public VkBufferUsageFlags2 Usage;
    }
}
