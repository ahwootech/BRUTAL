using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Xcb
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkXcbSurfaceCreateInfoKHR.html">VkXcbSurfaceCreateInfoKHR</see> - Structure specifying parameters of a newly created Xcb surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkXcbSurfaceCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_xcb_surface
    ///         typedef struct VkXcbSurfaceCreateInfoKHR {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkXcbSurfaceCreateFlagsKHR    flags;
    ///             xcb_connection_t*             connection;
    ///             xcb_window_t                  window;
    ///         } VkXcbSurfaceCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    [SupportedOSPlatform("linux")]
    public unsafe partial struct VkXcbSurfaceCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.XcbSurfaceCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkXcbSurfaceCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>Connection</c> is a pointer to an <c>xcb_connection_t</c> to the X server.
        /// </summary>
        [FieldOffset(24)]
        public void* Connection;

        /// <summary>
        ///     <c>Window</c> is the <c>xcb_window_t</c> for the X11 window to associate the surface with.
        /// </summary>
        [FieldOffset(32)]
        public int Window;
    }
}
