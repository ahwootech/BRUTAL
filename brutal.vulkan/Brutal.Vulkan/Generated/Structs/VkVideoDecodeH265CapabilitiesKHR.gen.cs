namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265CapabilitiesKHR.html">VkVideoDecodeH265CapabilitiesKHR</see> - Structure describing H.265 decode capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities for an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-h265-profile">H.265 decode profile^</see>, the
    ///         <c>VkVideoCapabilitiesKHR::pNext</c> chain <i>must</i> include a
    ///         <c>VkVideoDecodeH265CapabilitiesKHR</c> structure that will be filled with
    ///         the profile-specific capabilities.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeH265CapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_h265
    ///         typedef struct VkVideoDecodeH265CapabilitiesKHR {
    ///             VkStructureType         sType;
    ///             void*                   pNext;
    ///             StdVideoH265LevelIdc    maxLevelIdc;
    ///         } VkVideoDecodeH265CapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeH265CapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeH265CapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxLevelIdc</c> is a <c>StdVideoH265LevelIdc</c> value indicating the maximum H.265 level supported by the profile, where enum constant `STD_VIDEO_H265_LEVEL_IDC_&lt;major&gt;_&lt;minor&gt;` identifies H.265 level `&lt;major&gt;.&lt;minor&gt;` as defined in section A.4 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoH265LevelIdc MaxLevelIdc;
    }
}
