namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersGetInfoKHR.html">VkVideoEncodeH264SessionParametersGetInfoKHR</see> - Structure specifying parameters for retrieving encoded H.264 parameter set data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264SessionParametersGetInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264SessionParametersGetInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           writeStdSPS;
    ///             VkBool32           writeStdPPS;
    ///             uint32_t           stdSPSId;
    ///             uint32_t           stdPPSId;
    ///         } VkVideoEncodeH264SessionParametersGetInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeH264SessionParametersGetInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264SessionParametersGetInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WriteStdSPS</c> indicates whether the encoded <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-sps">H.264 sequence parameter set^</see> identified by <c>stdSPSId</c> is requested to be retrieved.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 WriteStdSPS;

        /// <summary>
        ///     <c>WriteStdPPS</c> indicates whether the encoded <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">H.264 picture parameter set^</see> identified by the pair constructed from <c>stdSPSId</c> and <c>stdPPSId</c> is requested to be retrieved.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 WriteStdPPS;

        /// <summary>
        ///     <c>StdSPSId</c> specifies the H.264 sequence parameter set ID used to identify the retrieved H.264 sequence and/or picture parameter set(s).
        /// </summary>
        [FieldOffset(24)]
        public int StdSPSId;

        /// <summary>
        ///     <c>StdPPSId</c> specifies the H.264 picture parameter set ID used to identify the retrieved H.264 picture parameter set when <c>writeStdPPS</c> is <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(28)]
        public int StdPPSId;
    }
}
