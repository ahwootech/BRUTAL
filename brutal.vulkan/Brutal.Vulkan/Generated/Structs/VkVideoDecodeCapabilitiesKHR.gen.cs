namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeCapabilitiesKHR.html">VkVideoDecodeCapabilitiesKHR</see> - Structure describing general video decode capabilities for a video profile
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When calling <c>vkGetPhysicalDeviceVideoCapabilitiesKHR</c> with
    ///         <c>pVideoProfile</c>-&gt;videoCodecOperation specifying a decode operation, the
    ///         <c>VkVideoDecodeCapabilitiesKHR</c> structure <i>must</i> be included in the
    ///         <c>pNext</c> chain of the <c>VkVideoCapabilitiesKHR</c> structure to retrieve
    ///         capabilities specific to video decoding.
    ///     </para>
    ///     <para>
    ///         The <c>VkVideoDecodeCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_video_decode_queue
    ///         typedef struct VkVideoDecodeCapabilitiesKHR {
    ///             VkStructureType                    sType;
    ///             void*                              pNext;
    ///             VkVideoDecodeCapabilityFlagsKHR    flags;
    ///         } VkVideoDecodeCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkVideoDecodeCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.VideoDecodeCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkVideoDecodeCapabilityFlagsKHR</c> describing the supported video decoding capabilities.
        /// </summary>
        [FieldOffset(16)]
        public VkVideoDecodeCapabilityFlagsKHR Flags;
    }
}
