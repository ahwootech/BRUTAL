namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeVectorFeaturesNV.html">VkPhysicalDeviceCooperativeVectorFeaturesNV</see> - Structure describing cooperative vector features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeVectorFeaturesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_vector
    ///         typedef struct VkPhysicalDeviceCooperativeVectorFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           cooperativeVector;
    ///             VkBool32           cooperativeVectorTraining;
    ///         } VkPhysicalDeviceCooperativeVectorFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCooperativeVectorFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeVectorFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CooperativeVector</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CooperativeVector;

        /// <summary>
        ///     <c>CooperativeVectorTraining</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 CooperativeVectorTraining;
    }
}
