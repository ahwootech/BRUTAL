namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE.html">VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE</see> - Structure describing additional layered fragment density map features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_fragment_density_map_layered
    ///         typedef struct VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           fragmentDensityMapLayered;
    ///         } VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentDensityMapLayered</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FragmentDensityMapLayered;
    }
}
