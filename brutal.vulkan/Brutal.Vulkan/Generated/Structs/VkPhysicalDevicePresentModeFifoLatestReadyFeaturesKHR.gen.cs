namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePresentModeFifoLatestReadyFeaturesKHR.html">VkPhysicalDevicePresentModeFifoLatestReadyFeaturesKHR</see> - Structure describing support for VK_PRESENT_MODE_FIFO_LATEST_READY_KHR
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePresentModeFifoLatestReadyFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_present_mode_fifo_latest_ready
    ///         typedef struct VkPhysicalDevicePresentModeFifoLatestReadyFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           presentModeFifoLatestReady;
    ///         } VkPhysicalDevicePresentModeFifoLatestReadyFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevicePresentModeFifoLatestReadyFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePresentModeFifoLatestReadyFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentModeFifoLatestReady</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PresentModeFifoLatestReady;
    }
}
