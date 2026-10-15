namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV.html">VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV</see> - Structure indicating support for fragment shading rate enums
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_fragment_shading_rate_enums
    ///         typedef struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           fragmentShadingRateEnums;
    ///             VkBool32           supersampleFragmentShadingRates;
    ///             VkBool32           noInvocationFragmentShadingRates;
    ///         } VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentShadingRateEnums</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FragmentShadingRateEnums;

        /// <summary>
        ///     <c>SupersampleFragmentShadingRates</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 SupersampleFragmentShadingRates;

        /// <summary>
        ///     <c>NoInvocationFragmentShadingRates</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 NoInvocationFragmentShadingRates;
    }
}
