namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT.html">VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT</see> - Structure describing advanced blending limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_blend_operation_advanced
    ///         typedef struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           advancedBlendMaxColorAttachments;
    ///             VkBool32           advancedBlendIndependentBlend;
    ///             VkBool32           advancedBlendNonPremultipliedSrcColor;
    ///             VkBool32           advancedBlendNonPremultipliedDstColor;
    ///             VkBool32           advancedBlendCorrelatedOverlap;
    ///             VkBool32           advancedBlendAllOperations;
    ///         } VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AdvancedBlendMaxColorAttachments</c>
        /// </summary>
        [FieldOffset(16)]
        public int AdvancedBlendMaxColorAttachments;

        /// <summary>
        ///     <c>AdvancedBlendIndependentBlend</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 AdvancedBlendIndependentBlend;

        /// <summary>
        ///     <c>AdvancedBlendNonPremultipliedSrcColor</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 AdvancedBlendNonPremultipliedSrcColor;

        /// <summary>
        ///     <c>AdvancedBlendNonPremultipliedDstColor</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 AdvancedBlendNonPremultipliedDstColor;

        /// <summary>
        ///     <c>AdvancedBlendCorrelatedOverlap</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 AdvancedBlendCorrelatedOverlap;

        /// <summary>
        ///     <c>AdvancedBlendAllOperations</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 AdvancedBlendAllOperations;
    }
}
