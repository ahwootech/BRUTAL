using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportSemaphoreWin32HandleInfoKHR.html">VkExportSemaphoreWin32HandleInfoKHR</see> - Structure specifying additional attributes of Windows handles exported from a semaphore
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To specify additional attributes of NT handles exported from a semaphore,
    ///         add a <c>VkExportSemaphoreWin32HandleInfoKHR</c> structure to the <c>pNext</c>
    ///         chain of the <c>VkSemaphoreCreateInfo</c> structure.
    ///         The <c>VkExportSemaphoreWin32HandleInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_semaphore_win32
    ///         typedef struct VkExportSemaphoreWin32HandleInfoKHR {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             const SECURITY_ATTRIBUTES*    pAttributes;
    ///             DWORD                         dwAccess;
    ///             LPCWSTR                       name;
    ///         } VkExportSemaphoreWin32HandleInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkExportSemaphoreWin32HandleInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportSemaphoreWin32HandleInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Attributes</c> is a pointer to a Windows <c>SECURITY_ATTRIBUTES</c> structure specifying security attributes of the handle.
        /// </summary>
        [FieldOffset(16)]
        public void* Attributes;

        /// <summary>
        ///     <c>DwAccess</c> is a <c>DWORD</c> specifying access rights of the handle.
        /// </summary>
        [FieldOffset(24)]
        public int DwAccess;

        /// <summary>
        ///     <c>Name</c> is a null-terminated UTF-16 string to associate with the underlying synchronization primitive referenced by NT handles exported from the created semaphore.
        /// </summary>
        [FieldOffset(32)]
        public char* Name;
    }
}
