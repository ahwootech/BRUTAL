namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentTimesInfoGOOGLE.html">VkPresentTimesInfoGOOGLE</see> - The earliest time each image should be presented
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When the `<c>VK_GOOGLE_display_timing</c>` extension is enabled, additional
    ///         fields <i>can</i> be specified that allow an application to specify the earliest
    ///         time that an image should be displayed.
    ///         This allows an application to avoid stutter that is caused by an image being
    ///         displayed earlier than planned.
    ///         Such stuttering can occur with both fixed and variable-refresh-rate
    ///         displays, because stuttering occurs when the geometry is not correctly
    ///         positioned for when the image is displayed.
    ///         An application <i>can</i> instruct the presentation engine that an image should
    ///         not be displayed earlier than a specified time by adding a
    ///         <c>VkPresentTimesInfoGOOGLE</c> structure to the <c>pNext</c> chain of the
    ///         <c>VkPresentInfoKHR</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkPresentTimesInfoGOOGLE</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_GOOGLE_display_timing
    ///         typedef struct VkPresentTimesInfoGOOGLE {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             uint32_t                      swapchainCount;
    ///             const VkPresentTimeGOOGLE*    pTimes;
    ///         } VkPresentTimesInfoGOOGLE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPresentTimesInfoGOOGLE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PresentTimesInfoGOOGLE;

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
        ///     <c>Times</c> is `NULL` or a pointer to an array of <c>VkPresentTimeGOOGLE</c> elements with <c>swapchainCount</c> entries. If not `NULL`, each element of <c>pTimes</c> contains the earliest time to present the image corresponding to the entry in the <c>VkPresentInfoKHR::pImageIndices</c> array.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentTimeGOOGLE* Times;
    }
}
