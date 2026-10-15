using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMetalBufferInfoEXT.html">VkImportMetalBufferInfoEXT</see> - Structure that identifies a Metal MTLBuffer object to use when creating a VkDeviceMemory object.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import a Metal <c>MTLBuffer</c> object to underlie a <c>VkDeviceMemory</c>
    ///         object, include a <c>VkImportMetalBufferInfoEXT</c> structure in the
    ///         <c>pNext</c> chain of the <c>VkMemoryAllocateInfo</c> structure in a
    ///         <c>vkAllocateMemory</c> command.
    ///     </para>
    ///     <para>
    ///         The <c>VkImportMetalBufferInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkImportMetalBufferInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             MTLBuffer_id       mtlBuffer;
    ///         } VkImportMetalBufferInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkImportMetalBufferInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMetalBufferInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MtlBuffer</c> is the Metal `id&lt;MTLBuffer&gt;` object that is to underlie the <c>VkDeviceMemory</c>.
        /// </summary>
        [FieldOffset(16)]
        public nint MtlBuffer;
    }
}
