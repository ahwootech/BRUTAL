namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalFenceInfo.html">VkPhysicalDeviceExternalFenceInfo</see> - Structure specifying fence creation parameters.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalFenceInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceExternalFenceInfo {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkExternalFenceHandleTypeFlagBits    handleType;
    ///         } VkPhysicalDeviceExternalFenceInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExternalFenceInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalFenceInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalFenceHandleTypeFlags</c> value specifying an external fence handle type for which capabilities will be returned.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalFenceHandleTypeFlags HandleType;
    }
}
