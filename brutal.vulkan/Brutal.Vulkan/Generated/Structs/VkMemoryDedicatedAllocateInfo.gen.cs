namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedAllocateInfo.html">VkMemoryDedicatedAllocateInfo</see> - Specify a dedicated memory allocation resource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain includes a <c>VkMemoryDedicatedAllocateInfo</c>
    ///         structure, then that structure includes a handle of the sole buffer or image
    ///         resource that the memory <i>can</i> be bound to.
    ///     </para>
    ///     <para>
    ///         The <c>VkMemoryDedicatedAllocateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkMemoryDedicatedAllocateInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImage            image;
    ///             VkBuffer           buffer;
    ///         } VkMemoryDedicatedAllocateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkMemoryDedicatedAllocateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryDedicatedAllocateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image</c> is <c>VK_NULL_HANDLE</c> or a handle of an image which this memory will be bound to.
        /// </summary>
        [FieldOffset(16)]
        public VkImage Image;

        /// <summary>
        ///     <c>Buffer</c> is <c>VK_NULL_HANDLE</c> or a handle of a buffer which this memory will be bound to.
        /// </summary>
        [FieldOffset(24)]
        public VkBuffer Buffer;
    }
}
