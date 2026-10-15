namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfacePresentModeKHR.html">VkSurfacePresentModeKHR</see> - Structure describing present mode of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfacePresentModeKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface_maintenance1
    ///         typedef struct VkSurfacePresentModeKHR {
    ///             VkStructureType     sType;
    ///             void*               pNext;
    ///             VkPresentModeKHR    presentMode;
    ///         } VkSurfacePresentModeKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSurfacePresentModeKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfacePresentModeKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentMode</c> is the presentation mode the swapchain will use.
        /// </summary>
        [FieldOffset(16)]
        public VkPresentModeKHR PresentMode;
    }
}
