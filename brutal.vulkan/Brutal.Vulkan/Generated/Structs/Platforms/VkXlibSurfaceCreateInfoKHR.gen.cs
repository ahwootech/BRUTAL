using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Xlib
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkXlibSurfaceCreateInfoKHR.html">VkXlibSurfaceCreateInfoKHR</see> - Structure specifying parameters of a newly created Xlib surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkXlibSurfaceCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_xlib_surface
    ///         typedef struct VkXlibSurfaceCreateInfoKHR {
    ///             VkStructureType                sType;
    ///             const void*                    pNext;
    ///             VkXlibSurfaceCreateFlagsKHR    flags;
    ///             Display*                       dpy;
    ///             Window                         window;
    ///         } VkXlibSurfaceCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    [SupportedOSPlatform("linux")]
    public unsafe partial struct VkXlibSurfaceCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.XlibSurfaceCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkXlibSurfaceCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>Dpy</c> is a pointer to an Xlib <c>Display</c> connection to the X server.
        /// </summary>
        [FieldOffset(24)]
        public void* Dpy;

        /// <summary>
        ///     <c>Window</c> is an Xlib <c>Window</c> to associate the surface with.
        /// </summary>
        [FieldOffset(32)]
        public nint Window;
    }
}
