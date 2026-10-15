namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreSubmitInfo.html">VkSemaphoreSubmitInfo</see> - Structure specifying a semaphore signal or wait operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkSemaphoreSubmitInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkSemaphoreSubmitInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkSemaphoreSubmitInfo {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkSemaphore              semaphore;
    ///             uint64_t                 value;
    ///             VkPipelineStageFlags2    stageMask;
    ///             uint32_t                 deviceIndex;
    ///         } VkSemaphoreSubmitInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkSemaphoreSubmitInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SemaphoreSubmitInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Semaphore</c> is a <c>VkSemaphore</c> affected by this operation.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphore Semaphore;

        /// <summary>
        ///     <c>Value</c> is ignored.
        /// </summary>
        [FieldOffset(24)]
        public nint Value;

        /// <summary>
        ///     <c>StageMask</c> is a <c>VkPipelineStageFlags2</c> mask of pipeline stages which limit the first synchronization scope of a semaphore signal operation, or second synchronization scope of a semaphore wait operation as described in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-waiting">semaphore wait operation^</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-signaling">semaphore signal operation^</see> sections of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization">the synchronization chapter^</see>.
        /// </summary>
        [FieldOffset(32)]
        public VkPipelineStageFlags2 StageMask;

        /// <summary>
        ///     <c>DeviceIndex</c> is the index of the device within a device group that executes the semaphore wait or signal operation.
        /// </summary>
        [FieldOffset(40)]
        public int DeviceIndex;
    }
}
