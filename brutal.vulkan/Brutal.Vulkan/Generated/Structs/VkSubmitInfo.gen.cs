namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubmitInfo.html">VkSubmitInfo</see> - Structure specifying a queue submit operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkSubmitInfo
    ///         The <c>VkSubmitInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSubmitInfo {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             uint32_t                       waitSemaphoreCount;
    ///             const VkSemaphore*             pWaitSemaphores;
    ///             const VkPipelineStageFlags*    pWaitDstStageMask;
    ///             uint32_t                       commandBufferCount;
    ///             const VkCommandBuffer*         pCommandBuffers;
    ///             uint32_t                       signalSemaphoreCount;
    ///             const VkSemaphore*             pSignalSemaphores;
    ///         } VkSubmitInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkSubmitInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubmitInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WaitSemaphoreCount</c> is the number of semaphores upon which to wait before executing the command buffers for the batch.
        /// </summary>
        [FieldOffset(16)]
        public int WaitSemaphoreCount;

        /// <summary>
        ///     <c>WaitSemaphores</c> is a pointer to an array of <c>VkSemaphore</c> handles upon which to wait before the command buffers for this batch begin execution. If semaphores to wait on are provided, they define a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-waiting">semaphore wait operation^</see>.
        /// </summary>
        [FieldOffset(24)]
        public VkSemaphore* WaitSemaphores;

        /// <summary>
        ///     <c>WaitDstStageMask</c> is a pointer to an array of pipeline stages at which each corresponding semaphore wait will occur.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineStageFlags* WaitDstStageMask;

        /// <summary>
        ///     <c>CommandBufferCount</c> is the number of command buffers to execute in the batch.
        /// </summary>
        [FieldOffset(40)]
        public int CommandBufferCount;

        /// <summary>
        ///     <c>CommandBuffers</c> is a pointer to an array of <c>VkCommandBuffer</c> handles to execute in the batch.
        /// </summary>
        [FieldOffset(48)]
        public VkCommandBuffer* CommandBuffers;

        /// <summary>
        ///     <c>SignalSemaphoreCount</c> is the number of semaphores to be signaled once the commands specified in <c>pCommandBuffers</c> have completed execution.
        /// </summary>
        [FieldOffset(56)]
        public int SignalSemaphoreCount;

        /// <summary>
        ///     <c>SignalSemaphores</c> is a pointer to an array of <c>VkSemaphore</c> handles which will be signaled when the command buffers for this batch have completed execution. If semaphores to be signaled are provided, they define a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-signaling">semaphore signal operation^</see>.
        /// </summary>
        [FieldOffset(64)]
        public VkSemaphore* SignalSemaphores;
    }
}
