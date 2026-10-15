using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMetalSurfaceCreateInfoEXT.html">VkMetalSurfaceCreateInfoEXT</see> - Structure specifying parameters of a newly created Metal surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMetalSurfaceCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_surface
    ///         typedef struct VkMetalSurfaceCreateInfoEXT {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkMetalSurfaceCreateFlagsEXT    flags;
    ///             const CAMetalLayer*             pLayer;
    ///         } VkMetalSurfaceCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkMetalSurfaceCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MetalSurfaceCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkMetalSurfaceCreateFlagsEXT Flags;

        /// <summary>
        ///     <c>Layer</c> is a reference to a basetype:CAMetalLayer object representing a renderable surface.
        /// </summary>
        [FieldOffset(24)]
        public void* Layer;
    }
}
