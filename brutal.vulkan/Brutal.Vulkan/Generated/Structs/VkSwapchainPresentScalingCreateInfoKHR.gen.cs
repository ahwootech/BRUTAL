namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainPresentScalingCreateInfoKHR.html">VkSwapchainPresentScalingCreateInfoKHR</see> - Scaling behavior when presenting to the surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When an application presents a swapchain image with dimensions different
    ///         than those of the target surface, different behavior is possible on
    ///         different platforms per their respective specifications:
    ///     </para>
    ///     <para>
    ///         * Presentation fails and <c>VK_ERROR_OUT_OF_DATE_KHR</c> is returned
    ///         * Scaling is done and <c>VK_SUCCESS</c> or <c>VK_SUBOPTIMAL_KHR</c> is
    ///         returned
    ///         * Unspecified scaling using an arbitrary combination of stretching,
    ///         centering and/or clipping.
    ///     </para>
    ///     <para>
    ///         Applications <i>can</i> define specific behavior when creating a swapchain by
    ///         including the <c>VkSwapchainPresentScalingCreateInfoKHR</c> structure in the
    ///         <c>pNext</c> chain of the <c>VkSwapchainCreateInfoKHR</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkSwapchainPresentScalingCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain_maintenance1
    ///         typedef struct VkSwapchainPresentScalingCreateInfoKHR {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkPresentScalingFlagsKHR    scalingBehavior;
    ///             VkPresentGravityFlagsKHR    presentGravityX;
    ///             VkPresentGravityFlagsKHR    presentGravityY;
    ///         } VkSwapchainPresentScalingCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSwapchainPresentScalingCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainPresentScalingCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ScalingBehavior</c> is `0` or the scaling method to use when the dimensions of the surface and swapchain images differ.
        /// </summary>
        [FieldOffset(16)]
        public VkPresentScalingFlagsKHR ScalingBehavior;

        /// <summary>
        ///     <c>PresentGravityX</c> is `0` or the x-axis direction in which swapchain image pixels gravitate relative to the surface when <c>scalingBehavior</c> does not result in a one-to-one pixel mapping between the scaled swapchain image and the surface.
        /// </summary>
        [FieldOffset(20)]
        public VkPresentGravityFlagsKHR PresentGravityX;

        /// <summary>
        ///     <c>PresentGravityY</c> is `0` or the y-axis direction in which swapchain image pixels gravitate relative to the surface when <c>scalingBehavior</c> does not result in a one-to-one pixel mapping between the scaled swapchain image and the surface.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentGravityFlagsKHR PresentGravityY;
    }
}
