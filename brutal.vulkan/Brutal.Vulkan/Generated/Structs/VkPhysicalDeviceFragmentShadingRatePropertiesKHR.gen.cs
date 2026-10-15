namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRatePropertiesKHR.html">VkPhysicalDeviceFragmentShadingRatePropertiesKHR</see> - Structure describing variable fragment shading rate limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentShadingRatePropertiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_fragment_shading_rate
    ///         typedef struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkExtent2D               minFragmentShadingRateAttachmentTexelSize;
    ///             VkExtent2D               maxFragmentShadingRateAttachmentTexelSize;
    ///             uint32_t                 maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
    ///             VkBool32                 primitiveFragmentShadingRateWithMultipleViewports;
    ///             VkBool32                 layeredShadingRateAttachments;
    ///             VkBool32                 fragmentShadingRateNonTrivialCombinerOps;
    ///             VkExtent2D               maxFragmentSize;
    ///             uint32_t                 maxFragmentSizeAspectRatio;
    ///             uint32_t                 maxFragmentShadingRateCoverageSamples;
    ///             VkSampleCountFlagBits    maxFragmentShadingRateRasterizationSamples;
    ///             VkBool32                 fragmentShadingRateWithShaderDepthStencilWrites;
    ///             VkBool32                 fragmentShadingRateWithSampleMask;
    ///             VkBool32                 fragmentShadingRateWithShaderSampleMask;
    ///             VkBool32                 fragmentShadingRateWithConservativeRasterization;
    ///             VkBool32                 fragmentShadingRateWithFragmentShaderInterlock;
    ///             VkBool32                 fragmentShadingRateWithCustomSampleLocations;
    ///             VkBool32                 fragmentShadingRateStrictMultiplyCombiner;
    ///         } VkPhysicalDeviceFragmentShadingRatePropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentShadingRatePropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinFragmentShadingRateAttachmentTexelSize</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D MinFragmentShadingRateAttachmentTexelSize;

        /// <summary>
        ///     <c>MaxFragmentShadingRateAttachmentTexelSize</c>
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D MaxFragmentShadingRateAttachmentTexelSize;

        /// <summary>
        ///     <c>MaxFragmentShadingRateAttachmentTexelSizeAspectRatio</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;

        /// <summary>
        ///     <c>PrimitiveFragmentShadingRateWithMultipleViewports</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 PrimitiveFragmentShadingRateWithMultipleViewports;

        /// <summary>
        ///     <c>LayeredShadingRateAttachments</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 LayeredShadingRateAttachments;

        /// <summary>
        ///     <c>FragmentShadingRateNonTrivialCombinerOps</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 FragmentShadingRateNonTrivialCombinerOps;

        /// <summary>
        ///     <c>MaxFragmentSize</c>
        /// </summary>
        [FieldOffset(48)]
        public VkExtent2D MaxFragmentSize;

        /// <summary>
        ///     <c>MaxFragmentSizeAspectRatio</c>
        /// </summary>
        [FieldOffset(56)]
        public int MaxFragmentSizeAspectRatio;

        /// <summary>
        ///     <c>MaxFragmentShadingRateCoverageSamples</c>
        /// </summary>
        [FieldOffset(60)]
        public int MaxFragmentShadingRateCoverageSamples;

        /// <summary>
        ///     <c>MaxFragmentShadingRateRasterizationSamples</c>
        /// </summary>
        [FieldOffset(64)]
        public VkSampleCountFlags MaxFragmentShadingRateRasterizationSamples;

        /// <summary>
        ///     <c>FragmentShadingRateWithShaderDepthStencilWrites</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 FragmentShadingRateWithShaderDepthStencilWrites;

        /// <summary>
        ///     <c>FragmentShadingRateWithSampleMask</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 FragmentShadingRateWithSampleMask;

        /// <summary>
        ///     <c>FragmentShadingRateWithShaderSampleMask</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 FragmentShadingRateWithShaderSampleMask;

        /// <summary>
        ///     <c>FragmentShadingRateWithConservativeRasterization</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 FragmentShadingRateWithConservativeRasterization;

        /// <summary>
        ///     <c>FragmentShadingRateWithFragmentShaderInterlock</c>
        /// </summary>
        [FieldOffset(84)]
        public Brutal.Bool32 FragmentShadingRateWithFragmentShaderInterlock;

        /// <summary>
        ///     <c>FragmentShadingRateWithCustomSampleLocations</c>
        /// </summary>
        [FieldOffset(88)]
        public Brutal.Bool32 FragmentShadingRateWithCustomSampleLocations;

        /// <summary>
        ///     <c>FragmentShadingRateStrictMultiplyCombiner</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 FragmentShadingRateStrictMultiplyCombiner;
    }
}
