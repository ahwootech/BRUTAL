namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionNeuralStatisticsCreateInfoARM.html">VkDataGraphPipelineSessionNeuralStatisticsCreateInfoARM</see> - Structure specifying neural statistics parameters of a newly created data graph pipeline session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSessionNeuralStatisticsCreateInfoARM
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///         typedef struct VkDataGraphPipelineSessionNeuralStatisticsCreateInfoARM {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             VkNeuralAcceleratorStatisticsModeARM    mode;
    ///         } VkDataGraphPipelineSessionNeuralStatisticsCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphPipelineSessionNeuralStatisticsCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineSessionNeuralStatisticsCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkNeuralAcceleratorStatisticsModeARM</c> specifying the neural statistics mode for the session being created.
        /// </summary>
        [FieldOffset(16)]
        public VkNeuralAcceleratorStatisticsModeARM Mode;
    }
}
