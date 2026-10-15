namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphProcessingEngineCreateInfoARM.html">VkDataGraphProcessingEngineCreateInfoARM</see> - Structure describing a collection of data graph processing engines for which the object being created is specialized
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDataGraphProcessingEngineCreateInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphProcessingEngineCreateInfoARM {
    ///             VkStructureType                                  sType;
    ///             const void*                                      pNext;
    ///             uint32_t                                         processingEngineCount;
    ///             VkPhysicalDeviceDataGraphProcessingEngineARM*    pProcessingEngines;
    ///         } VkDataGraphProcessingEngineCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphProcessingEngineCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphProcessingEngineCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ProcessingEngineCount</c> is the number of elements in <c>pProcessingEngines</c>.
        /// </summary>
        [FieldOffset(16)]
        public int ProcessingEngineCount;

        /// <summary>
        ///     <c>ProcessingEngines</c> is a pointer to an array of <c>processingEngineCount</c> <c>VkPhysicalDeviceDataGraphProcessingEngineARM</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkPhysicalDeviceDataGraphProcessingEngineARM* ProcessingEngines;
    }
}
