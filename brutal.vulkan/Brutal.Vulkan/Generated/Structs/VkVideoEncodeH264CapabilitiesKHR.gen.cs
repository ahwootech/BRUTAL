namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264CapabilitiesKHR.html">VkVideoEncodeH264CapabilitiesKHR</see> - Structure describing H.264 encode capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities for an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-profile">H.264 encode profile^</see>, the
    ///         <c>VkVideoCapabilitiesKHR::pNext</c> chain <i>must</i> include a
    ///         <c>VkVideoEncodeH264CapabilitiesKHR</c> structure that will be filled with
    ///         the profile-specific capabilities.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeH264CapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264CapabilitiesKHR {
    ///             VkStructureType                        sType;
    ///             void*                                  pNext;
    ///             VkVideoEncodeH264CapabilityFlagsKHR    flags;
    ///             StdVideoH264LevelIdc                   maxLevelIdc;
    ///             uint32_t                               maxSliceCount;
    ///             uint32_t                               maxPPictureL0ReferenceCount;
    ///             uint32_t                               maxBPictureL0ReferenceCount;
    ///             uint32_t                               maxL1ReferenceCount;
    ///             uint32_t                               maxTemporalLayerCount;
    ///             VkBool32                               expectDyadicTemporalLayerPattern;
    ///             int32_t                                minQp;
    ///             int32_t                                maxQp;
    ///             VkBool32                               prefersGopRemainingFrames;
    ///             VkBool32                               requiresGopRemainingFrames;
    ///             VkVideoEncodeH264StdFlagsKHR           stdSyntaxFlags;
    ///         } VkVideoEncodeH264CapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkVideoEncodeH264CapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264CapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoEncodeH264CapabilityFlagsKHR</c> indicating supported H.264 encoding capabilities.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeH264CapabilityFlagsKHR Flags;

        /// <summary>
        ///     <c>MaxLevelIdc</c> is a <c>StdVideoH264LevelIdc</c> value indicating the maximum H.264 level supported by the profile, where enum constant `STD_VIDEO_H264_LEVEL_IDC_&lt;major&gt;_&lt;minor&gt;` identifies H.264 level `&lt;major&gt;.&lt;minor&gt;` as defined in section A.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>.
        /// </summary>
        [FieldOffset(20)]
        public StdVideoH264LevelIdc MaxLevelIdc;

        /// <summary>
        ///     <c>MaxSliceCount</c> indicates the maximum number of slices that <i>can</i> be encoded for a single picture. Further restrictions may: apply to the number of slices that <i>can</i> be encoded for a single picture depending on other capabilities and codec-specific rules.
        /// </summary>
        [FieldOffset(24)]
        public int MaxSliceCount;

        /// <summary>
        ///     <c>MaxPPictureL0ReferenceCount</c> indicates the maximum number of reference pictures the implementation supports in the reference list L0 for <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-p-pic">P pictures^</see>. + [NOTE]
        /// </summary>
        [FieldOffset(28)]
        public int MaxPPictureL0ReferenceCount;

        /// <summary>
        ///     <c>MaxBPictureL0ReferenceCount</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxBPictureL0ReferenceCount;

        /// <summary>
        ///     <c>MaxL1ReferenceCount</c>
        /// </summary>
        [FieldOffset(36)]
        public int MaxL1ReferenceCount;

        /// <summary>
        ///     <c>MaxTemporalLayerCount</c>
        /// </summary>
        [FieldOffset(40)]
        public int MaxTemporalLayerCount;

        /// <summary>
        ///     <c>ExpectDyadicTemporalLayerPattern</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 ExpectDyadicTemporalLayerPattern;

        /// <summary>
        ///     <c>MinQp</c>
        /// </summary>
        [FieldOffset(48)]
        public int MinQp;

        /// <summary>
        ///     <c>MaxQp</c>
        /// </summary>
        [FieldOffset(52)]
        public int MaxQp;

        /// <summary>
        ///     <c>PrefersGopRemainingFrames</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 PrefersGopRemainingFrames;

        /// <summary>
        ///     <c>RequiresGopRemainingFrames</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 RequiresGopRemainingFrames;

        /// <summary>
        ///     <c>StdSyntaxFlags</c>
        /// </summary>
        [FieldOffset(64)]
        public VkVideoEncodeH264StdFlagsKHR StdSyntaxFlags;
    }
}
