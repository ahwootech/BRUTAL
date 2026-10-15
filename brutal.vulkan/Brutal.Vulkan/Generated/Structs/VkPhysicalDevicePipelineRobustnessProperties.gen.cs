namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineRobustnessProperties.html">VkPhysicalDevicePipelineRobustnessProperties</see> - Structure describing the default robustness behavior of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineRobustnessProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDevicePipelineRobustnessProperties {
    ///             VkStructureType                       sType;
    ///             void*                                 pNext;
    ///             VkPipelineRobustnessBufferBehavior    defaultRobustnessStorageBuffers;
    ///             VkPipelineRobustnessBufferBehavior    defaultRobustnessUniformBuffers;
    ///             VkPipelineRobustnessBufferBehavior    defaultRobustnessVertexInputs;
    ///             VkPipelineRobustnessImageBehavior     defaultRobustnessImages;
    ///         } VkPhysicalDevicePipelineRobustnessProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDevicePipelineRobustnessProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineRobustnessProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DefaultRobustnessStorageBuffers</c>
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineRobustnessBufferBehavior DefaultRobustnessStorageBuffers;

        /// <summary>
        ///     <c>DefaultRobustnessUniformBuffers</c>
        /// </summary>
        [FieldOffset(20)]
        public VkPipelineRobustnessBufferBehavior DefaultRobustnessUniformBuffers;

        /// <summary>
        ///     <c>DefaultRobustnessVertexInputs</c>
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineRobustnessBufferBehavior DefaultRobustnessVertexInputs;

        /// <summary>
        ///     <c>DefaultRobustnessImages</c>
        /// </summary>
        [FieldOffset(28)]
        public VkPipelineRobustnessImageBehavior DefaultRobustnessImages;
    }
}
