namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT.html">VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT</see> - Structure describing if dynamic feedback loops can be used
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_attachment_feedback_loop_dynamic_state
    ///         typedef struct VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           attachmentFeedbackLoopDynamicState;
    ///         } VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AttachmentFeedbackLoopDynamicState</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AttachmentFeedbackLoopDynamicState;
    }
}
