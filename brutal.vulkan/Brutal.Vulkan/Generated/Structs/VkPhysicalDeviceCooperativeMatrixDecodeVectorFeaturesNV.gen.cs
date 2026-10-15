namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV.html">VkPhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV</see> - Structure describing cooperative matrix decode vector features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cooperative_matrix_decode_vector
    ///         typedef struct VkPhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           cooperativeMatrixDecodeVector;
    ///         } VkPhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CooperativeMatrixDecodeVector</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 CooperativeMatrixDecodeVector;
    }
}
