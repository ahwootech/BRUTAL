using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMetalIOSurfaceInfoEXT.html">VkImportMetalIOSurfaceInfoEXT</see> - Structure that identifies a VkImage object and corresponding Metal IOSurfaceRef object to use.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import, or create, a Metal basetype:IOSurfaceRef object to underlie a
    ///         <c>VkImage</c> object, include a <c>VkImportMetalIOSurfaceInfoEXT</c>
    ///         structure in the <c>pNext</c> chain of the <c>VkImageCreateInfo</c> structure
    ///         in a <c>vkCreateImage</c> command.
    ///     </para>
    ///     <para>
    ///         The <c>VkImportMetalIOSurfaceInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkImportMetalIOSurfaceInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             IOSurfaceRef       ioSurface;
    ///         } VkImportMetalIOSurfaceInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkImportMetalIOSurfaceInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMetalIoSurfaceInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>IoSurface</c> is <c>VK_NULL_HANDLE</c> or the Metal basetype:IOSurfaceRef object that is to underlie the <c>VkImage</c>.
        /// </summary>
        [FieldOffset(16)]
        public nint IoSurface;
    }
}
