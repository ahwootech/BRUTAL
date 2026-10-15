namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorMappingSourceShaderRecordIndexEXT.html">VkDescriptorMappingSourceShaderRecordIndexEXT</see> - Structure specifying mapping resources to a heap index in shader record data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDescriptorMappingSourceShaderRecordIndexEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkDescriptorMappingSourceShaderRecordIndexEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkDescriptorMappingSourceShaderRecordIndexEXT {
    ///             uint32_t                      heapOffset;
    ///             uint32_t                      shaderRecordOffset;
    ///             uint32_t                      heapIndexStride;
    ///             uint32_t                      heapArrayStride;
    ///             const VkSamplerCreateInfo*    pEmbeddedSampler;
    ///             VkBool32                      useCombinedImageSamplerIndex;
    ///             uint32_t                      samplerHeapOffset;
    ///             uint32_t                      samplerShaderRecordOffset;
    ///             uint32_t                      samplerHeapIndexStride;
    ///             uint32_t                      samplerHeapArrayStride;
    ///         } VkDescriptorMappingSourceShaderRecordIndexEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkDescriptorMappingSourceShaderRecordIndexEXT()
    {
        /// <summary>
        ///     <c>HeapOffset</c> is a constant byte offset added to the heap address for the mapped resource or sampler.
        /// </summary>
        [FieldOffset(0)]
        public int HeapOffset;

        /// <summary>
        ///     <c>ShaderRecordOffset</c> is an index into shader record data where an index into the heap for the mapped resource will be retrieved.
        /// </summary>
        [FieldOffset(4)]
        public int ShaderRecordOffset;

        /// <summary>
        ///     <c>HeapIndexStride</c> is a constant byte stride that multiplies the index in shader record data.
        /// </summary>
        [FieldOffset(8)]
        public int HeapIndexStride;

        /// <summary>
        ///     <c>HeapArrayStride</c> is a constant byte stride that multiplies the shader binding and array index.
        /// </summary>
        [FieldOffset(12)]
        public int HeapArrayStride;

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
        ///     <c>SamplerShaderRecordOffset</c> is used only when mapping a combined image sampler, used in place of `shaderRecordOffset` to retrieve the sampler.
        /// </summary>
        [FieldOffset(32)]
        public int SamplerShaderRecordOffset;

        /// <summary>
        ///     <c>SamplerHeapIndexStride</c> is used only when mapping a combined image sampler, used in place of `heapIndexStride` to retrieve the sampler.
        /// </summary>
        [FieldOffset(36)]
        public int SamplerHeapIndexStride;

        /// <summary>
        ///     <c>SamplerHeapArrayStride</c> is used only when mapping a combined image sampler, used in place of `heapArrayStride` to retrieve the sampler.
        /// </summary>
        [FieldOffset(40)]
        public int SamplerHeapArrayStride;
    }
}
