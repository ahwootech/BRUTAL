using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceFullScreenExclusiveWin32InfoEXT.html">VkSurfaceFullScreenExclusiveWin32InfoEXT</see> - Structure specifying additional creation parameters specific to Win32 fullscreen exclusive mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceFullScreenExclusiveWin32InfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_win32_surface with VK_EXT_full_screen_exclusive
    ///         typedef struct VkSurfaceFullScreenExclusiveWin32InfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             HMONITOR           hmonitor;
    ///         } VkSurfaceFullScreenExclusiveWin32InfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkSurfaceFullScreenExclusiveWin32InfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceFullScreenExclusiveWin32InfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Hmonitor</c> is the Win32 <c>HMONITOR</c> handle identifying the display to create the surface with.
        /// </summary>
        [FieldOffset(16)]
        public nint Hmonitor;
    }
}
