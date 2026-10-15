using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceFullScreenExclusiveInfoEXT.html">VkSurfaceFullScreenExclusiveInfoEXT</see> - Structure specifying the preferred full-screen transition behavior
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkSwapchainCreateInfoKHR</c> includes a
    ///         <c>VkSurfaceFullScreenExclusiveInfoEXT</c> structure, then that structure
    ///         specifies the application&apos;s preferred full-screen transition behavior.
    ///     </para>
    ///     <para>
    ///         The <c>VkSurfaceFullScreenExclusiveInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_full_screen_exclusive
    ///         typedef struct VkSurfaceFullScreenExclusiveInfoEXT {
    ///             VkStructureType             sType;
    ///             void*                       pNext;
    ///             VkFullScreenExclusiveEXT    fullScreenExclusive;
    ///         } VkSurfaceFullScreenExclusiveInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkSurfaceFullScreenExclusiveInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceFullScreenExclusiveInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FullScreenExclusive</c> is a <c>VkFullScreenExclusiveEXT</c> value specifying the preferred full-screen transition behavior.
        /// </summary>
        [FieldOffset(16)]
        public VkFullScreenExclusiveEXT FullScreenExclusive;
    }
}
