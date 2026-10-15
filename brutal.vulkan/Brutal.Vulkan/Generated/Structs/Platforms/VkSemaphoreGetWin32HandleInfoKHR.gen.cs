using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSemaphoreGetWin32HandleInfoKHR.html">VkSemaphoreGetWin32HandleInfoKHR</see> - Structure describing a Win32 handle semaphore export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSemaphoreGetWin32HandleInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_semaphore_win32
    ///         typedef struct VkSemaphoreGetWin32HandleInfoKHR {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkSemaphore                              semaphore;
    ///             VkExternalSemaphoreHandleTypeFlagBits    handleType;
    ///         } VkSemaphoreGetWin32HandleInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkSemaphoreGetWin32HandleInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SemaphoreGetWin32HandleInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Semaphore</c> is the semaphore from which state will be exported.
        /// </summary>
        [FieldOffset(16)]
        public VkSemaphore Semaphore;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalSemaphoreHandleTypeFlags</c> value specifying the type of handle requested.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalSemaphoreHandleTypeFlags HandleType;
    }
}
