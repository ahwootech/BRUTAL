using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalBufferInfoEXT.html">VkExportMetalBufferInfoEXT</see> - Structure that identifies a VkDeviceMemory object and corresponding Metal MTLBuffer object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To export the Metal <c>MTLBuffer</c> object underlying a <c>VkDeviceMemory</c>
    ///         object, include a <c>VkExportMetalBufferInfoEXT</c> structure in the
    ///         <c>pNext</c> chain of the <c>pMetalObjectsInfo</c> parameter of a
    ///         <c>vkExportMetalObjectsEXT</c> call.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMetalBufferInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkExportMetalBufferInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceMemory     memory;
    ///             MTLBuffer_id       mtlBuffer;
    ///         } VkExportMetalBufferInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkExportMetalBufferInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMetalBufferInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Memory</c> is a <c>VkDeviceMemory</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MtlBuffer</c> is the Metal `id&lt;MTLBuffer&gt;` object underlying the <c>VkDeviceMemory</c> object in <c>memory</c>. The implementation will return the <c>MTLBuffer</c> in this member, or it will return `NULL` if no <c>MTLBuffer</c> could be found underlying the <c>VkDeviceMemory</c> object.
        /// </summary>
        [FieldOffset(24)]
        public nint MtlBuffer;
    }
}
