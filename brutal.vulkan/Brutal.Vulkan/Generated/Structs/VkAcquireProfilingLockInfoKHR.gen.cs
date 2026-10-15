namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAcquireProfilingLockInfoKHR.html">VkAcquireProfilingLockInfoKHR</see> - Structure specifying parameters to acquire the profiling lock
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAcquireProfilingLockInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef struct VkAcquireProfilingLockInfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkAcquireProfilingLockFlagsKHR    flags;
    ///             uint64_t                          timeout;
    ///         } VkAcquireProfilingLockInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAcquireProfilingLockInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AcquireProfilingLockInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkAcquireProfilingLockFlagsKHR Flags;

        /// <summary>
        ///     <c>Timeout</c> indicates how long the function waits, in nanoseconds, if the profiling lock is not available.
        /// </summary>
        [FieldOffset(24)]
        public nint Timeout;
    }
}
