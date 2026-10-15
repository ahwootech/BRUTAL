namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShadingRateFeaturesKHR.html">VkPhysicalDeviceFragmentShadingRateFeaturesKHR</see> - Structure indicating support for variable rate fragment shading
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentShadingRateFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_fragment_shading_rate
    ///         typedef struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           pipelineFragmentShadingRate;
    ///             VkBool32           primitiveFragmentShadingRate;
    ///             VkBool32           attachmentFragmentShadingRate;
    ///         } VkPhysicalDeviceFragmentShadingRateFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentShadingRateFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineFragmentShadingRate</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PipelineFragmentShadingRate;

        /// <summary>
        ///     <c>PrimitiveFragmentShadingRate</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PrimitiveFragmentShadingRate;

        /// <summary>
        ///     <c>AttachmentFragmentShadingRate</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 AttachmentFragmentShadingRate;
    }
}
