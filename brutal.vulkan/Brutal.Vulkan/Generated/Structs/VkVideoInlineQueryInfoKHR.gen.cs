namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoInlineQueryInfoKHR.html">VkVideoInlineQueryInfoKHR</see> - Structure specifying inline query information for video coding commands
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoInlineQueryInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_maintenance1
    ///         typedef struct VkVideoInlineQueryInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkQueryPool        queryPool;
    ///             uint32_t           firstQuery;
    ///             uint32_t           queryCount;
    ///         } VkVideoInlineQueryInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoInlineQueryInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoInlineQueryInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueryPool</c> is <c>VK_NULL_HANDLE</c> or a valid handle to a <c>VkQueryPool</c> object that will manage the results of the queries.
        /// </summary>
        [FieldOffset(16)]
        public VkQueryPool QueryPool;

        /// <summary>
        ///     <c>FirstQuery</c> is the query index within the query pool that will contain the query results for the first video coding operation. The query results of subsequent video coding operations will be contained by subsequent query indices.
        /// </summary>
        [FieldOffset(24)]
        public int FirstQuery;

        /// <summary>
        ///     <c>QueryCount</c> is the number of queries to execute. + [NOTE]
        /// </summary>
        [FieldOffset(28)]
        public int QueryCount;
    }
}
