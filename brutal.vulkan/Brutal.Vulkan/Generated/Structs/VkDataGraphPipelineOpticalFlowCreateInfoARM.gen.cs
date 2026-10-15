namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineOpticalFlowCreateInfoARM.html">VkDataGraphPipelineOpticalFlowCreateInfoARM</see> - Structure specifying the parameters of a newly-created optical flow graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDataGraphPipelineOpticalFlowCreateInfoARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkDataGraphPipelineOpticalFlowCreateInfoARM {
    ///             VkStructureType                              sType;
    ///             void*                                        pNext;
    ///             uint32_t                                     width;
    ///             uint32_t                                     height;
    ///             VkFormat                                     imageFormat;
    ///             VkFormat                                     flowVectorFormat;
    ///             VkFormat                                     costFormat;
    ///             VkDataGraphOpticalFlowGridSizeFlagsARM       outputGridSize;
    ///             VkDataGraphOpticalFlowGridSizeFlagsARM       hintGridSize;
    ///             VkDataGraphOpticalFlowPerformanceLevelARM    performanceLevel;
    ///             VkDataGraphOpticalFlowCreateFlagsARM         flags;
    ///         } VkDataGraphPipelineOpticalFlowCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkDataGraphPipelineOpticalFlowCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineOpticalFlowCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Width</c> is the width in pixels of the input or reference image to be bound to this optical flow pipeline.
        /// </summary>
        [FieldOffset(16)]
        public int Width;

        /// <summary>
        ///     <c>Height</c> is the height in pixels of the input or reference image to be bound to this optical flow pipeline.
        /// </summary>
        [FieldOffset(20)]
        public int Height;

        /// <summary>
        ///     <c>ImageFormat</c> is the <c>VkFormat</c> of the input and reference image to be bound to this optical flow pipeline.
        /// </summary>
        [FieldOffset(24)]
        public VkFormat ImageFormat;

        /// <summary>
        ///     <c>FlowVectorFormat</c> is the <c>VkFormat</c> of the flow vector maps (output or hint) to be bound to this optical flow pipeline.
        /// </summary>
        [FieldOffset(28)]
        public VkFormat FlowVectorFormat;

        /// <summary>
        ///     <c>CostFormat</c> is the <c>VkFormat</c> of the cost maps to be bound to this optical flow pipeline.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat CostFormat;

        /// <summary>
        ///     <c>OutputGridSize</c> is exactly one bit of <c>VkDataGraphOpticalFlowGridSizeFlagsARM</c> specifying the grid size of the output flow and cost maps to be bound to this optical flow pipeline. The size of the output flow and cost maps is a function of the input image dimensions and <c>outputGridSize</c> and is calculated as follows: + <c>OutputWidth = {lceil} <c>width</c> / OutputGridWidth {rceil}</c> + <c>OutputHeight = {lceil} <c>height</c> / OutputGridHeight {rceil}</c> + where OutputGridWidth and OutputGridHeight are determined by <c>outputGridSize</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkDataGraphOpticalFlowGridSizeFlagsARM OutputGridSize;

        /// <summary>
        ///     <c>HintGridSize</c> is one exactly bit of <c>VkDataGraphOpticalFlowGridSizeFlagsARM</c> specifying the grid size of the hint flow vector map to be bound to this optical flow pipeline. The size of the hint maps is a function of the input image dimensions and <c>hintGridSize</c> and is calculated as follows: + <c>HintWidth = {lceil} <c>width</c> / HintGridWidth {rceil}</c> + <c>HintHeight = {lceil} <c>height</c> / HintGridHeight {rceil}</c> + where HintGridWidth and HintGridHeight are determined by <c>hintGridSize</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkDataGraphOpticalFlowGridSizeFlagsARM HintGridSize;

        /// <summary>
        ///     <c>PerformanceLevel</c> is the <c>VkDataGraphOpticalFlowPerformanceLevelARM</c> used for this optical flow pipeline.
        /// </summary>
        [FieldOffset(44)]
        public VkDataGraphOpticalFlowPerformanceLevelARM PerformanceLevel;

        /// <summary>
        ///     <c>Flags</c> are the <c>VkDataGraphOpticalFlowCreateFlagsARM</c> used for this optical flow pipeline.
        /// </summary>
        [FieldOffset(48)]
        public VkDataGraphOpticalFlowCreateFlagsARM Flags;
    }
}
