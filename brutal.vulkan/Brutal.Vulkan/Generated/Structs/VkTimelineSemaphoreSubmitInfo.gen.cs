namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTimelineSemaphoreSubmitInfo.html">VkTimelineSemaphoreSubmitInfo</see> - Structure specifying signal and wait values for timeline semaphores
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To specify the values to use when waiting for and signaling semaphores
    ///         created with a <c>VkSemaphoreType</c> of <c>VK_SEMAPHORE_TYPE_TIMELINE</c>,
    ///         add a <c>VkTimelineSemaphoreSubmitInfo</c> structure to the <c>pNext</c> chain
    ///         of the <c>VkSubmitInfo</c> structure when using <c>vkQueueSubmit</c>
    ///         or the <c>VkBindSparseInfo</c> structure when using <c>vkQueueBindSparse</c>
    ///         .
    ///         The <c>VkTimelineSemaphoreSubmitInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkTimelineSemaphoreSubmitInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           waitSemaphoreValueCount;
    ///             const uint64_t*    pWaitSemaphoreValues;
    ///             uint32_t           signalSemaphoreValueCount;
    ///             const uint64_t*    pSignalSemaphoreValues;
    ///         } VkTimelineSemaphoreSubmitInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkTimelineSemaphoreSubmitInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TimelineSemaphoreSubmitInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WaitSemaphoreValueCount</c> is the number of semaphore wait values specified in <c>pWaitSemaphoreValues</c>.
        /// </summary>
        [FieldOffset(16)]
        public int WaitSemaphoreValueCount;

        /// <summary>
        ///     <c>WaitSemaphoreValues</c> is a pointer to an array of <c>waitSemaphoreValueCount</c> values for the corresponding semaphores in <c>VkSubmitInfo::pWaitSemaphores</c> to wait for.
        /// </summary>
        [FieldOffset(24)]
        public nint* WaitSemaphoreValues;

        /// <summary>
        ///     <c>SignalSemaphoreValueCount</c> is the number of semaphore signal values specified in <c>pSignalSemaphoreValues</c>.
        /// </summary>
        [FieldOffset(32)]
        public int SignalSemaphoreValueCount;

        /// <summary>
        ///     <c>SignalSemaphoreValues</c> is a pointer to an array <c>signalSemaphoreValueCount</c> values for the corresponding semaphores in <c>VkSubmitInfo::pSignalSemaphores</c> to set when signaled.
        /// </summary>
        [FieldOffset(40)]
        public nint* SignalSemaphoreValues;
    }
}
