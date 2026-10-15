namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageAlignmentControlPropertiesMESA.html">VkPhysicalDeviceImageAlignmentControlPropertiesMESA</see> - Structure describing supported image alignments for a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageAlignmentControlPropertiesMESA</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_MESA_image_alignment_control
    ///         typedef struct VkPhysicalDeviceImageAlignmentControlPropertiesMESA {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           supportedImageAlignmentMask;
    ///         } VkPhysicalDeviceImageAlignmentControlPropertiesMESA;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImageAlignmentControlPropertiesMESA()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageAlignmentControlPropertiesMESA;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SupportedImageAlignmentMask</c>
        /// </summary>
        [FieldOffset(16)]
        public int SupportedImageAlignmentMask;
    }
}
