namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMapFeaturesEXT.html">VkPhysicalDeviceFragmentDensityMapFeaturesEXT</see> - Structure describing fragment density map features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentDensityMapFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_fragment_density_map
    ///         typedef struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           fragmentDensityMap;
    ///             VkBool32           fragmentDensityMapDynamic;
    ///             VkBool32           fragmentDensityMapNonSubsampledImages;
    ///         } VkPhysicalDeviceFragmentDensityMapFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentDensityMapFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentDensityMap</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FragmentDensityMap;

        /// <summary>
        ///     <c>FragmentDensityMapDynamic</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 FragmentDensityMapDynamic;

        /// <summary>
        ///     <c>FragmentDensityMapNonSubsampledImages</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 FragmentDensityMapNonSubsampledImages;
    }
}
