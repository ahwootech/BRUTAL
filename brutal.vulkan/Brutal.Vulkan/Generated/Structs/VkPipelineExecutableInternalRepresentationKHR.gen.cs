namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableInternalRepresentationKHR.html">VkPipelineExecutableInternalRepresentationKHR</see> - Structure describing the textual form of a pipeline executable internal representation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineExecutableInternalRepresentationKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_executable_properties
    ///         typedef struct VkPipelineExecutableInternalRepresentationKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             char               name[VK_MAX_DESCRIPTION_SIZE];
    ///             char               description[VK_MAX_DESCRIPTION_SIZE];
    ///             VkBool32           isText;
    ///             size_t             dataSize;
    ///             void*              pData;
    ///         } VkPipelineExecutableInternalRepresentationKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 552)]
    public unsafe partial struct VkPipelineExecutableInternalRepresentationKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineExecutableInternalRepresentationKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte Name[256];

        ///
        [FieldOffset(272)]
        public fixed byte Description[256];

        /// <summary>
        ///     <c>IsText</c> specifies whether the returned data is text or opaque data. If <c>isText</c> is <c>VK_TRUE</c> then the data returned in <c>pData</c> is text and is guaranteed to be a null-terminated UTF-8 string.
        /// </summary>
        [FieldOffset(528)]
        public Brutal.Bool32 IsText;

        /// <summary>
        ///     <c>DataSize</c> is an integer related to the size, in bytes, of the internal representation&apos;s data, as described below.
        /// </summary>
        [FieldOffset(536)]
        public nuint DataSize;

        /// <summary>
        ///     <c>Data</c> is either `NULL` or a pointer to a block of data into which the implementation will write the internal representation.
        /// </summary>
        [FieldOffset(544)]
        public void* Data;
    }
}
