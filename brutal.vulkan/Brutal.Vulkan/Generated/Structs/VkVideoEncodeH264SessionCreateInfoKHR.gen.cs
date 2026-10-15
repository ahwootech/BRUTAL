namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionCreateInfoKHR.html">VkVideoEncodeH264SessionCreateInfoKHR</see> - Structure specifies H.264 encode session parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264SessionCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264SessionCreateInfoKHR {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkBool32                useMaxLevelIdc;
    ///             StdVideoH264LevelIdc    maxLevelIdc;
    ///         } VkVideoEncodeH264SessionCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH264SessionCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264SessionCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UseMaxLevelIdc</c> indicates whether the value of <c>maxLevelIdc</c> should be used by the implementation. When it is <c>VK_FALSE</c>, the implementation ignores the value of <c>maxLevelIdc</c> and uses the value of <c>VkVideoEncodeH264CapabilitiesKHR::maxLevelIdc</c>, as reported by <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> for the video profile.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UseMaxLevelIdc;

        /// <summary>
        ///     <c>MaxLevelIdc</c> is a <c>StdVideoH264LevelIdc</c> value specifying the upper bound on the H.264 level for the video bitstreams produced by the created video session, where enum constant `STD_VIDEO_H264_LEVEL_IDC_&lt;major&gt;_&lt;minor&gt;` identifies H.264 level `&lt;major&gt;.&lt;minor&gt;` as defined in section A.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h264">ITU-T H.264 Specification^</see>.
        /// </summary>
        [FieldOffset(20)]
        public StdVideoH264LevelIdc MaxLevelIdc;
    }
}
