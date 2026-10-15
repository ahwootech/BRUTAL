namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SessionCreateInfoKHR.html">VkVideoEncodeAV1SessionCreateInfoKHR</see> - Structure specifies AV1 encode session parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkVideoEncodeAV1SessionCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_encode_av1
    ///         typedef struct VkVideoEncodeAV1SessionCreateInfoKHR {
    ///             VkStructureType     sType;
    ///             const void*         pNext;
    ///             VkBool32            useMaxLevel;
    ///             StdVideoAV1Level    maxLevel;
    ///         } VkVideoEncodeAV1SessionCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoEncodeAV1SessionCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoEncodeAV1SessionCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UseMaxLevel</c> indicates whether the value of <c>maxLevel</c> should be used by the implementation. When it is set to <c>VK_FALSE</c>, the implementation ignores the value of <c>maxLevel</c> and uses the value of <c>VkVideoEncodeAV1CapabilitiesKHR::maxLevel</c>, as reported by <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> for the video profile.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UseMaxLevel;

        /// <summary>
        ///     <c>MaxLevel</c> is a <c>StdVideoAV1Level</c> value specifying the upper bound on the AV1 level for the video bitstreams produced by the created video session.
        /// </summary>
        [FieldOffset(20)]
        public StdVideoAV1Level MaxLevel;
    }
}
