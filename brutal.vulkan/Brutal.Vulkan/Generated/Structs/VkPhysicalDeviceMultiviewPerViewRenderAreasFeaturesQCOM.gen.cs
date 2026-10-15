namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM.html">VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM</see> - Structure describing multiview per view render areas features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_multiview_per_view_render_areas
    ///         typedef struct VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           multiviewPerViewRenderAreas;
    ///         } VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MultiviewPerViewRenderAreas</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MultiviewPerViewRenderAreas;
    }
}
