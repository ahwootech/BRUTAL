namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV.html">VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV</see> - Structure describing feature to allow descriptor pool overallocation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_descriptor_pool_overallocation
    ///         typedef struct VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           descriptorPoolOverallocation;
    ///         } VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDescriptorPoolOverallocationFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DescriptorPoolOverallocation</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DescriptorPoolOverallocation;
    }
}
