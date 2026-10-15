using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSurfaceCapabilitiesFullScreenExclusiveEXT.html">VkSurfaceCapabilitiesFullScreenExclusiveEXT</see> - Structure describing full screen exclusive capabilities of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSurfaceCapabilitiesFullScreenExclusiveEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_full_screen_exclusive
    ///         typedef struct VkSurfaceCapabilitiesFullScreenExclusiveEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           fullScreenExclusiveSupported;
    ///         } VkSurfaceCapabilitiesFullScreenExclusiveEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkSurfaceCapabilitiesFullScreenExclusiveEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SurfaceCapabilitiesFullScreenExclusiveEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FullScreenExclusiveSupported</c> is a boolean describing whether the surface is able to make use of exclusive full-screen access.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FullScreenExclusiveSupported;
    }
}
