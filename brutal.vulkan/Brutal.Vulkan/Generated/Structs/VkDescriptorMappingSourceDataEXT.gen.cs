namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorMappingSourceDataEXT.html">VkDescriptorMappingSourceDataEXT</see> - Union descriptor mapping source information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDescriptorMappingSourceDataEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorMappingSourceDataEXT</c> union is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef union VkDescriptorMappingSourceDataEXT {
    ///             VkDescriptorMappingSourceConstantOffsetEXT        constantOffset;
    ///             VkDescriptorMappingSourcePushIndexEXT             pushIndex;
    ///             VkDescriptorMappingSourceIndirectIndexEXT         indirectIndex;
    ///             VkDescriptorMappingSourceIndirectIndexArrayEXT    indirectIndexArray;
    ///             VkDescriptorMappingSourceHeapDataEXT              heapData;
    ///             uint32_t                                          pushDataOffset;
    ///             uint32_t                                          pushAddressOffset;
    ///             VkDescriptorMappingSourceIndirectAddressEXT       indirectAddress;
    ///             VkDescriptorMappingSourceShaderRecordIndexEXT     shaderRecordIndex;
    ///             uint32_t                                          shaderRecordDataOffset;
    ///             uint32_t                                          shaderRecordAddressOffset;
    ///         } VkDescriptorMappingSourceDataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct VkDescriptorMappingSourceDataEXT()
    {
        /// <summary>
        ///     <c>ConstantOffset</c> is a <c>VkDescriptorMappingSourceConstantOffsetEXT</c> structure specifying the mapping for resources at a constant byte offset into a heap.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorMappingSourceConstantOffsetEXT ConstantOffset;

        /// <summary>
        ///     <c>PushIndex</c> is a <c>VkDescriptorMappingSourcePushIndexEXT</c> structure specifying the mapping for resources at an index into a heap source from push data.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorMappingSourcePushIndexEXT PushIndex;

        /// <summary>
        ///     <c>IndirectIndex</c> is a <c>VkDescriptorMappingSourceIndirectIndexEXT</c> structure specifying the mapping for resources at an index into a heap source from an address in push data.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorMappingSourceIndirectIndexEXT IndirectIndex;

        /// <summary>
        ///     <c>IndirectIndexArray</c> is a <c>VkDescriptorMappingSourceIndirectIndexArrayEXT</c> structure specifying the mapping for resources to an array of indices into a heap source from an address in push data.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorMappingSourceIndirectIndexArrayEXT IndirectIndexArray;

        /// <summary>
        ///     <c>HeapData</c> is a <c>VkDescriptorMappingSourceHeapDataEXT</c> structure specifying an offset into heap data for a uniform buffer to map to.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorMappingSourceHeapDataEXT HeapData;

        /// <summary>
        ///     <c>PushDataOffset</c> an offset into push data for a uniform buffer to map to.
        /// </summary>
        [FieldOffset(0)]
        public int PushDataOffset;

        /// <summary>
        ///     <c>PushAddressOffset</c> an offset into push data storing an address for a resource to map to.
        /// </summary>
        [FieldOffset(0)]
        public int PushAddressOffset;

        /// <summary>
        ///     <c>IndirectAddress</c> is a <c>VkDescriptorMappingSourceIndirectAddressEXT</c> structure specifying an address in push data containing another address for a resource to map to.
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorMappingSourceIndirectAddressEXT IndirectAddress;

        /// <summary>
        ///     <c>ShaderRecordIndex</c>
        /// </summary>
        [FieldOffset(0)]
        public VkDescriptorMappingSourceShaderRecordIndexEXT ShaderRecordIndex;

        /// <summary>
        ///     <c>ShaderRecordDataOffset</c>
        /// </summary>
        [FieldOffset(0)]
        public int ShaderRecordDataOffset;

        /// <summary>
        ///     <c>ShaderRecordAddressOffset</c>
        /// </summary>
        [FieldOffset(0)]
        public int ShaderRecordAddressOffset;
    }
}
