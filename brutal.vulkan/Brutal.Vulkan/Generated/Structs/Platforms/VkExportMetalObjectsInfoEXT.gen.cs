using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectsInfoEXT.html">VkExportMetalObjectsInfoEXT</see> - Structure whose pNext chain identifies Vulkan objects and corresponding Metal objects
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExportMetalObjectsInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkExportMetalObjectsInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///         } VkExportMetalObjectsInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkExportMetalObjectsInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMetalObjectsInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;
    }
}
