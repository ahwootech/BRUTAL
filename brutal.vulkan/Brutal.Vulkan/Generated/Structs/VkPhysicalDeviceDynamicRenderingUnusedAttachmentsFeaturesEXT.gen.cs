namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT.html">VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT</see> - Structure describing the dynamic rendering unused attachment features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_dynamic_rendering_unused_attachments
    ///         typedef struct VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           dynamicRenderingUnusedAttachments;
    ///         } VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DynamicRenderingUnusedAttachments</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DynamicRenderingUnusedAttachments;
    }
}
