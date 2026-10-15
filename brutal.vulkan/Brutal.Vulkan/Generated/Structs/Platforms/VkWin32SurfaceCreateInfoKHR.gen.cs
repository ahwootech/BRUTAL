using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWin32SurfaceCreateInfoKHR.html">VkWin32SurfaceCreateInfoKHR</see> - Structure specifying parameters of a newly created Win32 surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkWin32SurfaceCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_win32_surface
    ///         typedef struct VkWin32SurfaceCreateInfoKHR {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkWin32SurfaceCreateFlagsKHR    flags;
    ///             HINSTANCE                       hinstance;
    ///             HWND                            hwnd;
    ///         } VkWin32SurfaceCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkWin32SurfaceCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.Win32SurfaceCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkWin32SurfaceCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>Hinstance</c> is the Win32 <c>HINSTANCE</c> for the window to associate the surface with.
        /// </summary>
        [FieldOffset(24)]
        public nint Hinstance;

        /// <summary>
        ///     <c>Hwnd</c> is the Win32 <c>HWND</c> for the window to associate the surface with.
        /// </summary>
        [FieldOffset(32)]
        public nint Hwnd;
    }
}
