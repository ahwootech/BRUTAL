namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeVP9ProfileInfoKHR.html">VkVideoDecodeVP9ProfileInfoKHR</see> - Structure specifying VP9 decode profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A video profile supporting VP9 video decode operations is specified by
    ///         setting <c>VkVideoProfileInfoKHR::videoCodecOperation</c> to
    ///         <c>VK_VIDEO_CODEC_OPERATION_DECODE_VP9_BIT_KHR</c> and adding a
    ///         <c>VkVideoDecodeVP9ProfileInfoKHR</c> structure to the
    ///         <c>VkVideoProfileInfoKHR::pNext</c> chain.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeVP9ProfileInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_vp9
    ///         typedef struct VkVideoDecodeVP9ProfileInfoKHR {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             StdVideoVP9Profile    stdProfile;
    ///         } VkVideoDecodeVP9ProfileInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeVP9ProfileInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeVP9ProfileInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdProfile</c> is a <c>StdVideoVP9Profile</c> value specifying the VP9 codec profile, as defined in section 7.2 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#google-vp9">VP9 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoVP9Profile StdProfile;
    }
}
