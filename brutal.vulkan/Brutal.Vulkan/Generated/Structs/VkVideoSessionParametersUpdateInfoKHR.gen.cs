namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersUpdateInfoKHR.html">VkVideoSessionParametersUpdateInfoKHR</see> - Structure specifying video session parameters update information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoSessionParametersUpdateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoSessionParametersUpdateInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           updateSequenceCount;
    ///         } VkVideoSessionParametersUpdateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoSessionParametersUpdateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoSessionParametersUpdateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UpdateSequenceCount</c> is the new <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#video-session-parameters">update sequence count^</see> to set for the video session parameters object.
        /// </summary>
        [FieldOffset(16)]
        public int UpdateSequenceCount;
    }
}
