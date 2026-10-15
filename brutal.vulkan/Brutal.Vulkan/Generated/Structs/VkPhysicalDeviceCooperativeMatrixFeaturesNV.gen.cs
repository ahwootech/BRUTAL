namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrixFeaturesNV.html">VkPhysicalDeviceCooperativeMatrixFeaturesNV</see> - Structure describing cooperative matrix features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeMatrixFeaturesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_matrix
    ///         typedef struct VkPhysicalDeviceCooperativeMatrixFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           cooperativeMatrix;
    ///             VkBool32           cooperativeMatrixRobustBufferAccess;
    ///         } VkPhysicalDeviceCooperativeMatrixFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CooperativeMatrix</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CooperativeMatrix;

        /// <summary>
        ///     <c>CooperativeMatrixRobustBufferAccess</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 CooperativeMatrixRobustBufferAccess;
    }
}
