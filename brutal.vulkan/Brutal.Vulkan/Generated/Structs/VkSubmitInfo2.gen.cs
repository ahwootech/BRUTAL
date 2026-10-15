namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubmitInfo2.html">VkSubmitInfo2</see> - Structure specifying a queue submit operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSubmitInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkSubmitInfo2 {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkSubmitFlags                       flags;
    ///             uint32_t                            waitSemaphoreInfoCount;
    ///             const VkSemaphoreSubmitInfo*        pWaitSemaphoreInfos;
    ///             uint32_t                            commandBufferInfoCount;
    ///             const VkCommandBufferSubmitInfo*    pCommandBufferInfos;
    ///             uint32_t                            signalSemaphoreInfoCount;
    ///             const VkSemaphoreSubmitInfo*        pSignalSemaphoreInfos;
    ///         } VkSubmitInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkSubmitInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubmitInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSubmitFlags</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkSubmitFlags Flags;

        /// <summary>
        ///     <c>WaitSemaphoreInfoCount</c> is the number of elements in <c>pWaitSemaphoreInfos</c>.
        /// </summary>
        [FieldOffset(20)]
        public int WaitSemaphoreInfoCount;

        /// <summary>
        ///     <c>WaitSemaphoreInfos</c> is a pointer to an array of <c>VkSemaphoreSubmitInfo</c> structures defining <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-waiting">semaphore wait operations^</see>.
        /// </summary>
        [FieldOffset(24)]
        public VkSemaphoreSubmitInfo* WaitSemaphoreInfos;

        /// <summary>
        ///     <c>CommandBufferInfoCount</c> is the number of elements in <c>pCommandBufferInfos</c> and the number of command buffers to execute in the batch.
        /// </summary>
        [FieldOffset(32)]
        public int CommandBufferInfoCount;

        /// <summary>
        ///     <c>CommandBufferInfos</c> is a pointer to an array of <c>VkCommandBufferSubmitInfo</c> structures describing command buffers to execute in the batch.
        /// </summary>
        [FieldOffset(40)]
        public VkCommandBufferSubmitInfo* CommandBufferInfos;

        /// <summary>
        ///     <c>SignalSemaphoreInfoCount</c> is the number of elements in <c>pSignalSemaphoreInfos</c>.
        /// </summary>
        [FieldOffset(48)]
        public int SignalSemaphoreInfoCount;

        /// <summary>
        ///     <c>SignalSemaphoreInfos</c> is a pointer to an array of <c>VkSemaphoreSubmitInfo</c> describing <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-signaling">semaphore signal operations^</see>.
        /// </summary>
        [FieldOffset(56)]
        public VkSemaphoreSubmitInfo* SignalSemaphoreInfos;
    }
}
