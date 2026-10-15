namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineNeuralStatisticsCreateInfoARM.html">VkDataGraphPipelineNeuralStatisticsCreateInfoARM</see> - Structure specifying neural statistics parameters of a newly created graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineNeuralStatisticsCreateInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineNeuralStatisticsCreateInfoARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///         typedef struct VkDataGraphPipelineNeuralStatisticsCreateInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           allowNeuralStatistics;
    ///         } VkDataGraphPipelineNeuralStatisticsCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphPipelineNeuralStatisticsCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineNeuralStatisticsCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AllowNeuralStatistics</c> specifies whether sessions for the newly created pipeline may: enable neural statistics reporting.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AllowNeuralStatistics;
    }
}
