namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainTimeDomainPropertiesEXT.html">VkSwapchainTimeDomainPropertiesEXT</see> - List of available time domains for a swapchain
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSwapchainTimeDomainPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_present_timing
    ///         typedef struct VkSwapchainTimeDomainPropertiesEXT {
    ///             VkStructureType     sType;
    ///             void*               pNext;
    ///             uint32_t            timeDomainCount;
    ///             VkTimeDomainKHR*    pTimeDomains;
    ///             uint64_t*           pTimeDomainIds;
    ///         } VkSwapchainTimeDomainPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkSwapchainTimeDomainPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainTimeDomainPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TimeDomainCount</c> is an integer related to the number of time domains available or queried, as described below.
        /// </summary>
        [FieldOffset(16)]
        public int TimeDomainCount;

        /// <summary>
        ///     <c>TimeDomains</c> is a pointer to an array of <c>VkTimeDomainKHR</c> values representing time domains that are available for the swapchain.
        /// </summary>
        [FieldOffset(24)]
        public VkTimeDomainKHR* TimeDomains;

        /// <summary>
        ///     <c>TimeDomainIds</c> is a pointer to an array of unique identifiers for each time domain.
        /// </summary>
        [FieldOffset(32)]
        public nint* TimeDomainIds;
    }
}
