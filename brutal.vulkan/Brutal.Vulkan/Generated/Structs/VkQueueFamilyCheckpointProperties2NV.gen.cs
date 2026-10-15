namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyCheckpointProperties2NV.html">VkQueueFamilyCheckpointProperties2NV</see> - Return structure for queue family checkpoint information query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyCheckpointProperties2NV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_diagnostic_checkpoints with VK_VERSION_1_3 or VK_KHR_synchronization2
    ///         typedef struct VkQueueFamilyCheckpointProperties2NV {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkPipelineStageFlags2    checkpointExecutionStageMask;
    ///         } VkQueueFamilyCheckpointProperties2NV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueueFamilyCheckpointProperties2NV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyCheckpointProperties2NV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CheckpointExecutionStageMask</c> is a mask indicating which pipeline stages the implementation can execute checkpoint markers in.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineStageFlags2 CheckpointExecutionStageMask;
    }
}
