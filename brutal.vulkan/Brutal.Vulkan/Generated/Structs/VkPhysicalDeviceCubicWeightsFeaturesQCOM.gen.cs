namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceCubicWeightsFeaturesQCOM.html">VkPhysicalDeviceCubicWeightsFeaturesQCOM</see> - Structure describing cubic weight selection features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceCubicWeightsFeaturesQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_filter_cubic_weights
    ///         typedef struct VkPhysicalDeviceCubicWeightsFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           selectableCubicWeights;
    ///         } VkPhysicalDeviceCubicWeightsFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceCubicWeightsFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceCubicWeightsFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SelectableCubicWeights</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SelectableCubicWeights;
    }
}
