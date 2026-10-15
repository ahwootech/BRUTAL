namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan13Properties.html">VkPhysicalDeviceVulkan13Properties</see> - Structure specifying physical device properties for functionality promoted to Vulkan 1.3
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkan13Properties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceVulkan13Properties {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             uint32_t              minSubgroupSize;
    ///             uint32_t              maxSubgroupSize;
    ///             uint32_t              maxComputeWorkgroupSubgroups;
    ///             VkShaderStageFlags    requiredSubgroupSizeStages;
    ///             uint32_t              maxInlineUniformBlockSize;
    ///             uint32_t              maxPerStageDescriptorInlineUniformBlocks;
    ///             uint32_t              maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
    ///             uint32_t              maxDescriptorSetInlineUniformBlocks;
    ///             uint32_t              maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    ///             uint32_t              maxInlineUniformTotalSize;
    ///             VkBool32              integerDotProduct8BitUnsignedAccelerated;
    ///             VkBool32              integerDotProduct8BitSignedAccelerated;
    ///             VkBool32              integerDotProduct8BitMixedSignednessAccelerated;
    ///             VkBool32              integerDotProduct4x8BitPackedUnsignedAccelerated;
    ///             VkBool32              integerDotProduct4x8BitPackedSignedAccelerated;
    ///             VkBool32              integerDotProduct4x8BitPackedMixedSignednessAccelerated;
    ///             VkBool32              integerDotProduct16BitUnsignedAccelerated;
    ///             VkBool32              integerDotProduct16BitSignedAccelerated;
    ///             VkBool32              integerDotProduct16BitMixedSignednessAccelerated;
    ///             VkBool32              integerDotProduct32BitUnsignedAccelerated;
    ///             VkBool32              integerDotProduct32BitSignedAccelerated;
    ///             VkBool32              integerDotProduct32BitMixedSignednessAccelerated;
    ///             VkBool32              integerDotProduct64BitUnsignedAccelerated;
    ///             VkBool32              integerDotProduct64BitSignedAccelerated;
    ///             VkBool32              integerDotProduct64BitMixedSignednessAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating8BitSignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating16BitSignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating32BitSignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating64BitSignedAccelerated;
    ///             VkBool32              integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
    ///             VkDeviceSize          storageTexelBufferOffsetAlignmentBytes;
    ///             VkBool32              storageTexelBufferOffsetSingleTexelAlignment;
    ///             VkDeviceSize          uniformTexelBufferOffsetAlignmentBytes;
    ///             VkBool32              uniformTexelBufferOffsetSingleTexelAlignment;
    ///             VkDeviceSize          maxBufferSize;
    ///         } VkPhysicalDeviceVulkan13Properties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 216)]
    public unsafe partial struct VkPhysicalDeviceVulkan13Properties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkan13Properties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinSubgroupSize</c>
        /// </summary>
        [FieldOffset(16)]
        public int MinSubgroupSize;

        /// <summary>
        ///     <c>MaxSubgroupSize</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxSubgroupSize;

        /// <summary>
        ///     <c>MaxComputeWorkgroupSubgroups</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxComputeWorkgroupSubgroups;

        /// <summary>
        ///     <c>RequiredSubgroupSizeStages</c>
        /// </summary>
        [FieldOffset(28)]
        public VkShaderStageFlags RequiredSubgroupSizeStages;

        /// <summary>
        ///     <c>MaxInlineUniformBlockSize</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxInlineUniformBlockSize;

        /// <summary>
        ///     <c>MaxPerStageDescriptorInlineUniformBlocks</c>
        /// </summary>
        [FieldOffset(36)]
        public int MaxPerStageDescriptorInlineUniformBlocks;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks</c>
        /// </summary>
        [FieldOffset(40)]
        public int MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;

        /// <summary>
        ///     <c>MaxDescriptorSetInlineUniformBlocks</c>
        /// </summary>
        [FieldOffset(44)]
        public int MaxDescriptorSetInlineUniformBlocks;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindInlineUniformBlocks</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;

        /// <summary>
        ///     <c>MaxInlineUniformTotalSize</c>
        /// </summary>
        [FieldOffset(52)]
        public int MaxInlineUniformTotalSize;

        /// <summary>
        ///     <c>IntegerDotProduct8BitUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 IntegerDotProduct8BitUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct8BitSignedAccelerated</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 IntegerDotProduct8BitSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct8BitMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 IntegerDotProduct8BitMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct4x8BitPackedUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 IntegerDotProduct4x8BitPackedUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct4x8BitPackedSignedAccelerated</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 IntegerDotProduct4x8BitPackedSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct4x8BitPackedMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct16BitUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 IntegerDotProduct16BitUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct16BitSignedAccelerated</c>
        /// </summary>
        [FieldOffset(84)]
        public Brutal.Bool32 IntegerDotProduct16BitSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct16BitMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(88)]
        public Brutal.Bool32 IntegerDotProduct16BitMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct32BitUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 IntegerDotProduct32BitUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct32BitSignedAccelerated</c>
        /// </summary>
        [FieldOffset(96)]
        public Brutal.Bool32 IntegerDotProduct32BitSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct32BitMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(100)]
        public Brutal.Bool32 IntegerDotProduct32BitMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct64BitUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(104)]
        public Brutal.Bool32 IntegerDotProduct64BitUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct64BitSignedAccelerated</c>
        /// </summary>
        [FieldOffset(108)]
        public Brutal.Bool32 IntegerDotProduct64BitSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProduct64BitMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(112)]
        public Brutal.Bool32 IntegerDotProduct64BitMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(116)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating8BitSignedAccelerated</c>
        /// </summary>
        [FieldOffset(120)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(124)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(128)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated</c>
        /// </summary>
        [FieldOffset(132)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(136)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(140)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating16BitSignedAccelerated</c>
        /// </summary>
        [FieldOffset(144)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(148)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(152)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating32BitSignedAccelerated</c>
        /// </summary>
        [FieldOffset(156)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(160)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated</c>
        /// </summary>
        [FieldOffset(164)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating64BitSignedAccelerated</c>
        /// </summary>
        [FieldOffset(168)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;

        /// <summary>
        ///     <c>IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated</c>
        /// </summary>
        [FieldOffset(172)]
        public Brutal.Bool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;

        /// <summary>
        ///     <c>StorageTexelBufferOffsetAlignmentBytes</c>
        /// </summary>
        [FieldOffset(176)]
        public ByteSize64 StorageTexelBufferOffsetAlignmentBytes;

        /// <summary>
        ///     <c>StorageTexelBufferOffsetSingleTexelAlignment</c>
        /// </summary>
        [FieldOffset(184)]
        public Brutal.Bool32 StorageTexelBufferOffsetSingleTexelAlignment;

        /// <summary>
        ///     <c>UniformTexelBufferOffsetAlignmentBytes</c>
        /// </summary>
        [FieldOffset(192)]
        public ByteSize64 UniformTexelBufferOffsetAlignmentBytes;

        /// <summary>
        ///     <c>UniformTexelBufferOffsetSingleTexelAlignment</c>
        /// </summary>
        [FieldOffset(200)]
        public Brutal.Bool32 UniformTexelBufferOffsetSingleTexelAlignment;

        /// <summary>
        ///     <c>MaxBufferSize</c>
        /// </summary>
        [FieldOffset(208)]
        public ByteSize64 MaxBufferSize;
    }
}
