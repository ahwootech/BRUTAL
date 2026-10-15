namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG.html">VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG</see> - Structure describing relaxed line rasterization features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_IMG_relaxed_line_rasterization
    ///         typedef struct VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           relaxedLineRasterization;
    ///         } VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRelaxedLineRasterizationFeaturesIMG;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RelaxedLineRasterization</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RelaxedLineRasterization;
    }
}
