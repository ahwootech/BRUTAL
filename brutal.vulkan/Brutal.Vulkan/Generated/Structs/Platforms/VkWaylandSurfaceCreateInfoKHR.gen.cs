using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Wayland
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWaylandSurfaceCreateInfoKHR.html">VkWaylandSurfaceCreateInfoKHR</see> - Structure specifying parameters of a newly created Wayland surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkWaylandSurfaceCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_wayland_surface
    ///         typedef struct VkWaylandSurfaceCreateInfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkWaylandSurfaceCreateFlagsKHR    flags;
    ///             struct wl_display*                display;
    ///             struct wl_surface*                surface;
    ///         } VkWaylandSurfaceCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    [SupportedOSPlatform("linux")]
    public unsafe partial struct VkWaylandSurfaceCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.WaylandSurfaceCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkWaylandSurfaceCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>Display</c> and <c>surface</c> are pointers to the Wayland <c>wl_display</c> and <c>wl_surface</c> to associate the surface with.
        /// </summary>
        [FieldOffset(24)]
        public void* Display;

        /// <summary>
        ///     <c>Surface</c>
        /// </summary>
        [FieldOffset(32)]
        public void* Surface;
    }
}
