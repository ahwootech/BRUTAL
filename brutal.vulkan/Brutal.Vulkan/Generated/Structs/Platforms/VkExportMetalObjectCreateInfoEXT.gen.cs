using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectCreateInfoEXT.html">VkExportMetalObjectCreateInfoEXT</see> - Structure that identifies the Metal objects that can be exported from Vulkan objects
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To export Metal objects from Vulkan objects, the application <i>must</i> first
    ///         indicate the intention to do so during the creation of the Vulkan object, by
    ///         including one or more <c>VkExportMetalObjectCreateInfoEXT</c> structures in
    ///         the <c>pNext</c> chain of the <c>VkInstanceCreateInfo</c>,
    ///         <c>VkMemoryAllocateInfo</c>, <c>VkImageCreateInfo</c>,
    ///         <c>VkImageViewCreateInfo</c>, <c>VkBufferViewCreateInfo</c>,
    ///         <c>VkSemaphoreCreateInfo</c>, or <c>VkEventCreateInfo</c>, in the
    ///         corresponding Vulkan object creation command.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMetalObjectCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkExportMetalObjectCreateInfoEXT {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkExportMetalObjectTypeFlagBitsEXT    exportObjectType;
    ///         } VkExportMetalObjectCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkExportMetalObjectCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMetalObjectCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExportObjectType</c> is a <c>VkExportMetalObjectTypeFlagsEXT</c> indicating the type of Metal object that the application may request to be exported from the Vulkan object.
        /// </summary>
        [FieldOffset(16)]
        public VkExportMetalObjectTypeFlagsEXT ExportObjectType;
    }
}
