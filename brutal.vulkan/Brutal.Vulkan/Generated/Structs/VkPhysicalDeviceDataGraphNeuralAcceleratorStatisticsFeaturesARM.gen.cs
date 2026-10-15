namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM.html">VkPhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM</see> - Structure describing features to control data graph neural accelerator statistics
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///         typedef struct VkPhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           dataGraphNeuralAcceleratorStatistics;
    ///         } VkPhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DataGraphNeuralAcceleratorStatistics</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DataGraphNeuralAcceleratorStatistics;
    }
}
