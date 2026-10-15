namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreSignalInfo.html">VkSemaphoreSignalInfo</see> - Structure containing information about a semaphore signal operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSemaphoreSignalInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSemaphoreSignalInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSemaphore        semaphore;
    ///             uint64_t           value;
    ///         } VkSemaphoreSignalInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSemaphoreSignalInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SemaphoreSignalInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Semaphore</c> is the handle of the semaphore to signal.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphore Semaphore;

        /// <summary>
        ///     <c>Value</c> is the value to signal.
        /// </summary>
        [FieldOffset(24)]
        public nint Value;
    }
}
