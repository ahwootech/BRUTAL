namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelinePropertiesIdentifierEXT.html">VkPipelinePropertiesIdentifierEXT</see> - Structure used to retrieve pipeline properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelinePropertiesIdentifierEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_pipeline_properties
    ///         typedef struct VkPipelinePropertiesIdentifierEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint8_t            pipelineIdentifier[VK_UUID_SIZE];
    ///         } VkPipelinePropertiesIdentifierEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelinePropertiesIdentifierEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelinePropertiesIdentifierEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte PipelineIdentifier[16];
    }
}
