namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance6Properties.html">VkPhysicalDeviceMaintenance6Properties</see> - Structure describing various implementation-defined properties introduced with VK_KHR_maintenance6
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMaintenance6Properties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceMaintenance6Properties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           blockTexelViewCompatibleMultipleLayers;
    ///             uint32_t           maxCombinedImageSamplerDescriptorCount;
    ///             VkBool32           fragmentShadingRateClampCombinerInputs;
    ///         } VkPhysicalDeviceMaintenance6Properties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceMaintenance6Properties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMaintenance6Properties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>BlockTexelViewCompatibleMultipleLayers</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 BlockTexelViewCompatibleMultipleLayers;

        /// <summary>
        ///     <c>MaxCombinedImageSamplerDescriptorCount</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxCombinedImageSamplerDescriptorCount;

        /// <summary>
        ///     <c>FragmentShadingRateClampCombinerInputs</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 FragmentShadingRateClampCombinerInputs;
    }
}
