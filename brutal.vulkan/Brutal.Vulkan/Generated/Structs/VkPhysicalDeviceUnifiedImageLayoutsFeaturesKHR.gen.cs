namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR.html">VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR</see> - Structure describing whether the implementation provides unified image layouts
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_unified_image_layouts
    ///         typedef struct VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           unifiedImageLayouts;
    ///             VkBool32           unifiedImageLayoutsVideo;
    ///         } VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceUnifiedImageLayoutsFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UnifiedImageLayouts</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 UnifiedImageLayouts;

        /// <summary>
        ///     <c>UnifiedImageLayoutsVideo</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 UnifiedImageLayoutsVideo;
    }
}
