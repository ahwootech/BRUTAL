namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeSessionParametersFeedbackInfoKHR.html">VkVideoEncodeSessionParametersFeedbackInfoKHR</see> - Structure providing feedback about the requested video session parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeSessionParametersFeedbackInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeSessionParametersFeedbackInfoKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           hasOverrides;
    ///         } VkVideoEncodeSessionParametersFeedbackInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeSessionParametersFeedbackInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeSessionParametersFeedbackInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HasOverrides</c> indicates whether any of the requested parameter data were <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-overrides">overridden^</see> by the implementation.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 HasOverrides;
    }
}
