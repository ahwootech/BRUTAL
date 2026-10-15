namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSparseImageMemoryRequirements2.html">VkSparseImageMemoryRequirements2</see> - (None)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSparseImageMemoryRequirements2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkSparseImageMemoryRequirements2 {
    ///             VkStructureType                    sType;
    ///             void*                              pNext;
    ///             VkSparseImageMemoryRequirements    memoryRequirements;
    ///         } VkSparseImageMemoryRequirements2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkSparseImageMemoryRequirements2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SparseImageMemoryRequirements2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryRequirements</c> is a <c>VkSparseImageMemoryRequirements</c> structure describing the memory requirements of the sparse image.
        /// </summary>
        [FieldOffset(16)]
        public VkSparseImageMemoryRequirements MemoryRequirements;
    }
}
