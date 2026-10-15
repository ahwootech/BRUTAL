namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSamplerFilterMinmaxProperties.html">VkPhysicalDeviceSamplerFilterMinmaxProperties</see> - Structure describing sampler filter minmax limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSamplerFilterMinmaxProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceSamplerFilterMinmaxProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           filterMinmaxSingleComponentFormats;
    ///             VkBool32           filterMinmaxImageComponentMapping;
    ///         } VkPhysicalDeviceSamplerFilterMinmaxProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSamplerFilterMinmaxProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FilterMinmaxSingleComponentFormats</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FilterMinmaxSingleComponentFormats;

        /// <summary>
        ///     <c>FilterMinmaxImageComponentMapping</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 FilterMinmaxImageComponentMapping;
    }
}
