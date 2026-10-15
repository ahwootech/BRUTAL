namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceYcbcrDegammaFeaturesQCOM.html">VkPhysicalDeviceYcbcrDegammaFeaturesQCOM</see> - Structure describing {YCbCr} degamma features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceYcbcrDegammaFeaturesQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_ycbcr_degamma
    ///         typedef struct VkPhysicalDeviceYcbcrDegammaFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           ycbcrDegamma;
    ///         } VkPhysicalDeviceYcbcrDegammaFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceYCbCrDegammaFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceYCbCrDegammaFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>YcbcrDegamma</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 YcbcrDegamma;
    }
}
