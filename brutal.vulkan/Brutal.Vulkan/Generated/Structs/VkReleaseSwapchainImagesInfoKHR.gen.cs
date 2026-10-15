namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkReleaseSwapchainImagesInfoKHR.html">VkReleaseSwapchainImagesInfoKHR</see> - Structure describing a list of swapchain image indices to be released
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkReleaseSwapchainImagesInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain_maintenance1
    ///         typedef struct VkReleaseSwapchainImagesInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSwapchainKHR     swapchain;
    ///             uint32_t           imageIndexCount;
    ///             const uint32_t*    pImageIndices;
    ///         } VkReleaseSwapchainImagesInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkReleaseSwapchainImagesInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ReleaseSwapchainImagesInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Swapchain</c> is a swapchain to which images are being released.
        /// </summary>
        [FieldOffset(16)]
        public VkSwapchainKHR Swapchain;

        /// <summary>
        ///     <c>ImageIndexCount</c> is the number of image indices to be released.
        /// </summary>
        [FieldOffset(24)]
        public int ImageIndexCount;

        /// <summary>
        ///     <c>ImageIndices</c> is a pointer to an array of indices into the array of <c>swapchain</c>&apos;s presentable images, with <c>imageIndexCount</c> entries.
        /// </summary>
        [FieldOffset(32)]
        public int* ImageIndices;
    }
}
