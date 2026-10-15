namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan12Features.html">VkPhysicalDeviceVulkan12Features</see> - Structure describing the Vulkan 1.2 features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkan12Features</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceVulkan12Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           samplerMirrorClampToEdge;
    ///             VkBool32           drawIndirectCount;
    ///             VkBool32           storageBuffer8BitAccess;
    ///             VkBool32           uniformAndStorageBuffer8BitAccess;
    ///             VkBool32           storagePushConstant8;
    ///             VkBool32           shaderBufferInt64Atomics;
    ///             VkBool32           shaderSharedInt64Atomics;
    ///             VkBool32           shaderFloat16;
    ///             VkBool32           shaderInt8;
    ///             VkBool32           descriptorIndexing;
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
    ///             VkBool32           samplerFilterMinmax;
    ///             VkBool32           scalarBlockLayout;
    ///             VkBool32           imagelessFramebuffer;
    ///             VkBool32           uniformBufferStandardLayout;
    ///             VkBool32           shaderSubgroupExtendedTypes;
    ///             VkBool32           separateDepthStencilLayouts;
    ///             VkBool32           hostQueryReset;
    ///             VkBool32           timelineSemaphore;
    ///             VkBool32           bufferDeviceAddress;
    ///             VkBool32           bufferDeviceAddressCaptureReplay;
    ///             VkBool32           bufferDeviceAddressMultiDevice;
    ///             VkBool32           vulkanMemoryModel;
    ///             VkBool32           vulkanMemoryModelDeviceScope;
    ///             VkBool32           vulkanMemoryModelAvailabilityVisibilityChains;
    ///             VkBool32           shaderOutputViewportIndex;
    ///             VkBool32           shaderOutputLayer;
    ///             VkBool32           subgroupBroadcastDynamicId;
    ///         } VkPhysicalDeviceVulkan12Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public unsafe partial struct VkPhysicalDeviceVulkan12Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkan12Features;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SamplerMirrorClampToEdge</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SamplerMirrorClampToEdge;

        /// <summary>
        ///     <c>DrawIndirectCount</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DrawIndirectCount;

        /// <summary>
        ///     <c>StorageBuffer8BitAccess</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 StorageBuffer8BitAccess;

        /// <summary>
        ///     <c>UniformAndStorageBuffer8BitAccess</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 UniformAndStorageBuffer8BitAccess;

        /// <summary>
        ///     <c>StoragePushConstant8</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 StoragePushConstant8;

        /// <summary>
        ///     <c>ShaderBufferInt64Atomics</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 ShaderBufferInt64Atomics;

        /// <summary>
        ///     <c>ShaderSharedInt64Atomics</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 ShaderSharedInt64Atomics;

        /// <summary>
        ///     <c>ShaderFloat16</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 ShaderFloat16;

        /// <summary>
        ///     <c>ShaderInt8</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 ShaderInt8;

        /// <summary>
        ///     <c>DescriptorIndexing</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 DescriptorIndexing;

        /// <summary>
        ///     <c>ShaderInputAttachmentArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 ShaderInputAttachmentArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderUniformTexelBufferArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 ShaderUniformTexelBufferArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderStorageTexelBufferArrayDynamicIndexing</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 ShaderStorageTexelBufferArrayDynamicIndexing;

        /// <summary>
        ///     <c>ShaderUniformBufferArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 ShaderUniformBufferArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderSampledImageArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 ShaderSampledImageArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderStorageBufferArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 ShaderStorageBufferArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderStorageImageArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 ShaderStorageImageArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderInputAttachmentArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(84)]
        public Brutal.Bool32 ShaderInputAttachmentArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderUniformTexelBufferArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(88)]
        public Brutal.Bool32 ShaderUniformTexelBufferArrayNonUniformIndexing;

        /// <summary>
        ///     <c>ShaderStorageTexelBufferArrayNonUniformIndexing</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 ShaderStorageTexelBufferArrayNonUniformIndexing;

        /// <summary>
        ///     <c>DescriptorBindingUniformBufferUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(96)]
        public Brutal.Bool32 DescriptorBindingUniformBufferUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingSampledImageUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(100)]
        public Brutal.Bool32 DescriptorBindingSampledImageUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingStorageImageUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(104)]
        public Brutal.Bool32 DescriptorBindingStorageImageUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingStorageBufferUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(108)]
        public Brutal.Bool32 DescriptorBindingStorageBufferUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingUniformTexelBufferUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(112)]
        public Brutal.Bool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingStorageTexelBufferUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(116)]
        public Brutal.Bool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;

        /// <summary>
        ///     <c>DescriptorBindingUpdateUnusedWhilePending</c>
        /// </summary>
        [FieldOffset(120)]
        public Brutal.Bool32 DescriptorBindingUpdateUnusedWhilePending;

        /// <summary>
        ///     <c>DescriptorBindingPartiallyBound</c>
        /// </summary>
        [FieldOffset(124)]
        public Brutal.Bool32 DescriptorBindingPartiallyBound;

        /// <summary>
        ///     <c>DescriptorBindingVariableDescriptorCount</c>
        /// </summary>
        [FieldOffset(128)]
        public Brutal.Bool32 DescriptorBindingVariableDescriptorCount;

        /// <summary>
        ///     <c>RuntimeDescriptorArray</c>
        /// </summary>
        [FieldOffset(132)]
        public Brutal.Bool32 RuntimeDescriptorArray;

        /// <summary>
        ///     <c>SamplerFilterMinmax</c>
        /// </summary>
        [FieldOffset(136)]
        public Brutal.Bool32 SamplerFilterMinmax;

        /// <summary>
        ///     <c>ScalarBlockLayout</c>
        /// </summary>
        [FieldOffset(140)]
        public Brutal.Bool32 ScalarBlockLayout;

        /// <summary>
        ///     <c>ImagelessFramebuffer</c>
        /// </summary>
        [FieldOffset(144)]
        public Brutal.Bool32 ImagelessFramebuffer;

        /// <summary>
        ///     <c>UniformBufferStandardLayout</c>
        /// </summary>
        [FieldOffset(148)]
        public Brutal.Bool32 UniformBufferStandardLayout;

        /// <summary>
        ///     <c>ShaderSubgroupExtendedTypes</c>
        /// </summary>
        [FieldOffset(152)]
        public Brutal.Bool32 ShaderSubgroupExtendedTypes;

        /// <summary>
        ///     <c>SeparateDepthStencilLayouts</c>
        /// </summary>
        [FieldOffset(156)]
        public Brutal.Bool32 SeparateDepthStencilLayouts;

        /// <summary>
        ///     <c>HostQueryReset</c>
        /// </summary>
        [FieldOffset(160)]
        public Brutal.Bool32 HostQueryReset;

        /// <summary>
        ///     <c>TimelineSemaphore</c>
        /// </summary>
        [FieldOffset(164)]
        public Brutal.Bool32 TimelineSemaphore;

        /// <summary>
        ///     <c>BufferDeviceAddress</c>
        /// </summary>
        [FieldOffset(168)]
        public Brutal.Bool32 BufferDeviceAddress;

        /// <summary>
        ///     <c>BufferDeviceAddressCaptureReplay</c>
        /// </summary>
        [FieldOffset(172)]
        public Brutal.Bool32 BufferDeviceAddressCaptureReplay;

        /// <summary>
        ///     <c>BufferDeviceAddressMultiDevice</c>
        /// </summary>
        [FieldOffset(176)]
        public Brutal.Bool32 BufferDeviceAddressMultiDevice;

        /// <summary>
        ///     <c>VulkanMemoryModel</c>
        /// </summary>
        [FieldOffset(180)]
        public Brutal.Bool32 VulkanMemoryModel;

        /// <summary>
        ///     <c>VulkanMemoryModelDeviceScope</c>
        /// </summary>
        [FieldOffset(184)]
        public Brutal.Bool32 VulkanMemoryModelDeviceScope;

        /// <summary>
        ///     <c>VulkanMemoryModelAvailabilityVisibilityChains</c>
        /// </summary>
        [FieldOffset(188)]
        public Brutal.Bool32 VulkanMemoryModelAvailabilityVisibilityChains;

        /// <summary>
        ///     <c>ShaderOutputViewportIndex</c>
        /// </summary>
        [FieldOffset(192)]
        public Brutal.Bool32 ShaderOutputViewportIndex;

        /// <summary>
        ///     <c>ShaderOutputLayer</c>
        /// </summary>
        [FieldOffset(196)]
        public Brutal.Bool32 ShaderOutputLayer;

        /// <summary>
        ///     <c>SubgroupBroadcastDynamicId</c>
        /// </summary>
        [FieldOffset(200)]
        public Brutal.Bool32 SubgroupBroadcastDynamicId;
    }
}
