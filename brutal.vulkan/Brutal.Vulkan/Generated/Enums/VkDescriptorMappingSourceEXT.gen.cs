namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorMappingSourceEXT.html">VkDescriptorMappingSourceEXT</see> - Specifies the mapping source for a shader binding
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The possible mapping sources for a shader binding are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef enum VkDescriptorMappingSourceEXT {
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_CONSTANT_OFFSET_EXT = 0,
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_PUSH_INDEX_EXT = 1,
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_INDIRECT_INDEX_EXT = 2,
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_INDIRECT_INDEX_ARRAY_EXT = 3,
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_RESOURCE_HEAP_DATA_EXT = 4,
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_PUSH_DATA_EXT = 5,
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_PUSH_ADDRESS_EXT = 6,
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_INDIRECT_ADDRESS_EXT = 7,
    ///             // Provided by VK_EXT_descriptor_heap with VK_KHR_ray_tracing_pipeline or VK_NV_ray_tracing
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_HEAP_WITH_SHADER_RECORD_INDEX_EXT = 8,
    ///             // Provided by VK_EXT_descriptor_heap with VK_KHR_ray_tracing_pipeline or VK_NV_ray_tracing
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_SHADER_RECORD_DATA_EXT = 9,
    ///             // Provided by VK_EXT_descriptor_heap with VK_KHR_ray_tracing_pipeline or VK_NV_ray_tracing
    ///             VK_DESCRIPTOR_MAPPING_SOURCE_SHADER_RECORD_ADDRESS_EXT = 10,
    ///         } VkDescriptorMappingSourceEXT;
    ///     </code>
    /// </remarks>
    public enum VkDescriptorMappingSourceEXT : int
    {
        /// <summary>
        ///     <c>HeapWithConstantOffsetEXT</c>  specifies that the resource will be backed by a descriptor from the heap at a constant index.
        /// </summary>
        HeapWithConstantOffsetEXT = 0,

        /// <summary>
        ///     <c>HeapWithPushIndexEXT</c> specifies that the resource will be backed by a descriptor from the heap at an index sourced from push data, added to a constant index.
        /// </summary>
        HeapWithPushIndexEXT = 1,

        /// <summary>
        ///     <c>HeapWithIndirectIndexEXT</c>  specifies that the resource will be backed by a descriptor from the heap at an index sourced from an address in push data, added to a constant index. If the mapping is an array, the array will be mapped to a base offset in indirect memory, and subsequent elements are mapped as offsets to that base.
        /// </summary>
        HeapWithIndirectIndexEXT = 2,

        /// <summary>
        ///     <c>HeapWithIndirectIndexArrayEXT</c>  specifies that the resource will be backed by a descriptor from the heap at an index sourced from an address in push data, added to a constant index. If the mapping is an array, each array element will be mapped to a separate index in indirect memory.
        /// </summary>
        HeapWithIndirectIndexArrayEXT = 3,

        /// <summary>
        ///     <c>ResourceHeapDataEXT</c> specifies that the resource will be backed by heap data directly.
        /// </summary>
        ResourceHeapDataEXT = 4,

        /// <summary>
        ///     <c>PushDataEXT</c> specifies that the resource will be backed by push data directly.
        /// </summary>
        PushDataEXT = 5,

        /// <summary>
        ///     <c>PushAddressEXT</c> specifies that the resource will be backed by an address in push data.
        /// </summary>
        PushAddressEXT = 6,

        /// <summary>
        ///     <c>IndirectAddressEXT</c> specifies that the resource will be backed by an address sourced via another address in push data.
        /// </summary>
        IndirectAddressEXT = 7,

        /// <summary>
        ///     <c>HeapWithShaderRecordIndexEXT</c>
        /// </summary>
        HeapWithShaderRecordIndexEXT = 8,

        /// <summary>
        ///     <c>ShaderRecordDataEXT</c>
        /// </summary>
        ShaderRecordDataEXT = 9,

        /// <summary>
        ///     <c>ShaderRecordAddressEXT</c>
        /// </summary>
        ShaderRecordAddressEXT = 10,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
