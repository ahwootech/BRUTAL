using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalDeviceInfoEXT.html">VkExportMetalDeviceInfoEXT</see> - Structure that identifies a VkDevice object and corresponding Metal MTLDevice object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To export the Metal <c>MTLDevice</c> object underlying the
    ///         <c>VkPhysicalDevice</c> associated with a <c>VkDevice</c> object, include a
    ///         <c>VkExportMetalDeviceInfoEXT</c> structure in the <c>pNext</c> chain of the
    ///         <c>pMetalObjectsInfo</c> parameter of a <c>vkExportMetalObjectsEXT</c> call.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMetalDeviceInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkExportMetalDeviceInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             MTLDevice_id       mtlDevice;
    ///         } VkExportMetalDeviceInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkExportMetalDeviceInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMetalDeviceInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MtlDevice</c> is the Metal `id&lt;MTLDevice&gt;` object underlying the <c>VkPhysicalDevice</c> associated with the <c>VkDevice</c> object identified in the call. The implementation will return the <c>MTLDevice</c> in this member, or it will return `NULL` if no <c>MTLDevice</c> could be found underlying the <c>VkPhysicalDevice</c> object.
        /// </summary>
        [FieldOffset(16)]
        public nint MtlDevice;
    }
}
