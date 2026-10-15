using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMemoryWin32HandleInfoNV.html">VkImportMemoryWin32HandleInfoNV</see> - Import Win32 memory created on the same physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import memory created on the same physical device but outside of the
    ///         current Vulkan instance, add a <c>VkImportMemoryWin32HandleInfoNV</c>
    ///         structure to the <c>pNext</c> chain of the <c>VkMemoryAllocateInfo</c>
    ///         structure, specifying a handle to and the type of the memory.
    ///     </para>
    ///     <para>
    ///         The <c>VkImportMemoryWin32HandleInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory_win32
    ///         typedef struct VkImportMemoryWin32HandleInfoNV {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkExternalMemoryHandleTypeFlagsNV    handleType;
    ///             HANDLE                               handle;
    ///         } VkImportMemoryWin32HandleInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkImportMemoryWin32HandleInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMemoryWin32HandleInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleType</c> is `0` or a <c>VkExternalMemoryHandleTypeFlagsNV</c> value specifying the type of memory handle in <c>handle</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlagsNV HandleType;

        /// <summary>
        ///     <c>Handle</c> is a Windows <c>HANDLE</c> referring to the memory.
        /// </summary>
        [FieldOffset(24)]
        public nint Handle;
    }
}
