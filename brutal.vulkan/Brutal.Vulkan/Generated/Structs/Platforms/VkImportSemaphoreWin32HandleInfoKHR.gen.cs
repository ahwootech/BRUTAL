using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportSemaphoreWin32HandleInfoKHR.html">VkImportSemaphoreWin32HandleInfoKHR</see> - Structure specifying Windows handle to import to a semaphore
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImportSemaphoreWin32HandleInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_semaphore_win32
    ///         typedef struct VkImportSemaphoreWin32HandleInfoKHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkSemaphore                              semaphore;
    ///             VkSemaphoreImportFlags                   flags;
    ///             VkExternalSemaphoreHandleTypeFlagBits    handleType;
    ///             HANDLE                                   handle;
    ///             LPCWSTR                                  name;
    ///         } VkImportSemaphoreWin32HandleInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkImportSemaphoreWin32HandleInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportSemaphoreWin32HandleInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Semaphore</c> is the semaphore into which the payload will be imported.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphore Semaphore;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSemaphoreImportFlags</c> specifying additional parameters for the semaphore payload import operation.
        /// </summary>
        [FieldOffset(24)]
        public VkSemaphoreImportFlags Flags;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalSemaphoreHandleTypeFlags</c> value specifying the type of <c>handle</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkExternalSemaphoreHandleTypeFlags HandleType;

        /// <summary>
        ///     <c>Handle</c> is `NULL` or the external handle to import.
        /// </summary>
        [FieldOffset(32)]
        public nint Handle;

        /// <summary>
        ///     <c>Name</c> is `NULL` or a null-terminated UTF-16 string naming the underlying synchronization primitive to import.
        /// </summary>
        [FieldOffset(40)]
        public char* Name;
    }
}
