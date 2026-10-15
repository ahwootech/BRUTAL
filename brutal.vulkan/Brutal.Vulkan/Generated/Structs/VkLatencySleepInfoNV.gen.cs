namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLatencySleepInfoNV.html">VkLatencySleepInfoNV</see> - Structure specifying the parameters of vkLatencySleepNV
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkLatencySleepInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency2
    ///         typedef struct VkLatencySleepInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSemaphore        signalSemaphore;
    ///             uint64_t           value;
    ///         } VkLatencySleepInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkLatencySleepInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.LatencySleepInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SignalSemaphore</c> is a semaphore that is signaled to indicate that the application <i>should</i> resume input sampling work.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphore SignalSemaphore;

        /// <summary>
        ///     <c>Value</c> is the value that <c>signalSemaphore</c> is set to for resuming sampling work.
        /// </summary>
        [FieldOffset(24)]
        public nint Value;
    }
}
