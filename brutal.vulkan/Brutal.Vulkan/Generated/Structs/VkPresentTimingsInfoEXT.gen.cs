namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentTimingsInfoEXT.html">VkPresentTimingsInfoEXT</see> - Array of VkPresentTimingInfoEXT to chain with VkPresentInfoKHR
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-presentAtAbsoluteTime"><c>presentAtAbsoluteTime</c>^</see> or
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-presentAtRelativeTime"><c>presentAtRelativeTime</c>^</see> feature is
    ///         enabled, an application <i>can</i> instruct the presentation engine to attempt to
    ///         display an image at a specified time, or for a minimum duration, by
    ///         including the <c>VkPresentTimingsInfoEXT</c> structure in the <c>pNext</c>
    ///         chain of the <c>VkPresentInfoKHR</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkPresentTimingsInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkPresentTimingsInfoEXT {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             uint32_t                         swapchainCount;
    ///             const VkPresentTimingInfoEXT*    pTimingInfos;
    ///         } VkPresentTimingsInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPresentTimingsInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PresentTimingsInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SwapchainCount</c> is the number of swapchains being presented to by this command.
        /// </summary>
        [FieldOffset(16)]
        public int SwapchainCount;

        /// <summary>
        ///     <c>TimingInfos</c> is `NULL` or a pointer to an array of <c>VkPresentTimingInfoEXT</c> elements with <c>swapchainCount</c> entries. If not `NULL`, each element of <c>pTimingInfos</c> contains timing information for the presentation of the image corresponding to the entry in the <c>VkPresentInfoKHR::pImageIndices</c> array.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentTimingInfoEXT* TimingInfos;
    }
}
