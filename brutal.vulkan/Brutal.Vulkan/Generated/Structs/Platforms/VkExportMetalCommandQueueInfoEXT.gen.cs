using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalCommandQueueInfoEXT.html">VkExportMetalCommandQueueInfoEXT</see> - Structure that identifies a VkQueue object and corresponding Metal MTLCommandQueue object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To export the Metal <c>MTLCommandQueue</c> object underlying a <c>VkQueue</c>
    ///         object, include a <c>VkExportMetalCommandQueueInfoEXT</c> structure in the
    ///         <c>pNext</c> chain of the <c>pMetalObjectsInfo</c> parameter of a
    ///         <c>vkExportMetalObjectsEXT</c> call.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMetalCommandQueueInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkExportMetalCommandQueueInfoEXT {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkQueue               queue;
    ///             MTLCommandQueue_id    mtlCommandQueue;
    ///         } VkExportMetalCommandQueueInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkExportMetalCommandQueueInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMetalCommandQueueInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Queue</c> is a <c>VkQueue</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkQueue Queue;

        /// <summary>
        ///     <c>MtlCommandQueue</c> is the Metal `id&lt;MTLCommandQueue&gt;` object underlying the <c>VkQueue</c> object in <c>queue</c>. The implementation will return the <c>MTLCommandQueue</c> in this member, or it will return `NULL` if no <c>MTLCommandQueue</c> could be found underlying the <c>VkQueue</c> object.
        /// </summary>
        [FieldOffset(24)]
        public nint MtlCommandQueue;
    }
}
