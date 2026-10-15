namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageProcessingPropertiesQCOM.html">VkPhysicalDeviceImageProcessingPropertiesQCOM</see> - Structure containing image processing properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageProcessingPropertiesQCOM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_image_processing
    ///         typedef struct VkPhysicalDeviceImageProcessingPropertiesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxWeightFilterPhases;
    ///             VkExtent2D         maxWeightFilterDimension;
    ///             VkExtent2D         maxBlockMatchRegion;
    ///             VkExtent2D         maxBoxFilterBlockSize;
    ///         } VkPhysicalDeviceImageProcessingPropertiesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPhysicalDeviceImageProcessingPropertiesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageProcessingPropertiesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxWeightFilterPhases</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxWeightFilterPhases;

        /// <summary>
        ///     <c>MaxWeightFilterDimension</c>
        /// </summary>
        [FieldOffset(20)]
        public VkExtent2D MaxWeightFilterDimension;

        /// <summary>
        ///     <c>MaxBlockMatchRegion</c>
        /// </summary>
        [FieldOffset(28)]
        public VkExtent2D MaxBlockMatchRegion;

        /// <summary>
        ///     <c>MaxBoxFilterBlockSize</c>
        /// </summary>
        [FieldOffset(36)]
        public VkExtent2D MaxBoxFilterBlockSize;
    }
}
