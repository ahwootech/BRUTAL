namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineIdentifierCreateInfoARM.html">VkDataGraphPipelineIdentifierCreateInfoARM</see> - Structure specifying an identifier for the newly created data graph pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineIdentifierCreateInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkDataGraphPipelineIdentifierCreateInfoARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkDataGraphPipelineIdentifierCreateInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           identifierSize;
    ///             const uint8_t*     pIdentifier;
    ///         } VkDataGraphPipelineIdentifierCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDataGraphPipelineIdentifierCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphPipelineIdentifierCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IdentifierSize</c> is the size in bytes of the identifier data accessible via <c>pIdentifier</c>.
        /// </summary>
        [FieldOffset(16)]
        public int IdentifierSize;

        /// <summary>
        ///     <c>Identifier</c> is a pointer to <c>identifierSize</c> bytes of data that describe the pipeline being created.
        /// </summary>
        [FieldOffset(24)]
        public byte* Identifier;
    }
}
