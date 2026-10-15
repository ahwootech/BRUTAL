namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupRenderPassBeginInfo.html">VkDeviceGroupRenderPassBeginInfo</see> - Set the initial device mask and render areas for a render pass instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkRenderPassBeginInfo</c>
    ///         includes a <c>VkDeviceGroupRenderPassBeginInfo</c> structure, then that
    ///         structure includes a device mask and set of render areas for the render pass
    ///         instance.
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceGroupRenderPassBeginInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkDeviceGroupRenderPassBeginInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           deviceMask;
    ///             uint32_t           deviceRenderAreaCount;
    ///             const VkRect2D*    pDeviceRenderAreas;
    ///         } VkDeviceGroupRenderPassBeginInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDeviceGroupRenderPassBeginInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceGroupRenderPassBeginInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceMask</c> is the device mask for the render pass instance.
        /// </summary>
        [FieldOffset(16)]
        public int DeviceMask;

        /// <summary>
        ///     <c>DeviceRenderAreaCount</c> is the number of elements in the <c>pDeviceRenderAreas</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int DeviceRenderAreaCount;

        /// <summary>
        ///     <c>DeviceRenderAreas</c> is a pointer to an array of <c>VkRect2D</c> structures defining the render area for each physical device.
        /// </summary>
        [FieldOffset(24)]
        public VkRect2D* DeviceRenderAreas;
    }
}
