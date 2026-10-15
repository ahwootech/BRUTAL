namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineResourceInfoImageLayoutARM.html">VkDataGraphPipelineResourceInfoImageLayoutARM</see> - Structure specifying parameters of a graph pipeline image resource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineResourceInfoImageLayoutARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineResourceInfoImageLayoutARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkDataGraphPipelineResourceInfoImageLayoutARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImageLayout      layout;
    ///         } VkDataGraphPipelineResourceInfoImageLayoutARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphPipelineResourceInfoImageLayoutARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineResourceInfoImageLayoutARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Layout</c> specifies the layout that the image subresource accessible from the view provided as a graph pipeline resource <i>must</i> be in at the time where the graph pipeline being created is dispatched.
        /// </summary>
        [FieldOffset(16)]
        public VkImageLayout Layout;
    }
}
