namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrix2FeaturesNV.html">VkPhysicalDeviceCooperativeMatrix2FeaturesNV</see> - Structure describing cooperative matrix features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeMatrix2FeaturesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_matrix2
    ///         typedef struct VkPhysicalDeviceCooperativeMatrix2FeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           cooperativeMatrixWorkgroupScope;
    ///             VkBool32           cooperativeMatrixFlexibleDimensions;
    ///             VkBool32           cooperativeMatrixReductions;
    ///             VkBool32           cooperativeMatrixConversions;
    ///             VkBool32           cooperativeMatrixPerElementOperations;
    ///             VkBool32           cooperativeMatrixTensorAddressing;
    ///             VkBool32           cooperativeMatrixBlockLoads;
    ///         } VkPhysicalDeviceCooperativeMatrix2FeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrix2FeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeMatrix2FeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CooperativeMatrixWorkgroupScope</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CooperativeMatrixWorkgroupScope;

        /// <summary>
        ///     <c>CooperativeMatrixFlexibleDimensions</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 CooperativeMatrixFlexibleDimensions;

        /// <summary>
        ///     <c>CooperativeMatrixReductions</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 CooperativeMatrixReductions;

        /// <summary>
        ///     <c>CooperativeMatrixConversions</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 CooperativeMatrixConversions;

        /// <summary>
        ///     <c>CooperativeMatrixPerElementOperations</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 CooperativeMatrixPerElementOperations;

        /// <summary>
        ///     <c>CooperativeMatrixTensorAddressing</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 CooperativeMatrixTensorAddressing;

        /// <summary>
        ///     <c>CooperativeMatrixBlockLoads</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 CooperativeMatrixBlockLoads;
    }
}
