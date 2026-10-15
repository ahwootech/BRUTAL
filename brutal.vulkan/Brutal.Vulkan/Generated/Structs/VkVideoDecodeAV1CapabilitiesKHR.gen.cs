namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1CapabilitiesKHR.html">VkVideoDecodeAV1CapabilitiesKHR</see> - Structure describing AV1 decode capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities for an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-av1-profile">AV1 decode profile^</see>, the
    ///         <c>VkVideoCapabilitiesKHR::pNext</c> chain <i>must</i> include a
    ///         <c>VkVideoDecodeAV1CapabilitiesKHR</c> structure that will be filled with the
    ///         profile-specific capabilities.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeAV1CapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_av1
    ///         typedef struct VkVideoDecodeAV1CapabilitiesKHR {
    ///             VkStructureType     sType;
    ///             void*               pNext;
    ///             StdVideoAV1Level    maxLevel;
    ///         } VkVideoDecodeAV1CapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeAV1CapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeAV1CapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxLevel</c> is a <c>StdVideoAV1Level</c> value specifying the maximum AV1 level supported by the profile, as defined in section A.3 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#aomedia-av1">AV1 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoAV1Level MaxLevel;
    }
}
