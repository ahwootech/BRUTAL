namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceTensorMemoryRequirementsARM.html">VkDeviceTensorMemoryRequirementsARM</see> - (None)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceTensorMemoryRequirementsARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkDeviceTensorMemoryRequirementsARM {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             const VkTensorCreateInfoARM*    pCreateInfo;
    ///         } VkDeviceTensorMemoryRequirementsARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceTensorMemoryRequirementsARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceTensorMemoryRequirementsARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CreateInfo</c> is a pointer to a <c>VkTensorCreateInfoARM</c> structure containing parameters affecting the creation of the tensor to query.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorCreateInfoARM* CreateInfo;
    }
}
