namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessCreateInfo.html">VkPipelineRobustnessCreateInfo</see> - Structure controlling the robustness of a newly created pipeline shader stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineRobustnessCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPipelineRobustnessCreateInfo {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkPipelineRobustnessBufferBehavior    storageBuffers;
    ///             VkPipelineRobustnessBufferBehavior    uniformBuffers;
    ///             VkPipelineRobustnessBufferBehavior    vertexInputs;
    ///             VkPipelineRobustnessImageBehavior     images;
    ///         } VkPipelineRobustnessCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineRobustnessCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineRobustnessCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StorageBuffers</c> sets the behavior of out of bounds accesses made to resources bound as:
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineRobustnessBufferBehavior StorageBuffers;

        /// <summary>
        ///     <c>UniformBuffers</c> describes the behavior of out of bounds accesses made to resources bound as:
        /// </summary>
        [FieldOffset(20)]
        public VkPipelineRobustnessBufferBehavior UniformBuffers;

        /// <summary>
        ///     <c>VertexInputs</c> describes the behavior of out of bounds accesses made to vertex input attributes
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineRobustnessBufferBehavior VertexInputs;

        /// <summary>
        ///     <c>Images</c> describes the behavior of out of bounds accesses made to resources bound as:
        /// </summary>
        [FieldOffset(28)]
        public VkPipelineRobustnessImageBehavior Images;
    }
}
