namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageAlignmentControlFeaturesMESA.html">VkPhysicalDeviceImageAlignmentControlFeaturesMESA</see> - Structure describing features supported by VK_MESA_image_alignment_control
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageAlignmentControlFeaturesMESA</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_MESA_image_alignment_control
    ///         typedef struct VkPhysicalDeviceImageAlignmentControlFeaturesMESA {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           imageAlignmentControl;
    ///         } VkPhysicalDeviceImageAlignmentControlFeaturesMESA;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImageAlignmentControlFeaturesMESA()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageAlignmentControlFeaturesMESA;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageAlignmentControl</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ImageAlignmentControl;
    }
}
