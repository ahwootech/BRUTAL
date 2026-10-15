namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentBarrierCreateInfoNV.html">VkSwapchainPresentBarrierCreateInfoNV</see> - specify the present barrier membership of this swapchain
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSwapchainPresentBarrierCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_present_barrier
    ///         typedef struct VkSwapchainPresentBarrierCreateInfoNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           presentBarrierEnable;
    ///         } VkSwapchainPresentBarrierCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSwapchainPresentBarrierCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainPresentBarrierCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentBarrierEnable</c> is a boolean value indicating a request for using the <i>present barrier</i>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PresentBarrierEnable;
    }
}
