using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalIOSurfaceInfoEXT.html">VkExportMetalIOSurfaceInfoEXT</see> - Structure that identifies a VkImage object and corresponding Metal IOSurfaceRef object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To export the Metal basetype:IOSurfaceRef object underlying a <c>VkImage</c>
    ///         object, include a <c>VkExportMetalIOSurfaceInfoEXT</c> structure in the
    ///         <c>pNext</c> chain of the <c>pMetalObjectsInfo</c> parameter of a
    ///         <c>vkExportMetalObjectsEXT</c> call.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMetalIOSurfaceInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkExportMetalIOSurfaceInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkImage            image;
    ///             IOSurfaceRef       ioSurface;
    ///         } VkExportMetalIOSurfaceInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkExportMetalIOSurfaceInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMetalIoSurfaceInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image</c> is a <c>VkImage</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkImage Image;

        /// <summary>
        ///     <c>IoSurface</c> is the Metal basetype:IOSurfaceRef object underlying the <c>VkImage</c> object in <c>image</c>. The implementation will return the basetype:IOSurfaceRef in this member, or it will return `NULL` if no basetype:IOSurfaceRef could be found underlying the <c>VkImage</c> object.
        /// </summary>
        [FieldOffset(24)]
        public nint IoSurface;
    }
}
