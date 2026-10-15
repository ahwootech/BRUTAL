namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceTransformFeedbackFeaturesEXT.html">VkPhysicalDeviceTransformFeedbackFeaturesEXT</see> - Structure describing transform feedback features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceTransformFeedbackFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_transform_feedback
    ///         typedef struct VkPhysicalDeviceTransformFeedbackFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           transformFeedback;
    ///             VkBool32           geometryStreams;
    ///         } VkPhysicalDeviceTransformFeedbackFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceTransformFeedbackFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceTransformFeedbackFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TransformFeedback</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 TransformFeedback;

        /// <summary>
        ///     <c>GeometryStreams</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 GeometryStreams;
    }
}
