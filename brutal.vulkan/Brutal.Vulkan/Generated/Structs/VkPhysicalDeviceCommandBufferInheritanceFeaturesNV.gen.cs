namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCommandBufferInheritanceFeaturesNV.html">VkPhysicalDeviceCommandBufferInheritanceFeaturesNV</see> - Structure describing whether the command buffer inheritance feature is supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCommandBufferInheritanceFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_command_buffer_inheritance
    ///         typedef struct VkPhysicalDeviceCommandBufferInheritanceFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           commandBufferInheritance;
    ///         } VkPhysicalDeviceCommandBufferInheritanceFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCommandBufferInheritanceFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCommandBufferInheritanceFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CommandBufferInheritance</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CommandBufferInheritance;
    }
}
