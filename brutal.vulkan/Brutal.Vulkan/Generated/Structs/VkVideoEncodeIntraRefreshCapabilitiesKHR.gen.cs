namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeIntraRefreshCapabilitiesKHR.html">VkVideoEncodeIntraRefreshCapabilitiesKHR</see> - Structure describing video encode intra refresh capabilities for a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> with
    ///         <c>pVideoProfile</c>-&gt;videoCodecOperation specifying an encode operation, the
    ///         <c>VkVideoEncodeIntraRefreshCapabilitiesKHR</c> structure <i>can</i> be included in
    ///         the <c>pNext</c> chain of the <c>VkVideoCapabilitiesKHR</c> structure to
    ///         retrieve capabilities specific to video encode intra refresh.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeIntraRefreshCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_intra_refresh
    ///         typedef struct VkVideoEncodeIntraRefreshCapabilitiesKHR {
    ///             VkStructureType                          sType;
    ///             void*                                    pNext;
    ///             VkVideoEncodeIntraRefreshModeFlagsKHR    intraRefreshModes;
    ///             uint32_t                                 maxIntraRefreshCycleDuration;
    ///             uint32_t                                 maxIntraRefreshActiveReferencePictures;
    ///             VkBool32                                 partitionIndependentIntraRefreshRegions;
    ///             VkBool32                                 nonRectangularIntraRefreshRegions;
    ///         } VkVideoEncodeIntraRefreshCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoEncodeIntraRefreshCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeIntraRefreshCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IntraRefreshModes</c> is a bitmask of <c>VkVideoEncodeIntraRefreshModeFlagsKHR</c> values indicating the set of supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-intra-refresh-modes">intra refresh modes^</see>.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeIntraRefreshModeFlagsKHR IntraRefreshModes;

        /// <summary>
        ///     <c>MaxIntraRefreshCycleDuration</c> specifies the maximum supported <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-intra-refresh-cycle-duration">intra refresh cycle duration^</see>.
        /// </summary>
        [FieldOffset(20)]
        public int MaxIntraRefreshCycleDuration;

        /// <summary>
        ///     <c>MaxIntraRefreshActiveReferencePictures</c> is the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#active-reference-pictures">active reference pictures^</see> when encoding pictures with <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-intra-refresh">intra refresh^</see> enabled. This capability indicates additional restrictions beyond the maximum number of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#active-reference-pictures">active reference pictures^</see> supported by the video profile, as reported in <c>VkVideoCapabilitiesKHR::maxActiveReferencePictures</c> and the maximum requested at video session creation time in <c>VkVideoSessionCreateInfoKHR::maxActiveReferencePictures</c>.
        /// </summary>
        [FieldOffset(24)]
        public int MaxIntraRefreshActiveReferencePictures;

        /// <summary>
        ///     <c>PartitionIndependentIntraRefreshRegions</c> specifies whether the implementation supports intra refresh regions that are independent of the picture partitioning used during encoding. If it is <c>VK_TRUE</c>, then pictures <i>can</i> be encoded with multiple picture partitions, independent of the used intra refresh mode. Otherwise, pictures cannot: be encoded with multiple picture partitions with any intra refresh mode other than <c>VK_VIDEO_ENCODE_INTRA_REFRESH_MODE_PER_PICTURE_PARTITION_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 PartitionIndependentIntraRefreshRegions;

        /// <summary>
        ///     <c>NonRectangularIntraRefreshRegions</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 NonRectangularIntraRefreshRegions;
    }
}
