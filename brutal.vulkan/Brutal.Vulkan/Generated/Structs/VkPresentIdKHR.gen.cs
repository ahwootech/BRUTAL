namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentIdKHR.html">VkPresentIdKHR</see> - The list of presentation identifiers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPresentIdKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_present_id
    ///         typedef struct VkPresentIdKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           swapchainCount;
    ///             const uint64_t*    pPresentIds;
    ///         } VkPresentIdKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPresentIdKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PresentIdKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SwapchainCount</c> is the number of swapchains being presented to the <c>vkQueuePresentKHR</c> command.
        /// </summary>
        [FieldOffset(16)]
        public int SwapchainCount;

        /// <summary>
        ///     <c>PresentIds</c> is `NULL` or a pointer to an array of <c>uint64_t</c> with <c>swapchainCount</c> entries. If not `NULL`, each non-zero value in <c>pPresentIds</c> specifies the present id to be associated with the presentation of the swapchain with the same index in the <c>vkQueuePresentKHR</c> call.
        /// </summary>
        [FieldOffset(24)]
        public nint* PresentIds;
    }
}
