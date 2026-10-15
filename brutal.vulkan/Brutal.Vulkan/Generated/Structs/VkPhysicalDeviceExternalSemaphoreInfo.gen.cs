namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalSemaphoreInfo.html">VkPhysicalDeviceExternalSemaphoreInfo</see> - Structure specifying semaphore creation parameters.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalSemaphoreInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceExternalSemaphoreInfo {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             VkExternalSemaphoreHandleTypeFlagBits    handleType;
    ///         } VkPhysicalDeviceExternalSemaphoreInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalSemaphoreInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalSemaphoreHandleTypeFlags</c> value specifying the external semaphore handle type for which capabilities will be returned.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalSemaphoreHandleTypeFlags HandleType;
    }
}
