namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentRegionsKHR.html">VkPresentRegionsKHR</see> - Structure hint of rectangular regions changed by vkQueuePresentKHR
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When the `<c>VK_KHR_incremental_present</c>` extension is enabled,
    ///         additional fields <i>can</i> be specified that allow an application to specify
    ///         that only certain rectangular regions of the presentable images of a
    ///         swapchain are changed.
    ///         This is an optimization hint that a presentation engine may: use to only
    ///         update the region of a surface that is actually changing.
    ///         The application still <i>must</i> ensure that all pixels of a presented image
    ///         contain the desired values, in case the presentation engine ignores this
    ///         hint.
    ///         An application <i>can</i> provide this hint by adding a <c>VkPresentRegionsKHR</c>
    ///         structure to the <c>pNext</c> chain of the <c>VkPresentInfoKHR</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkPresentRegionsKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_incremental_present
    ///         typedef struct VkPresentRegionsKHR {
    ///             VkStructureType              sType;
    ///             const void*                  pNext;
    ///             uint32_t                     swapchainCount;
    ///             const VkPresentRegionKHR*    pRegions;
    ///         } VkPresentRegionsKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPresentRegionsKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PresentRegionsKHR;

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
        ///     <c>Regions</c> is `NULL` or a pointer to an array of <c>VkPresentRegionKHR</c> elements with <c>swapchainCount</c> entries. If not `NULL`, each element of <c>pRegions</c> contains the region that has changed since the last present to the swapchain in the corresponding entry in the <c>VkPresentInfoKHR::pSwapchains</c> array.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentRegionKHR* Regions;
    }
}
