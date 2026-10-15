namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrixPropertiesNV.html">VkPhysicalDeviceCooperativeMatrixPropertiesNV</see> - Structure describing cooperative matrix properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeMatrixPropertiesNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_matrix
    ///         typedef struct VkPhysicalDeviceCooperativeMatrixPropertiesNV {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkShaderStageFlags    cooperativeMatrixSupportedStages;
    ///         } VkPhysicalDeviceCooperativeMatrixPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CooperativeMatrixSupportedStages</c>
        /// </summary>
        [FieldOffset(16)]
        public VkShaderStageFlags CooperativeMatrixSupportedStages;
    }
}
