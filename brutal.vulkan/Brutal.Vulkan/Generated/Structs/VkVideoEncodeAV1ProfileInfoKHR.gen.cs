namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1ProfileInfoKHR.html">VkVideoEncodeAV1ProfileInfoKHR</see> - Structure specifying AV1 encode-specific video profile parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A video profile supporting AV1 video encode operations is specified by
    ///         setting <c>VkVideoProfileInfoKHR::videoCodecOperation</c> to
    ///         <c>VK_VIDEO_CODEC_OPERATION_ENCODE_AV1_BIT_KHR</c> and adding a
    ///         <c>VkVideoEncodeAV1ProfileInfoKHR</c> structure to the
    ///         <c>VkVideoProfileInfoKHR::pNext</c> chain.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1ProfileInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1ProfileInfoKHR {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             StdVideoAV1Profile    stdProfile;
    ///         } VkVideoEncodeAV1ProfileInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeAV1ProfileInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1ProfileInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>StdProfile</c> is a <c>StdVideoAV1Profile</c> value specifying the AV1 codec profile, as defined in section A.2 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoAV1Profile StdProfile;
    }
}
