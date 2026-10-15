namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersGetInfoKHR.html">VkVideoEncodeH265SessionParametersGetInfoKHR</see> - Structure specifying parameters for retrieving encoded H.265 parameter set data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265SessionParametersGetInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265SessionParametersGetInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           writeStdVPS;
    ///             VkBool32           writeStdSPS;
    ///             VkBool32           writeStdPPS;
    ///             uint32_t           stdVPSId;
    ///             uint32_t           stdSPSId;
    ///             uint32_t           stdPPSId;
    ///         } VkVideoEncodeH265SessionParametersGetInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoEncodeH265SessionParametersGetInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265SessionParametersGetInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WriteStdVPS</c> indicates whether the encoded <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-vps">H.265 video parameter set^</see> identified by <c>stdVPSId</c> is requested to be retrieved.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 WriteStdVPS;

        /// <summary>
        ///     <c>WriteStdSPS</c> indicates whether the encoded <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-sps">H.265 sequence parameter set^</see> identified by the pair constructed from <c>stdVPSId</c> and <c>stdSPSId</c> is requested to be retrieved.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 WriteStdSPS;

        /// <summary>
        ///     <c>WriteStdPPS</c> indicates whether the encoded <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">H.265 picture parameter set^</see> identified by the triplet constructed from <c>stdVPSId</c>, <c>stdSPSId</c>, and <c>stdPPSId</c> is requested to be retrieved.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 WriteStdPPS;

        /// <summary>
        ///     <c>StdVPSId</c> specifies the H.265 video parameter set ID used to identify the retrieved H.265 video, sequence, and/or picture parameter set(s).
        /// </summary>
        [FieldOffset(28)]
        public int StdVPSId;

        /// <summary>
        ///     <c>StdSPSId</c> specifies the H.265 sequence parameter set ID used to identify the retrieved H.265 sequence and/or picture parameter set(s) when <c>writeStdSPS</c> and/or <c>writeStdPPS</c> is <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(32)]
        public int StdSPSId;

        /// <summary>
        ///     <c>StdPPSId</c> specifies the H.265 picture parameter set ID used to identify the retrieved H.265 picture parameter set when <c>writeStdPPS</c> is <c>VK_TRUE</c>.
        /// </summary>
        [FieldOffset(36)]
        public int StdPPSId;
    }
}
