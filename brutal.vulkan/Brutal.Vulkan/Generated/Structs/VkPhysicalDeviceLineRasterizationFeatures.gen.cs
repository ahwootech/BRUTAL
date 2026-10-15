namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLineRasterizationFeatures.html">VkPhysicalDeviceLineRasterizationFeatures</see> - Structure describing the line rasterization features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLineRasterizationFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceLineRasterizationFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           rectangularLines;
    ///             VkBool32           bresenhamLines;
    ///             VkBool32           smoothLines;
    ///             VkBool32           stippledRectangularLines;
    ///             VkBool32           stippledBresenhamLines;
    ///             VkBool32           stippledSmoothLines;
    ///         } VkPhysicalDeviceLineRasterizationFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceLineRasterizationFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLineRasterizationFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RectangularLines</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RectangularLines;

        /// <summary>
        ///     <c>BresenhamLines</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 BresenhamLines;

        /// <summary>
        ///     <c>SmoothLines</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 SmoothLines;

        /// <summary>
        ///     <c>StippledRectangularLines</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 StippledRectangularLines;

        /// <summary>
        ///     <c>StippledBresenhamLines</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 StippledBresenhamLines;

        /// <summary>
        ///     <c>StippledSmoothLines</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 StippledSmoothLines;
    }
}
