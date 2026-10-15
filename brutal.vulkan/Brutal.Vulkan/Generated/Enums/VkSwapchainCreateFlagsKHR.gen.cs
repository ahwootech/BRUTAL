namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainCreateFlagBitsKHR.html">VkSwapchainCreateFlagBitsKHR</see> - Bitmask controlling swapchain creation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkSwapchainCreateInfoKHR::flags</c>,
    ///         specifying parameters of swapchain creation, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain
    ///         typedef enum VkSwapchainCreateFlagBitsKHR {
    ///             // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///             VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = 0x00000001,
    ///             // Provided by VK_VERSION_1_1 with VK_KHR_swapchain
    ///             VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR = 0x00000002,
    ///             // Provided by VK_KHR_swapchain_mutable_format
    ///             VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR = 0x00000004,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_SWAPCHAIN_CREATE_PRESENT_TIMING_BIT_EXT = 0x00000200,
    ///             // Provided by VK_KHR_present_id2
    ///             VK_SWAPCHAIN_CREATE_PRESENT_ID_2_BIT_KHR = 0x00000040,
    ///             // Provided by VK_KHR_present_wait2
    ///             VK_SWAPCHAIN_CREATE_PRESENT_WAIT_2_BIT_KHR = 0x00000080,
    ///             // Provided by VK_KHR_swapchain_maintenance1
    ///             VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_KHR = 0x00000008,
    ///             // Provided by VK_EXT_multisampled_render_to_swapchain
    ///             VK_SWAPCHAIN_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT = 0x00000100,
    ///             // Provided by VK_EXT_swapchain_maintenance1
    ///             VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT = VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_KHR,
    ///         } VkSwapchainCreateFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkSwapchainCreateFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SplitInstanceBindRegionsBitKHR</c>
        /// </summary>
        SplitInstanceBindRegionsBitKHR = 0x00000001,

        /// <summary>
        ///     <c>ProtectedBitKHR</c>
        /// </summary>
        ProtectedBitKHR = 0x00000002,

        /// <summary>
        ///     <c>MutableFormatBitKHR</c>
        /// </summary>
        MutableFormatBitKHR = 0x00000004,

        /// <summary>
        ///     <c>PresentTimingBitEXT</c>
        /// </summary>
        PresentTimingBitEXT = 0x00000200,

        /// <summary>
        ///     <c>PresentId2BitKHR</c>
        /// </summary>
        PresentId2BitKHR = 0x00000040,

        /// <summary>
        ///     <c>PresentWait2BitKHR</c>
        /// </summary>
        PresentWait2BitKHR = 0x00000080,

        /// <summary>
        ///     <c>DeferredMemoryAllocationBitKHR</c>
        /// </summary>
        DeferredMemoryAllocationBitKHR = 0x00000008,

        /// <summary>
        ///     <c>MultisampledRenderToSingleSampledBitEXT</c>
        /// </summary>
        MultisampledRenderToSingleSampledBitEXT = 0x00000100,

        /// <summary>
        ///     <c>DeferredMemoryAllocationBitEXT</c>
        /// </summary>
        DeferredMemoryAllocationBitEXT = DeferredMemoryAllocationBitKHR,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
