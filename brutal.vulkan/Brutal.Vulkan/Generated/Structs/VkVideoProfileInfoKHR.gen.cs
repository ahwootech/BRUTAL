namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoProfileInfoKHR.html">VkVideoProfileInfoKHR</see> - Structure specifying a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoProfileInfoKHR</c> structure is defined as follows:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoProfileInfoKHR {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkVideoCodecOperationFlagBitsKHR    videoCodecOperation;
    ///             VkVideoChromaSubsamplingFlagsKHR    chromaSubsampling;
    ///             VkVideoComponentBitDepthFlagsKHR    lumaBitDepth;
    ///             VkVideoComponentBitDepthFlagsKHR    chromaBitDepth;
    ///         } VkVideoProfileInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoProfileInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoProfileInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoCodecOperation</c> is a <c>VkVideoCodecOperationFlagsKHR</c> value specifying a video codec operation.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoCodecOperationFlagsKHR VideoCodecOperation;

        /// <summary>
        ///     <c>ChromaSubsampling</c> is a bitmask of <c>VkVideoChromaSubsamplingFlagsKHR</c> specifying video chroma subsampling information.
        /// </summary>
        [FieldOffset(20)]
        public VkVideoChromaSubsamplingFlagsKHR ChromaSubsampling;

        /// <summary>
        ///     <c>LumaBitDepth</c> is a bitmask of <c>VkVideoComponentBitDepthFlagsKHR</c> specifying video luma bit depth information.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoComponentBitDepthFlagsKHR LumaBitDepth;

        /// <summary>
        ///     <c>ChromaBitDepth</c> is a bitmask of <c>VkVideoComponentBitDepthFlagsKHR</c> specifying video chroma bit depth information.
        /// </summary>
        [FieldOffset(28)]
        public VkVideoComponentBitDepthFlagsKHR ChromaBitDepth;
    }
}
