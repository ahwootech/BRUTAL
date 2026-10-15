namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceFormat2KHR.html">VkSurfaceFormat2KHR</see> - Structure describing a supported swapchain format tuple
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceFormat2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_get_surface_capabilities2
    ///         typedef struct VkSurfaceFormat2KHR {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkSurfaceFormatKHR    surfaceFormat;
    ///         } VkSurfaceFormat2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSurfaceFormat2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceFormat2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SurfaceFormat</c> is a <c>VkSurfaceFormatKHR</c> structure describing a format-color space pair that is compatible with the specified surface.
        /// </summary>
        [FieldOffset(16)]
        public VkSurfaceFormatKHR SurfaceFormat;
    }
}
