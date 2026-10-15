using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFenceGetWin32HandleInfoKHR.html">VkFenceGetWin32HandleInfoKHR</see> - Structure describing a Win32 handle fence export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkFenceGetWin32HandleInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_fence_win32
    ///         typedef struct VkFenceGetWin32HandleInfoKHR {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkFence                              fence;
    ///             VkExternalFenceHandleTypeFlagBits    handleType;
    ///         } VkFenceGetWin32HandleInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkFenceGetWin32HandleInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.FenceGetWin32HandleInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Fence</c> is the fence from which state will be exported.
        /// </summary>
        [FieldOffset(16)]
        public VkFence Fence;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalFenceHandleTypeFlags</c> value specifying the type of handle requested.
        /// </summary>
        [FieldOffset(24)]
        public VkExternalFenceHandleTypeFlags HandleType;
    }
}
