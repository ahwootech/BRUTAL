namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkNeuralAcceleratorStatisticsModeARM.html">VkNeuralAcceleratorStatisticsModeARM</see> - Enum specifying the mode of operation for neural accelerator statistics
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The available values for <c>VkNeuralAcceleratorStatisticsModeARM</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///         typedef enum VkNeuralAcceleratorStatisticsModeARM {
    ///             VK_NEURAL_ACCELERATOR_STATISTICS_MODE_DISABLED_ARM = 0,
    ///             VK_NEURAL_ACCELERATOR_STATISTICS_MODE_STATISTICS0_ARM = 1,
    ///             VK_NEURAL_ACCELERATOR_STATISTICS_MODE_STATISTICS1_ARM = 2,
    ///         } VkNeuralAcceleratorStatisticsModeARM;
    ///     </code>
    /// </remarks>
    public enum VkNeuralAcceleratorStatisticsModeARM : int
    {
        /// <summary>
        ///     <c>DisabledARM</c> specifies that neural accelerator statistics are disabled.
        /// </summary>
        DisabledARM = 0,

        /// <summary>
        ///     <c>Statistics0ARM</c> specifies the `statistics0` mode of operation.
        /// </summary>
        Statistics0ARM = 1,

        /// <summary>
        ///     <c>Statistics1ARM</c> specifies the `statistics1` mode of operation.
        /// </summary>
        Statistics1ARM = 2,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
