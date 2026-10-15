namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT.html">VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT</see> - Structure describing whether slice-based views of 3D images can be used in storage image descriptors
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_sliced_view_of_3d
    ///         typedef struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           imageSlicedViewOf3D;
    ///         } VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageSlicedViewOf3DFeaturesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ImageSlicedViewOf3D</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ImageSlicedViewOf3D;
    }
}
