namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelineRobustnessFeatures.html">VkPhysicalDevicePipelineRobustnessFeatures</see> - Structure describing whether an implementation supports robustness requests on a per-pipeline stage granularity
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelineRobustnessFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDevicePipelineRobustnessFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineRobustness;
    ///         } VkPhysicalDevicePipelineRobustnessFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelineRobustnessFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelineRobustnessFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineRobustness</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineRobustness;
    }
}
