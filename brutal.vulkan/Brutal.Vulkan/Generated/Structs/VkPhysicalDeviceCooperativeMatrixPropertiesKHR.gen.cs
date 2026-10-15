namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrixPropertiesKHR.html">VkPhysicalDeviceCooperativeMatrixPropertiesKHR</see> - Structure describing cooperative matrix properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeMatrixPropertiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_cooperative_matrix
    ///         typedef struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkShaderStageFlags    cooperativeMatrixSupportedStages;
    ///         } VkPhysicalDeviceCooperativeMatrixPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesKHR;

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
