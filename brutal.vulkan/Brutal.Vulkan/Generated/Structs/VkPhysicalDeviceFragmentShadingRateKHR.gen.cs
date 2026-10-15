namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRateKHR.html">VkPhysicalDeviceFragmentShadingRateKHR</see> - Structure returning information about sample count specific additional multisampling capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentShadingRateKHR</c> structure is defined as
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_fragment_shading_rate
    ///         typedef struct VkPhysicalDeviceFragmentShadingRateKHR {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkSampleCountFlags    sampleCounts;
    ///             VkExtent2D            fragmentSize;
    ///         } VkPhysicalDeviceFragmentShadingRateKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentShadingRateKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SampleCounts</c> is a bitmask of sample counts for which the shading rate described by <c>fragmentSize</c> is supported.
        /// </summary>
        [FieldOffset(16)]
        public VkSampleCountFlags SampleCounts;

        /// <summary>
        ///     <c>FragmentSize</c> is a <c>VkExtent2D</c> describing the width and height of a supported shading rate.
        /// </summary>
        [FieldOffset(20)]
        public VkExtent2D FragmentSize;
    }
}
