namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorMappingSourceConstantOffsetEXT.html">VkDescriptorMappingSourceConstantOffsetEXT</see> - Structure specifying mapping resources to a constant heap index
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDescriptorMappingSourceConstantOffsetEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorMappingSourceConstantOffsetEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkDescriptorMappingSourceConstantOffsetEXT {
    ///             uint32_t                      heapOffset;
    ///             uint32_t                      heapArrayStride;
    ///             const VkSamplerCreateInfo*    pEmbeddedSampler;
    ///             uint32_t                      samplerHeapOffset;
    ///             uint32_t                      samplerHeapArrayStride;
    ///         } VkDescriptorMappingSourceConstantOffsetEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDescriptorMappingSourceConstantOffsetEXT()
    {
        /// <summary>
        ///     <c>HeapOffset</c> is a constant byte offset added to the heap address for the mapped resource or sampler.
        /// </summary>
        [FieldOffset(0)]
        public int HeapOffset;

        /// <summary>
        ///     <c>HeapArrayStride</c> is a constant byte stride that multiplies the shader binding and array index.
        /// </summary>
        [FieldOffset(4)]
        public int HeapArrayStride;

        /// <summary>
        ///     <c>EmbeddedSampler</c> is an optional <c>VkSamplerCreateInfo</c> structure specifying a sampler to embed into the shader, in place of looking the sampler up in a heap.
        /// </summary>
        [FieldOffset(8)]
        public VkSamplerCreateInfo* EmbeddedSampler;

        /// <summary>
        ///     <c>SamplerHeapOffset</c> is used only when mapping a combined image sampler, used in place of `heapOffset` to retrieve the sampler.
        /// </summary>
        [FieldOffset(16)]
        public int SamplerHeapOffset;

        /// <summary>
        ///     <c>SamplerHeapArrayStride</c> is used only when mapping a combined image sampler, used in place of `heapArrayStride` to retrieve the sampler.
        /// </summary>
        [FieldOffset(20)]
        public int SamplerHeapArrayStride;
    }
}
