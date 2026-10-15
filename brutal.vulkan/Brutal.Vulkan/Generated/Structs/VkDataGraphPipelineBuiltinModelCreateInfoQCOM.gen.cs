namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineBuiltinModelCreateInfoQCOM.html">VkDataGraphPipelineBuiltinModelCreateInfoQCOM</see> - Structure specifying a built-in model for the newly created data graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineBuiltinModelCreateInfoQCOM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineBuiltinModelCreateInfoQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_data_graph_model
    ///         typedef struct VkDataGraphPipelineBuiltinModelCreateInfoQCOM {
    ///             VkStructureType                                        sType;
    ///             const void*                                            pNext;
    ///             const VkPhysicalDeviceDataGraphOperationSupportARM*    pOperation;
    ///         } VkDataGraphPipelineBuiltinModelCreateInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphPipelineBuiltinModelCreateInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineBuiltinModelCreateInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Operation</c> is a <c>VkPhysicalDeviceDataGraphOperationSupportARM</c> specifying the built-in operation.
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceDataGraphOperationSupportARM* Operation;
    }
}
