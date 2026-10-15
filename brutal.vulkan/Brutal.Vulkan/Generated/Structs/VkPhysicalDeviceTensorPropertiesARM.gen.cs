namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTensorPropertiesARM.html">VkPhysicalDeviceTensorPropertiesARM</see> - Structure describing the tensor properties of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTensorPropertiesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkPhysicalDeviceTensorPropertiesARM {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             uint32_t              maxTensorDimensionCount;
    ///             uint64_t              maxTensorElements;
    ///             uint64_t              maxPerDimensionTensorElements;
    ///             int64_t               maxTensorStride;
    ///             uint64_t              maxTensorSize;
    ///             uint32_t              maxTensorShaderAccessArrayLength;
    ///             uint32_t              maxTensorShaderAccessSize;
    ///             uint32_t              maxDescriptorSetStorageTensors;
    ///             uint32_t              maxPerStageDescriptorSetStorageTensors;
    ///             uint32_t              maxDescriptorSetUpdateAfterBindStorageTensors;
    ///             uint32_t              maxPerStageDescriptorUpdateAfterBindStorageTensors;
    ///             VkBool32              shaderStorageTensorArrayNonUniformIndexingNative;
    ///             VkShaderStageFlags    shaderTensorSupportedStages;
    ///         } VkPhysicalDeviceTensorPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkPhysicalDeviceTensorPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTensorPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxTensorDimensionCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxTensorDimensionCount;

        /// <summary>
        ///     <c>MaxTensorElements</c>
        /// </summary>
        [FieldOffset(24)]
        public nint MaxTensorElements;

        /// <summary>
        ///     <c>MaxPerDimensionTensorElements</c>
        /// </summary>
        [FieldOffset(32)]
        public nint MaxPerDimensionTensorElements;

        /// <summary>
        ///     <c>MaxTensorStride</c>
        /// </summary>
        [FieldOffset(40)]
        public long MaxTensorStride;

        /// <summary>
        ///     <c>MaxTensorSize</c>
        /// </summary>
        [FieldOffset(48)]
        public nint MaxTensorSize;

        /// <summary>
        ///     <c>MaxTensorShaderAccessArrayLength</c>
        /// </summary>
        [FieldOffset(56)]
        public int MaxTensorShaderAccessArrayLength;

        /// <summary>
        ///     <c>MaxTensorShaderAccessSize</c>
        /// </summary>
        [FieldOffset(60)]
        public int MaxTensorShaderAccessSize;

        /// <summary>
        ///     <c>MaxDescriptorSetStorageTensors</c>
        /// </summary>
        [FieldOffset(64)]
        public int MaxDescriptorSetStorageTensors;

        /// <summary>
        ///     <c>MaxPerStageDescriptorSetStorageTensors</c>
        /// </summary>
        [FieldOffset(68)]
        public int MaxPerStageDescriptorSetStorageTensors;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindStorageTensors</c>
        /// </summary>
        [FieldOffset(72)]
        public int MaxDescriptorSetUpdateAfterBindStorageTensors;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindStorageTensors</c>
        /// </summary>
        [FieldOffset(76)]
        public int MaxPerStageDescriptorUpdateAfterBindStorageTensors;

        /// <summary>
        ///     <c>ShaderStorageTensorArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 ShaderStorageTensorArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderTensorSupportedStages</c>
        /// </summary>
        [FieldOffset(84)]
        public VkShaderStageFlags ShaderTensorSupportedStages;
    }
}
