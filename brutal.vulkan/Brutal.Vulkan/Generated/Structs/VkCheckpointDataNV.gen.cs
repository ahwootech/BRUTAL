namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCheckpointDataNV.html">VkCheckpointDataNV</see> - Return structure for command buffer checkpoint data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCheckpointDataNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_diagnostic_checkpoints
    ///         typedef struct VkCheckpointDataNV {
    ///             VkStructureType            sType;
    ///             void*                      pNext;
    ///             VkPipelineStageFlagBits    stage;
    ///             void*                      pCheckpointMarker;
    ///         } VkCheckpointDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCheckpointDataNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CheckpointDataNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Stage</c> is a <c>VkPipelineStageFlags</c> value specifying which pipeline stage the checkpoint marker data refers to.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineStageFlags Stage;

        /// <summary>
        ///     <c>CheckpointMarker</c> contains the value of the last checkpoint marker executed in the stage that <c>stage</c> refers to.
        /// </summary>
        [FieldOffset(24)]
        public void* CheckpointMarker;
    }
}
