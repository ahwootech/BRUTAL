using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMetalSharedEventInfoEXT.html">VkImportMetalSharedEventInfoEXT</see> - Structure that identifies a VkSemaphore or VkEvent object and corresponding Metal Shared Event object to use.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import a Metal `id&lt;MTLSharedEvent&gt;` object to underlie a
    ///         <c>VkSemaphore</c> or <c>VkEvent</c> object, include a
    ///         <c>VkImportMetalSharedEventInfoEXT</c> structure in the <c>pNext</c> chain of
    ///         the <c>VkSemaphoreCreateInfo</c> or <c>VkEventCreateInfo</c> structure in a
    ///         <c>vkCreateSemaphore</c> or <c>vkCreateEvent</c> command, respectively.
    ///     </para>
    ///     <para>
    ///         The <c>VkImportMetalSharedEventInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkImportMetalSharedEventInfoEXT {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             MTLSharedEvent_id    mtlSharedEvent;
    ///         } VkImportMetalSharedEventInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkImportMetalSharedEventInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMetalSharedEventInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MtlSharedEvent</c> is the Metal `id&lt;MTLSharedEvent&gt;` object that is to underlie the <c>VkSemaphore</c> or <c>VkEvent</c>.
        /// </summary>
        [FieldOffset(16)]
        public nint MtlSharedEvent;
    }
}
