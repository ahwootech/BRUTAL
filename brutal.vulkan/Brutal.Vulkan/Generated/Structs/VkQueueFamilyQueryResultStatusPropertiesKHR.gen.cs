namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyQueryResultStatusPropertiesKHR.html">VkQueueFamilyQueryResultStatusPropertiesKHR</see> - Structure specifying support for result status query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyQueryResultStatusPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkQueueFamilyQueryResultStatusPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           queryResultStatusSupport;
    ///         } VkQueueFamilyQueryResultStatusPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueueFamilyQueryResultStatusPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyQueryResultStatusPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueryResultStatusSupport</c> reports <c>VK_TRUE</c> if query type <c>VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR</c> and use of <c>VK_QUERY_RESULT_WITH_STATUS_BIT_KHR</c> are supported.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 QueryResultStatusSupport;
    }
}
