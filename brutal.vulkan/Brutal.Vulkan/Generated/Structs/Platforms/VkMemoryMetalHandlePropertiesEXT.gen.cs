using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryMetalHandlePropertiesEXT.html">VkMemoryMetalHandlePropertiesEXT</see> - Properties of External Memory Metal Handles
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryMetalHandlePropertiesEXT</c> structure returned is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_external_memory_metal
    ///         typedef struct VkMemoryMetalHandlePropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           memoryTypeBits;
    ///         } VkMemoryMetalHandlePropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkMemoryMetalHandlePropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryMetalHandlePropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryTypeBits</c> is a bitmask containing one bit set for every memory type which the specified Metal handle <i>can</i> be imported as.
        /// </summary>
        [FieldOffset(16)]
        public int MemoryTypeBits;
    }
}
