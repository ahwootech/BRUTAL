namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoSessionMemoryRequirementsKHR.html">VkVideoSessionMemoryRequirementsKHR</see> - Structure describing video session memory requirements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoSessionMemoryRequirementsKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoSessionMemoryRequirementsKHR {
    ///             VkStructureType         sType;
    ///             void*                   pNext;
    ///             uint32_t                memoryBindIndex;
    ///             VkMemoryRequirements    memoryRequirements;
    ///         } VkVideoSessionMemoryRequirementsKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkVideoSessionMemoryRequirementsKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoSessionMemoryRequirementsKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryBindIndex</c> is the index of the memory binding.
        /// </summary>
        [FieldOffset(16)]
        public int MemoryBindIndex;

        /// <summary>
        ///     <c>MemoryRequirements</c> is a <c>VkMemoryRequirements</c> structure in which the requested memory binding requirements for the binding index specified by <c>memoryBindIndex</c> are returned.
        /// </summary>
        [FieldOffset(24)]
        public VkMemoryRequirements MemoryRequirements;
    }
}
