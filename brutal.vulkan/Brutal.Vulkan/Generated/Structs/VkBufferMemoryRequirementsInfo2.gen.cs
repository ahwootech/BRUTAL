namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferMemoryRequirementsInfo2.html">VkBufferMemoryRequirementsInfo2</see> - (None)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBufferMemoryRequirementsInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkBufferMemoryRequirementsInfo2 {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBuffer           buffer;
    ///         } VkBufferMemoryRequirementsInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBufferMemoryRequirementsInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BufferMemoryRequirementsInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Buffer</c> is the buffer to query.
        /// </summary>
        [FieldOffset(16)]
        public VkBuffer Buffer;
    }
}
