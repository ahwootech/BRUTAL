namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreWaitInfo.html">VkSemaphoreWaitInfo</see> - Structure containing information about the semaphore wait condition
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSemaphoreWaitInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSemaphoreWaitInfo {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkSemaphoreWaitFlags    flags;
    ///             uint32_t                semaphoreCount;
    ///             const VkSemaphore*      pSemaphores;
    ///             const uint64_t*         pValues;
    ///         } VkSemaphoreWaitInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkSemaphoreWaitInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SemaphoreWaitInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSemaphoreWaitFlags</c> specifying additional parameters for the semaphore wait operation.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphoreWaitFlags Flags;

        /// <summary>
        ///     <c>SemaphoreCount</c> is the number of semaphores to wait on.
        /// </summary>
        [FieldOffset(20)]
        public int SemaphoreCount;

        /// <summary>
        ///     <c>Semaphores</c> is a pointer to an array of <c>semaphoreCount</c> semaphore handles to wait on.
        /// </summary>
        [FieldOffset(24)]
        public VkSemaphore* Semaphores;

        /// <summary>
        ///     <c>Values</c> is a pointer to an array of <c>semaphoreCount</c> timeline semaphore values.
        /// </summary>
        [FieldOffset(32)]
        public nint* Values;
    }
}
