namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupCommandBufferBeginInfo.html">VkDeviceGroupCommandBufferBeginInfo</see> - Set the initial device mask for a command buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkCommandBufferBeginInfo</c> includes a
    ///         <c>VkDeviceGroupCommandBufferBeginInfo</c> structure, then that structure
    ///         includes an initial device mask for the command buffer.
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceGroupCommandBufferBeginInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkDeviceGroupCommandBufferBeginInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           deviceMask;
    ///         } VkDeviceGroupCommandBufferBeginInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceGroupCommandBufferBeginInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceGroupCommandBufferBeginInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceMask</c> is the initial value of the command buffer&apos;s device mask.
        /// </summary>
        [FieldOffset(16)]
        public int DeviceMask;
    }
}
