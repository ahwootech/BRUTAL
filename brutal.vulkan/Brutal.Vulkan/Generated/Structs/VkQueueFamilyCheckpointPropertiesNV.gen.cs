namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyCheckpointPropertiesNV.html">VkQueueFamilyCheckpointPropertiesNV</see> - Return structure for queue family checkpoint information query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyCheckpointPropertiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_diagnostic_checkpoints
    ///         typedef struct VkQueueFamilyCheckpointPropertiesNV {
    ///             VkStructureType         sType;
    ///             void*                   pNext;
    ///             VkPipelineStageFlags    checkpointExecutionStageMask;
    ///         } VkQueueFamilyCheckpointPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueueFamilyCheckpointPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyCheckpointPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CheckpointExecutionStageMask</c> is a mask indicating which pipeline stages the implementation can execute checkpoint markers in.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineStageFlags CheckpointExecutionStageMask;
    }
}
