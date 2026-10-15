namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceProtectedCapabilitiesKHR.html">VkSurfaceProtectedCapabilitiesKHR</see> - Structure describing capability of a surface to be protected
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         An application queries if a protected <c>VkSurfaceKHR</c> is displayable on a
    ///         specific windowing system using <c>VkSurfaceProtectedCapabilitiesKHR</c>,
    ///         which <i>can</i> be passed in <c>pNext</c> parameter of
    ///         <c>VkSurfaceCapabilities2KHR</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkSurfaceProtectedCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_surface_protected_capabilities
    ///         typedef struct VkSurfaceProtectedCapabilitiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           supportsProtected;
    ///         } VkSurfaceProtectedCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSurfaceProtectedCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceProtectedCapabilitiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportsProtected</c> specifies whether a protected swapchain created from <c>VkPhysicalDeviceSurfaceInfo2KHR::surface</c> for a particular windowing system <i>can</i> be displayed on screen or not. If <c>supportsProtected</c> is <c>VK_TRUE</c>, then creation of swapchains with the <c>VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR</c> flag set <i>must</i> be supported for <c>surface</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SupportsProtected;
    }
}
