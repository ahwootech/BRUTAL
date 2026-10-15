namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV.html">VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV</see> - Structure describing fragment shading rate limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_fragment_shading_rate_enums
    ///         typedef struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV {
    ///             VkStructureType          sType;
    ///             void*                    pNext;
    ///             VkSampleCountFlagBits    maxFragmentShadingRateInvocationCount;
    ///         } VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxFragmentShadingRateInvocationCount</c>
        /// </summary>
        [FieldOffset(16)]
        public VkSampleCountFlags MaxFragmentShadingRateInvocationCount;
    }
}
