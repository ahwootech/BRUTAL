namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM.html">VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM</see> - Structure describing multiview per view viewports features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_multiview_per_view_viewports
    ///         typedef struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           multiviewPerViewViewports;
    ///         } VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MultiviewPerViewViewports</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 MultiviewPerViewViewports;
    }
}
