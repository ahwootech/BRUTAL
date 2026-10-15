namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelinePropertyQueryResultARM.html">VkDataGraphPipelinePropertyQueryResultARM</see> - Structure describing a data graph pipeline property query or result
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelinePropertyQueryResultARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelinePropertyQueryResultARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelinePropertyQueryResultARM {
    ///             VkStructureType                   sType;
    ///             void*                             pNext;
    ///             VkDataGraphPipelinePropertyARM    property;
    ///             VkBool32                          isText;
    ///             size_t                            dataSize;
    ///             void*                             pData;
    ///         } VkDataGraphPipelinePropertyQueryResultARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDataGraphPipelinePropertyQueryResultARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelinePropertyQueryResultARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Property</c> is a <c>VkDataGraphPipelinePropertyARM</c> specifying the property of the data graph pipeline being queried.
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphPipelinePropertyARM Property;

        /// <summary>
        ///     <c>IsText</c> specifies whether the returned data is text or opaque data. If <c>isText</c> is <c>VK_TRUE</c> then the data returned in <c>pData</c> is text and guaranteed to be a null-terminated UTF-8 string.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 IsText;

        /// <summary>
        ///     <c>DataSize</c> is an integer related to the size, in bytes, of the data, as described below.
        /// </summary>
        [FieldOffset(24)]
        public nuint DataSize;

        /// <summary>
        ///     <c>Data</c> is either `NULL` or a pointer to a block of memory into which the implementation will return the property data.
        /// </summary>
        [FieldOffset(32)]
        public void* Data;
    }
}
