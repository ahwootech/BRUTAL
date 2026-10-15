namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT.html">VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT</see> - Structure describing whether the mutable descriptor type is supported
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_mutable_descriptor_type
    ///         typedef struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           mutableDescriptorType;
    ///         } VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMutableDescriptorTypeFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MutableDescriptorType</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MutableDescriptorType;
    }
}
