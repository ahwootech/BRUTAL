namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoSessionParametersCreateInfoKHR.html">VkVideoSessionParametersCreateInfoKHR</see> - Structure specifying parameters of a newly created video session parameters object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoSessionParametersCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoSessionParametersCreateInfoKHR {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             VkVideoSessionParametersCreateFlagsKHR    flags;
    ///             VkVideoSessionParametersKHR               videoSessionParametersTemplate;
    ///             VkVideoSessionKHR                         videoSession;
    ///         } VkVideoSessionParametersCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkVideoSessionParametersCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoSessionParametersCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoSessionParametersCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>VideoSessionParametersTemplate</c> is <c>VK_NULL_HANDLE</c> or a valid handle to a <c>VkVideoSessionParametersKHR</c> object used as a template for constructing the new video session parameters object.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoSessionParametersKHR VideoSessionParametersTemplate;

        /// <summary>
        ///     <c>VideoSession</c> is the video session object against which the video session parameters object is going to be created.
        /// </summary>
        [FieldOffset(32)]
        public VkVideoSessionKHR VideoSession;
    }
}
