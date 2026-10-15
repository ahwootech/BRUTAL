namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMapPropertiesEXT.html">VkPhysicalDeviceFragmentDensityMapPropertiesEXT</see> - Structure describing fragment density map properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentDensityMapPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_fragment_density_map
    ///         typedef struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent2D         minFragmentDensityTexelSize;
    ///             VkExtent2D         maxFragmentDensityTexelSize;
    ///             VkBool32           fragmentDensityInvocations;
    ///         } VkPhysicalDeviceFragmentDensityMapPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentDensityMapPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinFragmentDensityTexelSize</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D MinFragmentDensityTexelSize;

        /// <summary>
        ///     <c>MaxFragmentDensityTexelSize</c>
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D MaxFragmentDensityTexelSize;

        /// <summary>
        ///     <c>FragmentDensityInvocations</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 FragmentDensityInvocations;
    }
}
