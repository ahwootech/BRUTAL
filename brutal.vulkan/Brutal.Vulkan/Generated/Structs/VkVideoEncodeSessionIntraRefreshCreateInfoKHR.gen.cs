namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeSessionIntraRefreshCreateInfoKHR.html">VkVideoEncodeSessionIntraRefreshCreateInfoKHR</see> - Video encode session intra refresh parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeSessionIntraRefreshCreateInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_intra_refresh
    ///         typedef struct VkVideoEncodeSessionIntraRefreshCreateInfoKHR {
    ///             VkStructureType                             sType;
    ///             const void*                                 pNext;
    ///             VkVideoEncodeIntraRefreshModeFlagBitsKHR    intraRefreshMode;
    ///         } VkVideoEncodeSessionIntraRefreshCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeSessionIntraRefreshCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeSessionIntraRefreshCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IntraRefreshMode</c> is a <c>VkVideoEncodeIntraRefreshModeFlagsKHR</c> specifying the used <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#encode-intra-refresh-modes">intra refresh mode^</see>.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoEncodeIntraRefreshModeFlagsKHR IntraRefreshMode;
    }
}
