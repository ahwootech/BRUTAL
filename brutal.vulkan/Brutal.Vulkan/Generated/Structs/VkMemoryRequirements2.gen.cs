namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryRequirements2.html">VkMemoryRequirements2</see> - Structure specifying memory requirements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryRequirements2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkMemoryRequirements2 {
    ///             VkStructureType         sType;
    ///             void*                   pNext;
    ///             VkMemoryRequirements    memoryRequirements;
    ///         } VkMemoryRequirements2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkMemoryRequirements2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryRequirements2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryRequirements</c> is a <c>VkMemoryRequirements</c> structure describing the memory requirements of the resource.
        /// </summary>
        [FieldOffset(16)]
        public VkMemoryRequirements MemoryRequirements;
    }
}
