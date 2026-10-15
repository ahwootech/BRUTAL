namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandPoolCreateInfo.html">VkCommandPoolCreateInfo</see> - Structure specifying parameters of a newly created command pool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCommandPoolCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkCommandPoolCreateInfo {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkCommandPoolCreateFlags    flags;
    ///             uint32_t                    queueFamilyIndex;
    ///         } VkCommandPoolCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkCommandPoolCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandPoolCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkCommandPoolCreateFlags</c> indicating usage behavior for the pool and command buffers allocated from it.
        /// </summary>
        [FieldOffset(16)]
        public VkCommandPoolCreateFlags Flags;

        /// <summary>
        ///     <c>QueueFamilyIndex</c> designates a queue family as described in section <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#devsandqueues-queueprops">Queue Family Properties^</see>. All command buffers allocated from this command pool <i>must</i> be submitted on queues from the same queue family.
        /// </summary>
        [FieldOffset(20)]
        public int QueueFamilyIndex;
    }
}
