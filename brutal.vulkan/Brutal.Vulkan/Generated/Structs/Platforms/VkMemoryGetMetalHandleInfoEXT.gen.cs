using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryGetMetalHandleInfoEXT.html">VkMemoryGetMetalHandleInfoEXT</see> - Structure describing a Metal handle memory export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryGetMetalHandleInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_external_memory_metal
    ///         typedef struct VkMemoryGetMetalHandleInfoEXT {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkDeviceMemory                        memory;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///         } VkMemoryGetMetalHandleInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkMemoryGetMetalHandleInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryGetMetalHandleInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Memory</c> is the memory object from which the handle will be exported.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalMemoryHandleTypeFlags</c> value specifying the type of handle requested.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalMemoryHandleTypeFlags HandleType;
    }
}
