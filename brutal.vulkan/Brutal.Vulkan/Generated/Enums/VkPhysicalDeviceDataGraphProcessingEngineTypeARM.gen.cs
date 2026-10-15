namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDataGraphProcessingEngineTypeARM.html">VkPhysicalDeviceDataGraphProcessingEngineTypeARM</see> - Enumeration describing data graph processing engines
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPhysicalDeviceDataGraphProcessingEngineTypeARM
    ///     </para>
    ///     <para>
    ///         The defined data graph processing engines are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef enum VkPhysicalDeviceDataGraphProcessingEngineTypeARM {
    ///             VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_DEFAULT_ARM = 0,
    ///             // Provided by VK_QCOM_data_graph_model
    ///             VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_NEURAL_QCOM = 1000629000,
    ///             // Provided by VK_QCOM_data_graph_model
    ///             VK_PHYSICAL_DEVICE_DATA_GRAPH_PROCESSING_ENGINE_TYPE_COMPUTE_QCOM = 1000629001,
    ///         } VkPhysicalDeviceDataGraphProcessingEngineTypeARM;
    ///     </code>
    /// </remarks>
    public enum VkPhysicalDeviceDataGraphProcessingEngineTypeARM : int
    {
        /// <summary>
        ///     <c>DefaultARM</c>  corresponds to the default data graph processing engine.
        /// </summary>
        DefaultARM = 0,

        /// <summary>
        ///     <c>NeuralQCOM</c>
        /// </summary>
        NeuralQCOM = 1000629000,

        /// <summary>
        ///     <c>ComputeQCOM</c>
        /// </summary>
        ComputeQCOM = 1000629001,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
