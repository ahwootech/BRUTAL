namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoProfileListInfoKHR.html">VkVideoProfileListInfoKHR</see> - Structure specifying one or more video profiles used in conjunction
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoProfileListInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_queue
    ///         typedef struct VkVideoProfileListInfoKHR {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             uint32_t                        profileCount;
    ///             const VkVideoProfileInfoKHR*    pProfiles;
    ///         } VkVideoProfileListInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkVideoProfileListInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoProfileListInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ProfileCount</c> is the number of elements in the <c>pProfiles</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int ProfileCount;

        /// <summary>
        ///     <c>Profiles</c> is a pointer to an array of <c>VkVideoProfileInfoKHR</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkVideoProfileInfoKHR* Profiles;
    }
}
