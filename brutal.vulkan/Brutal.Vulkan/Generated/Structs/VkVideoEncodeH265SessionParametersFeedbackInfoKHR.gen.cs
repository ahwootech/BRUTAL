namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersFeedbackInfoKHR.html">VkVideoEncodeH265SessionParametersFeedbackInfoKHR</see> - Structure providing feedback about the requested H.265 video session parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeH265SessionParametersFeedbackInfoKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_h265
    ///         typedef struct VkVideoEncodeH265SessionParametersFeedbackInfoKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           hasStdVPSOverrides;
    ///             VkBool32           hasStdSPSOverrides;
    ///             VkBool32           hasStdPPSOverrides;
    ///         } VkVideoEncodeH265SessionParametersFeedbackInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoEncodeH265SessionParametersFeedbackInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeH265SessionParametersFeedbackInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HasStdVPSOverrides</c> indicates whether any of the parameters of the requested <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-vps">H.265 video parameter set^</see>, if one was requested via <c>VkVideoEncodeH265SessionParametersGetInfoKHR::writeStdVPS</c>, were <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-overrides">overridden^</see> by the implementation.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 HasStdVPSOverrides;

        /// <summary>
        ///     <c>HasStdSPSOverrides</c> indicates whether any of the parameters of the requested <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-sps">H.265 sequence parameter set^</see>, if one was requested via <c>VkVideoEncodeH265SessionParametersGetInfoKHR::writeStdSPS</c>, were <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-overrides">overridden^</see> by the implementation.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 HasStdSPSOverrides;

        /// <summary>
        ///     <c>HasStdPPSOverrides</c> indicates whether any of the parameters of the requested <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-h265-pps">H.265 picture parameter set^</see>, if one was requested via <c>VkVideoEncodeH265SessionParametersGetInfoKHR::writeStdPPS</c>, were <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-overrides">overridden^</see> by the implementation.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 HasStdPPSOverrides;
    }
}
