namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoCodingControlInfoKHR.html">VkVideoCodingControlInfoKHR</see> - Structure specifying video coding control parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoCodingControlInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoCodingControlInfoKHR {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkVideoCodingControlFlagsKHR    flags;
    ///         } VkVideoCodingControlInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoCodingControlInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoCodingControlInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoCodingControlFlagsKHR</c> specifying control flags.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoCodingControlFlagsKHR Flags;
    }
}
