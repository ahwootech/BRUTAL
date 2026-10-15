namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM.html">VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM</see> - Structure specifying a data graph processing engine type and queue family to query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM {
    ///             VkStructureType                                     sType;
    ///             const void*                                         pNext;
    ///             uint32_t                                            queueFamilyIndex;
    ///             VkPhysicalDeviceDataGraphProcessingEngineTypeARM    engineType;
    ///         } VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueueFamilyIndex</c> specifies the queue family being queried.
        /// </summary>
        [FieldOffset(16)]
        public int QueueFamilyIndex;

        /// <summary>
        ///     <c>EngineType</c> is a <c>VkPhysicalDeviceDataGraphProcessingEngineTypeARM</c> specifying the engine type whose properties are being queried.
        /// </summary>
        [FieldOffset(20)]
        public VkPhysicalDeviceDataGraphProcessingEngineTypeARM EngineType;
    }
}
