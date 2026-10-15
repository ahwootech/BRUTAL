namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDependencyInfo.html">VkDependencyInfo</see> - Structure specifying dependency information for a synchronization command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDependencyInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkDependencyInfo {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkDependencyFlags                dependencyFlags;
    ///             uint32_t                         memoryBarrierCount;
    ///             const VkMemoryBarrier2*          pMemoryBarriers;
    ///             uint32_t                         bufferMemoryBarrierCount;
    ///             const VkBufferMemoryBarrier2*    pBufferMemoryBarriers;
    ///             uint32_t                         imageMemoryBarrierCount;
    ///             const VkImageMemoryBarrier2*     pImageMemoryBarriers;
    ///         } VkDependencyInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkDependencyInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DependencyInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DependencyFlags</c> is a bitmask of <c>VkDependencyFlags</c> specifying how execution and memory dependencies are formed.
        /// </summary>
        [FieldOffset(16)]
        public VkDependencyFlags DependencyFlags;

        /// <summary>
        ///     <c>MemoryBarrierCount</c> is the length of the <c>pMemoryBarriers</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int MemoryBarrierCount;

        /// <summary>
        ///     <c>MemoryBarriers</c> is a pointer to an array of <c>VkMemoryBarrier2</c> structures defining memory dependencies between any memory accesses.
        /// </summary>
        [FieldOffset(24)]
        public VkMemoryBarrier2* MemoryBarriers;

        /// <summary>
        ///     <c>BufferMemoryBarrierCount</c> is the length of the <c>pBufferMemoryBarriers</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int BufferMemoryBarrierCount;

        /// <summary>
        ///     <c>BufferMemoryBarriers</c> is a pointer to an array of <c>VkBufferMemoryBarrier2</c> structures defining memory dependencies between buffer ranges.
        /// </summary>
        [FieldOffset(40)]
        public VkBufferMemoryBarrier2* BufferMemoryBarriers;

        /// <summary>
        ///     <c>ImageMemoryBarrierCount</c> is the length of the <c>pImageMemoryBarriers</c> array.
        /// </summary>
        [FieldOffset(48)]
        public int ImageMemoryBarrierCount;

        /// <summary>
        ///     <c>ImageMemoryBarriers</c> is a pointer to an array of <c>VkImageMemoryBarrier2</c> structures defining memory dependencies between image subresources.
        /// </summary>
        [FieldOffset(56)]
        public VkImageMemoryBarrier2* ImageMemoryBarriers;
    }
}
