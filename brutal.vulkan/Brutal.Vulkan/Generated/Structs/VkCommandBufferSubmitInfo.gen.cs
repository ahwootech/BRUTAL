namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferSubmitInfo.html">VkCommandBufferSubmitInfo</see> - Structure specifying a command buffer submission
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCommandBufferSubmitInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkCommandBufferSubmitInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkCommandBuffer    commandBuffer;
    ///             uint32_t           deviceMask;
    ///         } VkCommandBufferSubmitInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCommandBufferSubmitInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferSubmitInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CommandBuffer</c> is a <c>VkCommandBuffer</c> to be submitted for execution.
        /// </summary>
        [FieldOffset(16)]
        public VkCommandBuffer CommandBuffer;

        /// <summary>
        ///     <c>DeviceMask</c> is a bitmask indicating which devices in a device group execute the command buffer. A <c>deviceMask</c> of `0` is equivalent to setting all bits corresponding to valid devices in the group to `1`.
        /// </summary>
        [FieldOffset(24)]
        public int DeviceMask;
    }
}
