namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT.html">VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT</see> - Structure describing whether rasterization order attachment access can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_rasterization_order_attachment_access
    ///         typedef struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           rasterizationOrderColorAttachmentAccess;
    ///             VkBool32           rasterizationOrderDepthAttachmentAccess;
    ///             VkBool32           rasterizationOrderStencilAttachmentAccess;
    ///         } VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RasterizationOrderColorAttachmentAccess</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RasterizationOrderColorAttachmentAccess;

        /// <summary>
        ///     <c>RasterizationOrderDepthAttachmentAccess</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 RasterizationOrderDepthAttachmentAccess;

        /// <summary>
        ///     <c>RasterizationOrderStencilAttachmentAccess</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 RasterizationOrderStencilAttachmentAccess;
    }
}
