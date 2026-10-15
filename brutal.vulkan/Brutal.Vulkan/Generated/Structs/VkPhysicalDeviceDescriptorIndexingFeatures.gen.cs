namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorIndexingFeatures.html">VkPhysicalDeviceDescriptorIndexingFeatures</see> - Structure describing descriptor indexing features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorIndexingFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceDescriptorIndexingFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderInputAttachmentArrayDynamicIndexing;
    ///             VkBool32           shaderUniformTexelBufferArrayDynamicIndexing;
    ///             VkBool32           shaderStorageTexelBufferArrayDynamicIndexing;
    ///             VkBool32           shaderUniformBufferArrayNonUniformIndexing;
    ///             VkBool32           shaderSampledImageArrayNonUniformIndexing;
    ///             VkBool32           shaderStorageBufferArrayNonUniformIndexing;
    ///             VkBool32           shaderStorageImageArrayNonUniformIndexing;
    ///             VkBool32           shaderInputAttachmentArrayNonUniformIndexing;
    ///             VkBool32           shaderUniformTexelBufferArrayNonUniformIndexing;
    ///             VkBool32           shaderStorageTexelBufferArrayNonUniformIndexing;
    ///             VkBool32           descriptorBindingUniformBufferUpdateAfterBind;
    ///             VkBool32           descriptorBindingSampledImageUpdateAfterBind;
    ///             VkBool32           descriptorBindingStorageImageUpdateAfterBind;
    ///             VkBool32           descriptorBindingStorageBufferUpdateAfterBind;
    ///             VkBool32           descriptorBindingUniformTexelBufferUpdateAfterBind;
    ///             VkBool32           descriptorBindingStorageTexelBufferUpdateAfterBind;
    ///             VkBool32           descriptorBindingUpdateUnusedWhilePending;
    ///             VkBool32           descriptorBindingPartiallyBound;
    ///             VkBool32           descriptorBindingVariableDescriptorCount;
    ///             VkBool32           runtimeDescriptorArray;
    ///         } VkPhysicalDeviceDescriptorIndexingFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorIndexingFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderInputAttachmentArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderInputAttachmentArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderUniformTexelBufferArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderUniformTexelBufferArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderStorageTexelBufferArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderStorageTexelBufferArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderUniformBufferArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderUniformBufferArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderSampledImageArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ShaderSampledImageArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderStorageBufferArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 ShaderStorageBufferArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderStorageImageArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 ShaderStorageImageArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderInputAttachmentArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 ShaderInputAttachmentArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderUniformTexelBufferArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 ShaderUniformTexelBufferArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderStorageTexelBufferArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 ShaderStorageTexelBufferArrayNonUniformIndexing;

        /// <summary>
        ///     <c>DescriptorBindingUniformBufferUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 DescriptorBindingUniformBufferUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingSampledImageUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 DescriptorBindingSampledImageUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingStorageImageUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 DescriptorBindingStorageImageUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingStorageBufferUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 DescriptorBindingStorageBufferUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingUniformTexelBufferUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingStorageTexelBufferUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingUpdateUnusedWhilePending</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 DescriptorBindingUpdateUnusedWhilePending;

        /// <summary>
        ///     <c>DescriptorBindingPartiallyBound</c>
        /// </summary>
        [FieldOffset(84)]
        public Brutal.Bool32 DescriptorBindingPartiallyBound;

        /// <summary>
        ///     <c>DescriptorBindingVariableDescriptorCount</c>
        /// </summary>
        [FieldOffset(88)]
        public Brutal.Bool32 DescriptorBindingVariableDescriptorCount;

        /// <summary>
        ///     <c>RuntimeDescriptorArray</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 RuntimeDescriptorArray;
    }
}
