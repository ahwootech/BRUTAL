namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMap2PropertiesEXT.html">VkPhysicalDeviceFragmentDensityMap2PropertiesEXT</see> - Structure describing additional fragment density map properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentDensityMap2PropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_fragment_density_map2
    ///         typedef struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           subsampledLoads;
    ///             VkBool32           subsampledCoarseReconstructionEarlyAccess;
    ///             uint32_t           maxSubsampledArrayLayers;
    ///             uint32_t           maxDescriptorSetSubsampledSamplers;
    ///         } VkPhysicalDeviceFragmentDensityMap2PropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentDensityMap2PropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SubsampledLoads</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SubsampledLoads;

        /// <summary>
        ///     <c>SubsampledCoarseReconstructionEarlyAccess</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 SubsampledCoarseReconstructionEarlyAccess;

        /// <summary>
        ///     <c>MaxSubsampledArrayLayers</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxSubsampledArrayLayers;

        /// <summary>
        ///     <c>MaxDescriptorSetSubsampledSamplers</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxDescriptorSetSubsampledSamplers;
    }
}
