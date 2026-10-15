namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeVectorPropertiesNV.html">VkPhysicalDeviceCooperativeVectorPropertiesNV</see> - Structure describing cooperative vector properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeVectorPropertiesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_vector
    ///         typedef struct VkPhysicalDeviceCooperativeVectorPropertiesNV {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkShaderStageFlags    cooperativeVectorSupportedStages;
    ///             VkBool32              cooperativeVectorTrainingFloat16Accumulation;
    ///             VkBool32              cooperativeVectorTrainingFloat32Accumulation;
    ///             uint32_t              maxCooperativeVectorComponents;
    ///         } VkPhysicalDeviceCooperativeVectorPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceCooperativeVectorPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeVectorPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CooperativeVectorSupportedStages</c>
        /// </summary>
        [FieldOffset(16)]
        public VkShaderStageFlags CooperativeVectorSupportedStages;

        /// <summary>
        ///     <c>CooperativeVectorTrainingFloat16Accumulation</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 CooperativeVectorTrainingFloat16Accumulation;

        /// <summary>
        ///     <c>CooperativeVectorTrainingFloat32Accumulation</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 CooperativeVectorTrainingFloat32Accumulation;

        /// <summary>
        ///     <c>MaxCooperativeVectorComponents</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxCooperativeVectorComponents;
    }
}
