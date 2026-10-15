namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorIndexingProperties.html">VkPhysicalDeviceDescriptorIndexingProperties</see> - Structure describing descriptor indexing properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorIndexingProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceDescriptorIndexingProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxUpdateAfterBindDescriptorsInAllPools;
    ///             VkBool32           shaderUniformBufferArrayNonUniformIndexingNative;
    ///             VkBool32           shaderSampledImageArrayNonUniformIndexingNative;
    ///             VkBool32           shaderStorageBufferArrayNonUniformIndexingNative;
    ///             VkBool32           shaderStorageImageArrayNonUniformIndexingNative;
    ///             VkBool32           shaderInputAttachmentArrayNonUniformIndexingNative;
    ///             VkBool32           robustBufferAccessUpdateAfterBind;
    ///             VkBool32           quadDivergentImplicitLod;
    ///             uint32_t           maxPerStageDescriptorUpdateAfterBindSamplers;
    ///             uint32_t           maxPerStageDescriptorUpdateAfterBindUniformBuffers;
    ///             uint32_t           maxPerStageDescriptorUpdateAfterBindStorageBuffers;
    ///             uint32_t           maxPerStageDescriptorUpdateAfterBindSampledImages;
    ///             uint32_t           maxPerStageDescriptorUpdateAfterBindStorageImages;
    ///             uint32_t           maxPerStageDescriptorUpdateAfterBindInputAttachments;
    ///             uint32_t           maxPerStageUpdateAfterBindResources;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindSamplers;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindUniformBuffers;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindStorageBuffers;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindSampledImages;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindStorageImages;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindInputAttachments;
    ///         } VkPhysicalDeviceDescriptorIndexingProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorIndexingProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxUpdateAfterBindDescriptorsInAllPools</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxUpdateAfterBindDescriptorsInAllPools;

        /// <summary>
        ///     <c>ShaderUniformBufferArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderUniformBufferArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderSampledImageArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderSampledImageArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderStorageBufferArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderStorageBufferArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderStorageImageArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ShaderStorageImageArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderInputAttachmentArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 ShaderInputAttachmentArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>RobustBufferAccessUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 RobustBufferAccessUpdateAfterBind;

        /// <summary>
        ///     <c>QuadDivergentImplicitLod</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 QuadDivergentImplicitLod;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindSamplers</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxPerStageDescriptorUpdateAfterBindSamplers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindUniformBuffers</c>
        /// </summary>
        [FieldOffset(52)]
        public int MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindStorageBuffers</c>
        /// </summary>
        [FieldOffset(56)]
        public int MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindSampledImages</c>
        /// </summary>
        [FieldOffset(60)]
        public int MaxPerStageDescriptorUpdateAfterBindSampledImages;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindStorageImages</c>
        /// </summary>
        [FieldOffset(64)]
        public int MaxPerStageDescriptorUpdateAfterBindStorageImages;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindInputAttachments</c>
        /// </summary>
        [FieldOffset(68)]
        public int MaxPerStageDescriptorUpdateAfterBindInputAttachments;

        /// <summary>
        ///     <c>MaxPerStageUpdateAfterBindResources</c>
        /// </summary>
        [FieldOffset(72)]
        public int MaxPerStageUpdateAfterBindResources;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindSamplers</c>
        /// </summary>
        [FieldOffset(76)]
        public int MaxDescriptorSetUpdateAfterBindSamplers;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindUniformBuffers</c>
        /// </summary>
        [FieldOffset(80)]
        public int MaxDescriptorSetUpdateAfterBindUniformBuffers;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic</c>
        /// </summary>
        [FieldOffset(84)]
        public int MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindStorageBuffers</c>
        /// </summary>
        [FieldOffset(88)]
        public int MaxDescriptorSetUpdateAfterBindStorageBuffers;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic</c>
        /// </summary>
        [FieldOffset(92)]
        public int MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindSampledImages</c>
        /// </summary>
        [FieldOffset(96)]
        public int MaxDescriptorSetUpdateAfterBindSampledImages;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindStorageImages</c>
        /// </summary>
        [FieldOffset(100)]
        public int MaxDescriptorSetUpdateAfterBindStorageImages;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindInputAttachments</c>
        /// </summary>
        [FieldOffset(104)]
        public int MaxDescriptorSetUpdateAfterBindInputAttachments;
    }
}
