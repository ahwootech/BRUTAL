namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersFeedbackInfoKHR.html">VkVideoEncodeH264SessionParametersFeedbackInfoKHR</see> - Structure providing feedback about the requested H.264 video session parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH264SessionParametersFeedbackInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h264
    ///         typedef struct VkVideoEncodeH264SessionParametersFeedbackInfoKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           hasStdSPSOverrides;
    ///             VkBool32           hasStdPPSOverrides;
    ///         } VkVideoEncodeH264SessionParametersFeedbackInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeH264SessionParametersFeedbackInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH264SessionParametersFeedbackInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HasStdSPSOverrides</c> indicates whether any of the parameters of the requested <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-sps">H.264 sequence parameter set^</see>, if one was requested via <c>VkVideoEncodeH264SessionParametersGetInfoKHR::writeStdSPS</c>, were <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-overrides">overridden^</see> by the implementation.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 HasStdSPSOverrides;

        /// <summary>
        ///     <c>HasStdPPSOverrides</c> indicates whether any of the parameters of the requested <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h264-pps">H.264 picture parameter set^</see>, if one was requested via <c>VkVideoEncodeH264SessionParametersGetInfoKHR::writeStdPPS</c>, were <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-overrides">overridden^</see> by the implementation.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 HasStdPPSOverrides;
    }
}
