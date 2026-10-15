namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAllocationCallbacks.html">VkAllocationCallbacks</see> - Structure containing callback function pointers for memory allocation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Allocators are provided by the application as a pointer to a
    ///         <c>VkAllocationCallbacks</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkAllocationCallbacks {
    ///             void*                                   pUserData;
    ///             PFN_vkAllocationFunction                pfnAllocation;
    ///             PFN_vkReallocationFunction              pfnReallocation;
    ///             PFN_vkFreeFunction                      pfnFree;
    ///             PFN_vkInternalAllocationNotification    pfnInternalAllocation;
    ///             PFN_vkInternalFreeNotification          pfnInternalFree;
    ///         } VkAllocationCallbacks;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkAllocationCallbacks()
    {
        /// <summary>
        ///     <c>UserData</c>
        /// </summary>
        [FieldOffset(0)]
        public void* UserData;

        /// <summary>
        ///     <c>PfnAllocation</c>
        /// </summary>
        [FieldOffset(8)]
        public PfnVkAllocationFunction PfnAllocation;

        /// <summary>
        ///     <c>PfnReallocation</c>
        /// </summary>
        [FieldOffset(16)]
        public PfnVkReallocationFunction PfnReallocation;

        /// <summary>
        ///     <c>PfnFree</c>
        /// </summary>
        [FieldOffset(24)]
        public PfnVkFreeFunction PfnFree;

        /// <summary>
        ///     <c>PfnInternalAllocation</c>
        /// </summary>
        [FieldOffset(32)]
        public PfnVkInternalAllocationNotification PfnInternalAllocation;

        /// <summary>
        ///     <c>PfnInternalFree</c>
        /// </summary>
        [FieldOffset(40)]
        public PfnVkInternalFreeNotification PfnInternalFree;
    }
}
