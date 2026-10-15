namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageAlignmentControlCreateInfoMESA.html">VkImageAlignmentControlCreateInfoMESA</see> - Specify image alignment
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> list of <c>VkImageCreateInfo</c> includes a
    ///         <c>VkImageAlignmentControlCreateInfoMESA</c> structure, then that structure
    ///         describes desired alignment for this image.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageAlignmentControlCreateInfoMESA</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_MESA_image_alignment_control
    ///         typedef struct VkImageAlignmentControlCreateInfoMESA {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           maximumRequestedAlignment;
    ///         } VkImageAlignmentControlCreateInfoMESA;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImageAlignmentControlCreateInfoMESA()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageAlignmentControlCreateInfoMESA;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaximumRequestedAlignment</c> specifies the maximum alignment for the image.
        /// </summary>
        [FieldOffset(16)]
        public int MaximumRequestedAlignment;
    }
}
