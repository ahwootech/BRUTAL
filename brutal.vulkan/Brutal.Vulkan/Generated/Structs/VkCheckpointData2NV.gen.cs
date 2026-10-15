namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCheckpointData2NV.html">VkCheckpointData2NV</see> - Return structure for command buffer checkpoint data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCheckpointData2NV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_diagnostic_checkpoints with VK_VERSION_1_3 or VK_KHR_synchronization2
    ///         typedef struct VkCheckpointData2NV {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkPipelineStageFlags2    stage;
    ///             void*                    pCheckpointMarker;
    ///         } VkCheckpointData2NV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCheckpointData2NV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CheckpointData2NV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Stage</c> indicates a single pipeline stage which the checkpoint marker data refers to.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineStageFlags2 Stage;

        /// <summary>
        ///     <c>CheckpointMarker</c> contains the value of the last checkpoint marker executed in the stage that <c>stage</c> refers to.
        /// </summary>
        [FieldOffset(24)]
        public void* CheckpointMarker;
    }
}
