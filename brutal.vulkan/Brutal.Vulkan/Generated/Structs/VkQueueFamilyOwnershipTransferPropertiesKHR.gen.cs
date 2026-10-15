namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyOwnershipTransferPropertiesKHR.html">VkQueueFamilyOwnershipTransferPropertiesKHR</see> - Structure describing queue family ownership transfer properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueueFamilyOwnershipTransferPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance9
    ///         typedef struct VkQueueFamilyOwnershipTransferPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           optimalImageTransferToQueueFamilies;
    ///         } VkQueueFamilyOwnershipTransferPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueueFamilyOwnershipTransferPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueueFamilyOwnershipTransferPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OptimalImageTransferToQueueFamilies</c> is a bitmask of queue family indices that indicates which queue families belonging to the same logical device support implicitly acquiring optimal image resources owned by this queue family, without the resources&apos; contents becoming undefined:.
        /// </summary>
        [FieldOffset(16)]
        public int OptimalImageTransferToQueueFamilies;
    }
}
