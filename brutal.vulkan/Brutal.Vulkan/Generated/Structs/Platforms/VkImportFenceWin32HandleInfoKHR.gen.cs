using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportFenceWin32HandleInfoKHR.html">VkImportFenceWin32HandleInfoKHR</see> - (None)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImportFenceWin32HandleInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_fence_win32
    ///         typedef struct VkImportFenceWin32HandleInfoKHR {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkFence                              fence;
    ///             VkFenceImportFlags                   flags;
    ///             VkExternalFenceHandleTypeFlagBits    handleType;
    ///             HANDLE                               handle;
    ///             LPCWSTR                              name;
    ///         } VkImportFenceWin32HandleInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkImportFenceWin32HandleInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportFenceWin32HandleInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Fence</c> is the fence into which the state will be imported.
        /// </summary>
        [FieldOffset(16)]
        public VkFence Fence;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkFenceImportFlags</c> specifying additional parameters for the fence payload import operation.
        /// </summary>
        [FieldOffset(24)]
        public VkFenceImportFlags Flags;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalFenceHandleTypeFlags</c> value specifying the type of <c>handle</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkExternalFenceHandleTypeFlags HandleType;

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
