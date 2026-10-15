namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1ProfileInfoKHR.html">VkVideoDecodeAV1ProfileInfoKHR</see> - Structure specifying AV1 decode profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A video profile supporting AV1 video decode operations is specified by
    ///         setting <c>VkVideoProfileInfoKHR::videoCodecOperation</c> to
    ///         <c>VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR</c> and adding a
    ///         <c>VkVideoDecodeAV1ProfileInfoKHR</c> structure to the
    ///         <c>VkVideoProfileInfoKHR::pNext</c> chain.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeAV1ProfileInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_av1
    ///         typedef struct VkVideoDecodeAV1ProfileInfoKHR {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             StdVideoAV1Profile    stdProfile;
    ///             VkBool32              filmGrainSupport;
    ///         } VkVideoDecodeAV1ProfileInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeAV1ProfileInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeAV1ProfileInfoKHR;

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

        /// <summary>
        ///     <c>FilmGrainSupport</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 FilmGrainSupport;
    }
}
