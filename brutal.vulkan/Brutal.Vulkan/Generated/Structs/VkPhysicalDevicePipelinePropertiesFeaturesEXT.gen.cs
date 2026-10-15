namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePipelinePropertiesFeaturesEXT.html">VkPhysicalDevicePipelinePropertiesFeaturesEXT</see> - Structure describing what pipeline properties are supported
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePipelinePropertiesFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_pipeline_properties
    ///         typedef struct VkPhysicalDevicePipelinePropertiesFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelinePropertiesIdentifier;
    ///         } VkPhysicalDevicePipelinePropertiesFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePipelinePropertiesFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePipelinePropertiesFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelinePropertiesIdentifier</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelinePropertiesIdentifier;
    }
}
