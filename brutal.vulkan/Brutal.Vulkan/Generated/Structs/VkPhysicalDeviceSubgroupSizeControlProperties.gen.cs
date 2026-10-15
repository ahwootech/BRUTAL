namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubgroupSizeControlProperties.html">VkPhysicalDeviceSubgroupSizeControlProperties</see> - Structure describing the control subgroup size properties of an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSubgroupSizeControlProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceSubgroupSizeControlProperties {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             uint32_t              minSubgroupSize;
    ///             uint32_t              maxSubgroupSize;
    ///             uint32_t              maxComputeWorkgroupSubgroups;
    ///             VkShaderStageFlags    requiredSubgroupSizeStages;
    ///         } VkPhysicalDeviceSubgroupSizeControlProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSubgroupSizeControlProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MinSubgroupSize</c>
        /// </summary>
        [FieldOffset(16)]
        public int MinSubgroupSize;

        /// <summary>
        ///     <c>MaxSubgroupSize</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxSubgroupSize;

        /// <summary>
        ///     <c>MaxComputeWorkgroupSubgroups</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxComputeWorkgroupSubgroups;

        /// <summary>
        ///     <c>RequiredSubgroupSizeStages</c>
        /// </summary>
        [FieldOffset(28)]
        public VkShaderStageFlags RequiredSubgroupSizeStages;
    }
}
