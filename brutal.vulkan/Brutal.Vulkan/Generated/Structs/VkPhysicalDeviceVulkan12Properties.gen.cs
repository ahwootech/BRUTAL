namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan12Properties.html">VkPhysicalDeviceVulkan12Properties</see> - Structure specifying physical device properties for functionality promoted to Vulkan 1.2
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkan12Properties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceVulkan12Properties {
    ///             VkStructureType                      sType;
    ///             void*                                pNext;
    ///             VkDriverId                           driverID;
    ///             char                                 driverName[VK_MAX_DRIVER_NAME_SIZE];
    ///             char                                 driverInfo[VK_MAX_DRIVER_INFO_SIZE];
    ///             VkConformanceVersion                 conformanceVersion;
    ///             VkShaderFloatControlsIndependence    denormBehaviorIndependence;
    ///             VkShaderFloatControlsIndependence    roundingModeIndependence;
    ///             VkBool32                             shaderSignedZeroInfNanPreserveFloat16;
    ///             VkBool32                             shaderSignedZeroInfNanPreserveFloat32;
    ///             VkBool32                             shaderSignedZeroInfNanPreserveFloat64;
    ///             VkBool32                             shaderDenormPreserveFloat16;
    ///             VkBool32                             shaderDenormPreserveFloat32;
    ///             VkBool32                             shaderDenormPreserveFloat64;
    ///             VkBool32                             shaderDenormFlushToZeroFloat16;
    ///             VkBool32                             shaderDenormFlushToZeroFloat32;
    ///             VkBool32                             shaderDenormFlushToZeroFloat64;
    ///             VkBool32                             shaderRoundingModeRTEFloat16;
    ///             VkBool32                             shaderRoundingModeRTEFloat32;
    ///             VkBool32                             shaderRoundingModeRTEFloat64;
    ///             VkBool32                             shaderRoundingModeRTZFloat16;
    ///             VkBool32                             shaderRoundingModeRTZFloat32;
    ///             VkBool32                             shaderRoundingModeRTZFloat64;
    ///             uint32_t                             maxUpdateAfterBindDescriptorsInAllPools;
    ///             VkBool32                             shaderUniformBufferArrayNonUniformIndexingNative;
    ///             VkBool32                             shaderSampledImageArrayNonUniformIndexingNative;
    ///             VkBool32                             shaderStorageBufferArrayNonUniformIndexingNative;
    ///             VkBool32                             shaderStorageImageArrayNonUniformIndexingNative;
    ///             VkBool32                             shaderInputAttachmentArrayNonUniformIndexingNative;
    ///             VkBool32                             robustBufferAccessUpdateAfterBind;
    ///             VkBool32                             quadDivergentImplicitLod;
    ///             uint32_t                             maxPerStageDescriptorUpdateAfterBindSamplers;
    ///             uint32_t                             maxPerStageDescriptorUpdateAfterBindUniformBuffers;
    ///             uint32_t                             maxPerStageDescriptorUpdateAfterBindStorageBuffers;
    ///             uint32_t                             maxPerStageDescriptorUpdateAfterBindSampledImages;
    ///             uint32_t                             maxPerStageDescriptorUpdateAfterBindStorageImages;
    ///             uint32_t                             maxPerStageDescriptorUpdateAfterBindInputAttachments;
    ///             uint32_t                             maxPerStageUpdateAfterBindResources;
    ///             uint32_t                             maxDescriptorSetUpdateAfterBindSamplers;
    ///             uint32_t                             maxDescriptorSetUpdateAfterBindUniformBuffers;
    ///             uint32_t                             maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
    ///             uint32_t                             maxDescriptorSetUpdateAfterBindStorageBuffers;
    ///             uint32_t                             maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
    ///             uint32_t                             maxDescriptorSetUpdateAfterBindSampledImages;
    ///             uint32_t                             maxDescriptorSetUpdateAfterBindStorageImages;
    ///             uint32_t                             maxDescriptorSetUpdateAfterBindInputAttachments;
    ///             VkResolveModeFlags                   supportedDepthResolveModes;
    ///             VkResolveModeFlags                   supportedStencilResolveModes;
    ///             VkBool32                             independentResolveNone;
    ///             VkBool32                             independentResolve;
    ///             VkBool32                             filterMinmaxSingleComponentFormats;
    ///             VkBool32                             filterMinmaxImageComponentMapping;
    ///             uint64_t                             maxTimelineSemaphoreValueDifference;
    ///             VkSampleCountFlags                   framebufferIntegerColorSampleCounts;
    ///         } VkPhysicalDeviceVulkan12Properties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 736)]
    public unsafe partial struct VkPhysicalDeviceVulkan12Properties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkan12Properties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DriverID</c>
        /// </summary>
        [FieldOffset(16)]
        public VkDriverId DriverID;

        ///
        [FieldOffset(20)]
        public fixed byte DriverName[256];

        ///
        [FieldOffset(276)]
        public fixed byte DriverInfo[256];

        /// <summary>
        ///     <c>ConformanceVersion</c>
        /// </summary>
        [FieldOffset(532)]
        public VkConformanceVersion ConformanceVersion;

        /// <summary>
        ///     <c>DenormBehaviorIndependence</c>
        /// </summary>
        [FieldOffset(536)]
        public VkShaderFloatControlsIndependence DenormBehaviorIndependence;

        /// <summary>
        ///     <c>RoundingModeIndependence</c>
        /// </summary>
        [FieldOffset(540)]
        public VkShaderFloatControlsIndependence RoundingModeIndependence;

        /// <summary>
        ///     <c>ShaderSignedZeroInfNanPreserveFloat16</c>
        /// </summary>
        [FieldOffset(544)]
        public Brutal.Bool32 ShaderSignedZeroInfNanPreserveFloat16;

        /// <summary>
        ///     <c>ShaderSignedZeroInfNanPreserveFloat32</c>
        /// </summary>
        [FieldOffset(548)]
        public Brutal.Bool32 ShaderSignedZeroInfNanPreserveFloat32;

        /// <summary>
        ///     <c>ShaderSignedZeroInfNanPreserveFloat64</c>
        /// </summary>
        [FieldOffset(552)]
        public Brutal.Bool32 ShaderSignedZeroInfNanPreserveFloat64;

        /// <summary>
        ///     <c>ShaderDenormPreserveFloat16</c>
        /// </summary>
        [FieldOffset(556)]
        public Brutal.Bool32 ShaderDenormPreserveFloat16;

        /// <summary>
        ///     <c>ShaderDenormPreserveFloat32</c>
        /// </summary>
        [FieldOffset(560)]
        public Brutal.Bool32 ShaderDenormPreserveFloat32;

        /// <summary>
        ///     <c>ShaderDenormPreserveFloat64</c>
        /// </summary>
        [FieldOffset(564)]
        public Brutal.Bool32 ShaderDenormPreserveFloat64;

        /// <summary>
        ///     <c>ShaderDenormFlushToZeroFloat16</c>
        /// </summary>
        [FieldOffset(568)]
        public Brutal.Bool32 ShaderDenormFlushToZeroFloat16;

        /// <summary>
        ///     <c>ShaderDenormFlushToZeroFloat32</c>
        /// </summary>
        [FieldOffset(572)]
        public Brutal.Bool32 ShaderDenormFlushToZeroFloat32;

        /// <summary>
        ///     <c>ShaderDenormFlushToZeroFloat64</c>
        /// </summary>
        [FieldOffset(576)]
        public Brutal.Bool32 ShaderDenormFlushToZeroFloat64;

        /// <summary>
        ///     <c>ShaderRoundingModeRTEFloat16</c>
        /// </summary>
        [FieldOffset(580)]
        public Brutal.Bool32 ShaderRoundingModeRTEFloat16;

        /// <summary>
        ///     <c>ShaderRoundingModeRTEFloat32</c>
        /// </summary>
        [FieldOffset(584)]
        public Brutal.Bool32 ShaderRoundingModeRTEFloat32;

        /// <summary>
        ///     <c>ShaderRoundingModeRTEFloat64</c>
        /// </summary>
        [FieldOffset(588)]
        public Brutal.Bool32 ShaderRoundingModeRTEFloat64;

        /// <summary>
        ///     <c>ShaderRoundingModeRTZFloat16</c>
        /// </summary>
        [FieldOffset(592)]
        public Brutal.Bool32 ShaderRoundingModeRTZFloat16;

        /// <summary>
        ///     <c>ShaderRoundingModeRTZFloat32</c>
        /// </summary>
        [FieldOffset(596)]
        public Brutal.Bool32 ShaderRoundingModeRTZFloat32;

        /// <summary>
        ///     <c>ShaderRoundingModeRTZFloat64</c>
        /// </summary>
        [FieldOffset(600)]
        public Brutal.Bool32 ShaderRoundingModeRTZFloat64;

        /// <summary>
        ///     <c>MaxUpdateAfterBindDescriptorsInAllPools</c>
        /// </summary>
        [FieldOffset(604)]
        public int MaxUpdateAfterBindDescriptorsInAllPools;

        /// <summary>
        ///     <c>ShaderUniformBufferArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(608)]
        public Brutal.Bool32 ShaderUniformBufferArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderSampledImageArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(612)]
        public Brutal.Bool32 ShaderSampledImageArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderStorageBufferArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(616)]
        public Brutal.Bool32 ShaderStorageBufferArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderStorageImageArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(620)]
        public Brutal.Bool32 ShaderStorageImageArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>ShaderInputAttachmentArrayNonUniformIndexingNative</c>
        /// </summary>
        [FieldOffset(624)]
        public Brutal.Bool32 ShaderInputAttachmentArrayNonUniformIndexingNative;

        /// <summary>
        ///     <c>RobustBufferAccessUpdateAfterBind</c>
        /// </summary>
        [FieldOffset(628)]
        public Brutal.Bool32 RobustBufferAccessUpdateAfterBind;

        /// <summary>
        ///     <c>QuadDivergentImplicitLod</c>
        /// </summary>
        [FieldOffset(632)]
        public Brutal.Bool32 QuadDivergentImplicitLod;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindSamplers</c>
        /// </summary>
        [FieldOffset(636)]
        public int MaxPerStageDescriptorUpdateAfterBindSamplers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindUniformBuffers</c>
        /// </summary>
        [FieldOffset(640)]
        public int MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindStorageBuffers</c>
        /// </summary>
        [FieldOffset(644)]
        public int MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindSampledImages</c>
        /// </summary>
        [FieldOffset(648)]
        public int MaxPerStageDescriptorUpdateAfterBindSampledImages;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindStorageImages</c>
        /// </summary>
        [FieldOffset(652)]
        public int MaxPerStageDescriptorUpdateAfterBindStorageImages;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindInputAttachments</c>
        /// </summary>
        [FieldOffset(656)]
        public int MaxPerStageDescriptorUpdateAfterBindInputAttachments;

        /// <summary>
        ///     <c>MaxPerStageUpdateAfterBindResources</c>
        /// </summary>
        [FieldOffset(660)]
        public int MaxPerStageUpdateAfterBindResources;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindSamplers</c>
        /// </summary>
        [FieldOffset(664)]
        public int MaxDescriptorSetUpdateAfterBindSamplers;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindUniformBuffers</c>
        /// </summary>
        [FieldOffset(668)]
        public int MaxDescriptorSetUpdateAfterBindUniformBuffers;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic</c>
        /// </summary>
        [FieldOffset(672)]
        public int MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindStorageBuffers</c>
        /// </summary>
        [FieldOffset(676)]
        public int MaxDescriptorSetUpdateAfterBindStorageBuffers;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic</c>
        /// </summary>
        [FieldOffset(680)]
        public int MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindSampledImages</c>
        /// </summary>
        [FieldOffset(684)]
        public int MaxDescriptorSetUpdateAfterBindSampledImages;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindStorageImages</c>
        /// </summary>
        [FieldOffset(688)]
        public int MaxDescriptorSetUpdateAfterBindStorageImages;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindInputAttachments</c>
        /// </summary>
        [FieldOffset(692)]
        public int MaxDescriptorSetUpdateAfterBindInputAttachments;

        /// <summary>
        ///     <c>SupportedDepthResolveModes</c>
        /// </summary>
        [FieldOffset(696)]
        public VkResolveModeFlags SupportedDepthResolveModes;

        /// <summary>
        ///     <c>SupportedStencilResolveModes</c>
        /// </summary>
        [FieldOffset(700)]
        public VkResolveModeFlags SupportedStencilResolveModes;

        /// <summary>
        ///     <c>IndependentResolveNone</c>
        /// </summary>
        [FieldOffset(704)]
        public Brutal.Bool32 IndependentResolveNone;

        /// <summary>
        ///     <c>IndependentResolve</c>
        /// </summary>
        [FieldOffset(708)]
        public Brutal.Bool32 IndependentResolve;

        /// <summary>
        ///     <c>FilterMinmaxSingleComponentFormats</c>
        /// </summary>
        [FieldOffset(712)]
        public Brutal.Bool32 FilterMinmaxSingleComponentFormats;

        /// <summary>
        ///     <c>FilterMinmaxImageComponentMapping</c>
        /// </summary>
        [FieldOffset(716)]
        public Brutal.Bool32 FilterMinmaxImageComponentMapping;

        /// <summary>
        ///     <c>MaxTimelineSemaphoreValueDifference</c>
        /// </summary>
        [FieldOffset(720)]
        public nint MaxTimelineSemaphoreValueDifference;

        /// <summary>
        ///     <c>FramebufferIntegerColorSampleCounts</c>
        /// </summary>
        [FieldOffset(728)]
        public VkSampleCountFlags FramebufferIntegerColorSampleCounts;
    }
}
