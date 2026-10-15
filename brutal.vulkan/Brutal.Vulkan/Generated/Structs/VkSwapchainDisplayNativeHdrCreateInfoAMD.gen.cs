namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainDisplayNativeHdrCreateInfoAMD.html">VkSwapchainDisplayNativeHdrCreateInfoAMD</see> - Structure specifying display native HDR parameters of a newly created swapchain object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkSwapchainCreateInfoKHR</c> includes a
    ///         <c>VkSwapchainDisplayNativeHdrCreateInfoAMD</c> structure, then that
    ///         structure includes additional swapchain creation parameters specific to
    ///         display native HDR support.
    ///     </para>
    ///     <para>
    ///         The <c>VkSwapchainDisplayNativeHdrCreateInfoAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_display_native_hdr
    ///         typedef struct VkSwapchainDisplayNativeHdrCreateInfoAMD {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           localDimmingEnable;
    ///         } VkSwapchainDisplayNativeHdrCreateInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainDisplayNativeHdrCreateInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LocalDimmingEnable</c> specifies whether local dimming is enabled for the swapchain.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 LocalDimmingEnable;
    }
}
