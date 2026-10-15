namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDataGraphProcessingEngineARM.html">VkPhysicalDeviceDataGraphProcessingEngineARM</see> - Structure describing a data graph processing engine supported by a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDataGraphProcessingEngineARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkPhysicalDeviceDataGraphProcessingEngineARM {
    ///             VkPhysicalDeviceDataGraphProcessingEngineTypeARM    type;
    ///             VkBool32                                            isForeign;
    ///         } VkPhysicalDeviceDataGraphProcessingEngineARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkPhysicalDeviceDataGraphProcessingEngineARM()
    {
        /// <summary>
        ///     <c>Type</c> is a <c>VkPhysicalDeviceDataGraphProcessingEngineTypeARM</c> that specifies the type of the processing engine.
        /// </summary>
        [FieldOffset(0)]
        public VkPhysicalDeviceDataGraphProcessingEngineTypeARM Type;

        /// <summary>
        ///     <c>IsForeign</c> specifies whether the processing engine is foreign.
        /// </summary>
        [FieldOffset(4)]
        public Brutal.Bool32 IsForeign;
    }
}
