namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264CapabilitiesKHR.html">VkVideoDecodeH264CapabilitiesKHR</see> - Structure describing H.264 decode capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities for an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h264-profile">H.264 decode profile^</see>, the
    ///         <c>VkVideoCapabilitiesKHR::pNext</c> chain <i>must</i> include a
    ///         <c>VkVideoDecodeH264CapabilitiesKHR</c> structure that will be filled with
    ///         the profile-specific capabilities.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeH264CapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h264
    ///         typedef struct VkVideoDecodeH264CapabilitiesKHR {
    ///             VkStructureType         sType;
    ///             void*                   pNext;
    ///             StdVideoH264LevelIdc    maxLevelIdc;
    ///             VkOffset2D              fieldOffsetGranularity;
    ///         } VkVideoDecodeH264CapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoDecodeH264CapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH264CapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxLevelIdc</c> is a <c>StdVideoH264LevelIdc</c> value indicating the maximum H.264 level supported by the profile, where enum constant `STD_VIDEO_H264_LEVEL_IDC_&lt;major&gt;_&lt;minor&gt;` identifies H.264 level `&lt;major&gt;.&lt;minor&gt;` as defined in section A.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoH264LevelIdc MaxLevelIdc;

        /// <summary>
        ///     <c>FieldOffsetGranularity</c> is the minimum alignment for <c>VkVideoPictureResourceInfoKHR::codedOffset</c> specified for a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-picture-resources">video picture resource^</see> when using the picture layout <c>VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkOffset2D FieldOffsetGranularity;
    }
}
