namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageProcessing3FeaturesQCOM.html">VkPhysicalDeviceImageProcessing3FeaturesQCOM</see> - Structure describing image processing features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageProcessing3FeaturesQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_image_processing3
    ///         typedef struct VkPhysicalDeviceImageProcessing3FeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           imageGatherLinear;
    ///             VkBool32           imageGatherExtendedModes;
    ///             VkBool32           blockMatchExtendedClampToEdge;
    ///         } VkPhysicalDeviceImageProcessing3FeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceImageProcessing3FeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageProcessing3FeaturesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageGatherLinear</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ImageGatherLinear;

        /// <summary>
        ///     <c>ImageGatherExtendedModes</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ImageGatherExtendedModes;

        /// <summary>
        ///     <c>BlockMatchExtendedClampToEdge</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 BlockMatchExtendedClampToEdge;
    }
}
