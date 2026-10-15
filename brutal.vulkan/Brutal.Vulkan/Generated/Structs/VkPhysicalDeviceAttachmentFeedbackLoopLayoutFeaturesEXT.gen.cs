namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT.html">VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT</see> - Structure indicating support for a render feedback loop image layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_attachment_feedback_loop_layout
    ///         typedef struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           attachmentFeedbackLoopLayout;
    ///         } VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AttachmentFeedbackLoopLayout</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AttachmentFeedbackLoopLayout;
    }
}
