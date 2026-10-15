using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMemoryWin32HandleInfoNV.html">VkExportMemoryWin32HandleInfoNV</see> - Specify security attributes and access rights for Win32 memory handles
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When <c>VkExportMemoryAllocateInfoNV::handleTypes</c> includes
    ///         <c>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV</c>, add a
    ///         <c>VkExportMemoryWin32HandleInfoNV</c> structure to the <c>pNext</c> chain of
    ///         the <c>VkExportMemoryAllocateInfoNV</c> structure to specify security
    ///         attributes and access rights for the memory object&apos;s external handle.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMemoryWin32HandleInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_external_memory_win32
    ///         typedef struct VkExportMemoryWin32HandleInfoNV {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             const SECURITY_ATTRIBUTES*    pAttributes;
    ///             DWORD                         dwAccess;
    ///         } VkExportMemoryWin32HandleInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkExportMemoryWin32HandleInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMemoryWin32HandleInfoNV;

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
    }
}
