namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubgroupSizeControlFeatures.html">VkPhysicalDeviceSubgroupSizeControlFeatures</see> - Structure describing the subgroup size control features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSubgroupSizeControlFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceSubgroupSizeControlFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           subgroupSizeControl;
    ///             VkBool32           computeFullSubgroups;
    ///         } VkPhysicalDeviceSubgroupSizeControlFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSubgroupSizeControlFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SubgroupSizeControl</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SubgroupSizeControl;

        /// <summary>
        ///     <c>ComputeFullSubgroups</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ComputeFullSubgroups;
    }
}
