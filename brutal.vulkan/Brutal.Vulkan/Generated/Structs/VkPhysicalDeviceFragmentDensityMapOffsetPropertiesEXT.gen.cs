namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT.html">VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT</see> - Structure describing fragment density map offset properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_fragment_density_map_offset
    ///         typedef struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent2D         fragmentDensityOffsetGranularity;
    ///         } VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentDensityOffsetGranularity</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D FragmentDensityOffsetGranularity;
    }
}
