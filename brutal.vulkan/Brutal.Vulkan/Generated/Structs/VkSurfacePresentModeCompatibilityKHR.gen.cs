namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfacePresentModeCompatibilityKHR.html">VkSurfacePresentModeCompatibilityKHR</see> - Structure describing the subset of compatible presentation modes for the purposes of switching without swapchain recreation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfacePresentModeCompatibilityKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface_maintenance1
    ///         typedef struct VkSurfacePresentModeCompatibilityKHR {
    ///             VkStructureType      sType;
    ///             void*                pNext;
    ///             uint32_t             presentModeCount;
    ///             VkPresentModeKHR*    pPresentModes;
    ///         } VkSurfacePresentModeCompatibilityKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSurfacePresentModeCompatibilityKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfacePresentModeCompatibilityKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentModeCount</c> is an integer related to the number of present modes available or queried, as described below.
        /// </summary>
        [FieldOffset(16)]
        public int PresentModeCount;

        /// <summary>
        ///     <c>PresentModes</c> is a pointer to an array of <c>VkPresentModeKHR</c> in which present modes compatible with a given present mode are returned.
        /// </summary>
        [FieldOffset(24)]
        public VkPresentModeKHR* PresentModes;
    }
}
