namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineOpticalFlowDispatchInfoARM.html">VkDataGraphPipelineOpticalFlowDispatchInfoARM</see> - Structure specifying parameters of a optical flow vector calculation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDataGraphPipelineOpticalFlowDispatchInfoARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkDataGraphPipelineOpticalFlowDispatchInfoARM {
    ///             VkStructureType                          sType;
    ///             void*                                    pNext;
    ///             VkDataGraphOpticalFlowExecuteFlagsARM    flags;
    ///             uint32_t                                 meanFlowL1NormHint;
    ///         } VkDataGraphPipelineOpticalFlowDispatchInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphPipelineOpticalFlowDispatchInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineOpticalFlowDispatchInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> are the <c>VkDataGraphOpticalFlowExecuteFlagsARM</c> used for this command.
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphOpticalFlowExecuteFlagsARM Flags;

        /// <summary>
        ///     <c>MeanFlowL1NormHint</c> is an integer used to hint to the implementation that the mean L1 norm of flow vectors is expected to be centered around this value (in number of pixels of the input image). The implementation may use this value to influence how flow vectors are computed. Different values may result in different flow vectors and will affect the cost of computing the flow vectors. A value of 0 means that the application does not wish to provide a hint.
        /// </summary>
        [FieldOffset(20)]
        public int MeanFlowL1NormHint;
    }
}
