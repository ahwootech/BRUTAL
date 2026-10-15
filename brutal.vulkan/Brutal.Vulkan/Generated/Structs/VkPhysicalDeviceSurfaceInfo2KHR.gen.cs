namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSurfaceInfo2KHR.html">VkPhysicalDeviceSurfaceInfo2KHR</see> - Structure specifying a surface and related swapchain creation parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSurfaceInfo2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_get_surface_capabilities2
    ///         typedef struct VkPhysicalDeviceSurfaceInfo2KHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkSurfaceKHR       surface;
    ///         } VkPhysicalDeviceSurfaceInfo2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSurfaceInfo2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Surface</c> is the surface that will be associated with the swapchain.
        /// </summary>
        [FieldOffset(16)]
        public VkSurfaceKHR Surface;
    }
}
