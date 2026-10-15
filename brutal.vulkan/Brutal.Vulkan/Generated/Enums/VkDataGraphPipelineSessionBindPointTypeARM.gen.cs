namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionBindPointTypeARM.html">VkDataGraphPipelineSessionBindPointTypeARM</see> - Enumeration describing the type of bind points of a data graph pipeline session
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSessionBindPointTypeARM
    ///     </para>
    ///     <para>
    ///         Possible values of <c>VkDataGraphPipelineSessionBindPointTypeARM</c>,
    ///         specifying the type of a bind point of a data graph pipeline session, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef enum VkDataGraphPipelineSessionBindPointTypeARM {
    ///             VK_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_TYPE_MEMORY_ARM = 0,
    ///         } VkDataGraphPipelineSessionBindPointTypeARM;
    ///     </code>
    /// </remarks>
    public enum VkDataGraphPipelineSessionBindPointTypeARM : int
    {
        /// <summary>
        ///     <c>MemoryARM</c>  corresponds to a memory allocation.
        /// </summary>
        MemoryARM = 0,

        /// <summary>
        ///     <c>MaxEnumARM</c>
        /// </summary>
        MaxEnumARM = 0x7FFFFFFF,
    }
}
