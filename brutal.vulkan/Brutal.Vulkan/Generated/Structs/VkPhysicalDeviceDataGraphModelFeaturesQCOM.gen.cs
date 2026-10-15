namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDataGraphModelFeaturesQCOM.html">VkPhysicalDeviceDataGraphModelFeaturesQCOM</see> - Structure describing features to control data graph model
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDataGraphModelFeaturesQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_data_graph_model
    ///         typedef struct VkPhysicalDeviceDataGraphModelFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           dataGraphModel;
    ///         } VkPhysicalDeviceDataGraphModelFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDataGraphModelFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDataGraphModelFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DataGraphModel</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DataGraphModel;
    }
}
