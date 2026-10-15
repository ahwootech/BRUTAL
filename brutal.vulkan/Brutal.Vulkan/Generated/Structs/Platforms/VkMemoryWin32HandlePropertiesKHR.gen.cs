using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryWin32HandlePropertiesKHR.html">VkMemoryWin32HandlePropertiesKHR</see> - Properties of External Memory Windows Handles
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryWin32HandlePropertiesKHR</c> structure returned is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_memory_win32
    ///         typedef struct VkMemoryWin32HandlePropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           memoryTypeBits;
    ///         } VkMemoryWin32HandlePropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkMemoryWin32HandlePropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryWin32HandlePropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MemoryTypeBits</c> is a bitmask containing one bit set for every memory type which the specified windows handle <i>can</i> be imported as.
        /// </summary>
        [FieldOffset(16)]
        public int MemoryTypeBits;
    }
}
