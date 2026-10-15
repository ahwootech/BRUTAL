namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CapabilitiesKHR.html">VkVideoEncodeH265CapabilitiesKHR</see> - Structure describing H.265 encode capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities for an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-profile">H.265 encode profile^</see>, the
    ///         <c>VkVideoCapabilitiesKHR::pNext</c> chain <i>must</i> include a
    ///         <c>VkVideoEncodeH265CapabilitiesKHR</c> structure that will be filled with
    ///         the profile-specific capabilities.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeH265CapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265CapabilitiesKHR {
    ///             VkStructureType                                sType;
    ///             void*                                          pNext;
    ///             VkVideoEncodeH265CapabilityFlagsKHR            flags;
    ///             StdVideoH265LevelIdc                           maxLevelIdc;
    ///             uint32_t                                       maxSliceSegmentCount;
    ///             VkExtent2D                                     maxTiles;
    ///             VkVideoEncodeH265CtbSizeFlagsKHR               ctbSizes;
    ///             VkVideoEncodeH265TransformBlockSizeFlagsKHR    transformBlockSizes;
    ///             uint32_t                                       maxPPictureL0ReferenceCount;
    ///             uint32_t                                       maxBPictureL0ReferenceCount;
    ///             uint32_t                                       maxL1ReferenceCount;
    ///             uint32_t                                       maxSubLayerCount;
    ///             VkBool32                                       expectDyadicTemporalSubLayerPattern;
    ///             int32_t                                        minQp;
    ///             int32_t                                        maxQp;
    ///             VkBool32                                       prefersGopRemainingFrames;
    ///             VkBool32                                       requiresGopRemainingFrames;
    ///             VkVideoEncodeH265StdFlagsKHR                   stdSyntaxFlags;
    ///         } VkVideoEncodeH265CapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkVideoEncodeH265CapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265CapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoEncodeH265CapabilityFlagsKHR</c> indicating supported H.265 encoding capabilities.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeH265CapabilityFlagsKHR Flags;

        /// <summary>
        ///     <c>MaxLevelIdc</c> is a <c>StdVideoH265LevelIdc</c> value indicating the maximum H.265 level supported by the profile, where enum constant `STD_VIDEO_H265_LEVEL_IDC_&lt;major&gt;_&lt;minor&gt;` identifies H.265 level `&lt;major&gt;.&lt;minor&gt;` as defined in section A.4 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see>.
        /// </summary>
        [FieldOffset(20)]
        public StdVideoH265LevelIdc MaxLevelIdc;

        /// <summary>
        ///     <c>MaxSliceSegmentCount</c> indicates the maximum number of slice segments that <i>can</i> be encoded for a single picture. Further restrictions may: apply to the number of slice segments that <i>can</i> be encoded for a single picture depending on other capabilities and codec-specific rules.
        /// </summary>
        [FieldOffset(24)]
        public int MaxSliceSegmentCount;

        /// <summary>
        ///     <c>MaxTiles</c> indicates the maximum number of H.265 tile columns and rows, as defined in sections 3.175 and 3.176 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see> that <i>can</i> be encoded for a single picture. Further restrictions may: apply to the number of H.265 tiles that <i>can</i> be encoded for a single picture depending on other capabilities and codec-specific rules.
        /// </summary>
        [FieldOffset(28)]
        public VkExtent2D MaxTiles;

        /// <summary>
        ///     <c>CtbSizes</c> is a bitmask of <c>VkVideoEncodeH265CtbSizeFlagsKHR</c> describing the supported CTB sizes.
        /// </summary>
        [FieldOffset(36)]
        public VkVideoEncodeH265CtbSizeFlagsKHR CtbSizes;

        /// <summary>
        ///     <c>TransformBlockSizes</c> is a bitmask of <c>VkVideoEncodeH265TransformBlockSizeFlagsKHR</c> describing the supported transform block sizes.
        /// </summary>
        [FieldOffset(40)]
        public VkVideoEncodeH265TransformBlockSizeFlagsKHR TransformBlockSizes;

        /// <summary>
        ///     <c>MaxPPictureL0ReferenceCount</c> indicates the maximum number of reference pictures the implementation supports in the reference list L0 for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-p-pic">P pictures^</see>. + [NOTE]
        /// </summary>
        [FieldOffset(44)]
        public int MaxPPictureL0ReferenceCount;

        /// <summary>
        ///     <c>MaxBPictureL0ReferenceCount</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxBPictureL0ReferenceCount;

        /// <summary>
        ///     <c>MaxL1ReferenceCount</c>
        /// </summary>
        [FieldOffset(52)]
        public int MaxL1ReferenceCount;

        /// <summary>
        ///     <c>MaxSubLayerCount</c>
        /// </summary>
        [FieldOffset(56)]
        public int MaxSubLayerCount;

        /// <summary>
        ///     <c>ExpectDyadicTemporalSubLayerPattern</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 ExpectDyadicTemporalSubLayerPattern;

        /// <summary>
        ///     <c>MinQp</c>
        /// </summary>
        [FieldOffset(64)]
        public int MinQp;

        /// <summary>
        ///     <c>MaxQp</c>
        /// </summary>
        [FieldOffset(68)]
        public int MaxQp;

        /// <summary>
        ///     <c>PrefersGopRemainingFrames</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 PrefersGopRemainingFrames;

        /// <summary>
        ///     <c>RequiresGopRemainingFrames</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 RequiresGopRemainingFrames;

        /// <summary>
        ///     <c>StdSyntaxFlags</c>
        /// </summary>
        [FieldOffset(80)]
        public VkVideoEncodeH265StdFlagsKHR StdSyntaxFlags;
    }
}
