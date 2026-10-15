namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubgroupProperties.html">VkPhysicalDeviceSubgroupProperties</see> - Structure describing subgroup support for an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSubgroupProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceSubgroupProperties {
    ///             VkStructureType           sType;
    ///             void*                     pNext;
    ///             uint32_t                  subgroupSize;
    ///             VkShaderStageFlags        supportedStages;
    ///             VkSubgroupFeatureFlags    supportedOperations;
    ///             VkBool32                  quadOperationsInAllStages;
    ///         } VkPhysicalDeviceSubgroupProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceSubgroupProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSubgroupProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SubgroupSize</c>
        /// </summary>
        [FieldOffset(16)]
        public int SubgroupSize;

        /// <summary>
        ///     <c>SupportedStages</c>
        /// </summary>
        [FieldOffset(20)]
        public VkShaderStageFlags SupportedStages;

        /// <summary>
        ///     <c>SupportedOperations</c>
        /// </summary>
        [FieldOffset(24)]
        public VkSubgroupFeatureFlags SupportedOperations;

        /// <summary>
        ///     <c>QuadOperationsInAllStages</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 QuadOperationsInAllStages;
    }
}
