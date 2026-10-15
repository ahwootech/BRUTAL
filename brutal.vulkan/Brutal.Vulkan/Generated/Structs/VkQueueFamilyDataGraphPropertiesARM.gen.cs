namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyDataGraphPropertiesARM.html">VkQueueFamilyDataGraphPropertiesARM</see> - Structure describing a data graph processing engine and operation it supports
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyDataGraphPropertiesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkQueueFamilyDataGraphPropertiesARM {
    ///             VkStructureType                                 sType;
    ///             void*                                           pNext;
    ///             VkPhysicalDeviceDataGraphProcessingEngineARM    engine;
    ///             VkPhysicalDeviceDataGraphOperationSupportARM    operation;
    ///         } VkQueueFamilyDataGraphPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public unsafe partial struct VkQueueFamilyDataGraphPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyDataGraphPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Engine</c> is a <c>VkPhysicalDeviceDataGraphProcessingEngineARM</c> structure describing a data graph processing engine.
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceDataGraphProcessingEngineARM Engine;

        /// <summary>
        ///     <c>Operation</c> is a <c>VkPhysicalDeviceDataGraphOperationSupportARM</c> structure describing one or more operations supported by a data graph processing engine.
        /// </summary>
        [FieldOffset(24)]
        public VkPhysicalDeviceDataGraphOperationSupportARM Operation;
    }
}
