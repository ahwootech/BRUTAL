using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryGetWin32HandleInfoKHR.html">VkMemoryGetWin32HandleInfoKHR</see> - Structure describing a Win32 handle memory export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryGetWin32HandleInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_memory_win32
    ///         typedef struct VkMemoryGetWin32HandleInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkDeviceMemory                        memory;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///         } VkMemoryGetWin32HandleInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkMemoryGetWin32HandleInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryGetWin32HandleInfoKHR;

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
