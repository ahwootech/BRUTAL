using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMemoryWin32HandleInfoKHR.html">VkImportMemoryWin32HandleInfoKHR</see> - Import Win32 memory created on the same physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import memory from a Windows handle, add a
    ///         <c>VkImportMemoryWin32HandleInfoKHR</c> structure to the <c>pNext</c> chain of
    ///         the <c>VkMemoryAllocateInfo</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkImportMemoryWin32HandleInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_memory_win32
    ///         typedef struct VkImportMemoryWin32HandleInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///             HANDLE                                handle;
    ///             LPCWSTR                               name;
    ///         } VkImportMemoryWin32HandleInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkImportMemoryWin32HandleInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMemoryWin32HandleInfoKHR;

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
        public nint Handle;

        /// <summary>
        ///     <c>Name</c> is `NULL` or a null-terminated UTF-16 string naming the payload to import.
        /// </summary>
        [FieldOffset(32)]
        public char* Name;
    }
}
