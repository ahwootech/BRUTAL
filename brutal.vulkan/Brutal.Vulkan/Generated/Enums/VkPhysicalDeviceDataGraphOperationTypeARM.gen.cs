namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDataGraphOperationTypeARM.html">VkPhysicalDeviceDataGraphOperationTypeARM</see> - Enumeration describing data graph operations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPhysicalDeviceDataGraphOperationTypeARM
    ///     </para>
    ///     <para>
    ///         The defined data graph operations are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef enum VkPhysicalDeviceDataGraphOperationTypeARM {
    ///             VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_SPIRV_EXTENDED_INSTRUCTION_SET_ARM = 0,
    ///             // Provided by VK_QCOM_data_graph_model
    ///             VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_NEURAL_MODEL_QCOM = 1000629000,
    ///             // Provided by VK_QCOM_data_graph_model
    ///             VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_BUILTIN_MODEL_QCOM = 1000629001,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_PHYSICAL_DEVICE_DATA_GRAPH_OPERATION_TYPE_OPTICAL_FLOW_ARM = 1000631000,
    ///         } VkPhysicalDeviceDataGraphOperationTypeARM;
    ///     </code>
    /// </remarks>
    public enum VkPhysicalDeviceDataGraphOperationTypeARM : int
    {
        /// <summary>
        ///     <c>SpirvExtendedInstructionSetARM</c>  corresponds to operations provided by a SPIR-V extended instruction set.
        /// </summary>
        SpirvExtendedInstructionSetARM = 0,

        /// <summary>
        ///     <c>NeuralModelQCOM</c>
        /// </summary>
        NeuralModelQCOM = 1000629000,

        /// <summary>
        ///     <c>BuiltinModelQCOM</c>
        /// </summary>
        BuiltinModelQCOM = 1000629001,

        /// <summary>
        ///     <c>OpticalFlowARM</c>
        /// </summary>
        OpticalFlowARM = 1000631000,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
