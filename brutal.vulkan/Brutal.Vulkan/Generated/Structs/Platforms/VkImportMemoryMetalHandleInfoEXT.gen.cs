using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMemoryMetalHandleInfoEXT.html">VkImportMemoryMetalHandleInfoEXT</see> - Import Metal memory created on the same physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import memory from a Metal handle, add a
    ///         <c>VkImportMemoryMetalHandleInfoEXT</c> structure to the <c>pNext</c> chain of
    ///         the <c>VkMemoryAllocateInfo</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkImportMemoryMetalHandleInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_external_memory_metal
    ///         typedef struct VkImportMemoryMetalHandleInfoEXT {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///             void*                                 handle;
    ///         } VkImportMemoryMetalHandleInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkImportMemoryMetalHandleInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMemoryMetalHandleInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalMemoryHandleTypeFlags</c> value specifying the type of <c>handle</c> or <c>name</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlags HandleType;

        /// <summary>
        ///     <c>Handle</c> is `NULL` or the external handle to import.
        /// </summary>
        [FieldOffset(24)]
        public void* Handle;
    }
}
