namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferBeginInfo.html">VkCommandBufferBeginInfo</see> - Structure specifying a command buffer begin operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCommandBufferBeginInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkCommandBufferBeginInfo {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkCommandBufferUsageFlags                flags;
    ///             const VkCommandBufferInheritanceInfo*    pInheritanceInfo;
    ///         } VkCommandBufferBeginInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCommandBufferBeginInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferBeginInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkCommandBufferUsageFlags</c> specifying usage behavior for the command buffer.
        /// </summary>
        [FieldOffset(16)]
        public VkCommandBufferUsageFlags Flags;

        /// <summary>
        ///     <c>InheritanceInfo</c> is a pointer to a <c>VkCommandBufferInheritanceInfo</c> structure, used if <c>commandBuffer</c> is a secondary command buffer. If this is a primary command buffer, then this value is ignored.
        /// </summary>
        [FieldOffset(24)]
        public VkCommandBufferInheritanceInfo* InheritanceInfo;
    }
}
