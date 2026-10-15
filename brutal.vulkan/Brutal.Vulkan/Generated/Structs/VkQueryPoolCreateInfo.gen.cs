namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryPoolCreateInfo.html">VkQueryPoolCreateInfo</see> - Structure specifying parameters of a newly created query pool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueryPoolCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkQueryPoolCreateInfo {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkQueryPoolCreateFlags           flags;
    ///             VkQueryType                      queryType;
    ///             uint32_t                         queryCount;
    ///             VkQueryPipelineStatisticFlags    pipelineStatistics;
    ///         } VkQueryPoolCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkQueryPoolCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueryPoolCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkQueryPoolCreateFlags</c>
        /// </summary>
        [FieldOffset(16)]
        public VkQueryPoolCreateFlags Flags;

        /// <summary>
        ///     <c>QueryType</c> is a <c>VkQueryType</c> value specifying the type of queries managed by the pool.
        /// </summary>
        [FieldOffset(20)]
        public VkQueryType QueryType;

        /// <summary>
        ///     <c>QueryCount</c> is the number of queries managed by the pool.
        /// </summary>
        [FieldOffset(24)]
        public int QueryCount;

        /// <summary>
        ///     <c>PipelineStatistics</c>  is unused and ignored.
        /// </summary>
        [FieldOffset(28)]
        public VkQueryPipelineStatisticFlags PipelineStatistics;
    }
}
