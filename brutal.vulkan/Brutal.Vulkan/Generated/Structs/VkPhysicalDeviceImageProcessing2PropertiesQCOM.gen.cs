namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageProcessing2PropertiesQCOM.html">VkPhysicalDeviceImageProcessing2PropertiesQCOM</see> - Structure containing image processing2 properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageProcessing2PropertiesQCOM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_image_processing2
    ///         typedef struct VkPhysicalDeviceImageProcessing2PropertiesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent2D         maxBlockMatchWindow;
    ///         } VkPhysicalDeviceImageProcessing2PropertiesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImageProcessing2PropertiesQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageProcessing2PropertiesQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxBlockMatchWindow</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D MaxBlockMatchWindow;
    }
}
