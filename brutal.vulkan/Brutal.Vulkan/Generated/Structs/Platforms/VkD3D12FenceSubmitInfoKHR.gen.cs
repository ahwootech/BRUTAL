using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkD3D12FenceSubmitInfoKHR.html">VkD3D12FenceSubmitInfoKHR</see> - Structure specifying values for Direct3D 12 fence-backed semaphores
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To specify the values to use when waiting for and signaling semaphores whose
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-importing">current payload^</see> refers to a
    ///         Direct3D 12 fence, add a <c>VkD3D12FenceSubmitInfoKHR</c> structure to the
    ///         <c>pNext</c> chain of the <c>VkSubmitInfo</c> structure.
    ///         The <c>VkD3D12FenceSubmitInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_external_semaphore_win32
    ///         typedef struct VkD3D12FenceSubmitInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           waitSemaphoreValuesCount;
    ///             const uint64_t*    pWaitSemaphoreValues;
    ///             uint32_t           signalSemaphoreValuesCount;
    ///             const uint64_t*    pSignalSemaphoreValues;
    ///         } VkD3D12FenceSubmitInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkD3D12FenceSubmitInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.D3D12FenceSubmitInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WaitSemaphoreValuesCount</c> is the number of semaphore wait values specified in <c>pWaitSemaphoreValues</c>.
        /// </summary>
        [FieldOffset(16)]
        public int WaitSemaphoreValuesCount;

        /// <summary>
        ///     <c>WaitSemaphoreValues</c> is a pointer to an array of <c>waitSemaphoreValuesCount</c> values for the corresponding semaphores in <c>VkSubmitInfo::pWaitSemaphores</c> to wait for.
        /// </summary>
        [FieldOffset(24)]
        public nint* WaitSemaphoreValues;

        /// <summary>
        ///     <c>SignalSemaphoreValuesCount</c> is the number of semaphore signal values specified in <c>pSignalSemaphoreValues</c>.
        /// </summary>
        [FieldOffset(32)]
        public int SignalSemaphoreValuesCount;

        /// <summary>
        ///     <c>SignalSemaphoreValues</c> is a pointer to an array of <c>signalSemaphoreValuesCount</c> values for the corresponding semaphores in <c>VkSubmitInfo::pSignalSemaphores</c> to set when signaled.
        /// </summary>
        [FieldOffset(40)]
        public nint* SignalSemaphoreValues;
    }
}
