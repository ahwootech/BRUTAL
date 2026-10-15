namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceGroupSubmitInfo.html">VkDeviceGroupSubmitInfo</see> - Structure indicating which physical devices execute semaphore operations and command buffers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkSubmitInfo</c> includes a
    ///         <c>VkDeviceGroupSubmitInfo</c> structure, then that structure includes device
    ///         indices and masks specifying which physical devices execute semaphore
    ///         operations and command buffers.
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceGroupSubmitInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkDeviceGroupSubmitInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           waitSemaphoreCount;
    ///             const uint32_t*    pWaitSemaphoreDeviceIndices;
    ///             uint32_t           commandBufferCount;
    ///             const uint32_t*    pCommandBufferDeviceMasks;
    ///             uint32_t           signalSemaphoreCount;
    ///             const uint32_t*    pSignalSemaphoreDeviceIndices;
    ///         } VkDeviceGroupSubmitInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkDeviceGroupSubmitInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceGroupSubmitInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WaitSemaphoreCount</c> is the number of elements in the <c>pWaitSemaphoreDeviceIndices</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int WaitSemaphoreCount;

        /// <summary>
        ///     <c>WaitSemaphoreDeviceIndices</c> is a pointer to an array of <c>waitSemaphoreCount</c> device indices indicating which physical device executes the semaphore wait operation in the corresponding element of <c>VkSubmitInfo::pWaitSemaphores</c>.
        /// </summary>
        [FieldOffset(24)]
        public int* WaitSemaphoreDeviceIndices;

        /// <summary>
        ///     <c>CommandBufferCount</c> is the number of elements in the <c>pCommandBufferDeviceMasks</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int CommandBufferCount;

        /// <summary>
        ///     <c>CommandBufferDeviceMasks</c> is a pointer to an array of <c>commandBufferCount</c> device masks indicating which physical devices execute the command buffer in the corresponding element of <c>VkSubmitInfo::pCommandBuffers</c>. A physical device executes the command buffer if the corresponding bit is set in the mask.
        /// </summary>
        [FieldOffset(40)]
        public int* CommandBufferDeviceMasks;

        /// <summary>
        ///     <c>SignalSemaphoreCount</c> is the number of elements in the <c>pSignalSemaphoreDeviceIndices</c> array.
        /// </summary>
        [FieldOffset(48)]
        public int SignalSemaphoreCount;

        /// <summary>
        ///     <c>SignalSemaphoreDeviceIndices</c> is a pointer to an array of <c>signalSemaphoreCount</c> device indices indicating which physical device executes the semaphore signal operation in the corresponding element of <c>VkSubmitInfo::pSignalSemaphores</c>.
        /// </summary>
        [FieldOffset(56)]
        public int* SignalSemaphoreDeviceIndices;
    }
}
