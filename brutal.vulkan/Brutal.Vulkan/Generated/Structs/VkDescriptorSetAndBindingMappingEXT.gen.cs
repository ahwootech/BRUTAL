namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetAndBindingMappingEXT.html">VkDescriptorSetAndBindingMappingEXT</see> - Structure specifying mappings from a set of shader resources to a descriptor heap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDescriptorSetAndBindingMappingEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorSetAndBindingMappingEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkDescriptorSetAndBindingMappingEXT {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             uint32_t                            descriptorSet;
    ///             uint32_t                            firstBinding;
    ///             uint32_t                            bindingCount;
    ///             VkSpirvResourceTypeFlagsEXT         resourceMask;
    ///             VkDescriptorMappingSourceEXT        source;
    ///             VkDescriptorMappingSourceDataEXT    sourceData;
    ///         } VkDescriptorSetAndBindingMappingEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkDescriptorSetAndBindingMappingEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetAndBindingMappingEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorSet</c> is the value of <c>DescriptorSet</c> for resources that this mapping affects.
        /// </summary>
        [FieldOffset(16)]
        public int DescriptorSet;

        /// <summary>
        ///     <c>FirstBinding</c> is the first value of <c>Binding</c> of resources that this mapping affects.
        /// </summary>
        [FieldOffset(20)]
        public int FirstBinding;

        /// <summary>
        ///     <c>BindingCount</c> is the number of consecutive <c>Binding</c> values of resources that this mapping affects.
        /// </summary>
        [FieldOffset(24)]
        public int BindingCount;

        /// <summary>
        ///     <c>ResourceMask</c> is a mask of <c>VkSpirvResourceTypeFlagsEXT</c> values indicating which resource types are specified by this mapping.
        /// </summary>
        [FieldOffset(28)]
        public VkSpirvResourceTypeFlagsEXT ResourceMask;

        /// <summary>
        ///     <c>Source</c> is a <c>VkDescriptorMappingSourceEXT</c> value specifying the method of mapping specified for the affected resources.
        /// </summary>
        [FieldOffset(32)]
        public VkDescriptorMappingSourceEXT Source;

        /// <summary>
        ///     <c>SourceData</c> is a <c>VkDescriptorMappingSourceDataEXT</c> that provides the details of how each mapping is specified according to <c>source</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkDescriptorMappingSourceDataEXT SourceData;
    }
}
