namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderDescriptorSetAndBindingMappingInfoEXT.html">VkShaderDescriptorSetAndBindingMappingInfoEXT</see> - Structure specifying mappings from shader resources to descriptor heaps
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkShaderDescriptorSetAndBindingMappingInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkShaderDescriptorSetAndBindingMappingInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkShaderDescriptorSetAndBindingMappingInfoEXT {
    ///             VkStructureType                               sType;
    ///             const void*                                   pNext;
    ///             uint32_t                                      mappingCount;
    ///             const VkDescriptorSetAndBindingMappingEXT*    pMappings;
    ///         } VkShaderDescriptorSetAndBindingMappingInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkShaderDescriptorSetAndBindingMappingInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ShaderDescriptorSetAndBindingMappingInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MappingCount</c> is the number of elements in <c>pMappings</c>.
        /// </summary>
        [FieldOffset(16)]
        public int MappingCount;

        /// <summary>
        ///     <c>Mappings</c> is a pointer to an array of <c>VkDescriptorSetAndBindingMappingEXT</c> structures specifying mappings for a set of descriptors
        /// </summary>
        [FieldOffset(24)]
        public VkDescriptorSetAndBindingMappingEXT* Mappings;
    }
}
