namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeVP9CapabilitiesKHR.html">VkVideoDecodeVP9CapabilitiesKHR</see> - Structure describing VP9 decode capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> to query the
    ///         capabilities for an <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#decode-vp9-profile">VP9 decode profile^</see>, the
    ///         <c>VkVideoCapabilitiesKHR::pNext</c> chain <i>must</i> include a
    ///         <c>VkVideoDecodeVP9CapabilitiesKHR</c> structure that will be filled with the
    ///         profile-specific capabilities.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeVP9CapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_vp9
    ///         typedef struct VkVideoDecodeVP9CapabilitiesKHR {
    ///             VkStructureType     sType;
    ///             void*               pNext;
    ///             StdVideoVP9Level    maxLevel;
    ///         } VkVideoDecodeVP9CapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeVP9CapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeVP9CapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxLevel</c> is a <c>StdVideoVP9Level</c> value specifying the maximum VP9 level supported by the profile, as defined in section A.1 of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#google-vp9">VP9 Specification^</see>.
        /// </summary>
        [FieldOffset(16)]
        public StdVideoVP9Level MaxLevel;
    }
}
