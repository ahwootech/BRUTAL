namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeSessionParametersGetInfoKHR.html">VkVideoEncodeSessionParametersGetInfoKHR</see> - Structure specifying parameters for retrieving encoded video session parameter data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeSessionParametersGetInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_queue
    ///         typedef struct VkVideoEncodeSessionParametersGetInfoKHR {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkVideoSessionParametersKHR    videoSessionParameters;
    ///         } VkVideoEncodeSessionParametersGetInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeSessionParametersGetInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeSessionParametersGetInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoSessionParameters</c> is the <c>VkVideoSessionParametersKHR</c> object to retrieve encoded parameter data from.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoSessionParametersKHR VideoSessionParameters;
    }
}
