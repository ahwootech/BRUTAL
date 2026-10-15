namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLinearColorAttachmentFeaturesNV.html">VkPhysicalDeviceLinearColorAttachmentFeaturesNV</see> - Structure describing whether &amp;lt;&amp;lt;glossary-linear-color-attachment, Linear Color Attachment&amp;gt;&amp;gt; rendering is supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLinearColorAttachmentFeaturesNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_linear_color_attachment
    ///         typedef struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           linearColorAttachment;
    ///         } VkPhysicalDeviceLinearColorAttachmentFeaturesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLinearColorAttachmentFeaturesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LinearColorAttachment</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 LinearColorAttachment;
    }
}
