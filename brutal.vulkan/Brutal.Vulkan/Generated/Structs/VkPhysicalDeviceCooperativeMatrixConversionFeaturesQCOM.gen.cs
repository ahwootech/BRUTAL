namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrixConversionFeaturesQCOM.html">VkPhysicalDeviceCooperativeMatrixConversionFeaturesQCOM</see> - Structure describing cooperative matrix conversion features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeMatrixConversionFeaturesQCOM</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_cooperative_matrix_conversion
    ///         typedef struct VkPhysicalDeviceCooperativeMatrixConversionFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           cooperativeMatrixConversion;
    ///         } VkPhysicalDeviceCooperativeMatrixConversionFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixConversionFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeMatrixConversionFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CooperativeMatrixConversion</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CooperativeMatrixConversion;
    }
}
