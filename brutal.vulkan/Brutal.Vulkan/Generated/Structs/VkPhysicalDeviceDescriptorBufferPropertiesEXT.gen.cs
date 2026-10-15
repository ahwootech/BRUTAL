namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorBufferPropertiesEXT.html">VkPhysicalDeviceDescriptorBufferPropertiesEXT</see> - Structure describing descriptor buffer properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorBufferPropertiesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer
    ///         typedef struct VkPhysicalDeviceDescriptorBufferPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           combinedImageSamplerDescriptorSingleArray;
    ///             VkBool32           bufferlessPushDescriptors;
    ///             VkBool32           allowSamplerImageViewPostSubmitCreation;
    ///             VkDeviceSize       descriptorBufferOffsetAlignment;
    ///             uint32_t           maxDescriptorBufferBindings;
    ///             uint32_t           maxResourceDescriptorBufferBindings;
    ///             uint32_t           maxSamplerDescriptorBufferBindings;
    ///             uint32_t           maxEmbeddedImmutableSamplerBindings;
    ///             uint32_t           maxEmbeddedImmutableSamplers;
    ///             size_t             bufferCaptureReplayDescriptorDataSize;
    ///             size_t             imageCaptureReplayDescriptorDataSize;
    ///             size_t             imageViewCaptureReplayDescriptorDataSize;
    ///             size_t             samplerCaptureReplayDescriptorDataSize;
    ///             size_t             accelerationStructureCaptureReplayDescriptorDataSize;
    ///             size_t             samplerDescriptorSize;
    ///             size_t             combinedImageSamplerDescriptorSize;
    ///             size_t             sampledImageDescriptorSize;
    ///             size_t             storageImageDescriptorSize;
    ///             size_t             uniformTexelBufferDescriptorSize;
    ///             size_t             robustUniformTexelBufferDescriptorSize;
    ///             size_t             storageTexelBufferDescriptorSize;
    ///             size_t             robustStorageTexelBufferDescriptorSize;
    ///             size_t             uniformBufferDescriptorSize;
    ///             size_t             robustUniformBufferDescriptorSize;
    ///             size_t             storageBufferDescriptorSize;
    ///             size_t             robustStorageBufferDescriptorSize;
    ///             size_t             inputAttachmentDescriptorSize;
    ///             size_t             accelerationStructureDescriptorSize;
    ///             VkDeviceSize       maxSamplerDescriptorBufferRange;
    ///             VkDeviceSize       maxResourceDescriptorBufferRange;
    ///             VkDeviceSize       samplerDescriptorBufferAddressSpaceSize;
    ///             VkDeviceSize       resourceDescriptorBufferAddressSpaceSize;
    ///             VkDeviceSize       descriptorBufferAddressSpaceSize;
    ///         } VkPhysicalDeviceDescriptorBufferPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public unsafe partial struct VkPhysicalDeviceDescriptorBufferPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorBufferPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CombinedImageSamplerDescriptorSingleArray</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CombinedImageSamplerDescriptorSingleArray;

        /// <summary>
        ///     <c>BufferlessPushDescriptors</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 BufferlessPushDescriptors;

        /// <summary>
        ///     <c>AllowSamplerImageViewPostSubmitCreation</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 AllowSamplerImageViewPostSubmitCreation;

        /// <summary>
        ///     <c>DescriptorBufferOffsetAlignment</c>
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 DescriptorBufferOffsetAlignment;

        /// <summary>
        ///     <c>MaxDescriptorBufferBindings</c>
        /// </summary>
        [FieldOffset(40)]
        public int MaxDescriptorBufferBindings;

        /// <summary>
        ///     <c>MaxResourceDescriptorBufferBindings</c>
        /// </summary>
        [FieldOffset(44)]
        public int MaxResourceDescriptorBufferBindings;

        /// <summary>
        ///     <c>MaxSamplerDescriptorBufferBindings</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxSamplerDescriptorBufferBindings;

        /// <summary>
        ///     <c>MaxEmbeddedImmutableSamplerBindings</c>
        /// </summary>
        [FieldOffset(52)]
        public int MaxEmbeddedImmutableSamplerBindings;

        /// <summary>
        ///     <c>MaxEmbeddedImmutableSamplers</c>
        /// </summary>
        [FieldOffset(56)]
        public int MaxEmbeddedImmutableSamplers;

        /// <summary>
        ///     <c>BufferCaptureReplayDescriptorDataSize</c>
        /// </summary>
        [FieldOffset(64)]
        public nuint BufferCaptureReplayDescriptorDataSize;

        /// <summary>
        ///     <c>ImageCaptureReplayDescriptorDataSize</c>
        /// </summary>
        [FieldOffset(72)]
        public nuint ImageCaptureReplayDescriptorDataSize;

        /// <summary>
        ///     <c>ImageViewCaptureReplayDescriptorDataSize</c>
        /// </summary>
        [FieldOffset(80)]
        public nuint ImageViewCaptureReplayDescriptorDataSize;

        /// <summary>
        ///     <c>SamplerCaptureReplayDescriptorDataSize</c>
        /// </summary>
        [FieldOffset(88)]
        public nuint SamplerCaptureReplayDescriptorDataSize;

        /// <summary>
        ///     <c>AccelerationStructureCaptureReplayDescriptorDataSize</c>
        /// </summary>
        [FieldOffset(96)]
        public nuint AccelerationStructureCaptureReplayDescriptorDataSize;

        /// <summary>
        ///     <c>SamplerDescriptorSize</c>
        /// </summary>
        [FieldOffset(104)]
        public nuint SamplerDescriptorSize;

        /// <summary>
        ///     <c>CombinedImageSamplerDescriptorSize</c>
        /// </summary>
        [FieldOffset(112)]
        public nuint CombinedImageSamplerDescriptorSize;

        /// <summary>
        ///     <c>SampledImageDescriptorSize</c>
        /// </summary>
        [FieldOffset(120)]
        public nuint SampledImageDescriptorSize;

        /// <summary>
        ///     <c>StorageImageDescriptorSize</c>
        /// </summary>
        [FieldOffset(128)]
        public nuint StorageImageDescriptorSize;

        /// <summary>
        ///     <c>UniformTexelBufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(136)]
        public nuint UniformTexelBufferDescriptorSize;

        /// <summary>
        ///     <c>RobustUniformTexelBufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(144)]
        public nuint RobustUniformTexelBufferDescriptorSize;

        /// <summary>
        ///     <c>StorageTexelBufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(152)]
        public nuint StorageTexelBufferDescriptorSize;

        /// <summary>
        ///     <c>RobustStorageTexelBufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(160)]
        public nuint RobustStorageTexelBufferDescriptorSize;

        /// <summary>
        ///     <c>UniformBufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(168)]
        public nuint UniformBufferDescriptorSize;

        /// <summary>
        ///     <c>RobustUniformBufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(176)]
        public nuint RobustUniformBufferDescriptorSize;

        /// <summary>
        ///     <c>StorageBufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(184)]
        public nuint StorageBufferDescriptorSize;

        /// <summary>
        ///     <c>RobustStorageBufferDescriptorSize</c>
        /// </summary>
        [FieldOffset(192)]
        public nuint RobustStorageBufferDescriptorSize;

        /// <summary>
        ///     <c>InputAttachmentDescriptorSize</c>
        /// </summary>
        [FieldOffset(200)]
        public nuint InputAttachmentDescriptorSize;

        /// <summary>
        ///     <c>AccelerationStructureDescriptorSize</c>
        /// </summary>
        [FieldOffset(208)]
        public nuint AccelerationStructureDescriptorSize;

        /// <summary>
        ///     <c>MaxSamplerDescriptorBufferRange</c>
        /// </summary>
        [FieldOffset(216)]
        public ByteSize64 MaxSamplerDescriptorBufferRange;

        /// <summary>
        ///     <c>MaxResourceDescriptorBufferRange</c>
        /// </summary>
        [FieldOffset(224)]
        public ByteSize64 MaxResourceDescriptorBufferRange;

        /// <summary>
        ///     <c>SamplerDescriptorBufferAddressSpaceSize</c>
        /// </summary>
        [FieldOffset(232)]
        public ByteSize64 SamplerDescriptorBufferAddressSpaceSize;

        /// <summary>
        ///     <c>ResourceDescriptorBufferAddressSpaceSize</c>
        /// </summary>
        [FieldOffset(240)]
        public ByteSize64 ResourceDescriptorBufferAddressSpaceSize;

        /// <summary>
        ///     <c>DescriptorBufferAddressSpaceSize</c>
        /// </summary>
        [FieldOffset(248)]
        public ByteSize64 DescriptorBufferAddressSpaceSize;
    }
}
