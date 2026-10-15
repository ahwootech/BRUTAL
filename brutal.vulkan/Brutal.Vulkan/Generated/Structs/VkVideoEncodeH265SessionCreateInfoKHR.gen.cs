namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionCreateInfoKHR.html">VkVideoEncodeH265SessionCreateInfoKHR</see> - Structure specifies H.265 encode session parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265SessionCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265SessionCreateInfoKHR {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkBool32                useMaxLevelIdc;
    ///             StdVideoH265LevelIdc    maxLevelIdc;
    ///         } VkVideoEncodeH265SessionCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH265SessionCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265SessionCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UseMaxLevelIdc</c> indicates whether the value of <c>maxLevelIdc</c> should be used by the implementation. When it is <c>VK_FALSE</c>, the implementation ignores the value of <c>maxLevelIdc</c> and uses the value of <c>VkVideoEncodeH265CapabilitiesKHR::maxLevelIdc</c>, as reported by <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> for the video profile.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UseMaxLevelIdc;

        /// <summary>
        ///     <c>MaxLevelIdc</c> is a <c>StdVideoH265LevelIdc</c> value specifying the upper bound on the H.265 level for the video bitstreams produced by the created video session, where enum constant `STD_VIDEO_H265_LEVEL_IDC_&lt;major&gt;_&lt;minor&gt;` identifies H.265 level `&lt;major&gt;.&lt;minor&gt;` as defined in section A.4 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#itu-t-h265">ITU-T H.265 Specification^</see>.
        /// </summary>
        [FieldOffset(20)]
        public StdVideoH265LevelIdc MaxLevelIdc;
    }
}
