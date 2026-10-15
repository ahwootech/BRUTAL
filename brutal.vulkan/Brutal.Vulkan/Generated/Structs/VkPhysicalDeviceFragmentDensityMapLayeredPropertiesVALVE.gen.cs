namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE.html">VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE</see> - Structure describing fragment density map layered properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_fragment_density_map_layered
    ///         typedef struct VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxFragmentDensityMapLayers;
    ///         } VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxFragmentDensityMapLayers</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxFragmentDensityMapLayers;
    }
}
