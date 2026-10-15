namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfacePresentScalingCapabilitiesKHR.html">VkSurfacePresentScalingCapabilitiesKHR</see> - Structure describing the presentation scaling capabilities of the surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfacePresentScalingCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface_maintenance1
    ///         typedef struct VkSurfacePresentScalingCapabilitiesKHR {
    ///             VkStructureType             sType;
    ///             void*                       pNext;
    ///             VkPresentScalingFlagsKHR    supportedPresentScaling;
    ///             VkPresentGravityFlagsKHR    supportedPresentGravityX;
    ///             VkPresentGravityFlagsKHR    supportedPresentGravityY;
    ///             VkExtent2D                  minScaledImageExtent;
    ///             VkExtent2D                  maxScaledImageExtent;
    ///         } VkSurfacePresentScalingCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkSurfacePresentScalingCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfacePresentScalingCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportedPresentScaling</c> is a bitmask of <c>VkPresentScalingFlagsKHR</c> representing the scaling methods supported by the surface, or `0` if application-defined scaling is not supported.
        /// </summary>
        [FieldOffset(16)]
        public VkPresentScalingFlagsKHR SupportedPresentScaling;

        /// <summary>
        ///     <c>SupportedPresentGravityX</c> is a bitmask of <c>VkPresentGravityFlagsKHR</c> representing the X-axis pixel gravity supported by the surface, or `0` if Vulkan-defined pixel gravity is not supported for the X axis.
        /// </summary>
        [FieldOffset(20)]
        public VkPresentGravityFlagsKHR SupportedPresentGravityX;

        /// <summary>
        ///     <c>SupportedPresentGravityY</c> is a bitmask of <c>VkPresentGravityFlagsKHR</c> representing the Y-axis pixel gravity supported by the surface, or `0` if Vulkan-defined pixel gravity is not supported for the Y axis.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentGravityFlagsKHR SupportedPresentGravityY;

        /// <summary>
        ///     <c>MinScaledImageExtent</c> contains the smallest valid swapchain extent for the surface on the specified device when one of the scaling methods specified in <c>supportedPresentScaling</c> is used, or the special value <c>(0xFFFFFFFF, 0xFFFFFFFF)</c> indicating that the surface size will be determined by the extent of a swapchain targeting the surface. The <c>width</c> and <c>height</c> of the extent will each be smaller than or equal to the corresponding <c>width</c> and <c>height</c> of <c>VkSurfaceCapabilitiesKHR::minImageExtent</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkExtent2D MinScaledImageExtent;

        /// <summary>
        ///     <c>MaxScaledImageExtent</c> contains the largest valid swapchain extent for the surface on the specified device when one of the scaling methods specified in <c>supportedPresentScaling</c> is used, or the special value described above for <c>minScaledImageExtent</c>. The <c>width</c> and <c>height</c> of the extent will each be greater than or equal to the corresponding <c>width</c> and <c>height</c> of <c>VkSurfaceCapabilitiesKHR::maxImageExtent</c>.
        /// </summary>
        [FieldOffset(36)]
        public VkExtent2D MaxScaledImageExtent;
    }
}
