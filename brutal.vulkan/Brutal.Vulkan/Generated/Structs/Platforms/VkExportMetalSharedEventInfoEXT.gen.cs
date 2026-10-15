using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalSharedEventInfoEXT.html">VkExportMetalSharedEventInfoEXT</see> - Structure that identifies a VkSemaphore or VkEvent object and corresponding Metal MTLSharedEvent object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To export the Metal <c>MTLSharedEvent</c> object underlying a
    ///         <c>VkSemaphore</c> or <c>VkEvent</c> object, include a
    ///         <c>VkExportMetalSharedEventInfoEXT</c> structure in the <c>pNext</c> chain of
    ///         the <c>pMetalObjectsInfo</c> parameter of a <c>vkExportMetalObjectsEXT</c>
    ///         call.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMetalSharedEventInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkExportMetalSharedEventInfoEXT {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkSemaphore          semaphore;
    ///             VkEvent              event;
    ///             MTLSharedEvent_id    mtlSharedEvent;
    ///         } VkExportMetalSharedEventInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkExportMetalSharedEventInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMetalSharedEventInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Semaphore</c> is <c>VK_NULL_HANDLE</c> or a <c>VkSemaphore</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphore Semaphore;

        /// <summary>
        ///     <c>Event</c> is <c>VK_NULL_HANDLE</c> or a <c>VkEvent</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkEvent Event;

        /// <summary>
        ///     <c>MtlSharedEvent</c> is the Metal `id&lt;MTLSharedEvent&gt;` object underlying the <c>VkSemaphore</c> or <c>VkEvent</c> object in <c>semaphore</c> or <c>event</c>, respectively. The implementation will return the <c>MTLSharedEvent</c> in this member, or it will return `NULL` if no <c>MTLSharedEvent</c> could be found underlying the <c>VkSemaphore</c> or <c>VkEvent</c> object.
        /// </summary>
        [FieldOffset(32)]
        public nint MtlSharedEvent;
    }
}
