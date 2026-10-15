namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1CapabilitiesKHR.html">VkVideoEncodeAV1CapabilitiesKHR</see> - Structure describing AV1 encode capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities for an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-profile">AV1 encode profile^</see>, the
    ///         <c>VkVideoCapabilitiesKHR::pNext</c> chain <i>must</i> include a
    ///         <c>VkVideoEncodeAV1CapabilitiesKHR</c> structure that will be filled with the
    ///         profile-specific capabilities.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1CapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1CapabilitiesKHR {
    ///             VkStructureType                           sType;
    ///             void*                                     pNext;
    ///             VkVideoEncodeAV1CapabilityFlagsKHR        flags;
    ///             StdVideoAV1Level                          maxLevel;
    ///             VkExtent2D                                codedPictureAlignment;
    ///             VkExtent2D                                maxTiles;
    ///             VkExtent2D                                minTileSize;
    ///             VkExtent2D                                maxTileSize;
    ///             VkVideoEncodeAV1SuperblockSizeFlagsKHR    superblockSizes;
    ///             uint32_t                                  maxSingleReferenceCount;
    ///             uint32_t                                  singleReferenceNameMask;
    ///             uint32_t                                  maxUnidirectionalCompoundReferenceCount;
    ///             uint32_t                                  maxUnidirectionalCompoundGroup1ReferenceCount;
    ///             uint32_t                                  unidirectionalCompoundReferenceNameMask;
    ///             uint32_t                                  maxBidirectionalCompoundReferenceCount;
    ///             uint32_t                                  maxBidirectionalCompoundGroup1ReferenceCount;
    ///             uint32_t                                  maxBidirectionalCompoundGroup2ReferenceCount;
    ///             uint32_t                                  bidirectionalCompoundReferenceNameMask;
    ///             uint32_t                                  maxTemporalLayerCount;
    ///             uint32_t                                  maxSpatialLayerCount;
    ///             uint32_t                                  maxOperatingPoints;
    ///             uint32_t                                  minQIndex;
    ///             uint32_t                                  maxQIndex;
    ///             VkBool32                                  prefersGopRemainingFrames;
    ///             VkBool32                                  requiresGopRemainingFrames;
    ///             VkVideoEncodeAV1StdFlagsKHR               stdSyntaxFlags;
    ///         } VkVideoEncodeAV1CapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public unsafe partial struct VkVideoEncodeAV1CapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1CapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoEncodeAV1CapabilityFlagsKHR</c> indicating supported AV1 encoding capabilities.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeAV1CapabilityFlagsKHR Flags;

        /// <summary>
        ///     <c>MaxLevel</c> is a <c>StdVideoAV1Level</c> value indicating the maximum AV1 level supported by the profile, as defined in section A.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(20)]
        public StdVideoAV1Level MaxLevel;

        /// <summary>
        ///     <c>CodedPictureAlignment</c> indicates the alignment at which the implementation will code pictures. This capability does not impose any valid usage constraints on the application. However, depending on the <c>codedExtent</c> of the encode input picture resource, this capability may: result in a change of the resolution of the encoded picture, as described in more detail below.
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D CodedPictureAlignment;

        /// <summary>
        ///     <c>MaxTiles</c> indicates the maximum number of AV1 tile columns and rows the implementation supports.
        /// </summary>
        [FieldOffset(32)]
        public VkExtent2D MaxTiles;

        /// <summary>
        ///     <c>MinTileSize</c> indicates the minimum extent of individual AV1 tiles the implementation supports.
        /// </summary>
        [FieldOffset(40)]
        public VkExtent2D MinTileSize;

        /// <summary>
        ///     <c>MaxTileSize</c> indicates the maximum extent of individual AV1 tiles the implementation supports.
        /// </summary>
        [FieldOffset(48)]
        public VkExtent2D MaxTileSize;

        /// <summary>
        ///     <c>SuperblockSizes</c> is a bitmask of <c>VkVideoEncodeAV1SuperblockSizeFlagsKHR</c> values indicating the supported AV1 superblock sizes.
        /// </summary>
        [FieldOffset(56)]
        public VkVideoEncodeAV1SuperblockSizeFlagsKHR SuperblockSizes;

        /// <summary>
        ///     <c>MaxSingleReferenceCount</c> indicates the maximum number of reference pictures the implementation supports when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">single reference prediction mode^</see>.
        /// </summary>
        [FieldOffset(60)]
        public int MaxSingleReferenceCount;

        /// <summary>
        ///     <c>SingleReferenceNameMask</c> is a bitmask of supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference names^</see> when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">single reference prediction mode^</see>.
        /// </summary>
        [FieldOffset(64)]
        public int SingleReferenceNameMask;

        /// <summary>
        ///     <c>MaxUnidirectionalCompoundReferenceCount</c> indicates the maximum number of reference pictures the implementation supports when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">unidirectional compound prediction mode^</see>.
        /// </summary>
        [FieldOffset(68)]
        public int MaxUnidirectionalCompoundReferenceCount;

        /// <summary>
        ///     <c>MaxUnidirectionalCompoundGroup1ReferenceCount</c> indicates the maximum number of reference pictures the implementation supports when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">unidirectional compound prediction mode^</see> from reference frame group 1, as defined in section 6.10.24 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(72)]
        public int MaxUnidirectionalCompoundGroup1ReferenceCount;

        /// <summary>
        ///     <c>UnidirectionalCompoundReferenceNameMask</c> is a bitmask of supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference names^</see> when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">unidirectional compound prediction mode^</see>.
        /// </summary>
        [FieldOffset(76)]
        public int UnidirectionalCompoundReferenceNameMask;

        /// <summary>
        ///     <c>MaxBidirectionalCompoundReferenceCount</c> indicates the maximum number of reference pictures the implementation supports when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">bidirectional compound prediction mode^</see>.
        /// </summary>
        [FieldOffset(80)]
        public int MaxBidirectionalCompoundReferenceCount;

        /// <summary>
        ///     <c>MaxBidirectionalCompoundGroup1ReferenceCount</c> indicates the maximum number of reference pictures the implementation supports when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">bidirectional compound prediction mode^</see> from reference frame group 1, as defined in section 6.10.24 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(84)]
        public int MaxBidirectionalCompoundGroup1ReferenceCount;

        /// <summary>
        ///     <c>MaxBidirectionalCompoundGroup2ReferenceCount</c> indicates the maximum number of reference pictures the implementation supports when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">bidirectional compound prediction mode^</see> from reference frame group 2, as defined in section 6.10.24 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(88)]
        public int MaxBidirectionalCompoundGroup2ReferenceCount;

        /// <summary>
        ///     <c>BidirectionalCompoundReferenceNameMask</c> is a bitmask of supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-reference-names">AV1 reference names^</see> when using <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-prediction-modes">bidirectional compound prediction mode^</see>.
        /// </summary>
        [FieldOffset(92)]
        public int BidirectionalCompoundReferenceNameMask;

        /// <summary>
        ///     <c>MaxTemporalLayerCount</c> indicates the maximum number of AV1 temporal layers supported by the implementation.
        /// </summary>
        [FieldOffset(96)]
        public int MaxTemporalLayerCount;

        /// <summary>
        ///     <c>MaxSpatialLayerCount</c> indicates the maximum number of AV1 spatial layers supported by the implementation.
        /// </summary>
        [FieldOffset(100)]
        public int MaxSpatialLayerCount;

        /// <summary>
        ///     <c>MaxOperatingPoints</c> indicates the maximum number of AV1 operating points supported by the implementation.
        /// </summary>
        [FieldOffset(104)]
        public int MaxOperatingPoints;

        /// <summary>
        ///     <c>MinQIndex</c> indicates the minimum quantizer index value supported.
        /// </summary>
        [FieldOffset(108)]
        public int MinQIndex;

        /// <summary>
        ///     <c>MaxQIndex</c> indicates the maximum quantizer index value supported.
        /// </summary>
        [FieldOffset(112)]
        public int MaxQIndex;

        /// <summary>
        ///     <c>PrefersGopRemainingFrames</c> indicates that the implementation&apos;s rate control algorithm prefers the application to specify the number of frames in each <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-rate-control-group">AV1 rate control group^</see> <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop-remaining-frames">remaining^</see> in the current <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop">group of pictures^</see> when beginning a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-coding-scope">video coding scope^</see>.
        /// </summary>
        [FieldOffset(116)]
        public Brutal.Bool32 PrefersGopRemainingFrames;

        /// <summary>
        ///     <c>RequiresGopRemainingFrames</c> indicates that the implementation&apos;s rate control algorithm requires the application to specify the number of frames in each <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-rate-control-group">AV1 rate control group^</see> <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop-remaining-frames">remaining^</see> in the current <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-av1-gop">group of pictures^</see> when beginning a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-coding-scope">video coding scope^</see>.
        /// </summary>
        [FieldOffset(120)]
        public Brutal.Bool32 RequiresGopRemainingFrames;

        /// <summary>
        ///     <c>StdSyntaxFlags</c> is a bitmask of <c>VkVideoEncodeAV1StdFlagsKHR</c> indicating capabilities related to AV1 syntax elements.
        /// </summary>
        [FieldOffset(124)]
        public VkVideoEncodeAV1StdFlagsKHR StdSyntaxFlags;
    }
}
