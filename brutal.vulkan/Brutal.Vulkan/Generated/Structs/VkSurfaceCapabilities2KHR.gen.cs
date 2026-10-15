namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceCapabilities2KHR.html">VkSurfaceCapabilities2KHR</see> - Structure describing capabilities of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceCapabilities2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_get_surface_capabilities2
    ///         typedef struct VkSurfaceCapabilities2KHR {
    ///             VkStructureType             sType;
    ///             void*                       pNext;
    ///             VkSurfaceCapabilitiesKHR    surfaceCapabilities;
    ///         } VkSurfaceCapabilities2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkSurfaceCapabilities2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceCapabilities2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SurfaceCapabilities</c> is a <c>VkSurfaceCapabilitiesKHR</c> structure describing the capabilities of the specified surface.
        /// </summary>
        [FieldOffset(16)]
        public VkSurfaceCapabilitiesKHR SurfaceCapabilities;
    }
}
