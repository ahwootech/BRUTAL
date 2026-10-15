namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferAllocateInfo.html">VkCommandBufferAllocateInfo</see> - Structure specifying the allocation parameters for command buffer object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCommandBufferAllocateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkCommandBufferAllocateInfo {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkCommandPool           commandPool;
    ///             VkCommandBufferLevel    level;
    ///             uint32_t                commandBufferCount;
    ///         } VkCommandBufferAllocateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCommandBufferAllocateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferAllocateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CommandPool</c> is the command pool from which the command buffers are allocated.
        /// </summary>
        [FieldOffset(16)]
        public VkCommandPool CommandPool;

        /// <summary>
        ///     <c>Level</c> is a <c>VkCommandBufferLevel</c> value specifying the command buffer level.
        /// </summary>
        [FieldOffset(24)]
        public VkCommandBufferLevel Level;

        /// <summary>
        ///     <c>CommandBufferCount</c> is the number of command buffers to allocate from the pool.
        /// </summary>
        [FieldOffset(28)]
        internal int CommandBufferCount;
    }
}
