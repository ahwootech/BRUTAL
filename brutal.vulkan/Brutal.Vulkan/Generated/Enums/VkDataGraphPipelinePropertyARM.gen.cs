namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelinePropertyARM.html">VkDataGraphPipelinePropertyARM</see> - Enumeration describing the properties of a data graph pipeline that can be queried
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelinePropertyARM
    ///     </para>
    ///     <para>
    ///         Possible values of
    ///         <c>VkDataGraphPipelinePropertyQueryResultARM::property</c>, specifying
    ///         the property of the data graph pipeline being queried, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef enum VkDataGraphPipelinePropertyARM {
    ///             VK_DATA_GRAPH_PIPELINE_PROPERTY_CREATION_LOG_ARM = 0,
    ///             VK_DATA_GRAPH_PIPELINE_PROPERTY_IDENTIFIER_ARM = 1,
    ///             // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///             VK_DATA_GRAPH_PIPELINE_PROPERTY_NEURAL_ACCELERATOR_DEBUG_DATABASE_ARM = 1000676000,
    ///             // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///             VK_DATA_GRAPH_PIPELINE_PROPERTY_NEURAL_ACCELERATOR_STATISTICS_INFO_ARM = 1000676001,
    ///         } VkDataGraphPipelinePropertyARM;
    ///     </code>
    /// </remarks>
    public enum VkDataGraphPipelinePropertyARM : int
    {
        /// <summary>
        ///     <c>CreationLogARM</c> corresponds to a human-readable log produced during the creation of a data graph pipeline. It may: contain information about errors encountered during the creation or other information generally useful for debugging. This property <i>can</i> be queried for any data graph pipeline.
        /// </summary>
        CreationLogARM = 0,

        /// <summary>
        ///     <c>IdentifierARM</c> corresponds to an opaque identifier for the data graph pipeline. It <i>can</i> be used to create a graph pipeline from a pipeline cache without the need to provide any creation data beyond the identifier, using a <c>VkDataGraphPipelineIdentifierCreateInfoARM</c> structure.
        /// </summary>
        IdentifierARM = 1,

        /// <summary>
        ///     <c>NeuralAcceleratorDebugDatabaseARM</c>
        /// </summary>
        NeuralAcceleratorDebugDatabaseARM = 1000676000,

        /// <summary>
        ///     <c>NeuralAcceleratorStatisticsInfoARM</c>
        /// </summary>
        NeuralAcceleratorStatisticsInfoARM = 1000676001,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
