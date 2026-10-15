namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorMappingSourceIndirectIndexArrayEXT.html">VkDescriptorMappingSourceIndirectIndexArrayEXT</see> - Structure specifying mapping resources to a heap index array in indirect data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDescriptorMappingSourceIndirectIndexArrayEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorMappingSourceIndirectIndexArrayEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkDescriptorMappingSourceIndirectIndexArrayEXT {
    ///             uint32_t                      heapOffset;
    ///             uint32_t                      pushOffset;
    ///             uint32_t                      addressOffset;
    ///             uint32_t                      heapIndexStride;
    ///             const VkSamplerCreateInfo*    pEmbeddedSampler;
    ///             VkBool32                      useCombinedImageSamplerIndex;
    ///             uint32_t                      samplerHeapOffset;
    ///             uint32_t                      samplerPushOffset;
    ///             uint32_t                      samplerAddressOffset;
    ///             uint32_t                      samplerHeapIndexStride;
    ///         } VkDescriptorMappingSourceIndirectIndexArrayEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkDescriptorMappingSourceIndirectIndexArrayEXT()
    {
        /// <summary>
        ///     <c>HeapOffset</c> is a constant byte offset added to the heap address for the mapped resource or sampler.
        /// </summary>
        [FieldOffset(0)]
        public int HeapOffset;

        /// <summary>
        ///     <c>PushOffset</c> is an offset into push data where an the indirect address will be.
        /// </summary>
        [FieldOffset(4)]
        public int PushOffset;

        /// <summary>
        ///     <c>AddressOffset</c> is an index into the address in push data where an index into the heap for the mapped resource will be retrieved.
        /// </summary>
        [FieldOffset(8)]
        public int AddressOffset;

        /// <summary>
        ///     <c>HeapIndexStride</c> is a constant byte stride that multiplies the index in indirect data.
        /// </summary>
        [FieldOffset(12)]
        public int HeapIndexStride;

        /// <summary>
        ///     <c>EmbeddedSampler</c> is an optional <c>VkSamplerCreateInfo</c> structure specifying a sampler to embed into the shader, in place of looking the sampler up in a heap.
        /// </summary>
        [FieldOffset(16)]
        public VkSamplerCreateInfo* EmbeddedSampler;

        /// <summary>
        ///     <c>UseCombinedImageSamplerIndex</c> specifies whether the generated index value will be decoded as two packed indices if the mapped resource is an <c>OpTypeSampledImage</c>.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 UseCombinedImageSamplerIndex;

        /// <summary>
        ///     <c>SamplerHeapOffset</c> is used only when mapping a combined image sampler, used in place of `heapOffset` to retrieve the sampler.
        /// </summary>
        [FieldOffset(28)]
        public int SamplerHeapOffset;

        /// <summary>
        ///     <c>SamplerPushOffset</c> is used only when mapping a combined image sampler, used in place of `pushOffset` to retrieve the sampler.
        /// </summary>
        [FieldOffset(32)]
        public int SamplerPushOffset;

        /// <summary>
        ///     <c>SamplerAddressOffset</c> is used only when mapping a combined image sampler, used in place of `addressOffset` to retrieve the sampler.
        /// </summary>
        [FieldOffset(36)]
        public int SamplerAddressOffset;

        /// <summary>
        ///     <c>SamplerHeapIndexStride</c> is used only when mapping a combined image sampler, used in place of `heapIndexStride` to retrieve the sampler.
        /// </summary>
        [FieldOffset(40)]
        public int SamplerHeapIndexStride;
    }
}
